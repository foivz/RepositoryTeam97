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
    public partial class formaDokumentiPregled : Form
    {
        public formaDokumentiPregled()
        {
            InitializeComponent();
        }

        private void btnNarudzbenica_Click(object sender, EventArgs e)
        {
            formaNarudzbenica narudzbenica = new formaNarudzbenica();
            narudzbenica.Show();
        }

        private void btnIzdatnica_Click(object sender, EventArgs e)
        {
            formaIzdatnica izdatnica = new formaIzdatnica();
            izdatnica.Show();
        }

        private void btnPrimka_Click(object sender, EventArgs e)
        {
            formaPrimka primka = new formaPrimka();
            primka.Show();
        }

        private void btnOtpremnica_Click(object sender, EventArgs e)
        {
            formaOtpremnica otpremnica = new formaOtpremnica();
            otpremnica.Show();
        }

        private void picIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
