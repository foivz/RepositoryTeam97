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
    public partial class EvidencijaKontrole : Form
    {
        public EvidencijaKontrole()
        {
            InitializeComponent();
        }

       
        
      



         private void button1_Click(object sender, EventArgs e)
         {
         }

         private void EvidencijaKontrole_Load_1(object sender, EventArgs e)
         {
             poruka.SetToolTip(btn1, "Dodaj");
             brisi.SetToolTip(btn2, "Brisi");
             izlaz.SetToolTip(btn3, "Izlaz");
         }

         

         
        
    }
}
