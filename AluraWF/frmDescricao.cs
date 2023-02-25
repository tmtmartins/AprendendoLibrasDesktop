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
    public partial class frmDescricao : Form {
        public frmDescricao() {
            InitializeComponent();

            /*
            lblTitle.ForeColor = Color.FromArgb(244, 184, 96);
            lblDesc.ForeColor = Color.White;


            lblDesc.MaximumSize = new Size(1200, 0);
            lblDesc.AutoSize = true;
            lblDesc.Text = "Bom, partindo do início, libras, " +
                "também conhecida como língua de sinais é uma língua " +
                "que utiliza sinais ao invés de palavras e, cada sinal " +
                "possui seu significado dentro do nosso vocabulário. " +
                "Embora na teoria pareça algo simples, a língua de sinais " +
                "utiliza não só as mãos, mas também de muitos movimentos para " +
                "se expressar. E apesar do que muitos acham, língua de sinais " +
                "é tão eficaz quanto a comunicação oral, sendo reconhecida como " +
                "uma língua oficial no Brasil. \n\n " +
                "Libras foi criada com o intuito de atender as pessoas surdas, " +
                "facilitando a sua comunicação e expressão. Mas apesar de ter " +
                "sido criada com esse princípio, se tornou uma língua que " +
                "pode ser compreendida em todo o país, independente da região, " +
                "enquanto na língua oral, muitas vezes ficamos perdidos devido" +
                " aos diferentes tipos de sotaques e gírias em um país tão " +
                "grande e diverso.";

            lblDesc.Left = (Width - lblDesc.Width) / 2;
            lblTitle.Left = (Width - lblTitle.Width) / 2;*/
            Transform.ArredondaButton(btnVoltar);
        }

        private void btnVoltar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void frmDescricao_Load(object sender, EventArgs e)
        {

        }
    }
}
