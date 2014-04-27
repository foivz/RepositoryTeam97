using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikacija
{
    public partial class formaPrimka : Form
    {
        public formaPrimka()
        {
            InitializeComponent();
        }

        private void formaPrimka_Load(object sender, EventArgs e)
        {

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
