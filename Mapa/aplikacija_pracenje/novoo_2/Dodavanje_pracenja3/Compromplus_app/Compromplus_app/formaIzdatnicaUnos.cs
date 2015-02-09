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
    public partial class formaIzdatnicaUnos : Form
    {
        public formaIzdatnicaUnos()
        {
            InitializeComponent();

            T23_EnigmaEntities db = new T23_EnigmaEntities();
        }

        private void picIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picSpremi_Click(object sender, EventArgs e)
        {
            DateTime datum = dtpDatum.Value.Date;

            using (var db = new T23_EnigmaEntities())
            {

                Izdatnica izdatnica = new Izdatnica
                {
                    IdIzdatnica = int.Parse(txtIdDokument.Text),
                    naziv = txtNaziv.Text,
                    datum = datum,
                    opis = txtOpis.Text,
                    boja = txtBoja.Text, 
                    knjizenjeDok = 1

                };
                db.Izdatnica.Add(izdatnica);
                db.SaveChanges();
            }
            Close();
        }
    }
}
