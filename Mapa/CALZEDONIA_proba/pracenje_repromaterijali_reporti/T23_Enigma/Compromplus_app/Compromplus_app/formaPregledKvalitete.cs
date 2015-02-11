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
    public partial class formaPregledKvalitete : Form
    {
        public formaPregledKvalitete()
        {
            InitializeComponent();
        }

        private void formaPregledKvalitete_Load(object sender, EventArgs e)
        {
           
            
            // TODO: This line of code loads data into the 't23_EnigmaDataSet2.Artikl' table. You can move, or remove it, as needed.
            this.artiklTableAdapter.FillByKlasa(this.t23_EnigmaDataSet2.Artikl);

        }

        private void picIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           int IdStroj = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
       
            this.strojTableAdapter.FillByKlasa(this.t23_EnigmaDataSet2.Stroj, IdStroj);


       
        }
    }
}
