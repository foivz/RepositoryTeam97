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

        public formaPracenjeProizvodnjePregled()
        {
            InitializeComponent();
        }

        private void prikaziPracenje()
        {
            BindingList<PracenjeProizvodnje> listaPracenja = null;
            using (var db = new T23_EnigmaEntities())
            {
                listaPracenja = new BindingList<PracenjeProizvodnje>(db.PracenjeProizvodnje.ToList());
            }
            pracenjeProizvodnjeBindingSource.DataSource = listaPracenja;
        }


        private void formaPracenjeProizvodnjePregled_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't23_EnigmaDataSet2.Artikl' table. You can move, or remove it, as needed.
           // this.artiklTableAdapter.Fill(this.t23_EnigmaDataSet2.Artikl);
            // TODO: This line of code loads data into the 't23_EnigmaDataSet2.Djelatnik' table. You can move, or remove it, as needed.
            //this.djelatnikTableAdapter.Fill(this.t23_EnigmaDataSet2.Djelatnik);
            // TODO: This line of code loads data into the 't23_EnigmaDataSet2.Stroj' table. You can move, or remove it, as needed.
           // this.strojTableAdapter.Fill(this.t23_EnigmaDataSet2.Stroj);
            // TODO: This line of code loads data into the 't23_EnigmaDataSet2.PracenjeProizvodnje' table. You can move, or remove it, as needed.
            //this.pracenjeProizvodnjeTableAdapter.Fill(this.t23_EnigmaDataSet2.PracenjeProizvodnje);
            prikaziPracenje();

           
        }

        private void dgvPracenje_SelectionChanged(object sender, EventArgs e)
        {
            int IdStroj = int.Parse(dgvPracenje.CurrentRow.Cells[0].Value.ToString());
            this.strojTableAdapter.FillByIdStroj(this.t23_EnigmaDataSet2.Stroj, IdStroj );
            int IdDjelatnik = int.Parse(dgvPracenje.CurrentRow.Cells[0].Value.ToString());
            this.djelatnikTableAdapter.FillByIdDjelatnik(this.t23_EnigmaDataSet2.Djelatnik, IdDjelatnik);
            int IdArtikl = int.Parse(dgvPracenje.CurrentRow.Cells[0].Value.ToString());
            this.artiklTableAdapter.FillByIdArtikl(this.t23_EnigmaDataSet2.Artikl, IdArtikl);
        }



        /// <summary>
        /// Pretraživanje ovisno o ključu IdPracenjeProizvodnje.
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
                    foreach (DataGridViewRow row in dgvPracenje.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Equals(searchValue))
                        {
                            dgvPracenje.ClearSelection();
                            rowIndex = row.Index;
                            dgvPracenje.Rows[rowIndex].Selected = true;
                            dgvPracenje.FirstDisplayedScrollingRowIndex = rowIndex;
                            break;
                        }
                    }
                }

                catch (Exception)
                {
                    MessageBox.Show("Traženo praćenje proizvodnje nije pronađeno!");
                }
            }
        }

        private void picIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picIzvjestaj_Click(object sender, EventArgs e)
        {
            formaPracenjeProizvodnjeIzvjestaj izvjestaj = new formaPracenjeProizvodnjeIzvjestaj();
            izvjestaj.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            formaPracenjeProizvodnjeDjelatnika izvjestaj = new formaPracenjeProizvodnjeDjelatnika();
            izvjestaj.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            formaPracenjeProizvodnjeStrojevi izvjestaj = new formaPracenjeProizvodnjeStrojevi();
            izvjestaj.ShowDialog();
        }

        

        //private void picDodaj_Click(object sender, EventArgs e)
        //{
        //    formaPracenjeProizvodnjeUnos formaUnos = new formaPracenjeProizvodnjeUnos(selektiranoPracenje);
        //    formaUnos.ShowDialog();
        //    prikaziPracenje();
        //}

        //private void picIzmjeni_Click(object sender, EventArgs e)
        //{
        //    PracenjeProizvodnje selektiranoPracenje = pracenjeProizvodnjeBindingSource.Current as PracenjeProizvodnje;
        //    if (selektiranoPracenje != null)
        //    {
        //        formaPracenjeProizvodnjeUnos formaUnos = new formaPracenjeProizvodnjeUnos(selektiranoPracenje);
        //        formaUnos.ShowDialog();
        //        prikaziPracenje();
        //    }
        //}

        //private void picObrisi_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        PracenjeProizvodnje selektiranoPracenje = pracenjeProizvodnjeBindingSource.Current as PracenjeProizvodnje;
        //        if (selektiranoPracenje != null)
        //        {
        //            using (var db = new T23_EnigmaEntities())
        //            {
        //                db.PracenjeProizvodnje.Attach(selektiranoPracenje);
        //                db.PracenjeProizvodnje.Remove(selektiranoPracenje);
        //                db.SaveChanges();
        //            }
        //            prikaziPracenje();
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

       
    }
}
