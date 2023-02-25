using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluraWF {
    public partial class frmJogoDaMemoria : Form {

        int movimentos, cliques, cartasEncontradas, tagIndex;
        Image[] img = new Image[27];
        List<string> lista = new List<string>();
        int[] tags = new int[2];

        public frmJogoDaMemoria() {
            InitializeComponent();
            Iniciar();
        }

        private void Iniciar() {
            foreach (PictureBox item in Controls.OfType<PictureBox>()) {
                tagIndex = int.Parse(string.Format("{0}", item.Tag));
                img[tagIndex] = item.Image;
                item.Image = Properties.Resources.verso2;
                item.Enabled = true;
            }

            RandomPositions();
        }

        private void RandomPositions() {
            foreach (PictureBox item in Controls.OfType<PictureBox>()) {
                Random rdm = new Random();
                int[] xP = { 34, 140, 246, 352, 458, 564, 670, 776, 882 };
                int[] yP = { 31, 137, 244, 350, 456, 562 };

                Repetir:
                var X = xP[rdm.Next(0, xP.Length)];
                var Y = yP[rdm.Next(0, yP.Length)];

                string verificacao = X.ToString() + Y.ToString();

                if (lista.Contains(verificacao)) {
                    goto Repetir;
                }

                else {
                    item.Location = new Point(X, Y);
                    lista.Add(verificacao);
                }
            }
        }

        private void ImagensClick(object sender, EventArgs e) {
            bool parEncontrado = false;

            PictureBox pic = (PictureBox)sender;
            cliques++;
            pic.Enabled = false;

            tagIndex = int.Parse(string.Format("{0}", pic.Tag));
            pic.Image = img[tagIndex];
            pic.Refresh();

            if (cliques == 1) {
                tags[0] = int.Parse(string.Format("{0}", pic.Tag));
            }

            else if (cliques == 2) {
                movimentos++;
                lblMovimentos.Left = (pnMovimentos.Width - lblMovimentos.Width) / 2;
                lblMovimentos.Text = movimentos.ToString();
                tags[1] = int.Parse(string.Format("{0}", pic.Tag));
                parEncontrado = ChecagemPares();
                Desvirar(parEncontrado);
            }
        }

        private bool ChecagemPares() {

            cliques = 0;
            if (tags[0] == tags[1]) {
                return true;
            }
            else
                return false;
        }

        private void Desvirar(bool check) {

            Thread.Sleep(500);
            foreach (PictureBox item in Controls.OfType<PictureBox>()) {
                if (int.Parse(string.Format("{0}", item.Tag)) == tags[0] ||
                    int.Parse(string.Format("{0}", item.Tag)) == tags[1]){

                    if (check == true) {
                        item.Enabled = false;
                        cartasEncontradas++;
                    }

                    else {
                        item.Enabled = true;
                        item.Image = Properties.Resources.verso2;
                        item.Refresh();
                    }
                }
            }
            
            Finalizar();
        }

        private void Finalizar() {
            if (cartasEncontradas == (img.Length * 2)) {
                DialogResult result;
                result = MessageBox.Show("Parabéns!!! Você Ganhou o jogo com " + movimentos.ToString() + " motivmentos!!! \n" +
                    "Deseja recomeçar o jogo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == System.Windows.Forms.DialogResult.No) {
                    MessageBox.Show("Obrigada por jogar!");
                    this.Close();
                }

                else {
                    cliques = 0; movimentos = 0; cartasEncontradas = 0;
                    lista.Clear();
                    Iniciar();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e) {
            DialogResult result;
            result = MessageBox.Show("Deseja voltar ao menu e perder todo o progresso" +
                " obtido no jogo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == System.Windows.Forms.DialogResult.Yes) {
                this.Close();
            }
        }
    }
}
