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
    public partial class formaUtrosakUnos : Form
    {
        private Utrosak azuriraj;

        public formaUtrosakUnos(Utrosak utrosak)
        {
            InitializeComponent();
            azuriraj = utrosak;

            T23_EnigmaEntities db = new T23_EnigmaEntities();

            cboArtikl.DataSource = db.Artikl.ToList();
            cboArtikl.ValueMember = "IdArtikl";
            cboArtikl.DisplayMember = "naziv";

            cboRepromaterijal.DataSource = db.Repromaterijal.ToList();
            cboRepromaterijal.ValueMember = "IdRepromaterijal";
            cboRepromaterijal.DisplayMember = "naziv";

        }

        private void picIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picSpremi_Click(object sender, EventArgs e)
        {

            using (var db = new T23_EnigmaEntities())
            {
                if (azuriraj == null)
                {
                    //kreiramo novi objekt klase Utrosak te ga popunjavamo podacima iz forme
                    Utrosak utrosak = new Utrosak
                    {
                        IdUtrosak = int.Parse(txtIdUtrosak.Text),
                        velicina = int.Parse(txtVelicina.Text),
                        kolicina = int.Parse(txtKolicina.Text),
                        IdArtikl = int.Parse(cboArtikl.SelectedValue.ToString()),
                        IdRepromaterijal = int.Parse(cboRepromaterijal.SelectedValue.ToString()),


                    };

                    db.Utrosak.Add(utrosak);
                    db.SaveChanges();
                }

                else //Mjenjamo postojeći utrošak
                {
                    db.Utrosak.Attach(azuriraj); //registriramo postojeći utrošak

                    azuriraj.velicina = int.Parse(txtVelicina.Text);
                    azuriraj.kolicina = int.Parse(txtKolicina.Text);
                    azuriraj.IdArtikl = int.Parse(cboArtikl.SelectedValue.ToString());
                    azuriraj.IdRepromaterijal = int.Parse(cboRepromaterijal.SelectedValue.ToString());

                    db.SaveChanges();
                }
            }
            this.Close();
        }


        private void formaUtrosakUnos_Load(object sender, EventArgs e)
        {
            txtIdUtrosak.Focus();
            if (azuriraj != null)
            {
                txtIdUtrosak.ReadOnly = true;
                txtVelicina.Text = azuriraj.velicina.ToString();
                txtKolicina.Text = azuriraj.kolicina.ToString();
                //cboArtikl.SelectedItem = azuriraj.IdArtikl.ToString();
                //cboRepromaterijal.SelectedItem = azuriraj.IdRepromaterijal.ToString();

            }
        }
    }

}