using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPROMPlusdoo
{
    public partial class formaGlavniIzbornik : Form
    {
        public formaGlavniIzbornik()
        {
            InitializeComponent();
        }

        private void picArtikli_Click(object sender, EventArgs e)
        {
            formaArtikliPregled artikli = new formaArtikliPregled();
            artikli.Show();

        }

    }
}
