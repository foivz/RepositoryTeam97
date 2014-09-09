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
    public partial class formaUredjivanjeArtikala : Form
    {
        private bool azuriranje = false;
        

        public formaUredjivanjeArtikala(int IdArtikli, string naziv, string opis, string boja, int evidencijaKontrole)
        {
            InitializeComponent();
            this.txtIdArtikli.Text = Convert.ToString(IdArtikli);
            this.txtNaziv.Text = naziv;
            this.txtOpis.Text = opis;
            this.txtBoja.Text = boja;
            this.txtEvidencijaKontrole.Text = Convert.ToString(evidencijaKontrole);
            azuriranje = true;
        }

        public formaUredjivanjeArtikala()
        {
            InitializeComponent();
            azuriranje = false;
        }

        
        private void formaUredjivanjeArtikala_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.picSpremi, "Spremi promjene");

            System.Windows.Forms.ToolTip ToolTip2 = new System.Windows.Forms.ToolTip();
            ToolTip2.SetToolTip(this.picExit, "Izlaz");
        }
        
        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void picSpremi_Click(object sender, EventArgs e)
        {
            if (azuriranje == true)
            {
                if ((String.IsNullOrEmpty(txtIdArtikli.Text)) || (String.IsNullOrEmpty(txtNaziv.Text)) || (String.IsNullOrEmpty(txtOpis.Text)) || (String.IsNullOrEmpty(txtBoja.Text)) || (String.IsNullOrEmpty(txtEvidencijaKontrole.Text)))
                {
                    MessageBox.Show("Niste upisali sve podatke");
                }

                else
                {
                    this.artikliTableAdapter.UpdateQuery(txtNaziv.Text, txtOpis.Text, txtBoja.Text, int.Parse(txtEvidencijaKontrole.Text),int.Parse(txtIdArtikli.Text));
                    this.DialogResult = DialogResult.OK;
                }
            }
            else if (azuriranje == false)
            {
                if ((txtIdArtikli.Text == null) || (txtNaziv.Text == null) || (txtOpis.Text == null) || (txtBoja.Text == null) || (txtEvidencijaKontrole.Text == null))
                {
                    MessageBox.Show("Niste upisali sve podatke");
                }

                else
                {
                    this.artikliTableAdapter.InsertQuery(int.Parse(txtIdArtikli.Text), txtNaziv.Text, txtOpis.Text, txtBoja.Text, int.Parse(txtEvidencijaKontrole.Text));
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
