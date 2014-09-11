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
    public partial class formaDokumentiUnos : Form
    {
        public formaDokumentiUnos()
        {
            InitializeComponent();
            T28EnigmaEntities28 db = new T28EnigmaEntities28();

            cboTipDokumenta.DataSource = db.TipDokumenta.ToList();
            cboTipDokumenta.ValueMember = "IdTipDokumenta";
            cboTipDokumenta.DisplayMember = "naziv";

        }

        private void picSpremi_Click(object sender, EventArgs e)
        {
            DateTime datum = dateTimePicker1.Value.Date;
            
            using (var db = new T28EnigmaEntities28())
            {
                
                Dokument dokument = new Dokument
                {
                    IdDokument = int.Parse(txtIdDokument.Text),
                    tipDokumenta = int.Parse(cboTipDokumenta.SelectedValue.ToString()),
                    datum = datum,
                    opis = txtOpis.Text
                    
                };
                db.Dokument.Add(dokument);
                db.SaveChanges();
            }
            Close();
        }

       
    }
}
