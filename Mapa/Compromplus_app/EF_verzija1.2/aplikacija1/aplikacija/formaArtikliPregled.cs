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
    public partial class formaArtikliPregled : Form
    {
        public formaArtikliPregled()
        {
            InitializeComponent();
            T28EnigmaEntities28 dc = new T28EnigmaEntities28();
            dgvArtikli.DataSource = dc.Artikli.ToList();

        }

        private Artikli selektiraniArtikl; 

        private void prikaziArtikle()
        {
            BindingList<Artikli> listaArtikala = null;
            using (var db = new T28EnigmaEntities28())
            {
                listaArtikala = new BindingList<Artikli>(db.Artikli.ToList());
            }
            artikliBindingSource.DataSource = listaArtikala;
        }

        private void formaArtikliPregled_Load(object sender, EventArgs e)
        {
            prikaziArtikle();
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            formaArtikliUnos formaUnos = new formaArtikliUnos(selektiraniArtikl);
            formaUnos.ShowDialog();
            prikaziArtikle();
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            Artikli selektiraniArtikl = artikliBindingSource.Current as Artikli;
            if (selektiraniArtikl != null)
            {
                formaArtikliUnos formaUnos = new formaArtikliUnos(selektiraniArtikl);
                formaUnos.ShowDialog();
                prikaziArtikle();

            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            Artikli selektiraniArtikli = artikliBindingSource.Current as Artikli;
            if (selektiraniArtikl != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!",
                        MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new T28EnigmaEntities28())
                    {
                        db.Artikli.Attach(selektiraniArtikl);
                        db.Artikli.Remove(selektiraniArtikl);
                        db.SaveChanges();
                    }
                    prikaziArtikle();

                }

            }

        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPretrazivanje_TextChanged(object sender, EventArgs e)
        {
            T28EnigmaEntities28 dc = new T28EnigmaEntities28();
            if (txtPretrazivanje.Text != string.Empty)
            {
                var items = dc.Artikli.Where(s => s.naziv.Contains(txtPretrazivanje.Text) || s.opis.Contains(txtPretrazivanje.Text) || s.boja.Contains(txtPretrazivanje.Text));
                dgvArtikli.DataSource = items.ToList();
            }
            else
                dgvArtikli.DataSource = dc.Artikli.ToList();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text;
            int rowIndex = -1;

                foreach (DataGridViewRow row in dgvArtikli.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {
                        dgvArtikli.ClearSelection();
                        rowIndex = row.Index;
                        dgvArtikli.Rows[rowIndex].Selected = true;
                        dgvArtikli.FirstDisplayedScrollingRowIndex = rowIndex;                            
                        break;
                    }
                 }
        }

        

        

    }
}
