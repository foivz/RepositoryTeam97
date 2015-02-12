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

        /// <summary>
        /// Otvaramo praćenje proizvodnje koji želimo mjenjati/ažurirati u novoj formi
        /// </summary>
        /// <param name="praćenje">praćenje koji želimo mjenjati</param>
        public formaPracenjeProizvodnjeUnos(PracenjeProizvodnje pracenje)
        {
            InitializeComponent();
            azuriraj = pracenje;

            T23_EnigmaEntities db = new T23_EnigmaEntities();

            cboArtikl.DataSource = db.Artikl.ToList();
            cboArtikl.ValueMember = "IdArtikl";
            cboArtikl.DisplayMember = "naziv";

            cboDjelatnik.DataSource = db.Djelatnik.ToList();
            cboDjelatnik.ValueMember = "IdDjelatnik";
            cboDjelatnik.DisplayMember = "ime";

            cboStroj.DataSource = db.Stroj.ToList();
            cboStroj.ValueMember = "IdStroj";
            cboStroj.DisplayMember = "naziv";
        }

        private void formaPracenjeProizvodnjeUnos_Load(object sender, EventArgs e)
        {
            txtIdPracenje.Focus();
            if (azuriraj != null)
            {
                txtIdPracenje.ReadOnly = true;
                txtVelicina.Text = azuriraj.velicina.ToString();
                txtKolicina.Text = azuriraj.kolicina.ToString();
                //cboArtikl.SelectedItem = azuriraj.IdArtikl.ToString();
                //cboDjelatnik.SelectedItem = azuriraj.IdDjelatnici.ToString();
                //cboStroj.SelectedItem = azuriraj.IdStroj.ToString();
            }
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
                    //kreiramo novi objekt klase PracenjeProizvodnje te ga popunjavamo podacima iz forme
                    PracenjeProizvodnje pracenje = new PracenjeProizvodnje
                    {
                        IdPracenjeProizvodnje = int.Parse(txtIdPracenje.Text),
                        velicina = int.Parse(txtVelicina.Text),
                        kolicina = int.Parse(txtKolicina.Text),
                        IdArtikl = int.Parse(cboArtikl.SelectedValue.ToString()),
                        IdDjelatnici = int.Parse(cboDjelatnik.SelectedValue.ToString()),
                        IdStroj = int.Parse(cboStroj.SelectedValue.ToString())
                        
                    };

                    db.PracenjeProizvodnje.Add(pracenje);
                    db.SaveChanges();
                }

                else //Mjenjamo postojeće praćenje proizvodnje   
                {
                    db.PracenjeProizvodnje.Attach(azuriraj); //registriramo postojeće pracenje proizvodnje

                        azuriraj.velicina = int.Parse(txtVelicina.Text);
                        azuriraj.kolicina = int.Parse(txtKolicina.Text);
                        azuriraj.IdArtikl = int.Parse(cboArtikl.SelectedValue.ToString());
                        azuriraj.IdDjelatnici = int.Parse(cboDjelatnik.SelectedValue.ToString());
                        azuriraj.IdStroj = int.Parse(cboStroj.SelectedValue.ToString());
                    db.SaveChanges();
                }
            }
            this.Close();
        }
    }
}
