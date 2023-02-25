using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluraWF {
    public partial class frmMenu : Form {
        public frmMenu() {
            InitializeComponent();
            Transform.ArredondaButton(btnSair);

            PrivateFontCollection gb = new PrivateFontCollection();
            gb.AddFontFile("../../Fontes/Gaegu-Bold.ttf");
            lblCreditos.Font = new Font(gb.Families[0], 20, FontStyle.Bold);
            lblCreditos.Left = (Width - lblCreditos.Width) / 2;
        }

        private void Teste_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void button1_Click_1(object sender, EventArgs e) {

        }

        private void btn_sair_Click(object sender, EventArgs e) {
            DialogResult result;
            result = MessageBox.Show("Deseja sair e encerrar a aplicação?",
                "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == System.Windows.Forms.DialogResult.Yes) {
                Application.Exit();
            }
        }

        private void btn_descricao_Click(object sender, EventArgs e) {
            frmDescricao desc = new frmDescricao();
            desc.Show();
        }

        private void btn_Alfabeto_Click(object sender, EventArgs e) {
            frmAlfabeto alfabeto = new frmAlfabeto();
            alfabeto.Show();
        }

        private void btnMontarPalavra_Click(object sender, EventArgs e) {
            frmForca forca = new frmForca();
            forca.Show();
        }

        private void btnGerador_Click(object sender, EventArgs e) {
            frmGeradorPalavras gerador = new frmGeradorPalavras();
            gerador.Show();
        }

        private void btnHistoria_Click(object sender, EventArgs e) {
            frmHistoria hist = new frmHistoria();
            hist.Show();
        }

        private void btnJogoMemoria_Click(object sender, EventArgs e)
        {
            frmJogoDaMemoria memoria = new frmJogoDaMemoria();
            memoria.Show();
        }

        private void lblCreditos_Click(object sender, EventArgs e) {
            frmCreditos creditos = new frmCreditos();
            creditos.Show();
        }
    }
}
