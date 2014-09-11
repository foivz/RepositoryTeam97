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
    public partial class formaStatistika : Form
    {
        public formaStatistika()
        {
            InitializeComponent();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKlase_Click(object sender, EventArgs e)
        {
            formaStatistikaKlase klase = new formaStatistikaKlase();
            klase.Show();

        }

        private void btnDokumenti_Click(object sender, EventArgs e)
        {
            formaStatistikaDokumenti dokumenti = new formaStatistikaDokumenti();
            dokumenti.Show();
        }
    }
}
