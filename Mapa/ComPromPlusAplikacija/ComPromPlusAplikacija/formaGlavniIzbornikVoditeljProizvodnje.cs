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
    public partial class formaGlavniIzbornikVoditeljProizvodnje : Form
    {
        public formaGlavniIzbornikVoditeljProizvodnje()
        {
            InitializeComponent();
        }

        private void picArtikli_Click_1(object sender, EventArgs e)
        {
            formaArtikliPregled artikli = new formaArtikliPregled();
            artikli.Show();
        }

        private void picDjelatnici_Click_1(object sender, EventArgs e)
        {
            formaDjelatniciPregled djelatnici = new formaDjelatniciPregled();
            djelatnici.Show();

        }

        private void picStatistika_Click_1(object sender, EventArgs e)
        {
            formaStatistika statistika = new formaStatistika();
            statistika.Show();
        }

        private void picIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formaPrijava prijava = new formaPrijava();
            prijava.Show();
            this.Close();
        }

      

        private void pomoćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start(@"C:\Users\Ivan\Desktop\korisnickaPDF.docx");

        }

        private void odjavaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            formaPrijava prijava = new formaPrijava();
            prijava.Show();
            this.Close();
        }

        private void izlazToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pomoćToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start(@"C:\Users\Ivan\Desktop\korisnickaPDF.docx");
        }

        private void picIzlaz_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

    }
}
