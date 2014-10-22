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

        private void prikaziNarudzbu()
        {
            BindingList<Narudzbenica> listaNarudzbe = null;
            using (var db = new T23_Enigma2Entities())
            {
                listaNarudzbe = new BindingList<Narudzbenica>(db.Narudzbenica.ToList());
            }
            narudzbenicaBindingSource.DataSource = listaNarudzbe;
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
            formaNarudzbenicaUnos unos = new formaNarudzbenicaUnos(this, narudzba);
            unos.Show();
        }

        private void formaNarudzbenica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't23_Enigma2DataSet.stavkeNarudzbenice' table. You can move, or remove it, as needed.
            this.stavkeNarudzbeniceTableAdapter.Fill(this.t23_Enigma2DataSet.stavkeNarudzbenice);
            // TODO: This line of code loads data into the 't23_Enigma2DataSet.Narudzbenica' table. You can move, or remove it, as needed.
            this.narudzbenicaTableAdapter.Fill(this.t23_Enigma2DataSet.Narudzbenica);

        }

        private void picIzmjeni_Click(object sender, EventArgs e)
        {
            Narudzbenica selektiranaNarudzbenica = narudzbenicaBindingSource.Current as Narudzbenica;
            if (selektiranaNarudzbenica != null)
            {
                formaNarudzbenicaUnos formaUnosNarudzbenica = new formaNarudzbenicaUnos(selektiranaNarudzbenica);
                formaUnosNarudzbenica.ShowDialog();
                prikaziNarudzbu();
            }

        }
    }
}
