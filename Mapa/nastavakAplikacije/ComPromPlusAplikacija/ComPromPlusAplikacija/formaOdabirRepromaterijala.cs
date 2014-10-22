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
    public partial class formaOdabirRepromaterijala : Form

    {
        public formaOdabirRepromaterijala odabirRepromaterijala;
        int repromaterijali = 0;

        public static bool odustani = false;
        private int selectedRowIndex;
       

        public formaOdabirRepromaterijala(formaNarudzbenicaUnos parentForm, formaNarudzbenica narudzba)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }
         private string sifraNarudzbe;

        private void formaOdabirRepromaterijala_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't23_Enigma2DataSet.Repromaterijali' table. You can move, or remove it, as needed.
            this.repromaterijaliTableAdapter.Fill(this.t23_Enigma2DataSet.Repromaterijali);

             //odmah na početku postavi da je prvi red u datagridu selektiran i učitaj prvu sliku prvog repromaterijala (selektiranog tepiha) u imagebox
            //selectedRowIndex = 0;
            //DataGridViewRow selectedRow = dgvDokumenti.Rows[selectedRowIndex];

        }

        private void btnDalje_Click(object sender, EventArgs e)
        {

              foreach (DataGridViewRow row in dgvDokumenti.Rows)
            {
                //provjeri za svaki repromaterijal da li je označen u datagridu...
                if (Convert.ToBoolean(row.Cells[chk.Name].Value) == true)
                {
                    //... pa u tom slučaju dodaj ga na izvjestaj, odnosno tom repromaterijali pridruži broj trenutnog izvjestaja
                    repromaterijali++;
                    //repromaterijaliTableAdapter.Update...(formaNarudzbenicaUnos.izvjestaj, Convert.ToString(row.Cells[sifraRepromaterijala.Name].Value));
                }
            }

            if (repromaterijali == 0)
            {
                MessageBox.Show("Morate odabrati barem 1 repromaterijal");
            }

            else
            {
                //prijeđi na sljedeći korak 
                this.Hide();
                 formaOdabirProdavaca prodavac = new formaOdabirProdavaca();
                 prodavac.Show();
                if (odustani == false)
                {
                    this.Show();
                }
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDokumenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5) //provjerava da li je pritisnut check box jer me samo u tom slučaju zanima nekakva promjena, ne zanima me ako korisnik npr pritisne ime repromaterijala
            {
                if (Convert.ToBoolean(dgvDokumenti.Rows[selectedRowIndex].Cells[chk.Name].Value) == false) // ako je kućica check boxa prazna...
                {
                    dgvDokumenti.Rows[selectedRowIndex].Cells[chk.Name].Value = true; //....onda je označi
                }

                else if (Convert.ToBoolean(dgvDokumenti.Rows[selectedRowIndex].Cells[chk.Name].Value) == true) //ako je repromaterijal označen....
                {
                    dgvDokumenti.Rows[selectedRowIndex].Cells[chk.Name].Value = false; //....onda ga odznači iz datagrida
                }
            }
        }


        private void dgvDokumenti_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {//ako korisnik klikne na zaglavlje stupca (kako bi sortirao repromaterijale po nekom atributu) aplikacija treba "zapamtiti" šifru trenutno selektiranog repromaterijala kako bi se poslije mogla pozicionirati
                //na taj isti tepih
                sifraNarudzbe = dgvDokumenti.SelectedRows[0].Cells[sifraRepromaterijala.Name].Value.ToString();
            }

            else
            {
                selectedRowIndex = e.RowIndex; // argument eventa je red na kojem je pritisnuta tipka miša, a pošto je objekt klase datagrid iz njega možemo "dobiti" index trenutnog reda
                DataGridViewRow selectedRow = dgvDokumenti.Rows[selectedRowIndex];
                
            }
            
        
        
        }

        public formaOdabirRepromaterijala parentForm { get; set; }
    }
}
