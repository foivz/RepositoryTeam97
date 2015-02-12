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
    public partial class formaUtrosakPregled : Form
    {
        private Utrosak selektiraniUtrosak;

        public formaUtrosakPregled()
        {
            InitializeComponent();
        }

        //private void prikaziUtrosak()
        //{
        //    BindingList<Utrosak> listaUtroska = null;
        //    using (var db = new T23_EnigmaEntities())
        //    {
        //        listaUtroska = new BindingList<Utrosak>(db.Utrosak.ToList());
        //    }
        //    utrosakBindingSource.DataSource = listaUtroska;
        //}

        
        private void formaUtrosakPregled_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't23_EnigmaDataSet1.Repromaterijal' table. You can move, or remove it, as needed.
           // this.repromaterijalTableAdapter.Fill(this.t23_EnigmaDataSet1.Repromaterijal);
            // TODO: This line of code loads data into the 't23_EnigmaDataSet1.Artikl' table. You can move, or remove it, as needed.
            this.artiklTableAdapter.Fill(this.t23_EnigmaDataSet1.Artikl);
            // TODO: This line of code loads data into the 't23_EnigmaDataSet1.Utrosak' table. You can move, or remove it, as needed.
            //this.utrosakTableAdapter.Fill(this.t23_EnigmaDataSet1.Utrosak);
           
        }

        private void dgvArtikl_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArtikl.RowCount > 0)
            {
                int IdArtikl = int.Parse(dgvArtikl.CurrentRow.Cells[0].Value.ToString());
                this.utrosakTableAdapter.FillById(this.t23_EnigmaDataSet1.Utrosak,IdArtikl);
                this.repromaterijalTableAdapter.FillByArtikl(this.t23_EnigmaDataSet1.Repromaterijal, IdArtikl);
            }
        }

        private void picIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picIzvjestaj_Click(object sender, EventArgs e)
        {
            formaUtrosakIzvjestaj izvjestaj = new formaUtrosakIzvjestaj();
            izvjestaj.ShowDialog();
        }
        /// <summary>
        /// Pretraživanje ovisno o ključu IdUtrosak.
        /// Na traženi red se selektira i fokusira pomoću Selected.Row-a
        /// </summary>
        //private void btnPretrazivanjeSifra_Click(object sender, EventArgs e)
        //{
        //    string searchValue = txtPretrazivanjeSifra.Text;
        //    int rowIndex = -1;

        //    if (String.IsNullOrEmpty(txtPretrazivanjeSifra.Text))
        //    {
        //        MessageBox.Show("Unesite šifru!");
        //    }
        //    else
        //    {
        //        try
        //        {
        //            foreach (DataGridViewRow row in dgvUtrosak.Rows)
        //            {
        //                if (row.Cells[0].Value.ToString().Equals(searchValue))
        //                {
        //                    dgvUtrosak.ClearSelection();
        //                    rowIndex = row.Index;
        //                    dgvUtrosak.Rows[rowIndex].Selected = true;
        //                    dgvUtrosak.FirstDisplayedScrollingRowIndex = rowIndex;
        //                    break;
        //                }
        //            }
        //        }

        //        catch (Exception)
        //        {
        //            MessageBox.Show("Traženi utrošak nije pronađen!");
        //        }
        //    }
        //}

        //private void picDodaj_Click(object sender, EventArgs e)
        //{
        //    formaUtrosakUnos formaUnos = new formaUtrosakUnos(selektiraniUtrosak);
        //    formaUnos.ShowDialog();
        //    prikaziUtrosak();
        //}

        //private void picIzmjeni_Click(object sender, EventArgs e)
        //{
        //    Utrosak selektiraniUtrosak = utrosakBindingSource.Current as Utrosak;
        //    if (selektiraniUtrosak != null)
        //    {
        //        formaUtrosakUnos formaUnos = new formaUtrosakUnos(selektiraniUtrosak);
        //        formaUnos.ShowDialog();
        //        prikaziUtrosak();
        //    }
        //}

        //private void picObrisi_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Utrosak selektiraniUtrosak = utrosakBindingSource.Current as Utrosak;
        //        if (selektiraniUtrosak != null)
        //        {
        //            using (var db = new T23_EnigmaEntities())
        //            {
        //                db.Utrosak.Attach(selektiraniUtrosak);
        //                db.Utrosak.Remove(selektiraniUtrosak);
        //                db.SaveChanges();
        //            }
        //            prikaziUtrosak();
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        
        
        }
    }

