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
    public partial class formaOtpremnica : Form
    {
        public formaOtpremnica()
        {
            InitializeComponent();
        }

        private void picIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formaOtpremnica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't23_Enigma2DataSet.stavkeOtpremnice' table. You can move, or remove it, as needed.
            this.stavkeOtpremniceTableAdapter.Fill(this.t23_Enigma2DataSet.stavkeOtpremnice);
            // TODO: This line of code loads data into the 't23_Enigma2DataSet.Otpremnica' table. You can move, or remove it, as needed.
            this.otpremnicaTableAdapter.Fill(this.t23_Enigma2DataSet.Otpremnica);

        }

        private void picDodaj_Click(object sender, EventArgs e)
        {
            formaOtpremnicaUnos otpremnica = new formaOtpremnicaUnos();
            otpremnica.Show();
        }
    }
}
