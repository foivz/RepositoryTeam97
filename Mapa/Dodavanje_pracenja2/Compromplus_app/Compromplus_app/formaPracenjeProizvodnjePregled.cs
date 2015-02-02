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

        private void prikaziStroj(PracenjeProizvodnje stroj)
        {
            try
            {
                BindingList<Stroj> listaStroja = null;
                using (var db = new T23_EnigmaEntities())
                {
                    db.PracenjeProizvodnje.Attach(stroj);
                    listaStroja = new BindingList<Stroj>(stroj.Stroj.ToList<Stroj>());
                }
                strojBindingSource.DataSource = listaStroja;
            }

            catch (Exception)
            {

            }
        }

        private void prikaziArtikl(PracenjeProizvodnje artikl2)
        {
            try
            {
                BindingList<Artikl> listaArtikl = null;
                using (var db = new T23_EnigmaEntities())
                {
                    db.PracenjeProizvodnje.Attach(artikl2);
                    listaArtikl = new BindingList<Artikl>(artikl2.Artikl.ToList<Artikl>());
                }
                artiklBindingSource.DataSource = listaArtikl;
            }

            catch (Exception)
            {

            }
        }

        private void prikaziDjelatnika(PracenjeProizvodnje djelatnik)
        {
            try
            {
                BindingList<Djelatnik> listaDjelatnika = null;
                using (var db = new T23_EnigmaEntities())
                {
                    db.PracenjeProizvodnje.Attach(djelatnik);
                    listaDjelatnika = new BindingList<Djelatnik>(djelatnik.Djelatnik.ToList<Djelatnik>());
                }
                djelatnikBindingSource.DataSource = listaDjelatnika;
            }

            catch (Exception)
            {

            }
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



        //private void dgvPracenje_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (dgvPracenje.SelectedRows.Count > 0)
        //    {
        //        int selectedrowindex = dgvPracenje.SelectedCells[0].RowIndex;
        //        DataGridViewRow selectedRow = dgvPracenje.Rows[selectedrowindex];

        //        string stroj = Convert.ToString(selectedRow.Cells["stroj_idDataGridViewTextBoxColumn"].Value);
        //        status = int.Parse(stroj);

        //        //string kolicineTipDokumenta = Convert.ToString(selectedRow.Cells["tipDokumentaDataGridViewTextBoxColumn"].Value);
        //        //tipDokumenta = int.Parse(kolicineTipDokumenta);
        //    }

        //    PracenjeProizvodnje selektiranoPracenje = strojBindingSource.Current as PracenjeProizvodnje;
        //    if (selektiranoPracenje != null)
        //    {
        //        prikaziStroj(selektiranoPracenje);
        //    }
        //}
        private void formaPracenjeProizvodnjePregled_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't23_EnigmaDataSet4.Artikl' table. You can move, or remove it, as needed.
            this.artiklTableAdapter.Fill(this.t23_EnigmaDataSet4.Artikl);
            // TODO: This line of code loads data into the 't23_EnigmaDataSet3.Djelatnik' table. You can move, or remove it, as needed.
            this.djelatnikTableAdapter.Fill(this.t23_EnigmaDataSet3.Djelatnik);
            // TODO: This line of code loads data into the 't23_EnigmaDataSet2.Stroj' table. You can move, or remove it, as needed.
            this.strojTableAdapter.Fill(this.t23_EnigmaDataSet2.Stroj);
            prikaziProizvodnje();

            // TODO: This line of code loads data into the 't23_EnigmaDataSet1.PracenjeProizvodnje' table. You can move, or remove it, as needed.
            this.pracenjeProizvodnjeTableAdapter.Fill(this.t23_EnigmaDataSet1.PracenjeProizvodnje);
            prikaziStroj(pracenjeProizvodnjeBindingSource.Current as PracenjeProizvodnje);
            prikaziArtikl(pracenjeProizvodnjeBindingSource.Current as PracenjeProizvodnje);
            prikaziDjelatnika(pracenjeProizvodnjeBindingSource.Current as PracenjeProizvodnje);


        }
    }

}
