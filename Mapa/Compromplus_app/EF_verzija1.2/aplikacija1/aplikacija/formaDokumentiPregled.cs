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

        DateTimePicker dtpDokument;

        private void dokumentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.stavke_dokumentaBindingSource.EndEdit();
                this.dokumentBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.t28EnigmaDataSet);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void formaDokumentiPregled_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't28EnigmaDataSet.TipDokumenta' table. You can move, or remove it, as needed.
            this.tipDokumentaTableAdapter.Fill(this.t28EnigmaDataSet.TipDokumenta);
            // TODO: This line of code loads data into the 't28EnigmaDataSet.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter.Fill(this.t28EnigmaDataSet.Artikli);
            // TODO: This line of code loads data into the 't28EnigmaDataSet.stavke_dokumenta' table. You can move, or remove it, as needed.
            this.stavke_dokumentaTableAdapter.Fill(this.t28EnigmaDataSet.stavke_dokumenta);
            // TODO: This line of code loads data into the 't28EnigmaDataSet.stavke_dokumenta' table. You can move, or remove it, as needed.
            this.stavke_dokumentaTableAdapter.Fill(this.t28EnigmaDataSet.stavke_dokumenta);
            // TODO: This line of code loads data into the 't28EnigmaDataSet.Dokument' table. You can move, or remove it, as needed.
            this.dokumentTableAdapter.Fill(this.t28EnigmaDataSet.Dokument);

            dtpDokument = new DateTimePicker();
            dtpDokument.Format = DateTimePickerFormat.Short;
            dtpDokument.Visible = false;
            dtpDokument.Width = 100;
            dokumentDataGridView.Controls.Add(dtpDokument);

            dtpDokument.ValueChanged += this.dtpDokument_ValueChanged;
            dokumentDataGridView.CellBeginEdit += this.dokumentDataGridView_CellBeginEdit;

            dokumentDataGridView.CellEndEdit += this.dokumentDataGridView_CellEndEdit;

        }

        private void dokumentDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dokumentDataGridView.RowCount > 0)
            {
                int IdDokument = int.Parse(dokumentDataGridView.CurrentRow.Cells[0].Value.ToString());
                this.stavke_dokumentaTableAdapter.FillByStavkeDokumenta(this.t28EnigmaDataSet.stavke_dokumenta, IdDokument);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Želite li obrisati ovaj dokument?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                for (int i = 0; i < stavke_dokumentaDataGridView.Rows.Count; i++)
                {
                    stavke_dokumentaDataGridView.Rows.RemoveAt(i);
                }
                dokumentDataGridView.Rows.RemoveAt(dokumentDataGridView.CurrentRow.Index);
            }
        }

        private void dokumentDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                if ((dokumentDataGridView.Focused) && (dokumentDataGridView.CurrentCell.ColumnIndex==1))
                {
	                dtpDokument.Location=dokumentDataGridView.GetCellDisplayRectangle(e.ColumnIndex,e.RowIndex,false).Location;
	                dtpDokument.Visible = true;

                    if(dokumentDataGridView.CurrentCell.Value!=DBNull.Value)
                    {
	                    dtpDokument.Value=(DateTime)dokumentDataGridView.CurrentCell.Value;
                    }

                    else
                    {
	                    dtpDokument.Value=DateTime.Today;
                    }

                }

                else
                {
	                dtpDokument.Visible=false;
                }

            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dokumentDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                if ((dokumentDataGridView.Focused) && (dokumentDataGridView.CurrentCell.ColumnIndex == 1))
                {
                    dokumentDataGridView.CurrentCell.Value = dtpDokument.Value.Date;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtpDokument_ValueChanged(object sender, EventArgs e)
        {
            dokumentDataGridView.CurrentCell.Value = dtpDokument.Text;
        }

        
    }
}
