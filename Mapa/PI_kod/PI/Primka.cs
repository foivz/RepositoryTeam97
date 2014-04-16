using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI
{
    public partial class Primka : Form
    {
        public Primka()
        {
            InitializeComponent();
        }



        private void Primka_Load(object sender, EventArgs e)
        {
            poruka.SetToolTip(button1, "Dodaj");
            brisi.SetToolTip(button3, "Brisi");
            izlaz.SetToolTip(button4, "Izlaz");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
