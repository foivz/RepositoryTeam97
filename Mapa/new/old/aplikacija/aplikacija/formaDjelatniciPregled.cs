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
            using (var db = new T28EnigmaEntities28())
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
            T28EnigmaEntities28 dc = new T28EnigmaEntities28();
            if (txtPretrazivanje.Text != string.Empty)
            {
                var items = dc.Djelatnik.Where(s => s.ime.Contains(txtPretrazivanje.Text) || s.prezime.Contains(txtPretrazivanje.Text) || s.adresa.Contains(txtPretrazivanje.Text));
                dgvDjelatnici.DataSource = items.ToList();
            }
            else
                dgvDjelatnici.DataSource = dc.Djelatnik.ToList();   
        }

        private void picUnos_Click(object sender, EventArgs e)
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

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchValue = txtPretrazivanje2.Text;
            int rowIndex = -1;

            if (String.IsNullOrEmpty(txtPretrazivanje2.Text))
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

        private void picObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                Djelatnik selektiraniDjelatnik = djelatnikBindingSource.Current as Djelatnik;
                if (selektiraniDjelatnik != null)
                {
                    using (var db = new T28EnigmaEntities28())
                    {
                        db.Djelatnik.Attach(selektiraniDjelatnik);
                        db.Djelatnik.Remove(selektiraniDjelatnik);
                        db.SaveChanges();
                    }
                    prikaziDjelatnike();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
