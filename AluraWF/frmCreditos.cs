using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluraWF {
    public partial class frmCreditos : Form {
        public frmCreditos() {
            InitializeComponent();
            Transform.ArredondaButton(btnVoltar);
        }

        private void btnVoltar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
