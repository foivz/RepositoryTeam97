using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComPromPlusAplikacija
{
    public partial class formaOdabirProdavaca : Form
    {

        public static bool odustani = false;
        formaOdabirRepromaterijala parentForm;
        private int selectedRowIndex;
        private string idProdavaca;
        int prodavac = 0;

        public formaOdabirProdavaca(formaOdabirRepromaterijala parentForm, formaNarudzbenica narudzba)
        {
            InitializeComponent();
            this.parentForm = parentForm;

        }

        private void formaOdabirProdavaca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't23_Enigma2DataSet.Narudzbenica' table. You can move, or remove it, as needed.
            this.narudzbenicaTableAdapter.Fill(this.t23_Enigma2DataSet.Narudzbenica);
            // TODO: This line of code loads data into the 't23_Enigma2DataSet.poslovniPartner' table. You can move, or remove it, as needed.
            this.poslovniPartnerTableAdapter.Fill(this.t23_Enigma2DataSet.poslovniPartner);

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnŠalji_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgvProdavaci.Rows)
            {
                if (Convert.ToBoolean(row.Cells[check.Name].Value) == true)
                {
                    //dodaj označenog prodavaca na izvjestaj narudzbe
                    prodavac++;
                    poslovniPartnerTableAdapter.AddProdavacNaizvjestajNarudzbe(Convert.ToString(row.Cells[id.Name].Value), formaNarudzbenica.izvjestajNarudzbe);
                }
            }

            if (prodavac == 0)
            {
                MessageBox.Show("Morate odabrati jednog prodavaca");
            }

            else
            {
                formaIzvjestajNarudzbenice izvjestajNarudz = new formaIzvjestajNarudzbenice(this, narudzba);
                this.Hide();
                izvjestajNarudz.ShowDialog();
                this.Show();
            }

            formaIzvjestajNarudzbenice izvjestaj = new formaIzvjestajNarudzbenice(this, narudzba);
            izvjestaj.Show();
            this.Close();
            
        }

        private void dgvDokumenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                //provjera da li je korisnik već odabrao jednog prodavaca
                //ako da onda se briše prijašnje selektirani prodavac i označi se trenutno selektirani
                //moguće je na 1 izvjestaj odabrati samo jednog prodavaca
                foreach (DataGridViewRow row in this.dgvProdavaci.Rows)
                {
                    if (row.Cells[id.Name].Value == dgvProdavaci.Rows[selectedRowIndex].Cells[id.Name].Value)
                    {//ako dođe do trenutno selektiranog reda njega ne diraj (inače korisnik ne bi mogao uopće odselektirati prodavaca
                        //jer bi se uvijek checkbox selektiranog novog prodavaca postavio ne unchecked a dolje opet na checked
                        continue;
                    }
                    if (Convert.ToBoolean(row.Cells[check.Name].Value) == true)
                    {
                        row.Cells[check.Name].Value = false;
                    }
                }

                if (Convert.ToBoolean(dgvProdavaci.Rows[selectedRowIndex].Cells[check.Name].Value) == false)
                {
                    dgvProdavaci.Rows[selectedRowIndex].Cells[check.Name].Value = true;
                }

                else if (Convert.ToBoolean(dgvProdavaci.Rows[selectedRowIndex].Cells[check.Name].Value) == true)
                {
                    dgvProdavaci.Rows[selectedRowIndex].Cells[check.Name].Value = false;
                }
            }

        }

        private void dgvDokumenti_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (!String.IsNullOrEmpty(idProdavaca) && e.ListChangedType == ListChangedType.Reset)
            {
                int row = poslovniPartnerBindingSource.Find("ID", idProdavaca);

                dgvProdavaci.BeginInvoke((MethodInvoker)delegate()
                {
                    if (row != -1)
                    {
                        dgvProdavaci.Rows[row].Selected = true;
                        dgvProdavaci.CurrentCell = dgvProdavaci[0, row];
                    }
                });
            }
        }

    }
}
