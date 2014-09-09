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
    public partial class formaStatistikaKlase : Form
    {
        public formaStatistikaKlase()
        {
            InitializeComponent();
        }

        private void formaStatistikaKlase_Load(object sender, EventArgs e)
        {
            
            T28EnigmaEntities28 dc = new T28EnigmaEntities28();

            var klasaA = dc.Artikli.Count(t => t.evidencijaKontrole == 1);
            var klasaB = dc.Artikli.Count(t => t.evidencijaKontrole == 2);
            var klasaC = dc.Artikli.Count(t => t.evidencijaKontrole == 3);


            this.chart2.Series["Klasa A"].Points.AddXY("Artikl", klasaA);
            this.chart2.Series["Klasa B"].Points.AddXY("Artikl", klasaB);
            this.chart2.Series["Klasa C"].Points.AddXY("Artikl", klasaC);
            
        }

        
    }
}
