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
    public partial class formaDjelatniciUnos : Form
    {
        private Djelatnik izmjeniDjelatnika;

        public formaDjelatniciUnos(Djelatnik djelatnik)
        {
            InitializeComponent();
            izmjeniDjelatnika = djelatnik;
        }

        private void formaDjelatniciUnos_Load(object sender, EventArgs e)
        {
            txtIdDjelatnici.Focus();
            if (izmjeniDjelatnika != null)
            {
                txtIdDjelatnici.Text = izmjeniDjelatnika.IdDjelatnik.ToString();
                txtIme.Text = izmjeniDjelatnika.ime.ToString();
                txtPrezime.Text = izmjeniDjelatnika.prezime.ToString();
                txtAdresa.Text = izmjeniDjelatnika.adresa.ToString();
                txtStrucnaSprema.Text = izmjeniDjelatnika.strucnaSprema.ToString();
            }
        }

        private void picSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new T28EnigmaEntities28())
            {
                if (izmjeniDjelatnika == null)
                {
                    Djelatnik djelatnik = new Djelatnik
                    {
                        IdDjelatnik = int.Parse(txtIdDjelatnici.Text),
                        ime = txtIme.Text,
                        prezime = txtPrezime.Text,
                        adresa = txtAdresa.Text,
                        strucnaSprema = txtStrucnaSprema.Text,

                    };

                    db.Djelatnik.Add(djelatnik);
                    db.SaveChanges();
                }

                else //Mjenjamo postojeći    
                {
                    db.Djelatnik.Attach(izmjeniDjelatnika); //registriramo postojeći 

                    izmjeniDjelatnika.IdDjelatnik = int.Parse(txtIdDjelatnici.Text);
                    izmjeniDjelatnika.ime = txtIme.Text;
                    izmjeniDjelatnika.prezime = txtPrezime.Text;
                    izmjeniDjelatnika.adresa = txtAdresa.Text;
                    izmjeniDjelatnika.strucnaSprema = txtStrucnaSprema.Text;
                    db.SaveChanges();
                }

            }
            this.Close();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
