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
    public partial class formaPracenjeProizvodnjeIzvjestaj : Form
    {
        public formaPracenjeProizvodnjeIzvjestaj()
        {
            InitializeComponent();
        }

        private void formaPracenjeProizvodnjeIzvjestaj_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'T23_EnigmaDataSet2.PracenjeProizvodnje' table. You can move, or remove it, as needed.
            this.PracenjeProizvodnjeTableAdapter.Fill(this.T23_EnigmaDataSet2.PracenjeProizvodnje);
            
        }


            // na promjenu odabrane vrijednosti unutar ComboBox-a moraju se popuniti DataSetovi da prikažu nove podatke.
    
            private void cboIdPracenje_SelectedValueChanged(object sender, EventArgs e)
            {
                if
               (cboIdPracenje.SelectedValue != null)
                {
                    int IdArtikla = (int)cboIdPracenje.SelectedValue;
                    this.ArtiklTableAdapter.FillByIdArtikl(this.T23_EnigmaDataSet2.Artikl, IdArtikla);
                    int IdStroj = (int)cboIdPracenje.SelectedValue;
                    this.StrojTableAdapter.FillByIdStroj(this.T23_EnigmaDataSet2.Stroj, IdStroj);
                    int IdDjelatnik = (int)cboIdPracenje.SelectedValue;
                    this.DjelatnikTableAdapter.FillByIdDjelatnik(this.T23_EnigmaDataSet2.Djelatnik, IdDjelatnik);

                }

                this.izvjestajPracenja.RefreshReport();

            }
          
        
}
}

    


