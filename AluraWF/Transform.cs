using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluraWF {
    class Transform {

        public static void ArredondaButton(Button botao) {

            GraphicsPath forma = new GraphicsPath();
            /* Define como uma elipse o formato do objeto criado
             atribuindo valores para os parâmetros de posição e tamanho*/

            forma.AddEllipse(0, 0, botao.Width, botao.Height);
            /* Define a região do botão a ser arredondado, ou seja,
            o botão em si*/

            botao.Region = new Region(forma);

        }

        public static void SelecionarImagens(string palavra, PictureBox pb) {
            char[] arr = null;
            arr = palavra.ToCharArray();

            string file = "";

            foreach (char c in arr) {
                string letra = "";

                if (c.Equals('C')) {
                    letra = ("C1");
                }

                else if (c.Equals('Ç')) {
                    letra = ("C2");
                }

                else if (c.Equals('+')) {
                    letra = ("mais");
                }

                else if (c.Equals('-')) {
                    letra = ("menos");
                }

                else if (c.Equals('*')) {
                    letra = ("multi");
                }

                else if (c.Equals('/')) {
                    letra = ("div");
                }

                else if (c.Equals(' ')) {
                    letra = ("espaço");
                }

                else {
                    letra = c.ToString();
                }

                file += ($"../../Imagens/Alfabeto/{letra}.png#");
            }

            System.Drawing.Bitmap imagensCombinadas;
            //obtem a posicao da ultima ocorrência do caractere #
            int posicao = file.LastIndexOf('#');

            //remove a última ocorrência do caractere #
            string arquivosSelecionados = file.Remove(posicao);
            string[] arquivos = arquivosSelecionados.Split('#');

            imagensCombinadas = CombinarImagens(arquivos);
            string pathNewImage = "../../Imagens/Gerador/teste.jpg";

            if (System.IO.File.Exists(pathNewImage)) {
                System.IO.File.Delete(pathNewImage);
            }

            imagensCombinadas.Save(pathNewImage, System.Drawing.Imaging.ImageFormat.Jpeg);

            using (FileStream fs = new FileStream(pathNewImage, FileMode.Open)) {
                pb.Image = Image.FromStream(fs);
                fs.Close();
            }
        }

        public static System.Drawing.Bitmap CombinarImagens(string[] files) {
            //lê todas as imagens para a memória
            List<System.Drawing.Bitmap> images = new List<System.Drawing.Bitmap>();
            System.Drawing.Bitmap imagemFinal = null;

            try {
                int width = 0;
                int height = 0;

                foreach (string image in files) {
                    //cria um bitmap a partir do arquivo e o inclui na lista
                    System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(image);

                    //atualiza o tamanho da imagem bitmap final
                    width += bitmap.Width;
                    height = bitmap.Height > height ? bitmap.Height : height;

                    images.Add(bitmap);
                }

                //cria um bitmap para tratar a imagem combinada
                imagemFinal = new System.Drawing.Bitmap(width, height);

                //Obtem o objeto gráfico da imagem 
                using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(imagemFinal)) {
                    //define a cor de fundo
                    g.Clear(System.Drawing.Color.Black);

                    //percorre imagem por imagem e gera uma unica imagem final
                    int offset = 0;
                    foreach (System.Drawing.Bitmap image in images) {
                        g.DrawImage(image,
                          new System.Drawing.Rectangle(offset, 0, image.Width, image.Height));
                        offset += image.Width;
                    }
                }

                return imagemFinal;
            }
            catch (Exception ex) {
                if (imagemFinal != null)
                    imagemFinal.Dispose();

                throw ex;
            }
        }


    }
}
