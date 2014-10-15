using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComPromPlusAplikacija
{
    public partial class formaNarudzbenicaUnos : Form
    {
        public formaNarudzbenicaUnos()
        {
            InitializeComponent();
        }

        private void btnDalje_Click(object sender, EventArgs e)
        {
            formaOdabirRepromaterijala repromat = new formaOdabirRepromaterijala();
            repromat.Show();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
