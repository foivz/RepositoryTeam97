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
    public partial class djelatnici : Form
    {
        public djelatnici()
        {
            InitializeComponent();
        }

        private void djelatnici_Load(object sender, EventArgs e)
        {
            poruka.SetToolTip(button1, "Dodaj");
            brisi.SetToolTip(button3, "Brisi");
            izlaz.SetToolTip(button4, "Izlaz");

        }

        
    }
}
