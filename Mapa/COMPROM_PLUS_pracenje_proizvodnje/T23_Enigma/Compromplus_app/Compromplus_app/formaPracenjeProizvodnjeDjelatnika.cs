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
    public partial class formaPracenjeProizvodnjeDjelatnika : Form
    {
        public formaPracenjeProizvodnjeDjelatnika()
        {
            InitializeComponent();
        }

        private void formaPracenjeProizvodnjeDjelatnika_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'T23_EnigmaDataSet2.Stroj' table. You can move, or remove it, as needed.
            this.PracenjeProizvodnjeTableAdapter.Fill(this.T23_EnigmaDataSet2.PracenjeProizvodnje);

        }

        private void cboDjelatnik_SelectedValueChanged(object sender, EventArgs e)
        {
            if
           (cboDjelatnik.SelectedValue != null)
            {
                int IdArtikla = (int)cboDjelatnik.SelectedValue;
                this.ArtiklTableAdapter.FillByIdArtikl(this.T23_EnigmaDataSet2.Artikl, IdArtikla);
                int IdStroj = (int)cboDjelatnik.SelectedValue;
                this.StrojTableAdapter.FillByIdStroj(this.T23_EnigmaDataSet2.Stroj, IdStroj);
                int IdDjelatnik = (int)cboDjelatnik.SelectedValue;
                this.DjelatnikTableAdapter.FillByIdDjelatnik(this.T23_EnigmaDataSet2.Djelatnik, IdDjelatnik);
                
            }

            this.reportViewer1.RefreshReport();
        }

        private void cboDjelatnik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
