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
    public partial class formaRepromaterijaliPregled : Form

    {

        private Repromaterijali selektiraniRepromaterijal;

        public formaRepromaterijaliPregled()
        {
            InitializeComponent();
        }

        private void formaRepromaterijaliPregled_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't23_Enigma2DataSet.Repromaterijali' table. You can move, or remove it, as needed.
            this.repromaterijaliTableAdapter.Fill(this.t23_Enigma2DataSet.Repromaterijali);

        }

        /// <summary>
        /// Dohvaćamo listu svih repromaterijala iz baze podataka, te ih prikazujemo u datagridview-u
        /// </summary>
        private void prikaziRepromaterijale()
        {
            BindingList<Repromaterijali> listaRepromaterijali = null;
            using (var db = new T23_Enigma2Entities())
            {
                listaRepromaterijali = new BindingList<Repromaterijali>(db.Repromaterijali.ToList());
            }
            repromaterijaliBindingSource.DataSource = listaRepromaterijali;
        }

      

        /// <summary>
        /// Instantno pretraživanje repromaterijala ovisno o parametru unesenom u txtPretrazivanje, nakon čega
        /// rezultat dohavać u listu te prikazuje u datagridview-u
        /// </summary>
        private void txtPretrazivanje_TextChanged_1(object sender, EventArgs e)
        {

            T23_Enigma2Entities dc = new T23_Enigma2Entities();
            if (txtPretrazivanje.Text != string.Empty)
            {
                var items = dc.Repromaterijali.Where(s => s.naziv.Contains(txtPretrazivanje.Text) || s.opis.Contains(txtPretrazivanje.Text) || s.boja.Contains(txtPretrazivanje.Text));
                dgvRepromaterijali.DataSource = items.ToList();
            }
            else
                dgvRepromaterijali.DataSource = dc.Artikli.ToList();
        }


        /// <summary>
        /// Pretraživanje ovisno o ključu IdRepromaterijala.
        /// Na traženi red se selektira i fokusira pomoću Selected.Row-a
        /// </summary>

        private void btnPretrazivanjeSifra_Click_1(object sender, EventArgs e)
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
                    foreach (DataGridViewRow row in dgvRepromaterijali.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Equals(searchValue))
                        {
                            dgvRepromaterijali.ClearSelection();
                            rowIndex = row.Index;
                            dgvRepromaterijali.Rows[rowIndex].Selected = true;
                            dgvRepromaterijali.FirstDisplayedScrollingRowIndex = rowIndex;
                            break;
                        }
                    }
                }

                catch (Exception)
                {
                    MessageBox.Show("Traženi repromaterijal nije pronađen!");
                }
            }
        }
        private void picDodaj_Click(object sender, EventArgs e)
        {
            formaRepromaterijali formaUnosRepromaterijali = new formaRepromaterijali(selektiraniRepromaterijal);
            formaUnosRepromaterijali.ShowDialog();
            prikaziRepromaterijale();
        }

        private void picIzmjeni_Click(object sender, EventArgs e)
        {
            Repromaterijali selektiraniRepromaterijal = repromaterijaliBindingSource.Current as Repromaterijali;
            if (selektiraniRepromaterijal != null)
            {
                formaRepromaterijali formaUnosRepromaterijali = new formaRepromaterijali(selektiraniRepromaterijal);
                formaUnosRepromaterijali.ShowDialog();
                prikaziRepromaterijale();
            }
        }

        private void picObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                Repromaterijali selektiraniRepromaterijal = repromaterijaliBindingSource.Current as Repromaterijali;
                if (selektiraniRepromaterijal != null)
                {
                    using (var db = new T23_Enigma2Entities())
                    {
                        db.Repromaterijali.Attach(selektiraniRepromaterijal);
                        db.Repromaterijali.Remove(selektiraniRepromaterijal);
                        db.SaveChanges();
                    }
                    prikaziRepromaterijale();
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


    }
}
