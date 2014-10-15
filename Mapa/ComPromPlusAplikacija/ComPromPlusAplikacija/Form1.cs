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
    public partial class formaUlaz : Form
    {
        public formaUlaz()
        {
            InitializeComponent();
        }

        private void btnUlaz_Click(object sender, EventArgs e)
        {
            formaPrijava prijava = new formaPrijava();
            prijava.Show();
            this.Hide();
        }
    }
}
