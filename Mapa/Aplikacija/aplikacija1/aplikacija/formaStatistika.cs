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

        private void btnKlaseStatistika_Click(object sender, EventArgs e)
        {
            formaStatistikaKlase klase = new formaStatistikaKlase();
            klase.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formaStatistikaDokumenti vrste = new formaStatistikaDokumenti();
            vrste.Show();
        }
    }
}
