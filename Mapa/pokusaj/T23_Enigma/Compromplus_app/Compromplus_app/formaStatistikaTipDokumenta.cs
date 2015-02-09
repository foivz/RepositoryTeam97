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
    public partial class formaStatistikaTipDokumenta : Form
    {
        public formaStatistikaTipDokumenta()
        {
            InitializeComponent();
        }

        private void formaStatistikaTipDokumenta_Load(object sender, EventArgs e)
        {
            T23_EnigmaEntities dc = new T23_EnigmaEntities();

            var izdatnica = dc.Dokument.Count(t => t.tipDokumenta == 1);
            var otpremnica = dc.Dokument.Count(t => t.tipDokumenta == 2);
            var primka = dc.Dokument.Count(t => t.tipDokumenta == 3);


            this.chart1.Series["Izdatnica"].Points.AddXY("Dokument", izdatnica);
            this.chart1.Series["Otpremnica"].Points.AddXY("Dokument", otpremnica);
            this.chart1.Series["Primka"].Points.AddXY("Dokument", primka);
        }
    }
}
