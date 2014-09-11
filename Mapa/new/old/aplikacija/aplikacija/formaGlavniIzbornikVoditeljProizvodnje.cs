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
    public partial class formaGlavniIzbornikVoditeljProizvodnje : Form
    {
        public formaGlavniIzbornikVoditeljProizvodnje()
        {
            InitializeComponent();
        }

        private void picIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picDjelatnici_Click(object sender, EventArgs e)
        {
            formaDjelatniciPregled djelatnici = new formaDjelatniciPregled();
            djelatnici.Show();
        }

        private void picArtikli_Click(object sender, EventArgs e)
        {
            formaArtikliPregled artikli = new formaArtikliPregled();
            artikli.Show();
        }

        private void picStatistika_Click(object sender, EventArgs e)
        {
            formaStatistika statistika = new formaStatistika();
            statistika.Show();
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formaPrijava prijava = new formaPrijava();
            prijava.Show();
            this.Close();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
