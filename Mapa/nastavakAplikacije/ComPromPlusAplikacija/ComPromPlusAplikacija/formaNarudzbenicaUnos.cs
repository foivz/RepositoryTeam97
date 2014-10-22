using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComPromPlusAplikacija
{
    public partial class formaNarudzbenicaUnos : Form
    {
        public static int izvjestajNarudzbe;
        public static bool odustani = false;
        public formaNarudzbenica parentForm;

        public formaNarudzbenicaUnos(formaNarudzbenica parent)
        {
            InitializeComponent();
            parentForm = parent;
            izvjestajNarudzbe = 0;
        }

        private void btnDalje_Click(object sender, EventArgs e)
        {
            
            //pošalji referencu forme roditelja (narudzbenica) formi djetetu (odabir repromaterijala) kako bi na gumb odustani mogao sve forme pogasiti(odnosno ugasiti cijelu narudzbu)
            formaOdabirRepromaterijala repromat = new formaOdabirRepromaterijala (this, parentForm);
            //napravi novi prazan izvjestaj narudzbe sa svojim id-em u bazi podataka
            narudzbenicaTableAdapter.InsertNovaNarudzba();
            //dohvati broj izvjestaja (novokreiranog)
            izvjestajNarudzbe = (int)narudzbenicaTableAdapter.BrojIzvjestajaNarudzbe();
            //prijeđi na sljedeći korak narudzbe
            this.Hide();
            repromat.ShowDialog();
            if (odustani == false)
            {
                this.Show();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            //provjeri da li je izvjestaj kreiran...
            if (izvjestajNarudzbe != 0)
            {
                //... i onda u tom slučaju ga obriši iz baze podataka
               //------- narudzbenicaTableAdapter.DeleteIzvjestaj(izvjestaj);
            }
            parentForm.Show();
            this.Close();
        }

    }
}
