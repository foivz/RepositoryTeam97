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
    public partial class formaRepromaterijaliPregled : Form
    {


        private Repromaterijal selektiraniRepromaterijal;

        public formaRepromaterijaliPregled()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Dohvaćamo listu svih repromaterijala iz baze podataka, te ih prikazujemo u datagridview-u
        /// </summary>
        private void prikaziRepromaterijal()
        {
            BindingList<Repromaterijal> listaRepromaterijala = null;
            using (var db = new T23_EnigmaEntities())
            {
                listaRepromaterijala = new BindingList<Repromaterijal>(db.Repromaterijal.ToList());
            }
            repromaterijalBindingSource.DataSource = listaRepromaterijala;
        }



        private void formaRepromaterijaliPregled_Load(object sender, EventArgs e)
        {

            prikaziRepromaterijal();
            // TODO: This line of code loads data into the 't23_EnigmaDataSet3.Repromaterijal' table. You can move, or remove it, as needed.
            this.repromaterijalTableAdapter.Fill(this.t23_EnigmaDataSet3.Repromaterijal);

        }


        /// <summary>
        /// Instantno pretraživanje reproamterijala ovisno o parametru unesenom u txtPretrazivanje, nakon čega
        /// rezultat dohavać u listu te prikazuje u datagridview-u
        /// </summary>
        private void txtPretrazivanje_TextChanged(object sender, EventArgs e)
        {
            T23_EnigmaEntities dc = new T23_EnigmaEntities();
            if (txtPretrazivanje.Text != string.Empty)
            {
                var items = dc.Repromaterijal.Where(s => s.naziv.Contains(txtPretrazivanje.Text) || s.opis.Contains(txtPretrazivanje.Text) || s.boja.Contains(txtPretrazivanje.Text));
                dgvRepromaterijali.DataSource = items.ToList();
            }
            else
                dgvRepromaterijali.DataSource = dc.Repromaterijal.ToList();
        }




        /// <summary>
        /// Pretraživanje ovisno o ključu IdRepromaterijal.
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
            formaRepromaterijaliUnos formaUnosRepromaterijala = new formaRepromaterijaliUnos(selektiraniRepromaterijal);
            formaUnosRepromaterijala.ShowDialog();
            prikaziRepromaterijal();
        }


        private void picIzmjeni_Click(object sender, EventArgs e)
        {
            Repromaterijal selektiranirepromaterijal = repromaterijalBindingSource.Current as Repromaterijal;
            if (selektiraniRepromaterijal != null)
            {
                formaRepromaterijaliUnos formaUnosRepromaterijali = new formaRepromaterijaliUnos(selektiraniRepromaterijal);
                formaUnosRepromaterijali.ShowDialog();
                prikaziRepromaterijal();
            }
        }
        private void picIzlaz_Click(object sender, EventArgs e)
        {

        }

  
    }
}
