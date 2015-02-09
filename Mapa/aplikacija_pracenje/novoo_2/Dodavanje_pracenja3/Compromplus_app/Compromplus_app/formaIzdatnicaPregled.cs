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
    public partial class formaIzdatnicaPregled : Form
    {

        private Izdatnica proknjizi;
        int status;

        public formaIzdatnicaPregled()
        {
            InitializeComponent();
        }

        private void prikaziIzdatnice()
        {
            BindingList<Izdatnica> listaDokumenata = null;
            using (var db = new T23_EnigmaEntities())
            {
                listaDokumenata = new BindingList<Izdatnica>(db.Izdatnica.ToList());
            }
            izdatnicaBindingSource.DataSource = listaDokumenata;


        }

        private void prikaziStavke(Izdatnica izdatnica)
        {
            try
            {
                BindingList<stavkeIzdatnice> listaStavki = null;
                using (var db = new T23_EnigmaEntities())
                {
                    db.Izdatnica.Attach(izdatnica);
                    listaStavki = new BindingList<stavkeIzdatnice>(izdatnica.stavkeIzdatnice.ToList<stavkeIzdatnice>());
                }
                stavkeIzdatniceBindingSource.DataSource = listaStavki;
            }

            catch (Exception)
            {

            }
        }

        private void formaIzdatnicaPregled_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't23_EnigmaDataSet8.stavkeIzdatnice' table. You can move, or remove it, as needed.
            //this.stavkeIzdatniceTableAdapter.Fill(this.t23_EnigmaDataSet8.stavkeIzdatnice);
            // TODO: This line of code loads data into the 't23_EnigmaDataSet7.Izdatnica' table. You can move, or remove it, as needed.
            //this.izdatnicaTableAdapter.Fill(this.t23_EnigmaDataSet7.Izdatnica);
            prikaziIzdatnice();
            prikaziStavke(izdatnicaBindingSource.Current as Izdatnica);

        }



        private void picIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picDodaj_Click(object sender, EventArgs e)
        {
            formaIzdatnicaUnos unos = new formaIzdatnicaUnos();
            unos.ShowDialog();
            prikaziIzdatnice();
        }

        private void dgvIzdatnice_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvIzdatnice.SelectedRows.Count > 0)
            {
                int selectedrowindex = dgvIzdatnice.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvIzdatnice.Rows[selectedrowindex];

                string knjizenje = Convert.ToString(selectedRow.Cells["knjizenjeDokDataGridViewTextBoxColumn"].Value);
                status = int.Parse(knjizenje);

            }

            Izdatnica selektiranaIzdatnica = izdatnicaBindingSource.Current as Izdatnica;
            if (selektiranaIzdatnica != null)
            {
                prikaziStavke(selektiranaIzdatnica);
            }
        }

        private void btnNovaStavka_Click(object sender, EventArgs e)
        {
            if (status == 1)
            {
                formaStavkeIzdatnice unos = new formaStavkeIzdatnice(izdatnicaBindingSource.Current as Izdatnica);
                unos.ShowDialog();
                prikaziStavke(izdatnicaBindingSource.Current as Izdatnica);
            }
            else
            {
                MessageBox.Show("Nemoguće dodati stavku. Dokument je već proknjižen");
            }
        }

        private void picProknjizi_Click(object sender, EventArgs e)
        {
            if (status == 1)
            {
                Izdatnica selektiranaIzdatnica = izdatnicaBindingSource.Current as Izdatnica;
                if (selektiranaIzdatnica != null)
                {
                    proknjiziDokument(selektiranaIzdatnica);
                    kolicineIzdatnica();
                    MessageBox.Show("Dokument je proknjižen");
                }

            }

            else
            {
                MessageBox.Show("Dokument je već proknjižen");
            }
        }

        private void proknjiziDokument(Izdatnica izdatnica)
        {
            proknjizi = izdatnica;

            using (var db = new T23_EnigmaEntities())
            {
                db.Izdatnica.Attach(proknjizi); //registriramo postojeći dokument
                //proknjizi.knjizenjeDokumenta = 2;
                db.SaveChanges();
            }
            dgvIzdatnice.Refresh();
        }

        private void kolicineIzdatnica()
        {
            var baza = new T23_EnigmaEntities();
            foreach (DataGridViewRow red in dgvStavkeIzdatnice.Rows)
            {
                int id = Convert.ToInt32(red.Cells[0].Value);
                var kol = Convert.ToInt32(red.Cells[2].Value); ;
                var artikl = baza.Artikl.First(o => o.IdArtikl == id);
                artikl.kolicina = artikl.kolicina - kol;
                baza.SaveChanges();
            }
        }

        private void txtPretrazivanje_TextChanged(object sender, EventArgs e)
        {
            T23_EnigmaEntities dc = new T23_EnigmaEntities();
            if (txtPretrazivanje.Text != string.Empty)
            {
                var items = dc.Izdatnica.Where(s => s.opis.Contains(txtPretrazivanje.Text));
                dgvIzdatnice.DataSource = items.ToList();
            }
            else
                dgvIzdatnice.DataSource = dc.Dokument.ToList();
        }

        private void btnPretrazivanjeSifra_Click(object sender, EventArgs e)
        {
            string searchValue = txtPretrazivanjeSifra.Text;
            int rowIndex = -1;

            if (String.IsNullOrEmpty(txtPretrazivanjeSifra.Text))
            {
                MessageBox.Show("Unesite šifru!");
            }
            else
            {
                try
                {
                    foreach (DataGridViewRow row in dgvIzdatnice.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Equals(searchValue))
                        {
                            dgvIzdatnice.ClearSelection();
                            rowIndex = row.Index;
                            dgvIzdatnice.Rows[rowIndex].Selected = true;
                            dgvIzdatnice.FirstDisplayedScrollingRowIndex = rowIndex;
                            break;
                        }
                    }
                }

                catch (Exception)
                {
                    MessageBox.Show("Traženi artikl nije pronađen!");
                }
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (status == 1)
            {
                try
                {
                    stavkeIzdatnice stavke = stavkeIzdatniceBindingSource.Current as stavkeIzdatnice;
                    if (stavke != null)
                    {
                        using (var db = new T23_EnigmaEntities())
                        {
                            db.stavkeIzdatnice.Attach(stavke);
                            db.stavkeIzdatnice.Remove(stavke);
                            db.SaveChanges();
                        }
                        prikaziStavke(izdatnicaBindingSource.Current as Izdatnica);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Nemoguće obrisati stavke proknjiženih dokumenata");
            }
        }

        private void picObrisi_Click(object sender, EventArgs e)
        {
            if (status == 1)
            {
                Izdatnica selektiranaIzdatnica = izdatnicaBindingSource.Current as Izdatnica;
                if (selektiranaIzdatnica!= null)
                {
                    if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        using (var db = new T23_EnigmaEntities())
                        {
                            db.Izdatnica.Attach(selektiranaIzdatnica);
                            if (selektiranaIzdatnica.stavkeIzdatnice.Count == 0)
                            {
                                db.Izdatnica.Remove(selektiranaIzdatnica);
                                db.SaveChanges();
                            }

                            else
                            {
                                MessageBox.Show("Nije moguće obrisati Izdatnicu koji sadrži stavke!");
                            }
                        }
                        prikaziIzdatnice();
                    }
                }
            }

            else
            {
                MessageBox.Show("Nemoguće obrisati izdatnicu koji je već proknjižen");
            }
        }


    }
}
