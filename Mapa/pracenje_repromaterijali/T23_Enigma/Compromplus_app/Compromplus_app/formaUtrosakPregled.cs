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
        public formaUtrosakPregled()
        {
            InitializeComponent();
        }

        
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

       

        
        
        }
    }

