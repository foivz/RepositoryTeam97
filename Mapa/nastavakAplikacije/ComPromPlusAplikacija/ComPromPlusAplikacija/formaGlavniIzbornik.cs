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
    public partial class formaGlavniIzbornik : Form
    {
        public formaGlavniIzbornik()
        {
            InitializeComponent();
        }

        private void picArtikli_Click(object sender, EventArgs e)
        {
            formaArtikliPregled artikli = new formaArtikliPregled();
            artikli.Show();

        }

        private void picDokumenti_Click(object sender, EventArgs e)
        {
            formaDokumentiPregled dokumenti = new formaDokumentiPregled();
            dokumenti.Show();
        }

        private void picDjelatnici_Click(object sender, EventArgs e)
        {
            formaDjelatniciPregled djelatnici = new formaDjelatniciPregled();
            djelatnici.Show();
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

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pomoćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start(@"C:\Users\Ivan\Desktop\korisnickaPDF.docx");
        }

        private void picStatistika_Click(object sender, EventArgs e)
        {
            formaStatistika statistika = new formaStatistika();
            statistika.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            formaRepromaterijaliPregled repromaterijali = new formaRepromaterijaliPregled();
            repromaterijali.Show();
        }
    }
}
