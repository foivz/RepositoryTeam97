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
    public partial class formaNarudzbenica : Form
    {
        public formaNarudzbenica()
        {
            InitializeComponent();
        }

      

        private void dgvStavkeDokumenata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNovaStavka_Click(object sender, EventArgs e)
        {

        }

        private void dgvDokumenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {

        }

        private void picIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblDodaj_Click(object sender, EventArgs e)
        {

        }

        private void picDodaj_Click(object sender, EventArgs e)
        {
            formaNarudzbenicaUnos unos = new formaNarudzbenicaUnos();
            unos.Show();
        }

        private void formaNarudzbenica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't23_Enigma2DataSet.stavkeNarudzbenice' table. You can move, or remove it, as needed.
            this.stavkeNarudzbeniceTableAdapter.Fill(this.t23_Enigma2DataSet.stavkeNarudzbenice);
            // TODO: This line of code loads data into the 't23_Enigma2DataSet.Narudzbenica' table. You can move, or remove it, as needed.
            this.narudzbenicaTableAdapter.Fill(this.t23_Enigma2DataSet.Narudzbenica);

        }
    }
}
