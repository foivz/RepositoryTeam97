namespace aplikacija
{
    partial class formaDokumenti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formaDokumenti));
            this.label1 = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.lblObrisi = new System.Windows.Forms.Label();
            this.lblSpremi = new System.Windows.Forms.Label();
            this.lblUnos = new System.Windows.Forms.Label();
            this.picObrisi = new System.Windows.Forms.PictureBox();
            this.picUnos = new System.Windows.Forms.PictureBox();
            this.picSpremi = new System.Windows.Forms.PictureBox();
            this.lblDokumentiIkona = new System.Windows.Forms.Label();
            this.picDokumentiIkona = new System.Windows.Forms.PictureBox();
            this.dokumentDataGridView = new System.Windows.Forms.DataGridView();
            this.dgvStavkeDokumenata = new System.Windows.Forms.DataGridView();
            this.t28EnigmaDataSet = new aplikacija.T28EnigmaDataSet();
            this.artikliBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.artikliTableAdapter = new aplikacija.T28EnigmaDataSetTableAdapters.ArtikliTableAdapter();
            this.stavkedokumentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nazivArtikla = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObrisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpremi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDokumentiIkona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeDokumenata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t28EnigmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkedokumentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(815, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 120;
            this.label1.Text = "Izlaz";
            // 
            // picExit
            // 
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(794, 24);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(68, 70);
            this.picExit.TabIndex = 119;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // lblObrisi
            // 
            this.lblObrisi.AutoSize = true;
            this.lblObrisi.Location = new System.Drawing.Point(686, 97);
            this.lblObrisi.Name = "lblObrisi";
            this.lblObrisi.Size = new System.Drawing.Size(33, 13);
            this.lblObrisi.TabIndex = 118;
            this.lblObrisi.Text = "Obriši";
            // 
            // lblSpremi
            // 
            this.lblSpremi.AutoSize = true;
            this.lblSpremi.Location = new System.Drawing.Point(589, 97);
            this.lblSpremi.Name = "lblSpremi";
            this.lblSpremi.Size = new System.Drawing.Size(39, 13);
            this.lblSpremi.TabIndex = 117;
            this.lblSpremi.Text = "Spremi";
            // 
            // lblUnos
            // 
            this.lblUnos.AutoSize = true;
            this.lblUnos.Location = new System.Drawing.Point(489, 97);
            this.lblUnos.Name = "lblUnos";
            this.lblUnos.Size = new System.Drawing.Size(58, 13);
            this.lblUnos.TabIndex = 116;
            this.lblUnos.Text = "Dodaj novi";
            // 
            // picObrisi
            // 
            this.picObrisi.Image = ((System.Drawing.Image)(resources.GetObject("picObrisi.Image")));
            this.picObrisi.Location = new System.Drawing.Point(672, 24);
            this.picObrisi.Name = "picObrisi";
            this.picObrisi.Size = new System.Drawing.Size(68, 70);
            this.picObrisi.TabIndex = 115;
            this.picObrisi.TabStop = false;
            // 
            // picUnos
            // 
            this.picUnos.Image = ((System.Drawing.Image)(resources.GetObject("picUnos.Image")));
            this.picUnos.Location = new System.Drawing.Point(482, 24);
            this.picUnos.Name = "picUnos";
            this.picUnos.Size = new System.Drawing.Size(68, 70);
            this.picUnos.TabIndex = 114;
            this.picUnos.TabStop = false;
            // 
            // picSpremi
            // 
            this.picSpremi.Image = ((System.Drawing.Image)(resources.GetObject("picSpremi.Image")));
            this.picSpremi.Location = new System.Drawing.Point(576, 24);
            this.picSpremi.Name = "picSpremi";
            this.picSpremi.Size = new System.Drawing.Size(68, 70);
            this.picSpremi.TabIndex = 113;
            this.picSpremi.TabStop = false;
            // 
            // lblDokumentiIkona
            // 
            this.lblDokumentiIkona.AutoSize = true;
            this.lblDokumentiIkona.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDokumentiIkona.Location = new System.Drawing.Point(140, 36);
            this.lblDokumentiIkona.Name = "lblDokumentiIkona";
            this.lblDokumentiIkona.Size = new System.Drawing.Size(184, 39);
            this.lblDokumentiIkona.TabIndex = 97;
            this.lblDokumentiIkona.Text = "Dokumenti";
            // 
            // picDokumentiIkona
            // 
            this.picDokumentiIkona.Image = ((System.Drawing.Image)(resources.GetObject("picDokumentiIkona.Image")));
            this.picDokumentiIkona.Location = new System.Drawing.Point(62, 24);
            this.picDokumentiIkona.Name = "picDokumentiIkona";
            this.picDokumentiIkona.Size = new System.Drawing.Size(63, 66);
            this.picDokumentiIkona.TabIndex = 96;
            this.picDokumentiIkona.TabStop = false;
            // 
            // dokumentDataGridView
            // 
            this.dokumentDataGridView.AutoGenerateColumns = false;
            this.dokumentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dokumentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dokumentDataGridView.DataSource = this.dokumentBindingSource;
            this.dokumentDataGridView.Location = new System.Drawing.Point(32, 154);
            this.dokumentDataGridView.Name = "dokumentDataGridView";
            this.dokumentDataGridView.Size = new System.Drawing.Size(811, 190);
            this.dokumentDataGridView.TabIndex = 120;
            this.dokumentDataGridView.SelectionChanged += new System.EventHandler(this.dokumentDataGridView_SelectionChanged);
            // 
            // dgvStavkeDokumenata
            // 
            this.dgvStavkeDokumenata.AutoGenerateColumns = false;
            this.dgvStavkeDokumenata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeDokumenata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivArtikla,
            this.kolicinaDataGridViewTextBoxColumn});
            this.dgvStavkeDokumenata.DataSource = this.stavkedokumentaBindingSource;
            this.dgvStavkeDokumenata.Location = new System.Drawing.Point(32, 383);
            this.dgvStavkeDokumenata.Name = "dgvStavkeDokumenata";
            this.dgvStavkeDokumenata.Size = new System.Drawing.Size(811, 150);
            this.dgvStavkeDokumenata.TabIndex = 121;
            // 
            // t28EnigmaDataSet
            // 
            this.t28EnigmaDataSet.DataSetName = "T28EnigmaDataSet";
            this.t28EnigmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artikliBindingSource1
            // 
            this.artikliBindingSource1.DataMember = "Artikli";
            this.artikliBindingSource1.DataSource = this.t28EnigmaDataSet;
            // 
            // artikliTableAdapter
            // 
            this.artikliTableAdapter.ClearBeforeFill = true;
            // 
            // stavkedokumentaBindingSource
            // 
            this.stavkedokumentaBindingSource.DataSource = typeof(aplikacija.stavke_dokumenta);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdDokument";
            this.dataGridViewTextBoxColumn1.HeaderText = "Šifra dokumenta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tipDokumenta";
            this.dataGridViewTextBoxColumn5.HeaderText = "Vrsta dokumenta";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 103;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "datum";
            this.dataGridViewTextBoxColumn3.HeaderText = "Datum";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "opis";
            this.dataGridViewTextBoxColumn4.HeaderText = "Opis";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dokumentBindingSource
            // 
            this.dokumentBindingSource.DataSource = typeof(aplikacija.Dokument);
            // 
            // artikliBindingSource
            // 
            this.artikliBindingSource.DataSource = typeof(aplikacija.Artikli);
            // 
            // nazivArtikla
            // 
            this.nazivArtikla.DataPropertyName = "artikliId";
            this.nazivArtikla.DataSource = this.artikliBindingSource1;
            this.nazivArtikla.DisplayMember = "naziv";
            this.nazivArtikla.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.nazivArtikla.HeaderText = "Naziv artikla";
            this.nazivArtikla.Name = "nazivArtikla";
            this.nazivArtikla.ValueMember = "IdArtikli";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // formaDokumenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 667);
            this.Controls.Add(this.dgvStavkeDokumenata);
            this.Controls.Add(this.dokumentDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.lblObrisi);
            this.Controls.Add(this.lblSpremi);
            this.Controls.Add(this.lblUnos);
            this.Controls.Add(this.picObrisi);
            this.Controls.Add(this.picUnos);
            this.Controls.Add(this.picSpremi);
            this.Controls.Add(this.lblDokumentiIkona);
            this.Controls.Add(this.picDokumentiIkona);
            this.Name = "formaDokumenti";
            this.Text = "formaDokument";
            this.Load += new System.EventHandler(this.formaDokumenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObrisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpremi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDokumentiIkona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeDokumenata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t28EnigmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkedokumentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label lblObrisi;
        private System.Windows.Forms.Label lblSpremi;
        private System.Windows.Forms.Label lblUnos;
        private System.Windows.Forms.PictureBox picObrisi;
        private System.Windows.Forms.PictureBox picUnos;
        private System.Windows.Forms.PictureBox picSpremi;
        private System.Windows.Forms.Label lblDokumentiIkona;
        private System.Windows.Forms.PictureBox picDokumentiIkona;
        private System.Windows.Forms.BindingSource dokumentBindingSource;
        private System.Windows.Forms.DataGridView dokumentDataGridView;
        private System.Windows.Forms.DataGridView dgvStavkeDokumenata;
        private System.Windows.Forms.BindingSource stavkedokumentaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private T28EnigmaDataSet t28EnigmaDataSet;
        private System.Windows.Forms.BindingSource artikliBindingSource1;
        private T28EnigmaDataSetTableAdapters.ArtikliTableAdapter artikliTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn nazivArtikla;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;

    }
}