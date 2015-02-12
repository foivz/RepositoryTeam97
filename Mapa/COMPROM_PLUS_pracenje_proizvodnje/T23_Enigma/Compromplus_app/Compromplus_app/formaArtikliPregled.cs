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
    public partial class formaArtikliPregled : Form
    {
        private Artikl selektiraniArtikl;

        public formaArtikliPregled()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Dohvaćamo listu svih artikala iz baze podataka, te ih prikazujemo u datagridview-u
        /// </summary>
        private void prikaziArtikle()
        {
            BindingList<Artikl> listaArtikala = null;
            using (var db = new T23_EnigmaEntities())
            {
                listaArtikala = new BindingList<Artikl>(db.Artikl.ToList());
            }
            artiklBindingSource.DataSource = listaArtikala;
        }

        private void formaArtikliPregled_Load(object sender, EventArgs e)
        {
            prikaziArtikle();
        }

        /// <summary>
        /// Instantno pretraživanje artikala ovisno o parametru unesenom u txtPretrazivanje, nakon čega
        /// rezultat dohavać u listu te prikazuje u datagridview-u
        /// </summary>
        private void txtPretrazivanje_TextChanged(object sender, EventArgs e)
        {
            T23_EnigmaEntities dc = new T23_EnigmaEntities();
            if (txtPretrazivanje.Text != string.Empty)
            {
                var items = dc.Artikl.Where(s => s.naziv.Contains(txtPretrazivanje.Text) || s.opis.Contains(txtPretrazivanje.Text) || s.boja.Contains(txtPretrazivanje.Text));
                dgvArtikli.DataSource = items.ToList();
            }
            else
                dgvArtikli.DataSource = dc.Artikl.ToList();
        }


        /// <summary>
        /// Pretraživanje ovisno o ključu IdArtikli.
        /// Na traženi red se selektira i fokusira pomoću Selected.Row-a
        /// </summary>
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
                    foreach (DataGridViewRow row in dgvArtikli.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Equals(searchValue))
                        {
                            dgvArtikli.ClearSelection();
                            rowIndex = row.Index;
                            dgvArtikli.Rows[rowIndex].Selected = true;
                            dgvArtikli.FirstDisplayedScrollingRowIndex = rowIndex;
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

        private void picDodaj_Click(object sender, EventArgs e)
        {
            formaArtikliUnos formaUnos = new formaArtikliUnos(selektiraniArtikl);
            formaUnos.ShowDialog();
            prikaziArtikle();
        }

        private void picIzmjeni_Click(object sender, EventArgs e)
        {
            Artikl selektiraniArtikl = artiklBindingSource.Current as Artikl;
            if (selektiraniArtikl != null)
            {
                formaArtikliUnos formaUnosArtikli = new formaArtikliUnos(selektiraniArtikl);
                formaUnosArtikli.ShowDialog();
                prikaziArtikle();
            }
        }

        private void picObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                Artikl selektiraniArtikl = artiklBindingSource.Current as Artikl;
                if (selektiraniArtikl != null)
                {
                    using (var db = new T23_EnigmaEntities())
                    {
                        db.Artikl.Attach(selektiraniArtikl);
                        db.Artikl.Remove(selektiraniArtikl);
                        db.SaveChanges();
                    }
                    prikaziArtikle();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void picIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvArtikli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
