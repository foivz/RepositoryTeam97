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
    public partial class formaPrijava : Form
    {
        public formaPrijava()
        {
            InitializeComponent();
        }
        private void btnPrijava_Click(object sender, EventArgs e)
        {
            using (var db = new T23_Enigma2Entities())
            {
                var query = from Korisnik in db.Korisnik
                            select new
                            {
                                korisnickoIme = Korisnik.korisnickoIme,
                                lozinka = Korisnik.lozinka,
                                tipKorisnika = Korisnik.tipKorisnika
                            };
                Boolean nadeno = false;
                foreach (var Korisnik in query)
                {
                    //administrator
                    if ((txtKorisnickoIme.Text == Korisnik.korisnickoIme) && (Korisnik.lozinka == txtLozinka.Text) && (Korisnik.tipKorisnika == 1))
                    {
                        formaGlavniIzbornik izbornik = new formaGlavniIzbornik();
                        izbornik.Show();
                        this.Hide();
                        nadeno = true;

                    }

                    //voditelj proizvodenje
                    else if ((txtKorisnickoIme.Text == Korisnik.korisnickoIme) && (Korisnik.lozinka == txtLozinka.Text) && (Korisnik.tipKorisnika == 2))
                    {
                        formaGlavniIzbornikVoditeljProizvodnje izbornik = new formaGlavniIzbornikVoditeljProizvodnje();
                        izbornik.Show();
                        this.Hide();
                        nadeno = true;

                    }

                    //voditelj skladišta
                    else if ((txtKorisnickoIme.Text == Korisnik.korisnickoIme) && (Korisnik.lozinka == txtLozinka.Text) && (Korisnik.tipKorisnika == 3))
                    {
                        formaGlavniIzbornikVoditeljSkladista izbornik = new formaGlavniIzbornikVoditeljSkladista();
                        izbornik.Show();
                        this.Hide();
                        nadeno = true;

                    }
                }

                if (!nadeno)
                {
                    MessageBox.Show("Neispravan unos!");
                }

            }


            if (txtKorisnickoIme.Text == "")
            {
                MessageBox.Show("Niste unjeli korisničko ime!");
            }

            else if (txtLozinka.Text == "")
            {
                MessageBox.Show("Niste unijeli lozinku!");
            }
        }

       
     
    }
}
