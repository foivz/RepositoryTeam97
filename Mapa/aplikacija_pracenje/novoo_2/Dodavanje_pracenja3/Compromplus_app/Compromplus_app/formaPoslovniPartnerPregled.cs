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
    public partial class formaPoslovniPartnerPregled : Form
    {
        public formaPoslovniPartnerPregled()
        {
            InitializeComponent();
        }

        private void formaPoslovniPartnerPregled_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't23_EnigmaDataSet6.poslovniPartner' table. You can move, or remove it, as needed.
            this.poslovniPartnerTableAdapter.Fill(this.t23_EnigmaDataSet6.poslovniPartner);

        }
    }
}
