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
    public partial class formaDokumentiPregled : Form
    {
        //int selektiraniArtikl;
        private Dokument proknjizi;
        int status;
        int tipDokumenta;

        public formaDokumentiPregled()
        {
            InitializeComponent();
        }

        private void prikaziDokumente()
        {
            BindingList<Dokument> listaDokumenata = null;
            using (var db = new T23_EnigmaEntities())
            {
                listaDokumenata = new BindingList<Dokument>(db.Dokument.ToList());
            }
            dokumentBindingSource.DataSource = listaDokumenata;
      

        }

        private void prikaziStavke(Dokument dokument)
        {
            try
            {
                BindingList<StavkeDokumenta> listaStavki = null;
                using (var db = new T23_EnigmaEntities())
                {
                    db.Dokument.Attach(dokument);
                    listaStavki = new BindingList<StavkeDokumenta>(dokument.StavkeDokumenta.ToList<StavkeDokumenta>());
                }
                stavkeDokumentaBindingSource.DataSource = listaStavki;
            }

            catch (Exception)
            {

            }
        }

        private void formaDokumentiPregled_Load(object sender, EventArgs e)
        {
            prikaziDokumente();
            prikaziStavke(dokumentBindingSource.Current as Dokument);

            
        }

        private void dgvDokumenti_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvDokumenti.SelectedRows.Count > 0)
            {
                int selectedrowindex = dgvDokumenti.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvDokumenti.Rows[selectedrowindex];

                string knjizenje = Convert.ToString(selectedRow.Cells["knjizenjeDokumentaDataGridViewTextBoxColumn"].Value);
                status = int.Parse(knjizenje);

                string kolicineTipDokumenta = Convert.ToString(selectedRow.Cells["tipDokumentaDataGridViewTextBoxColumn"].Value);
                tipDokumenta = int.Parse(kolicineTipDokumenta);
            }

            Dokument selektiraniDokument = dokumentBindingSource.Current as Dokument;
            if (selektiraniDokument != null)
            {
                prikaziStavke(selektiraniDokument);
            }
        }

        private void picIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picDodaj_Click(object sender, EventArgs e)
        {
            formaDokumentiUnos unos = new formaDokumentiUnos();
            unos.ShowDialog();
            prikaziDokumente();
        }

        private void btnNovaStavka_Click(object sender, EventArgs e)
        {
            if (status == 1)
            {
                formaStavkeDokumenta unos = new formaStavkeDokumenta(dokumentBindingSource.Current as Dokument);
                unos.ShowDialog();
                prikaziStavke(dokumentBindingSource.Current as Dokument);
            }
            else
            {
                MessageBox.Show("Nemoguće dodati stavku. Dokument je već proknjižen");
            }
        }

        private void picProknjizi_Click(object sender, EventArgs e)
        {
            if (status == 1)
            {
                Dokument selektiraniDokument = dokumentBindingSource.Current as Dokument;
                if (selektiraniDokument != null)
                {
                    if (tipDokumenta == 1)
                    {
                        proknjiziDokument(selektiraniDokument);
                        kolicinePrimka();
                        MessageBox.Show("Dokument je proknjižen");
                    }

                    if (tipDokumenta == 2 || tipDokumenta == 3)
                    {
                        proknjiziDokument(selektiraniDokument);
                        kolicineOstali();
                        MessageBox.Show("Dokument je proknjižen");
                    }
                    
                }
            }

            else
            {
                MessageBox.Show("Dokument je već proknjižen");
            }

        }

        private void proknjiziDokument(Dokument dokument)
        {
            proknjizi = dokument;

            using (var db = new T23_EnigmaEntities())
            {
                db.Dokument.Attach(proknjizi); //registriramo postojeći dokument
                    proknjizi.knjizenjeDokumenta = 2;
                db.SaveChanges();
            }
            dgvDokumenti.Refresh();
        }


       

        private void kolicinePrimka()
        {
            var baza = new T23_EnigmaEntities();
            foreach (DataGridViewRow red in dgvStavkeDokumenata.Rows)
            {
                int id = Convert.ToInt32(red.Cells[0].Value); //dohvati idArtikla
                var kol = Convert.ToInt32(red.Cells[2].Value); ; //dohvati kolicinu stavke
                var artikl = baza.Artikl.First(o => o.IdArtikl == id);//id = prosljedjeni artikl
                artikl.kolicina = artikl.kolicina + kol;//postojeca kolicina + nova;
                baza.SaveChanges();
            }
        }


        //smanjenje kolicina za otpremincu i izdatnicu
        private void kolicineOstali()
        {
            var baza = new T23_EnigmaEntities();
            foreach (DataGridViewRow red in dgvStavkeDokumenata.Rows)
            {
                int id = Convert.ToInt32(red.Cells[0].Value); 
                var kol = Convert.ToInt32(red.Cells[2].Value); ; 
                var artikl = baza.Artikl.First(o => o.IdArtikl == id);
                artikl.kolicina = artikl.kolicina - kol;
                baza.SaveChanges();
            }
        }

        

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (status == 1)
            {
                try
                {
                    StavkeDokumenta stavke = stavkeDokumentaBindingSource.Current as StavkeDokumenta;
                    if (stavke != null)
                    {
                        using (var db = new T23_EnigmaEntities())
                        {
                            db.StavkeDokumenta.Attach(stavke);
                            db.StavkeDokumenta.Remove(stavke);
                            db.SaveChanges();
                        }
                        prikaziStavke(dokumentBindingSource.Current as Dokument);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Nemoguće obrisati stavke proknjiženih dokumenata");
            }
        }

        private void picObrisi_Click(object sender, EventArgs e)
        {
            if (status == 1)
            {
                Dokument selektiraniDokument = dokumentBindingSource.Current as Dokument;
                if (selektiraniDokument != null)
                {
                    if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        using (var db = new T23_EnigmaEntities())
                        {
                            db.Dokument.Attach(selektiraniDokument);
                            if (selektiraniDokument.StavkeDokumenta.Count == 0)
                            {
                                db.Dokument.Remove(selektiraniDokument);
                                db.SaveChanges();
                            }

                            else
                            {
                                MessageBox.Show("Nije moguće obrisati dokument koji sadrži stavke!");
                            }
                        }
                        prikaziDokumente();
                    }
                }
            }

            else
            {
                MessageBox.Show("Nmoguće obrisati dokument koji je već proknjižen");
            }
        }

        private void txtPretrazivanje_TextChanged(object sender, EventArgs e)
        {
            T23_EnigmaEntities dc = new T23_EnigmaEntities();
            if (txtPretrazivanje.Text != string.Empty)
            {
                var items = dc.Dokument.Where(s => s.opis.Contains(txtPretrazivanje.Text));
                dgvDokumenti.DataSource = items.ToList();
            }
            else
                dgvDokumenti.DataSource = dc.Dokument.ToList();
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
                    foreach (DataGridViewRow row in dgvDokumenti.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Equals(searchValue))
                        {
                            dgvDokumenti.ClearSelection();
                            rowIndex = row.Index;
                            dgvDokumenti.Rows[rowIndex].Selected = true;
                            dgvDokumenti.FirstDisplayedScrollingRowIndex = rowIndex;
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

        private void picIzmjeni_Click(object sender, EventArgs e)
        {

        }

        
       
    }
}
