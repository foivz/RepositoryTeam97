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
    public partial class formaOdabirProdavaca : Form
    {
        public formaOdabirProdavaca()
        {
            InitializeComponent();
        }

        private void formaOdabirProdavaca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't23_Enigma2DataSet.Narudzbenica' table. You can move, or remove it, as needed.
            this.narudzbenicaTableAdapter.Fill(this.t23_Enigma2DataSet.Narudzbenica);
            // TODO: This line of code loads data into the 't23_Enigma2DataSet.poslovniPartner' table. You can move, or remove it, as needed.
            this.poslovniPartnerTableAdapter.Fill(this.t23_Enigma2DataSet.poslovniPartner);

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnŠalji_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Narudžba poslana!");
            this.Close();
            
        }
    }
}
