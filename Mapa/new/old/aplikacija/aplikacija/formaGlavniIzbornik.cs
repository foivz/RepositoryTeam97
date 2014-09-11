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
    public partial class formaGlavniIzbornik : Form
    {

        public formaGlavniIzbornik()
        {

            InitializeComponent();
        }

        private void picLogoVeliki_Click(object sender, EventArgs e)
        {

        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picDokumenti_Click(object sender, EventArgs e)
        {
            formaDokumentiPregled dokumenti = new formaDokumentiPregled();
            dokumenti.Show();
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

        private void picRepromaterijal_Click(object sender, EventArgs e)
        {
            formaRepromaterijalPregled repromaterijal = new formaRepromaterijalPregled();
            repromaterijal.Show();
        }

        private void picStatistika_Click(object sender, EventArgs e)
        {
            formaStatistika statistika = new formaStatistika();
            statistika.Show();
        }

        private void picPracenjeProizvoda_Click(object sender, EventArgs e)
        {
            formaPracenjeProizvoda pracenje = new formaPracenjeProizvoda();
            pracenje.Show();
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
