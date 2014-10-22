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
    public partial class formaPrimka : Form
    {
        public formaPrimka()
        {
            InitializeComponent();
        }

        private void picIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
