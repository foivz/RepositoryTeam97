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

        private void formaDokumenti_Load(object sender, EventArgs e)
        {
            prikaziDokumente();
        }
    }
}
