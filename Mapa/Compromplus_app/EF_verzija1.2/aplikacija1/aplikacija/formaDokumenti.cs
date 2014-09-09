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
    public partial class formaDokumenti : Form
    {
        public formaDokumenti()
        {
            InitializeComponent();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void prikaziDokumente()
        {
            BindingList<Dokument> listaDokumenata = null;
            using (var db = new T28EnigmaEntities28())
            {
                listaDokumenata = new BindingList<Dokument>(db.Dokument.ToList());
            }
            dokumentBindingSource.DataSource = listaDokumenata;
        }


        private void prikaziStavke(Dokument dokument)
        {
            BindingList<stavke_dokumenta> listaStavki = null;
            using (var db = new T28EnigmaEntities28())
            {
                db.Dokument.Attach(dokument);
                listaStavki = new BindingList<stavke_dokumenta>(dokument.stavke_dokumenta.ToList<stavke_dokumenta>());
            }
            stavkedokumentaBindingSource.DataSource = listaStavki;
        }

        private void formaDokumenti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't28EnigmaDataSet.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter.Fill(this.t28EnigmaDataSet.Artikli);
            prikaziDokumente();
            prikaziStavke(dokumentBindingSource.Current as Dokument);
        }

        private void dokumentDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            Dokument selektiraniDokument = dokumentBindingSource.Current as Dokument;
            if (selektiraniDokument != null)
            {
                prikaziStavke(selektiraniDokument);
            }
        }
    }
}
