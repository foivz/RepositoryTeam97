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
    public partial class formaPracenjeProizvodnjePregled : Form
    {
        public formaPracenjeProizvodnjePregled()
        {
            InitializeComponent();
        }

        private void formaPracenjeProizvodnjePregled_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't23_EnigmaDataSet1.PracenjeProizvodnje' table. You can move, or remove it, as needed.
            this.pracenjeProizvodnjeTableAdapter.Fill(this.t23_EnigmaDataSet1.PracenjeProizvodnje);

        }

        private void picDodaj_Click(object sender, EventArgs e)
        {
            formaPracenjeProizvodnjeUnos pracenjeUnos = new formaPracenjeProizvodnjeUnos();
            pracenjeUnos.Show();
        }
    }
}
