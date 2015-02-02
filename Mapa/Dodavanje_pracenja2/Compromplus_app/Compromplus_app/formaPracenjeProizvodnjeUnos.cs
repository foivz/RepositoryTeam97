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
    public partial class formaPracenjeProizvodnjeUnos : Form
    {
        private PracenjeProizvodnje azuriraj;


        public formaPracenjeProizvodnjeUnos(PracenjeProizvodnje pracenje)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.azuriraj = pracenje;
        }

        private void formaPracenjeProizvodnjeUnos_Load(object sender, EventArgs e)
        {
            //txtIdArtikl.Focus();
            if (azuriraj != null)
            {
                //txtIdArtikl.ReadOnly = true;
                txtKolicina.Text = azuriraj.kolicina.ToString();
                txtOpis.Text = azuriraj.opis.ToString();
                txtNaziv.Text = azuriraj.naziv.ToString();
                txtIdDjelatnik.Text = azuriraj.djelatnik_id.ToString();
                txtIdStroj.Text = azuriraj.stroj_id.ToString();
                dtpDatum.Text = azuriraj.datum.ToString();
                txtIdArtikl.Text = azuriraj.artikl_id.ToString();
            }
        }

        private void picSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new T23_EnigmaEntities())
            {
                if (azuriraj == null)
                {
                    //kreiramo novi objekt klase PracenjeProizvodnje te ga popunjavamo podacima iz forme
                    PracenjeProizvodnje pracenje = new PracenjeProizvodnje
                    {
                        artikl_id = int.Parse(txtIdArtikl.Text),
                        stroj_id = int.Parse(txtIdStroj.Text),
                        djelatnik_id = int.Parse(txtIdDjelatnik.Text),
                        opis = txtOpis.Text,
                        naziv = txtNaziv.Text,
                        kolicina = int.Parse(txtKolicina.Text)
                    };

                    db.PracenjeProizvodnje.Add(pracenje);
                    db.SaveChanges();
                }

                else //Mjenjamo postojeće praćenje proizvodnje  
                {
                    db.PracenjeProizvodnje.Attach(azuriraj); //registriramo postojeće praćenje proizvodnje

                        azuriraj.artikl_id = int.Parse(txtIdArtikl.Text);
                        azuriraj.stroj_id = int.Parse(txtIdStroj.Text);
                        azuriraj.djelatnik_id = int.Parse(txtIdDjelatnik.Text);
                        azuriraj.opis = txtOpis.Text;
                        azuriraj.naziv = txtNaziv.Text;
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
