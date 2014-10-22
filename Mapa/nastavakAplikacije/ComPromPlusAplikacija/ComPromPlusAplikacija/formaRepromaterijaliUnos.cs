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
    public partial class formaRepromaterijali : Form
    {
        private Repromaterijali azuriraj;

        public formaRepromaterijali(Repromaterijali repromaterijal)
        {
            InitializeComponent();
            azuriraj = repromaterijal;

        }
       

        private void forma_Load(object sender, EventArgs e)
        {
            
            txtIdRepromaterijal.Focus();
            if (azuriraj != null)
            {
                txtIdRepromaterijal.ReadOnly = true;
                txtBoja.Text = azuriraj.boja.ToString();
                txtOpis.Text = azuriraj.opis.ToString();
                txtNaziv.Text = azuriraj.naziv.ToString();
                
                txtKolicina.Text = azuriraj.kolicina.ToString();
            }


        }

        private void picSpremi_Click(object sender, EventArgs e)
        {
             using (var db = new T23_Enigma2Entities())
            {
                if (azuriraj == null)
                {
                    //kreiramo novi objekt klase Repromaterijali te ga popunjavamo podacima iz forme
                    Repromaterijali repromaterijal = new Repromaterijali
                    {
                        Id = int.Parse(txtIdRepromaterijal.Text),
                        boja = txtBoja.Text,
                        opis = txtOpis.Text,
                        naziv = txtNaziv.Text,
                        kolicina = int.Parse(txtKolicina.Text)

                    };

                    db.Repromaterijali.Add(repromaterijal);
                    db.SaveChanges();
                }

                else //Mjenjamo postojeći repromaterijal
                {
                    db.Repromaterijali.Attach(azuriraj); //registriramo postojeći repromaterijal

                    azuriraj.naziv = txtNaziv.Text;
                    azuriraj.boja = txtBoja.Text;
                    azuriraj.opis = txtOpis.Text;
                    
                    azuriraj.kolicina = int.Parse(txtKolicina.Text);
                    db.SaveChanges();
                }
            }
            this.Close();
        }

        private void picIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
