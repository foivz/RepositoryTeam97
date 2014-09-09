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
    public partial class formaRepromaterijaliPregled : Form
    {
        private Repromaterijal selektiraniRepromaterijal;
        public formaRepromaterijaliPregled()
        {
            InitializeComponent();
        }

        public void prikaziRepromaterijale()
        {
            BindingList<Repromaterijal> listaRepromaterijala = null;
            using (var db = new T28EnigmaEntities28())
            {
                listaRepromaterijala = new BindingList<Repromaterijal>(db.Repromaterijal.ToList());
            }
            repromaterijalBindingSource.DataSource = listaRepromaterijala;
        }

        private void formaRepromaterijaliPregled_Load(object sender, EventArgs e)
        {
            prikaziRepromaterijale();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            T28EnigmaEntities28 dc = new T28EnigmaEntities28();
            if (txtPretrazivanje.Text != string.Empty)
            {
                var items = dc.Repromaterijal.Where(s => s.boja.Contains(txtPretrazivanje.Text) || s.opis.Contains(txtPretrazivanje.Text) || s.vrsta_materijala.Contains(txtPretrazivanje.Text));
                dgvRepromaterijal.DataSource = items.ToList();
            }
            else
                dgvRepromaterijal.DataSource = dc.Artikli.ToList();
        }

        private void picUnos_Click(object sender, EventArgs e)
        {
            formaRepromaterijalUnos formaUnosRepromaterijala = new formaRepromaterijalUnos(selektiraniRepromaterijal);
            formaUnosRepromaterijala.ShowDialog();
            prikaziRepromaterijale();
        }

        private void picSpremi_Click(object sender, EventArgs e)
        {
            Repromaterijal selektiraniRepromaterijal = repromaterijalBindingSource.Current as Repromaterijal;
            if (selektiraniRepromaterijal != null)
            {
                formaRepromaterijalUnos formaUnosRepromaterijala = new formaRepromaterijalUnos(selektiraniRepromaterijal);
                formaUnosRepromaterijala.ShowDialog();
                prikaziRepromaterijale();
            }
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
                    foreach (DataGridViewRow row in dgvRepromaterijal.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Equals(searchValue))
                        {
                            dgvRepromaterijal.ClearSelection();
                            rowIndex = row.Index;
                            dgvRepromaterijal.Rows[rowIndex].Selected = true;
                            dgvRepromaterijal.FirstDisplayedScrollingRowIndex = rowIndex;
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                Repromaterijal selektiraniRepromaterijal = repromaterijalBindingSource.Current as Repromaterijal;
                if (selektiraniRepromaterijal != null)
                {
                    using (var db = new T28EnigmaEntities28())
                    {
                        db.Repromaterijal.Attach(selektiraniRepromaterijal);
                        db.Repromaterijal.Remove(selektiraniRepromaterijal);
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
    }
}
