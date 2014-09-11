using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikacija
{
    public partial class formaArtikliUnos : Form
    {
        private Artikli azuriraj;

        /// <summary>
        /// Otvaramo artikl koji želimo mjenjati/ažurirati u novoj formi
        /// </summary>
        /// <param name="artikl">Artikl koji želimo mjenjati</param>
        public formaArtikliUnos(Artikli artikl)
        {
            InitializeComponent();
            azuriraj = artikl;
        }


        //Rukuje događajem pokretanja forme
        private void formaArtikliUnos_Load(object sender, EventArgs e)
        {
            txtIdArtikli.Focus();
            if (azuriraj != null)
            {
                txtIdArtikli.Text = azuriraj.IdArtikli.ToString();
                txtBoja.Text = azuriraj.boja.ToString();
                txtOpis.Text = azuriraj.opis.ToString();
                txtNaziv.Text = azuriraj.naziv.ToString();
                txtEvidencijaKontrole.Text = azuriraj.evidencijaKontrole.ToString();
                txtKolicinaNaSkladistu.Text = azuriraj.kolicinaNaSkladistu.ToString();

            }
        }


        private void picSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new T28EnigmaEntities28())
            {
                if (azuriraj == null)
                {
                    //kreiramo novi objekt klase Artikli te ga popunjavamo podacima iz forme
                    Artikli artikl = new Artikli
                    {
                        IdArtikli = int.Parse(txtIdArtikli.Text),
                        boja = txtBoja.Text,
                        opis = txtOpis.Text,
                        naziv = txtNaziv.Text,
                        evidencijaKontrole = int.Parse(txtEvidencijaKontrole.Text),
                        kolicinaNaSkladistu = int.Parse(txtKolicinaNaSkladistu.Text)
                    };

                    db.Artikli.Add(artikl);
                    db.SaveChanges();
                }

                else //Mjenjamo postojeći artikl   
                {
                    db.Artikli.Attach(azuriraj); //registriramo postojeći artikl

                    azuriraj.IdArtikli = int.Parse(txtIdArtikli.Text);
                    azuriraj.naziv = txtNaziv.Text;
                    azuriraj.boja = txtBoja.Text;
                    azuriraj.opis = txtOpis.Text;
                    azuriraj.evidencijaKontrole = int.Parse(txtEvidencijaKontrole.Text);
                    azuriraj.kolicinaNaSkladistu = int.Parse(txtKolicinaNaSkladistu.Text);
                    db.SaveChanges();
                }

            }
            this.Close();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboEvidencijaKvaliteteId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEvidencijaKvaliteteId.SelectedItem == "Klasa A")
            {
                txtEvidencijaKontrole.Text = "1";
            }

            else if (cboEvidencijaKvaliteteId.SelectedItem == "Klasa B")
            {
                txtEvidencijaKontrole.Text = "2";
            }

            else if (cboEvidencijaKvaliteteId.SelectedItem == "Klasa C")
            {
                txtEvidencijaKontrole.Text = "3";
            }
        }



        
    }
}
