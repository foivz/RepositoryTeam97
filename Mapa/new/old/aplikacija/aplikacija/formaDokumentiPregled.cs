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
    public partial class formaDokumentiPregled : Form
    {
        public formaDokumentiPregled()
        {
            InitializeComponent();
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

        private void formaDokumentiPregled_Load(object sender, EventArgs e)
        {
            prikaziDokumente();
            prikaziStavke(dokumentBindingSource.Current as Dokument);
        }

        private void dgvDokumenti_SelectionChanged(object sender, EventArgs e)
        {
            Dokument selektiraniDokument = dokumentBindingSource.Current as Dokument;
            if (selektiraniDokument != null)
            {
                prikaziStavke(selektiraniDokument);
            }
        }

        private void btnNoviDokument_Click(object sender, EventArgs e)
        {
            formaDokumentiUnos unos = new formaDokumentiUnos();
            unos.ShowDialog();
            prikaziDokumente();
        }

        private void btnNovaStavka_Click(object sender, EventArgs e)
        {
            formaStavkeDokumentaUnos unos = new formaStavkeDokumentaUnos(dokumentBindingSource.Current as Dokument);
            unos.ShowDialog();
            prikaziStavke(dokumentBindingSource.Current as Dokument);
        }

        


    }
}
