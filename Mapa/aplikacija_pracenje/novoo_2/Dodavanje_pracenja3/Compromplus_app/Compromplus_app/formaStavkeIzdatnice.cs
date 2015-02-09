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
    public partial class formaStavkeIzdatnice : Form
    {
        private Izdatnica selektirana;
        int selektiraniArtikl;

        public formaStavkeIzdatnice(Izdatnica izdatnica)
        {
            InitializeComponent();
            selektirana = izdatnica;
            T23_EnigmaEntities db = new T23_EnigmaEntities();
        }

        private void prikaziArtikle()
        {
            BindingList<Artikl> listaArtikala = null;
            using (var db = new T23_EnigmaEntities())
            {
                listaArtikala = new BindingList<Artikl>(db.Artikl.ToList());
            }
            artiklBindingSource.DataSource = listaArtikala;
        }

        private void dgvArtikli_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArtikli.SelectedRows.Count > 0)
            {
                selektiraniArtikl = int.Parse(dgvArtikli.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void picSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new T23_EnigmaEntities())
            {

                db.Izdatnica.Attach(selektirana);
                stavkeIzdatnice stavke = new stavkeIzdatnice
                {
                    idArtikla = selektiraniArtikl,
                    Izdatnica = selektirana,
                    kolicina = int.Parse(txtKolicina.Text),
                };
                db.stavkeIzdatnice.Add(stavke);
                db.SaveChanges();
            }
            Close();
        }

        private void picIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void formaStavkeIzdatnice_Load(object sender, EventArgs e)
        {
            prikaziArtikle();
        }

        
    }
}
