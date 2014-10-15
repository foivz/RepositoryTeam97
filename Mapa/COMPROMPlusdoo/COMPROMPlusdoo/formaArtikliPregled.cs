using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPROMPlusdoo
{
    public partial class formaArtikliPregled : Form
    {
        private Artikli selektiraniArtikl;

        public formaArtikliPregled()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Dohvaćamo listu svih artikala iz baze podataka, te ih prikazujemo u datagridview-u
        /// </summary>
        private void prikaziArtikle()
        {
            BindingList<Artikli> listaArtikala = null;
            using (var db = new T23_Enigma2Entities())
            {
                listaArtikala = new BindingList<Artikli>(db.Artikli.ToList());
            }
            bindingSourceArtikli.DataSource = listaArtikala;
        }

        private void formaArtikliPregled_Load1(object sender, EventArgs e)
        {
            prikaziArtikle();
        }

        /// <summary>
        /// Instantno pretraživanje artikala ovisno o parametru unesenom u txtPretrazivanje, nakon čega
        /// rezultat dohavać u listu te prikazuje u datagridview-u
        /// </summary>
        private void txtPretrazivanje_TextChanged_1(object sender, EventArgs e)
        {
            T23_Enigma2Entities dc = new T23_Enigma2Entities();
            if (txtPretrazivanje.Text != string.Empty)
            {
                var items = dc.Artikli.Where(s => s.naziv.Contains(txtPretrazivanje.Text) || s.opis.Contains(txtPretrazivanje.Text) || s.boja.Contains(txtPretrazivanje.Text));
                dgvArtikli.DataSource = items.ToList();
            }
            else
                dgvArtikli.DataSource = dc.Artikli.ToList();
        }


        /// <summary>
        /// Pretraživanje ovisno o ključu IdArtikli.
        /// Na traženi red se selektira i fokusira pomoću Selected.Row-a
        /// </summary>
        private void btnPretrazivanjeSifra_Click_1(object sender, EventArgs e)
        {

        }

        private void picDodaj_Click(object sender, EventArgs e)
        {
            formaArtikliUnos formaUnos = new formaArtikliUnos(selektiraniArtikl);
            formaUnos.ShowDialog();
            prikaziArtikle();
        }

        private void picIzmjeni_Click(object sender, EventArgs e)
        {
            Artikli selektiraniArtikl = bindingSourceArtikli.Current as Artikli;
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
                Artikli selektiraniArtikl = bindingSourceArtikli.Current as Artikli;
                if (selektiraniArtikl != null)
                {
                    using (var db = new T23_Enigma2Entities())
                    {
                        db.Artikli.Attach(selektiraniArtikl);
                        db.Artikli.Remove(selektiraniArtikl);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


      

        
    }
}
