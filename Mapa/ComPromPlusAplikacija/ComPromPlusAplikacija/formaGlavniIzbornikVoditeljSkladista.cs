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
    public partial class formaGlavniIzbornikVoditeljSkladista : Form
    {
        public formaGlavniIzbornikVoditeljSkladista()
        {
            InitializeComponent();
        }
        private void picDokumenti_Click_1(object sender, EventArgs e)
        {
            formaDokumentiPregled dokumenti = new formaDokumentiPregled();
            dokumenti.Show();
        }

        private void picIzlaz_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
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


      
    }
}
