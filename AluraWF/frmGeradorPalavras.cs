using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.IO;
using System.Drawing.Drawing2D;

namespace AluraWF {
    public partial class frmGeradorPalavras : Form {
        public frmGeradorPalavras() {
            InitializeComponent();
            lblDescricao.Left = (Width - lblDescricao.Width) / 2;
            
            var botoes = new[] { btnBuscar, btnSair, btnLimpar };
            //colocando todos os buttons em um array e chamando a função ArredondaButton
            foreach (var botao in botoes) {
                Transform.ArredondaButton(botao);
            }
        }


        private void btn_sair_Click(object sender, EventArgs e) {
            this.Close();
        }


            private void btnBuscar_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(tbPalavra.Text)) {
                MessageBox.Show("Insira uma palavra ou número na caixa de texto para buscar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbPalavra.Text.Length > 15) {
                MessageBox.Show("A palavra ou frase inserida não pode conter mais de 15 caracteres.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPalavra.Clear();
            }
            
            
            else if (tbPalavra.Text.Contains("|") ||
                    tbPalavra.Text.Contains("?") ||
                    tbPalavra.Text.Contains("'") ||
                    tbPalavra.Text.Contains('"') ||
                    tbPalavra.Text.Contains(">") ||
                    tbPalavra.Text.Contains("<") ||
                    tbPalavra.Text.Contains(",") ||
                    tbPalavra.Text.Contains(".") ||
                    tbPalavra.Text.Contains(";") ||
                    tbPalavra.Text.Contains("´") ||
                    tbPalavra.Text.Contains("`") ||
                    tbPalavra.Text.Contains("^") ||
                    tbPalavra.Text.Contains("~") ||
                    tbPalavra.Text.Contains("#") ||
                    tbPalavra.Text.Contains("@") ||
                    tbPalavra.Text.Contains("!") ||
                    tbPalavra.Text.Contains("$") ||
                    tbPalavra.Text.Contains("%") ||
                    tbPalavra.Text.Contains("¨") ||
                    tbPalavra.Text.Contains("&") ||
                    tbPalavra.Text.Contains("(") ||
                    tbPalavra.Text.Contains(")") ||
                    tbPalavra.Text.Contains("_") ||
                    tbPalavra.Text.Contains("=") ||
                    tbPalavra.Text.Contains("}") ||
                    tbPalavra.Text.Contains("{") ||
                    tbPalavra.Text.Contains("[") ||
                    tbPalavra.Text.Contains("]") ||
                    tbPalavra.Text.Contains("º") ||
                    tbPalavra.Text.Contains("Ä") ||
                    tbPalavra.Text.Contains("Å") ||
                    tbPalavra.Text.Contains("Á") ||
                    tbPalavra.Text.Contains("Â") ||
                    tbPalavra.Text.Contains("À") ||
                    tbPalavra.Text.Contains("Ã") ||
                    tbPalavra.Text.Contains("É") ||
                    tbPalavra.Text.Contains("é") ||
                    tbPalavra.Text.Contains("Ê") ||
                    tbPalavra.Text.Contains("Ë") ||
                    tbPalavra.Text.Contains("È") ||
                    tbPalavra.Text.Contains("Í") ||
                    tbPalavra.Text.Contains("Î") ||
                    tbPalavra.Text.Contains("Ï") ||
                    tbPalavra.Text.Contains("Ì") ||
                    tbPalavra.Text.Contains("Ö") ||
                    tbPalavra.Text.Contains("Ó") ||
                    tbPalavra.Text.Contains("Ô") ||
                    tbPalavra.Text.Contains("Ò") ||
                    tbPalavra.Text.Contains("Õ") ||
                    tbPalavra.Text.Contains("Ö") ||
                    tbPalavra.Text.Contains("Ü") ||
                    tbPalavra.Text.Contains("Ú") ||
                    tbPalavra.Text.Contains("Û")) {

                MessageBox.Show("Não podem ser digitadas letras com acentuação " +
                    "ou caracteres especiais além dos operadores matemáticos (+, -, /, *).",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPalavra.Clear();
            }

            else {
                string palavra = tbPalavra.Text;
                Transform.SelecionarImagens(palavra, pbGerador);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            tbPalavra.Text = "";
            pbGerador.Image = null;
        }
    }
}
