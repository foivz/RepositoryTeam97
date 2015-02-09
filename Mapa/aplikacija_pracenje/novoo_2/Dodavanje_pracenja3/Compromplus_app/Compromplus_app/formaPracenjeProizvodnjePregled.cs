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
    public partial class formaPracenjeProizvodnjePregled : Form
    {
        private PracenjeProizvodnje selektiranoPracenje;
        int status;

        public formaPracenjeProizvodnjePregled()
        {
            InitializeComponent();
        }

        private void prikaziProizvodnje()
        {
            BindingList<PracenjeProizvodnje> listaProizvodnje = null;
            using (var db = new T23_EnigmaEntities())
            {
                listaProizvodnje = new BindingList<PracenjeProizvodnje>(db.PracenjeProizvodnje.ToList());
            }
            pracenjeProizvodnjeBindingSource.DataSource = listaProizvodnje;
        }


        private void picDodaj_Click(object sender, EventArgs e)
        {
            formaPracenjeProizvodnjeUnos pracenjeUnos = new formaPracenjeProizvodnjeUnos(selektiranoPracenje);
            pracenjeUnos.Show();
        }

          /// <summary>
        /// Instantno pretraživanje  ovisno o parametru unesenom u txtPretrazivanje, nakon čega
        /// rezultat dohavać u listu te prikazuje u datagridview-u
        /// </summary>

        private void txtPretrazivanje_TextChanged(object sender, EventArgs e)
        {
          
            T23_EnigmaEntities dc = new T23_EnigmaEntities();
            if (txtPretrazivanje.Text != string.Empty)
            {
                var items = dc.PracenjeProizvodnje.Where(s => s.naziv.Contains(txtPretrazivanje.Text) || s.opis.Contains(txtPretrazivanje.Text));
                dgvPracenje.DataSource = items.ToList();
            }
            else
                dgvPracenje.DataSource = dc.PracenjeProizvodnje.ToList();
        
        }

        private void picIzmjeni_Click(object sender, EventArgs e)
        {
            PracenjeProizvodnje selektiranoPracenje = pracenjeProizvodnjeBindingSource.Current as PracenjeProizvodnje;
            if (selektiranoPracenje != null)
            {
                formaPracenjeProizvodnjeUnos formaUnosPracenjeProizvodnje = new formaPracenjeProizvodnjeUnos(selektiranoPracenje);
                formaUnosPracenjeProizvodnje.ShowDialog();
                prikaziProizvodnje();
            }
        }

        private void picIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void picObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                PracenjeProizvodnje selektiranoPracenje = pracenjeProizvodnjeBindingSource.Current as PracenjeProizvodnje;
                if (selektiranoPracenje != null)
                {
                    using (var db = new T23_EnigmaEntities())
                    {
                        db.PracenjeProizvodnje.Attach(selektiranoPracenje);
                        db.PracenjeProizvodnje.Remove(selektiranoPracenje);
                        db.SaveChanges();
                    }
                    prikaziProizvodnje();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void formaPracenjeProizvodnjePregled_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't23_EnigmaDataSet5.Stroj' table. You can move, or remove it, as needed.
           // this.strojTableAdapter1.Fill(this.t23_EnigmaDataSet5.Stroj);
            // TODO: This line of code loads data into the 't23_EnigmaDataSet5.Artikl' table. You can move, or remove it, as needed.
            this.artiklTableAdapter1.Fill(this.t23_EnigmaDataSet5.Artikl);
            // TODO: This line of code loads data into the 't23_EnigmaDataSet5.Djelatnik' table. You can move, or remove it, as needed.
            this.djelatnikTableAdapter1.Fill(this.t23_EnigmaDataSet5.Djelatnik);
            //prikaziProizvodnje();
            // TODO: This line of code loads data into the 't23_EnigmaDataSet5.PracenjeProizvodnje' table. You can move, or remove it, as needed.
            this.pracenjeProizvodnjeTableAdapter1.Fill(this.t23_EnigmaDataSet5.PracenjeProizvodnje);
           

        }

        private void btnDjelatnik_Click(object sender, EventArgs e)
        {
            //formaStavkeDokumenta unos = new formaStavkeDokumenta(dokumentBindingSource.Current as Dokument);
            //unos.ShowDialog();
            //prikaziStavke(dokumentBindingSource.Current as Dokument);
        }

        private void formaPracenjeProizvodnjePregled_MouseUp(object sender, MouseEventArgs e)
        {
            formaPracenjeProizvodnjePregled browseOrdersFrom = new formaPracenjeProizvodnjePregled();
            browseOrdersFrom.MdiParent = this; //postavlja prozor kao djete od frmMain
            browseOrdersFrom.WindowState = FormWindowState.Maximized;
            browseOrdersFrom.Show();
        }

   

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pracenjeProizvodnjeBindingSource.EndEdit();
            this.pracenjeProizvodnjeTableAdapter.UpdateAll(this.t23_EnigmaDataSet1);
        }

        private void dgvPracenje_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvPracenje.RowCount > 0)
            {
                int IdStroj = int.Parse(dgvPracenje.CurrentRow.Cells[0].Value.ToString());
                this.strojTableAdapter.FillByIdStroj(this.t23_EnigmaDataSet5.Stroj, IdStroj);

            }  
        }

       
    }

}
