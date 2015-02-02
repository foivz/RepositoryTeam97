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
    public partial class formaDjelatniciPregled : Form
    {
        private Djelatnik selektiraniDjelatnik;

        public formaDjelatniciPregled()
        {
            InitializeComponent();
        }

        private void prikaziDjelatnike()
        {
            BindingList<Djelatnik> listaDjelatnika = null;
            using (var db = new T23_EnigmaEntities())
            {
                listaDjelatnika = new BindingList<Djelatnik>(db.Djelatnik.ToList());
            }
            djelatnikBindingSource.DataSource = listaDjelatnika;
        }

        private void formaDjelatniciPregled_Load(object sender, EventArgs e)
        {
            prikaziDjelatnike();
        }

        private void txtPretrazivanje_TextChanged(object sender, EventArgs e)
        {
            T23_EnigmaEntities dc = new T23_EnigmaEntities();
            if (txtPretrazivanje.Text != string.Empty)
            {
                var items = dc.Djelatnik.Where(s => s.ime.Contains(txtPretrazivanje.Text) || s.prezime.Contains(txtPretrazivanje.Text) || s.adresa.Contains(txtPretrazivanje.Text));
                dgvDjelatnici.DataSource = items.ToList();
            }
            else
                dgvDjelatnici.DataSource = dc.Djelatnik.ToList(); 
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
                    foreach (DataGridViewRow row in dgvDjelatnici.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Equals(searchValue))
                        {
                            dgvDjelatnici.ClearSelection();
                            rowIndex = row.Index;
                            dgvDjelatnici.Rows[rowIndex].Selected = true;
                            dgvDjelatnici.FirstDisplayedScrollingRowIndex = rowIndex;
                            break;
                        }
                    }
                }

                catch (Exception)
                {
                    MessageBox.Show("Traženi djelatnik nije pronađen!");
                }
            }
        }

        private void picDodaj_Click(object sender, EventArgs e)
        {
            formaDjelatniciUnos formaUnos = new formaDjelatniciUnos(selektiraniDjelatnik);
            formaUnos.ShowDialog();
            prikaziDjelatnike();
        }

        private void picIzmjeni_Click(object sender, EventArgs e)
        {
            Djelatnik selektiraniDjelatnik = djelatnikBindingSource.Current as Djelatnik;
            if (selektiraniDjelatnik != null)
            {
                formaDjelatniciUnos formaUnosDjelatnici = new formaDjelatniciUnos(selektiraniDjelatnik);
                formaUnosDjelatnici.ShowDialog();
                prikaziDjelatnike();
            }
        }
    }
}
