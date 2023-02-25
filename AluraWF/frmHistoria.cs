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
    public partial class frmHistoria : Form {
        public frmHistoria() {
            InitializeComponent();
        }

        private void frmHistoria_Load(object sender, EventArgs e)
        {
            lblTitle.ForeColor = Color.FromArgb(244, 184, 96);

            lblDesc1.MaximumSize = new Size(800, 0);
            lblDesc1.AutoSize = true;
            lblDesc1.Text = "A Língua Brasileira de Sinais  é a língua utilizada na comunicação " +
                "dos surdos no Brasil. A linguagem foi desenvolvida durante a fundação do Instituto" +
                " Nacional de Educação de Surdos no século XIX. Em 1855, d.Pedro II convidou para o" +
                " Brasil um professor francês que se chamava Ernest Huet para que ele iniciasse a " +
                "educação de surdos no Brasil. \n";

            lblDesc2.MaximumSize = new Size(1150, 0);
            lblDesc2.AutoSize = true;
            lblDesc2.Text = "Ernest Huet era surdo desde os seus 12 anos de idade, " +
                "sua atuação no Brasil iniciou - se quando foi fundado, em 1857, o Imperial Instituto" +
                " dos Surdos - Mudos, instituição que atualmente é conhecida como Instituto Nacional " +
                "de Educação de Surdos ou Ines. Ernest foi o pioneiro em nosso país para a educação de" +
                " surdos, mas inicialmente não teve muitos alunos. O trabalho de Huet permitiu que uma " +
                "língua de sinais própria de nosso país fosse desenvolvida. \n\nO sistema de ensino " +
                "implantado por Huet no Brasil predominou até o começo do século XX. A partir da Nova " +
                "República, sobretudo depois da virada do século XXI, a comunidade surda conquistou " +
                "importantes direitos. Uma conquista muito importante deu - se com a Lei nº 40.436, " +
                "de 24 de abril de 2002, que determinou que a Libras deve ser reconhecida como meio " +
                "legal de comunicação e expressão da comunidade surda brasileira e que o poder público" +
                " deve fornecer meio para o uso e difusão da Libras no Brasil.\n\nNo âmbito educacional" +
                ", a educação de todos os brasileiros foi reconhecida como um direito na Constituição " +
                "de 1988, e isso abriu espaço para que leis fossem regulamentadas para garantir o acesso " +
                "do surdo a uma educação pública e de qualidade.Assim, por exemplo, ao aluno surdo ficou " +
                "garantido, por lei, o direito de um acompanhamento especializado, o que é importante para" +
                " garantir a inclusão dessa comunidade. \n\nAlgumas datas importantes: " +
                "\n2004: Lei que determina o uso de recursos visuais e legendas nas propagandas oficiais " +
                "do governo; \n2008: Instituído o Dia Nacional do Surdo, comemorado em 26 de " +
                "Setembro, considerado o mês dos surdos;\n2010: Foi regulamentada a profissão de " +
                "Tradutor e Intérprete de Libras;\n2015: Publicação da Lei Brasileira de Inclusão" +
                "(ou Estatuto da Pessoa com Deficiência), que trata da acessibilidade em áreas como" +
                " educação, \nsaúde, lazer, cultura, trabalho etc.;\n2016: Anatel publica resolução" +
                " com as regras para o atendimento das pessoas com deficiência por parte das empresas de telecomunicações;\n\n\n";

            lblDesc2.Left = (Width - lblDesc2.Width) / 2;
            //lblTitle.Left = (Width - lblTitle.Width) / 2;
            Transform.ArredondaButton(btnVoltar);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
