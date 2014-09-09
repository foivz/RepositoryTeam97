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
    public partial class formaRepromaterijalUnos : Form
    {
        private Repromaterijal izmjeni;

        public formaRepromaterijalUnos(Repromaterijal repromaterijal)
        {
            InitializeComponent();
            izmjeni = repromaterijal;

        }


        private void formaRepromaterijalUnos_Load(object sender, EventArgs e)
        {
            txtIdRepromaterijal.Focus();
            if (izmjeni != null)
            {
                txtIdRepromaterijal.Text = izmjeni.IdRepromaterijal.ToString();
                txtBoja.Text = izmjeni.boja.ToString();
                txtOpis.Text = izmjeni.opis.ToString(); ;
                txtVrstaMaterijala.Text = izmjeni.vrsta_materijala.ToString();
            }
        } 


        private void btnSpremiRepromaterijale_Click(object sender, EventArgs e)
        {
            using (var db = new T28EnigmaEntities28())
            {

                if (izmjeni == null)
                {
                    Repromaterijal repromaterijal = new Repromaterijal
                    {
                        IdRepromaterijal = int.Parse(txtIdRepromaterijal.Text),
                        boja = txtBoja.Text,
                        opis = txtOpis.Text,
                        vrsta_materijala = txtVrstaMaterijala.Text
                    };
                    db.Repromaterijal.Add(repromaterijal);
                    db.SaveChanges();

                }
                else
                {
                    db.Repromaterijal.Attach(izmjeni);
                    izmjeni.IdRepromaterijal = int.Parse(txtIdRepromaterijal.Text);
                    izmjeni.boja = txtBoja.Text;
                    izmjeni.opis = txtOpis.Text;
                    izmjeni.vrsta_materijala = txtVrstaMaterijala.Text;

                    db.SaveChanges();
                }
            }
            Close();
        }

        private void picSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new T28EnigmaEntities28())
            {

                if (izmjeni == null)
                {
                    Repromaterijal repromaterijal = new Repromaterijal
                    {
                        IdRepromaterijal = int.Parse(txtIdRepromaterijal.Text),
                        boja = txtBoja.Text,
                        opis = txtOpis.Text,
                        vrsta_materijala = txtVrstaMaterijala.Text
                    };
                    db.Repromaterijal.Add(repromaterijal);
                    db.SaveChanges();

                }
                else
                {
                    db.Repromaterijal.Attach(izmjeni);
                    izmjeni.IdRepromaterijal = int.Parse(txtIdRepromaterijal.Text);
                    izmjeni.boja = txtBoja.Text;
                    izmjeni.opis = txtOpis.Text;
                    izmjeni.vrsta_materijala = txtVrstaMaterijala.Text;

                    db.SaveChanges();
                }
            }
            Close();
        }

        
    }
}
