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
    public partial class formaArtikliUnos : Form
    {
        private Artikl azuriraj;

        /// <summary>
        /// Otvaramo artikl koji želimo mjenjati/ažurirati u novoj formi
        /// </summary>
        /// <param name="artikl">Artikl koji želimo mjenjati</param>
        public formaArtikliUnos(Artikl artikl)
        {
            InitializeComponent();
            azuriraj = artikl;

        }

        private void formaArtikliUnos_Load(object sender, EventArgs e)
        {
            txtIdArtikl.Focus();
            if (azuriraj != null)
            {
                txtIdArtikl.ReadOnly = true;
                txtBoja.Text = azuriraj.boja.ToString();
                txtOpis.Text = azuriraj.opis.ToString();
                txtNaziv.Text = azuriraj.naziv.ToString();
                cboKlasa.SelectedItem = azuriraj.klasa.ToString();
                txtKolicina.Text = azuriraj.kolicina.ToString();
            }
           

        }

        private void picSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new T23_EnigmaEntities())
            {
                if (azuriraj == null)
                {
                    //kreiramo novi objekt klase Artikl te ga popunjavamo podacima iz forme
                    Artikl artikl = new Artikl
                    {
                        IdArtikl = int.Parse(txtIdArtikl.Text),
                        boja = txtBoja.Text,
                        opis = txtOpis.Text,
                        naziv = txtNaziv.Text,
                        klasa = cboKlasa.Text,
                        kolicina = int.Parse(txtKolicina.Text)
                    };

                    db.Artikl.Add(artikl);
                    db.SaveChanges();
                }

                else //Mjenjamo postojeći artikl   
                {
                    db.Artikl.Attach(azuriraj); //registriramo postojeći artikl

                    azuriraj.naziv = txtNaziv.Text;
                    azuriraj.boja = txtBoja.Text;
                    azuriraj.opis = txtOpis.Text;
                    azuriraj.klasa = cboKlasa.Text;
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
