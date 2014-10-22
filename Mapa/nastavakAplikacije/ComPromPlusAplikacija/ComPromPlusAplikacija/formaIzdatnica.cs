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
    public partial class formaIzdatnica : Form
    {
        public formaIzdatnica()
        {
            InitializeComponent();
        }

        private void picIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formaIzdatnica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't23_Enigma2DataSet.stavkeIzdatnice' table. You can move, or remove it, as needed.
            this.stavkeIzdatniceTableAdapter.Fill(this.t23_Enigma2DataSet.stavkeIzdatnice);
            // TODO: This line of code loads data into the 't23_Enigma2DataSet.Izdatnica' table. You can move, or remove it, as needed.
            this.izdatnicaTableAdapter.Fill(this.t23_Enigma2DataSet.Izdatnica);

        }
    }
}
