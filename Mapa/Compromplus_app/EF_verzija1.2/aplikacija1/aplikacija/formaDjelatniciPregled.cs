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
    public partial class formaDjelatniciPregled : Form
    {
        public formaDjelatniciPregled()
        {
            InitializeComponent();
            T28EnigmaEntities28 dc = new T28EnigmaEntities28();
            dgvDjelatnici.DataSource = dc.Djelatnik.ToList();

        }

        private Djelatnik selektiraniDjelatnik;

        private void prikaziDjelatnike()
        {
            BindingList<Djelatnik> listaDjelatnika = null;
            using (var db = new T28EnigmaEntities28())
            {
                listaDjelatnika = new BindingList<Djelatnik>(db.Djelatnik.ToList());
            }
            djelatnikBindingSource.DataSource = listaDjelatnika;
        }

        private void formaDjelatniciPregled_Load(object sender, EventArgs e)
        {
            prikaziDjelatnike();
        }

        private void txtPretrazivanje_TextChanged(object sender, EventArgs e)
        {
            T28EnigmaEntities28 dc = new T28EnigmaEntities28();
            if (txtPretrazivanje.Text != string.Empty)
            {
                var items = dc.Djelatnik.Where(s => s.ime.Contains(txtPretrazivanje.Text) || s.prezime.Contains(txtPretrazivanje.Text) || s.adresa.Contains(txtPretrazivanje.Text));
                dgvDjelatnici.DataSource = items.ToList();
            }
            else
                dgvDjelatnici.DataSource = dc.Djelatnik.ToList();   
        }


    }
}
