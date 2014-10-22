namespace ComPromPlusAplikacija
{
    partial class formaOdabirRepromaterijala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formaOdabirRepromaterijala));
            this.dgvDokumenti = new System.Windows.Forms.DataGridView();
            this.repromaterijaliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t23_Enigma2DataSet = new ComPromPlusAplikacija.T23_Enigma2DataSet();
            this.repromaterijaliTableAdapter = new ComPromPlusAplikacija.T23_Enigma2DataSetTableAdapters.RepromaterijaliTableAdapter();
            this.tableAdapterManager = new ComPromPlusAplikacija.T23_Enigma2DataSetTableAdapters.TableAdapterManager();
            this.lblNaslovniText = new System.Windows.Forms.Label();
            this.picDjelatnici = new System.Windows.Forms.PictureBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnDalje = new System.Windows.Forms.Button();
            this.sifraRepromaterijala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDokumenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repromaterijaliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_Enigma2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDjelatnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDokumenti
            // 
            this.dgvDokumenti.AllowUserToAddRows = false;
            this.dgvDokumenti.AllowUserToDeleteRows = false;
            this.dgvDokumenti.AutoGenerateColumns = false;
            this.dgvDokumenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDokumenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sifraRepromaterijala,
            this.nazivDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.bojaDataGridViewTextBoxColumn,
            this.chk});
            this.dgvDokumenti.DataSource = this.repromaterijaliBindingSource;
            this.dgvDokumenti.Location = new System.Drawing.Point(30, 134);
            this.dgvDokumenti.Name = "dgvDokumenti";
            this.dgvDokumenti.Size = new System.Drawing.Size(646, 285);
            this.dgvDokumenti.TabIndex = 43;
            this.dgvDokumenti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDokumenti_CellContentClick);
            this.dgvDokumenti.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDokumenti_CellMouseDown);
            
            // 
            // repromaterijaliBindingSource
            // 
            this.repromaterijaliBindingSource.DataMember = "Repromaterijali";
            this.repromaterijaliBindingSource.DataSource = this.t23_Enigma2DataSet;
            // 
            // t23_Enigma2DataSet
            // 
            this.t23_Enigma2DataSet.DataSetName = "T23_Enigma2DataSet";
            this.t23_Enigma2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repromaterijaliTableAdapter
            // 
            this.repromaterijaliTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArtikliTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DjelatnikTableAdapter = null;
            this.tableAdapterManager.IzdatnicaTableAdapter = null;
            this.tableAdapterManager.knjizenjeDokumentaTableAdapter = null;
            this.tableAdapterManager.KorisnikTableAdapter = null;
            this.tableAdapterManager.NarudzbenicaTableAdapter = null;
            this.tableAdapterManager.OtpremnicaTableAdapter = null;
            this.tableAdapterManager.poslovniPartnerTableAdapter = null;
            this.tableAdapterManager.pracenjeProizvodnjeTableAdapter = null;
            this.tableAdapterManager.PrimkaTableAdapter = null;
            this.tableAdapterManager.RepromaterijaliTableAdapter = this.repromaterijaliTableAdapter;
            this.tableAdapterManager.stavkeIzdatniceTableAdapter = null;
            this.tableAdapterManager.stavkeNarudzbeniceTableAdapter = null;
            this.tableAdapterManager.stavkeOtpremniceTableAdapter = null;
            this.tableAdapterManager.stavkePrimkeTableAdapter = null;
            this.tableAdapterManager.StrojTableAdapter = null;
            this.tableAdapterManager.tipKorisnikaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ComPromPlusAplikacija.T23_Enigma2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtrosakTableAdapter = null;
            // 
            // lblNaslovniText
            // 
            this.lblNaslovniText.AutoSize = true;
            this.lblNaslovniText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.lblNaslovniText.Location = new System.Drawing.Point(106, 27);
            this.lblNaslovniText.Name = "lblNaslovniText";
            this.lblNaslovniText.Size = new System.Drawing.Size(543, 38);
            this.lblNaslovniText.TabIndex = 83;
            this.lblNaslovniText.Text = "Narudžbenica odabir repromaterijala";
            // 
            // picDjelatnici
            // 
            this.picDjelatnici.Image = ((System.Drawing.Image)(resources.GetObject("picDjelatnici.Image")));
            this.picDjelatnici.Location = new System.Drawing.Point(30, 12);
            this.picDjelatnici.Name = "picDjelatnici";
            this.picDjelatnici.Size = new System.Drawing.Size(70, 67);
            this.picDjelatnici.TabIndex = 82;
            this.picDjelatnici.TabStop = false;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.Location = new System.Drawing.Point(701, 261);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(115, 35);
            this.btnOdustani.TabIndex = 84;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDalje
            // 
            this.btnDalje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDalje.Location = new System.Drawing.Point(701, 204);
            this.btnDalje.Name = "btnDalje";
            this.btnDalje.Size = new System.Drawing.Size(115, 39);
            this.btnDalje.TabIndex = 85;
            this.btnDalje.Text = "Dalje";
            this.btnDalje.UseVisualStyleBackColor = true;
            this.btnDalje.Click += new System.EventHandler(this.btnDalje_Click);
            // 
            // sifraRepromaterijala
            // 
            this.sifraRepromaterijala.DataPropertyName = "Id";
            this.sifraRepromaterijala.HeaderText = "Id";
            this.sifraRepromaterijala.Name = "sifraRepromaterijala";
            this.sifraRepromaterijala.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // bojaDataGridViewTextBoxColumn
            // 
            this.bojaDataGridViewTextBoxColumn.DataPropertyName = "boja";
            this.bojaDataGridViewTextBoxColumn.HeaderText = "Boja";
            this.bojaDataGridViewTextBoxColumn.Name = "bojaDataGridViewTextBoxColumn";
            // 
            // chk
            // 
            this.chk.HeaderText = "Označi";
            this.chk.Name = "chk";
            this.chk.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // formaOdabirRepromaterijala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 468);
            this.Controls.Add(this.btnDalje);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.lblNaslovniText);
            this.Controls.Add(this.picDjelatnici);
            this.Controls.Add(this.dgvDokumenti);
            this.Name = "formaOdabirRepromaterijala";
            this.Text = "Odabir repromaterijala";
            this.Load += new System.EventHandler(this.formaOdabirRepromaterijala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDokumenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repromaterijaliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_Enigma2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDjelatnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDokumenti;
        private T23_Enigma2DataSet t23_Enigma2DataSet;
        private System.Windows.Forms.BindingSource repromaterijaliBindingSource;
        private T23_Enigma2DataSetTableAdapters.RepromaterijaliTableAdapter repromaterijaliTableAdapter;
        private T23_Enigma2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblNaslovniText;
        private System.Windows.Forms.PictureBox picDjelatnici;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDalje;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraRepromaterijala;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bojaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
    }
}