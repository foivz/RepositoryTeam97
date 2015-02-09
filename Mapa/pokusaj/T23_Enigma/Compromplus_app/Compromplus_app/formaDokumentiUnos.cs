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
    public partial class formaDokumentiUnos : Form
    {
        public formaDokumentiUnos()
        {
            InitializeComponent();

            T23_EnigmaEntities db = new T23_EnigmaEntities();
            cboTipDokumenta.DataSource = db.TipDokumenta.ToList();
            cboTipDokumenta.ValueMember = "IdTipDokumenta";
            cboTipDokumenta.DisplayMember = "naziv";
        }

        private void picIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picSpremi_Click(object sender, EventArgs e)
        {
            DateTime datum = dtpDatum.Value.Date;

            using (var db = new T23_EnigmaEntities())
            {

                Dokument dokument = new Dokument
                {
                    IdDokument = int.Parse(txtIdDokument.Text),
                    tipDokumenta = int.Parse(cboTipDokumenta.SelectedValue.ToString()),
                    datum = datum,
                    opis = txtOpis.Text,
                    knjizenjeDokumenta = 1

                };
                db.Dokument.Add(dokument);
                db.SaveChanges();
            }
            Close();
        }
    }
}
