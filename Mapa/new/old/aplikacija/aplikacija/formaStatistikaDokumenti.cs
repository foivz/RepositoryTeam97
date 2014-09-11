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
    public partial class formaStatistikaDokumenti : Form
    {
        public formaStatistikaDokumenti()
        {
            InitializeComponent();
        }

        private void formaStatistikaDokumenti_Load(object sender, EventArgs e)
        {
            T28EnigmaEntities28 dc = new T28EnigmaEntities28();

            var izdatnica = dc.Dokument.Count(t => t.tipDokumenta == 1);
            var otpremnica = dc.Dokument.Count(t => t.tipDokumenta == 2);
            var primka = dc.Dokument.Count(t => t.tipDokumenta == 3);


            this.chart1.Series["Izdatnica"].Points.AddXY("Dokument", izdatnica);
            this.chart1.Series["Otpremnica"].Points.AddXY("Dokument", otpremnica);
            this.chart1.Series["Primka"].Points.AddXY("Dokument", primka);
        }
    }
}
