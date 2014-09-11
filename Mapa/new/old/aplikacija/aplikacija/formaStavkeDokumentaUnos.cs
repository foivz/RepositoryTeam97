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
    public partial class formaStavkeDokumentaUnos : Form
    {
        private Dokument selektirani;

        public formaStavkeDokumentaUnos(Dokument dokument)
        {
            InitializeComponent();
            selektirani = dokument;
            T28EnigmaEntities28 db = new T28EnigmaEntities28();
            cboArtikl.DataSource = db.Artikli.ToList();
            cboArtikl.ValueMember = "IdArtikli";
            cboArtikl.DisplayMember = "IdArtikli";
        }

        private void picSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new T28EnigmaEntities28())
            {
                db.Dokument.Attach(selektirani);
                stavke_dokumenta stavke = new stavke_dokumenta
                {
                    artikliId = int.Parse(cboArtikl.SelectedValue.ToString()),
                    dokumentId = 1,
                    kolicina = int.Parse(txtKolicinaNaSkladistu.Text),
                };
                db.stavke_dokumenta.Add(stavke);
                db.SaveChanges();
            }
            Close();
        }
    }
}
