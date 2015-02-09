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
    public partial class formaPracenjeProizvodnjePregled : Form
    {
        public formaPracenjeProizvodnjePregled()
        {
            InitializeComponent();
        }

        private void formaPracenjeProizvodnjePregled_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't23_EnigmaDataSet2.Artikl' table. You can move, or remove it, as needed.
           // this.artiklTableAdapter.Fill(this.t23_EnigmaDataSet2.Artikl);
            // TODO: This line of code loads data into the 't23_EnigmaDataSet2.Djelatnik' table. You can move, or remove it, as needed.
            //this.djelatnikTableAdapter.Fill(this.t23_EnigmaDataSet2.Djelatnik);
            // TODO: This line of code loads data into the 't23_EnigmaDataSet2.Stroj' table. You can move, or remove it, as needed.
           // this.strojTableAdapter.Fill(this.t23_EnigmaDataSet2.Stroj);
            // TODO: This line of code loads data into the 't23_EnigmaDataSet2.PracenjeProizvodnje' table. You can move, or remove it, as needed.
            this.pracenjeProizvodnjeTableAdapter.Fill(this.t23_EnigmaDataSet2.PracenjeProizvodnje);

        }

        private void dgvPracenje_SelectionChanged(object sender, EventArgs e)
        {
            int IdStroj = int.Parse(dgvPracenje.CurrentRow.Cells[0].Value.ToString());
            this.strojTableAdapter.FillByIdStroj(this.t23_EnigmaDataSet2.Stroj, IdStroj);
            int IdDjelatnik = int.Parse(dgvPracenje.CurrentRow.Cells[0].Value.ToString());
            this.djelatnikTableAdapter.FillByIdDjelatnik(this.t23_EnigmaDataSet2.Djelatnik, IdDjelatnik);
            int IdArtikl = int.Parse(dgvPracenje.CurrentRow.Cells[0].Value.ToString());
            this.artiklTableAdapter.FillByIdArtikl(this.t23_EnigmaDataSet2.Artikl, IdArtikl);
        }
    }
}
