using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluraWF {
    public partial class frmForca : Form {

        private static string pSorteada = "";
        private static string pTela = "";
        private static string caractere = "#";

        public frmForca() {
            InitializeComponent();

            lblDescricao.Left = (Width - lblDescricao.Width) / 2;
            int tamanhoTela = this.Width;
            pbMenu.Width = tamanhoTela;
            StartPlay(7, 0);

            Transform.ArredondaButton(btnVoltar);
        }

        static string GerarPalavra() {
            //colocando todas as palavras separadas por linha do arquivo dentro de um array
            string[] palavras = System.IO.File.ReadAllLines($"../../Imagens/Gerador/Palavras.txt");
            
            //gerando um numero aleatório entre 0 e a qtd de itens do array para poder sortear a palavra
            Random randNum = new Random();
            int n = randNum.Next(0, (int)palavras.Length - 1);

            pSorteada = palavras[n];

            return pSorteada;
        }

        public void StartPlay(int tentativas, int erros) {

            lblErros.Text = erros.ToString();
            lblTentativas.Text = tentativas.ToString();

            string pSorteada = GerarPalavra();

            string palavraOk = "";

            for (int i = 0; i < pSorteada.Length; i++) {
                palavraOk = palavraOk + caractere;
            }

            pTela = palavraOk;
            lblPalavra.Text = pTela;
            lblPalavra.Left = (Width - lblPalavra.Width)/ 2;

            Transform.SelecionarImagens(pSorteada, pbPalavra);

        }

        public void OnClick(string letra) {
            Boolean encontrou = false;
            string txt = "";
            int tentativas = Convert.ToInt32(lblTentativas.Text);
            int erros = Convert.ToInt32(lblErros.Text);
            int pletra;


            for (int i = 0; i < pSorteada.Length; i++) {
                if (pSorteada[i] == Convert.ToChar(letra)) {
                    encontrou = true;
                    txt = txt + letra;
                }

                else
                    txt = txt + pTela[i];
            }

            pTela = txt;
            lblPalavra.Text = pTela;


            if (encontrou == true) {
                if (!lblPalavra.Text.Contains(caractere)) {
                    DialogResult result;
                    result = MessageBox.Show("Parabéns!!! Você Ganhou!!! \n" +
                        "Deseja recomeçar o jogo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == System.Windows.Forms.DialogResult.No)
                        this.Close();

                    else
                        StartPlay(7,0);
                }
            }
            else if (tentativas == 1) {

                DialogResult result;
                result = MessageBox.Show($"Poxa, que pena :/ Você perdeu! \n" +
                    "A palavra era: " + pSorteada + "!\n" +
                    "Deseja recomeçar o jogo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == System.Windows.Forms.DialogResult.No)
                    this.Close();

                else
                    StartPlay(7, 0);
            }
            else {
                erros = erros + 1;
                tentativas = tentativas - 1;
                lblErros.Text = erros.ToString();
                lblTentativas.Text = tentativas.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            
            DialogResult result;
            result = MessageBox.Show("Deseja voltar ao menu e perder todo o progresso" +
                " obtido no jogo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == System.Windows.Forms.DialogResult.Yes) {
                // Closes the parent form.
                this.Close();
            }

        }

        private void btnA_Click(object sender, EventArgs e) {
            OnClick("A");
        }

        private void btnB_Click(object sender, EventArgs e) {
            OnClick("B");
        }

        private void btnN_Click(object sender, EventArgs e) {
            OnClick("N");
        }

        private void btnO_Click(object sender, EventArgs e) {
            OnClick("O");
        }

        private void button1_Click_1(object sender, EventArgs e) {
            StartPlay(7, 0);
        }

        private void button2_Click(object sender, EventArgs e) {
            StartPlay(5, 0);
        }

        private void button3_Click(object sender, EventArgs e) {
            StartPlay(3, 0);
        }

        private void btnC1_Click(object sender, EventArgs e) {
            OnClick("C");
        }

        private void btnC2_Click(object sender, EventArgs e) {
            OnClick("Ç");
        }

        private void btnD_Click(object sender, EventArgs e) {
            OnClick("D");
        }

        private void btnM_Click(object sender, EventArgs e) {
            OnClick("M");
        }

        private void btnE_Click(object sender, EventArgs e) {
            OnClick("E");
        }

        private void btnF_Click(object sender, EventArgs e) {
            OnClick("F");
        }

        private void btnG_Click(object sender, EventArgs e) {
            OnClick("G");
        }

        private void btnH_Click(object sender, EventArgs e) {
            OnClick("H");
        }

        private void btnI_Click(object sender, EventArgs e) {
            OnClick("I");
        }

        private void btnJ_Click(object sender, EventArgs e) {
            OnClick("J");
        }

        private void btnK_Click(object sender, EventArgs e) {
            OnClick("K");
        }

        private void btnL_Click(object sender, EventArgs e) {
            OnClick("L");
        }

        private void btnP_Click(object sender, EventArgs e) {
            OnClick("P");
        }

        private void btnQ_Click(object sender, EventArgs e) {
            OnClick("Q");
        }

        private void btnR_Click(object sender, EventArgs e) {
            OnClick("R");
        }

        private void btnS_Click(object sender, EventArgs e) {
            OnClick("S");
        }

        private void btnT_Click(object sender, EventArgs e) {
            OnClick("T");
        }

        private void btnU_Click(object sender, EventArgs e) {
            OnClick("U");
        }

        private void btnV_Click(object sender, EventArgs e) {
            OnClick("V");
        }

        private void btnW_Click(object sender, EventArgs e) {
            OnClick("W");
        }

        private void btnX_Click(object sender, EventArgs e) {
            OnClick("X");
        }

        private void btnY_Click(object sender, EventArgs e) {
            OnClick("Y");
        }

        private void btnZ_Click(object sender, EventArgs e) {
            OnClick("Z");
        }
    }
}
