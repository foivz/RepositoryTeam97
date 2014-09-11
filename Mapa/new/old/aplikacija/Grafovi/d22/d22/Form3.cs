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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.chart1.Series["Klasa A"].Points.AddXY("Artikl1", 33);
            this.chart1.Series["Klasa B"].Points.AddXY("Artikl1", 50);
            this.chart1.Series["Klasa A"].Points.AddXY("Artikl2", 43);
            this.chart1.Series["Klasa B"].Points.AddXY("Artikl2", 43);
            this.chart1.Series["Klasa A"].Points.AddXY("Artikl3", 80);
            this.chart1.Series["Klasa B"].Points.AddXY("Artikl3", 23);
            this.chart1.Series["Klasa A"].Points.AddXY("Artikl4", 95);
            this.chart1.Series["Klasa B"].Points.AddXY("Artikl4", 83);

        }
    }
}
