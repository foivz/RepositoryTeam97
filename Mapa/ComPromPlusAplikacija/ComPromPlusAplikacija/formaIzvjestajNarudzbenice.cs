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
    public partial class formaIzvjestajNarudzbenice : Form

    {
        public formaNarudzbenica formaNarudzbe;
        formaOdabirProdavaca parentForm;

        public formaIzvjestajNarudzbenice(formaOdabirProdavaca parentForm, formaNarudzbenica narudzba)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }


        private void btnŠalji_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(datagridProdavac.Rows[0].Cells[6].Value) != null)
            {
                string idFirma = "";
                if (Convert.ToString(datagridProdavac.Rows[0].Cells[6].Value) == "")
                {
                    idFirma = null;
                }
                else
                {
                    idFirma = Convert.ToString(datagridProdavac.Rows[0].Cells[6].Value);
                }
                poslovniPartnerTableAdapter.azurirajPodatkeIzv(idFirma,
                    Convert.ToString(datagridProdavac.Rows[0].Cells[0].Value), formaNarudzbenicaUnos.izvjestajNarudzbe);
            }
            else
            {
                narudzbenicaTableAdapter.azurirajPodatkeRac(null, Convert.ToString(datagridProdavac.Rows[0].Cells[0].Value),
                     formaNarudzbenicaUnos.izvjestajNarudzbe);
            }
            narudzbenicaTableAdapter.Kupi(formaNarudzbenicaUnos.izvjestajNarudzbe);
            formaOdabirRepromaterijala.odustani = true;
            formaOdabirProdavaca.odustani = true;
            formaNarudzbenica narudzbenica = new formaNarudzbenica();
            narudzbenica.ShowDialog();
            this.parentForm.Close();
            
            this.Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            narudzbenicaTableAdapter.DeleteizvjestajNarudzbe(formaNarudzbenicaUnos.izvjestajNarudzbe);
            formaOdabirProdavaca.odustani = true;
            formaOdabirRepromaterijala.odustani = true;
            formaNarudzbenicaUnos.odustani = true;
            formaNarudzbenica narudzbenica = new formaNarudzbenica();
            narudzbenica.ShowDialog();
            this.parentForm.Close();
            this.Close();
        }

        
    }
}
