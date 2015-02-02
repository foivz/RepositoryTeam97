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
    public partial class formaStatistikaKlase : Form
    {
        public formaStatistikaKlase()
        {
            InitializeComponent();
        }

        private void formaStatistikaKlase_Load(object sender, EventArgs e)
        {
            T23_EnigmaEntities dc = new T23_EnigmaEntities();

            var klasaA = dc.Artikl.Count(t => t.klasa == "A");
            var klasaB = dc.Artikl.Count(t => t.klasa == "B");
            var klasaC = dc.Artikl.Count(t => t.klasa == "C");


            this.chart1.Series["A"].Points.AddXY("Artikl", klasaA);
            this.chart1.Series["B"].Points.AddXY("Artikl", klasaB);
            this.chart1.Series["C"].Points.AddXY("Artikl", klasaC);
        }
    }
}
