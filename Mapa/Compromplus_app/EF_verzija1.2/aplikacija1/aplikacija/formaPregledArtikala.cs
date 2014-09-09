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
    public partial class formaPregledArtikala : Form
    {
        public formaPregledArtikala()
        {
            InitializeComponent();
        }

        private int selectedRowIndex;
        private int sifraArtikla;



        private void artikliBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.artikliBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t28EnigmaDataSet);

        }

        private void pregledArtikala_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't28EnigmaDataSet.EvidencijaKontrole' table. You can move, or remove it, as needed.
            this.evidencijaKontroleTableAdapter.Fill(this.t28EnigmaDataSet.EvidencijaKontrole);
            // TODO: This line of code loads data into the 't28EnigmaDataSet.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter.Fill(this.t28EnigmaDataSet.Artikli);

        }

        private void txtPretrazivanje_TextChanged(object sender, EventArgs e)
        {

            artikliTableAdapter.FillByFilter(t28EnigmaDataSet.Artikli,txtPretrazivanje.Text);
            artikliDataGridView.Refresh();
        }

        private void picUnos_Click(object sender, EventArgs e)
        {

            formaUredjivanjeArtikala UrediArtikl = new formaUredjivanjeArtikala();
            UrediArtikl.ShowDialog();

            if (UrediArtikl.DialogResult == DialogResult.OK)
            {
                this.artikliTableAdapter.Fill(this.t28EnigmaDataSet.Artikli);
                artikliDataGridView.Refresh();
            }
        }

        private void picSpremi_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = artikliDataGridView.Rows[selectedRowIndex];

            formaUredjivanjeArtikala UrediArtikl = new formaUredjivanjeArtikala(int.Parse(Convert.ToString(selectedRow.Cells[dataGridViewTextBoxIdArtikl.Name].Value)), Convert.ToString(selectedRow.Cells[dataGridViewTextBoxNaziv.Name].Value), Convert.ToString(selectedRow.Cells[dataGridViewTextBoxOpis.Name].Value), Convert.ToString(selectedRow.Cells[dataGridViewTextBoxBoja.Name].Value), int.Parse(Convert.ToString(selectedRow.Cells[evidencijaKontrole.Name].Value)));
            UrediArtikl.Show();

            if (UrediArtikl.DialogResult == DialogResult.OK)
            {
                this.artikliTableAdapter.Fill(this.t28EnigmaDataSet.Artikli);
                artikliDataGridView.Refresh();
            }
        }

        private void picObrisi_Click(object sender, EventArgs e)
        {
            /*
            sifraTepiha = Convert.ToString(selectedRow.Cells[sifraTepihaDataGridViewTextBoxColumn.Name].Value);
            this.tepihTableAdapter.DeleteFromSlika(sifraTepiha);
            this.tepihTableAdapter.DeleteFromTepih(sifraTepiha);
            this.tepihTableAdapter.Fill(this.TepisiDBFileDataSet1.Tepih);
            dgvPregledKataloga.Refresh();

             */

            DataGridViewRow selectedRow = artikliDataGridView.Rows[selectedRowIndex];
            sifraArtikla = int.Parse(Convert.ToString(selectedRow.Cells[dataGridViewTextBoxIdArtikl.Name].Value));
            this.artikliTableAdapter.DeleteQuery(sifraArtikla);
            this.artikliTableAdapter.Fill(this.t28EnigmaDataSet.Artikli);
            artikliDataGridView.Refresh();


        }

        private void artikliDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
                selectedRowIndex = e.RowIndex;
                DataGridViewRow selectedRow = artikliDataGridView.Rows[selectedRowIndex];
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        


        
        
    }
}
