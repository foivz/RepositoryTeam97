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
    public partial class formaOdabirRepromaterijala : Form
    {
        public formaOdabirRepromaterijala()
        {
            InitializeComponent();
        }

        private void formaOdabirRepromaterijala_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't23_Enigma2DataSet.Repromaterijali' table. You can move, or remove it, as needed.
            this.repromaterijaliTableAdapter.Fill(this.t23_Enigma2DataSet.Repromaterijali);

        }

        private void btnDalje_Click(object sender, EventArgs e)
        {
            formaOdabirProdavaca prodavac = new formaOdabirProdavaca();
            prodavac.Show();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
