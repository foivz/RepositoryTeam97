using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace d22
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            this.chart2.Series["Klasa A"].Points.AddXY("Artikl1", 105);
            this.chart2.Series["Klasa B"].Points.AddXY("Artikl1", 50);
            this.chart2.Series["Klasa A"].Points.AddXY("Artikl2", 250);
            this.chart2.Series["Klasa B"].Points.AddXY("Artikl2", 43);
            this.chart2.Series["Klasa A"].Points.AddXY("Artikl3", 80);
            this.chart2.Series["Klasa B"].Points.AddXY("Artikl3", 23);
            this.chart2.Series["Klasa A"].Points.AddXY("Artikl4", 500);
            this.chart2.Series["Klasa B"].Points.AddXY("Artikl4", 83);
        }
    }
}
