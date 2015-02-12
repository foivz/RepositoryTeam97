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
    public partial class formaUtrosakIzvjestaj : Form
    {
        public formaUtrosakIzvjestaj()
        {
            InitializeComponent();
        }

        private void formaUtrosakIzvjestaj_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't23_EnigmaDataSet1.Utrosak' table. You can move, or remove it, as needed.
            //this.UtrosakTableAdapter.Fill(this.t23_EnigmaDataSet1.Utrosak);
            // TODO: This line of code loads data into the 't23_EnigmaDataSet1.Repromaterijal' table. You can move, or remove it, as needed.
            //this.RepromaterijalTableAdapter.Fill(this.t23_EnigmaDataSet1.Repromaterijal);
            // TODO: This line of code loads data into the 't23_EnigmaDataSet1.Artikl' table. You can move, or remove it, as needed.
            this.artiklTableAdapter.Fill(this.t23_EnigmaDataSet1.Artikl);

            
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if
               (cboUtrosak.SelectedValue != null)
            {
                int IdArtikla = (int)cboUtrosak.SelectedValue;
                this.RepromaterijalTableAdapter.FillByArtikl(this.t23_EnigmaDataSet1.Repromaterijal, IdArtikla);
                int IdArtikla2 = (int)cboUtrosak.SelectedValue;
                this.UtrosakTableAdapter.FillById(this.t23_EnigmaDataSet1.Utrosak, IdArtikla2);

            }
            this.reportViewer1.RefreshReport();
        }
    }
}
