using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compromplus_app
{
    public partial class formaStatistika : Form
    {
        public formaStatistika()
        {
            InitializeComponent();
        }

        private void btnKlase_Click(object sender, EventArgs e)
        {
            formaStatistikaKlase klase = new formaStatistikaKlase();
            klase.Show();
        }

        private void btnDokumenti_Click(object sender, EventArgs e)
        {
            formaStatistikaTipDokumenta tip = new formaStatistikaTipDokumenta();
            tip.Show();
        }

        private void picIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
