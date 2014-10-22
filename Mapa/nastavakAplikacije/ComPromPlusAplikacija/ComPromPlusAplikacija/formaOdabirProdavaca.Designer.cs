namespace ComPromPlusAplikacija
{
    partial class formaOdabirProdavaca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formaOdabirProdavaca));
            this.lblNaslovniText = new System.Windows.Forms.Label();
            this.picDjelatnici = new System.Windows.Forms.PictureBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnDalje = new System.Windows.Forms.Button();
            this.dgvProdavaci = new System.Windows.Forms.DataGridView();
            this.poslovniPartnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t23_Enigma2DataSet = new ComPromPlusAplikacija.T23_Enigma2DataSet();
            this.poslovniPartnerTableAdapter = new ComPromPlusAplikacija.T23_Enigma2DataSetTableAdapters.poslovniPartnerTableAdapter();
            this.tableAdapterManager = new ComPromPlusAplikacija.T23_Enigma2DataSetTableAdapters.TableAdapterManager();
            this.narudzbenicaTableAdapter = new ComPromPlusAplikacija.T23_Enigma2DataSetTableAdapters.NarudzbenicaTableAdapter();
            this.narudzbenicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picDjelatnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdavaci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniPartnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_Enigma2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslovniText
            // 
            this.lblNaslovniText.AutoSize = true;
            this.lblNaslovniText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.lblNaslovniText.Location = new System.Drawing.Point(90, 30);
            this.lblNaslovniText.Name = "lblNaslovniText";
            this.lblNaslovniText.Size = new System.Drawing.Size(480, 38);
            this.lblNaslovniText.TabIndex = 85;
            this.lblNaslovniText.Text = "Narudžbenica odabir prodavača";
            // 
            // picDjelatnici
            // 
            this.picDjelatnici.Image = ((System.Drawing.Image)(resources.GetObject("picDjelatnici.Image")));
            this.picDjelatnici.Location = new System.Drawing.Point(14, 15);
            this.picDjelatnici.Name = "picDjelatnici";
            this.picDjelatnici.Size = new System.Drawing.Size(70, 67);
            this.picDjelatnici.TabIndex = 84;
            this.picDjelatnici.TabStop = false;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.Location = new System.Drawing.Point(607, 250);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(115, 35);
            this.btnOdustani.TabIndex = 86;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDalje
            // 
            this.btnDalje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDalje.Location = new System.Drawing.Point(607, 188);
            this.btnDalje.Name = "btnDalje";
            this.btnDalje.Size = new System.Drawing.Size(115, 39);
            this.btnDalje.TabIndex = 87;
            this.btnDalje.Text = "Dalje";
            this.btnDalje.UseVisualStyleBackColor = true;
            this.btnDalje.Click += new System.EventHandler(this.btnŠalji_Click);
            // 
            // dgvProdavaci
            // 
            this.dgvProdavaci.AllowUserToAddRows = false;
            this.dgvProdavaci.AllowUserToDeleteRows = false;
            this.dgvProdavaci.AutoGenerateColumns = false;
            this.dgvProdavaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdavaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nazivDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.check});
            this.dgvProdavaci.DataSource = this.poslovniPartnerBindingSource;
            this.dgvProdavaci.Location = new System.Drawing.Point(42, 106);
            this.dgvProdavaci.Name = "dgvProdavaci";
            this.dgvProdavaci.Size = new System.Drawing.Size(528, 279);
            this.dgvProdavaci.TabIndex = 88;
            this.dgvProdavaci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDokumenti_CellContentClick);
            this.dgvProdavaci.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDokumenti_DataBindingComplete);
            // 
            // poslovniPartnerBindingSource
            // 
            this.poslovniPartnerBindingSource.DataMember = "poslovniPartner";
            this.poslovniPartnerBindingSource.DataSource = this.t23_Enigma2DataSet;
            // 
            // t23_Enigma2DataSet
            // 
            this.t23_Enigma2DataSet.DataSetName = "T23_Enigma2DataSet";
            this.t23_Enigma2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // poslovniPartnerTableAdapter
            // 
            this.poslovniPartnerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArtikliTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DjelatnikTableAdapter = null;
            this.tableAdapterManager.IzdatnicaTableAdapter = null;
            this.tableAdapterManager.knjizenjeDokumentaTableAdapter = null;
            this.tableAdapterManager.KorisnikTableAdapter = null;
            this.tableAdapterManager.NarudzbenicaTableAdapter = this.narudzbenicaTableAdapter;
            this.tableAdapterManager.OtpremnicaTableAdapter = null;
            this.tableAdapterManager.poslovniPartnerTableAdapter = this.poslovniPartnerTableAdapter;
            this.tableAdapterManager.pracenjeProizvodnjeTableAdapter = null;
            this.tableAdapterManager.PrimkaTableAdapter = null;
            this.tableAdapterManager.RepromaterijaliTableAdapter = null;
            this.tableAdapterManager.stavkeIzdatniceTableAdapter = null;
            this.tableAdapterManager.stavkeNarudzbeniceTableAdapter = null;
            this.tableAdapterManager.stavkeOtpremniceTableAdapter = null;
            this.tableAdapterManager.stavkePrimkeTableAdapter = null;
            this.tableAdapterManager.StrojTableAdapter = null;
            this.tableAdapterManager.tipKorisnikaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ComPromPlusAplikacija.T23_Enigma2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtrosakTableAdapter = null;
            // 
            // narudzbenicaTableAdapter
            // 
            this.narudzbenicaTableAdapter.ClearBeforeFill = true;
            // 
            // narudzbenicaBindingSource
            // 
            this.narudzbenicaBindingSource.DataMember = "FK_Narudzbenica_ToTable";
            this.narudzbenicaBindingSource.DataSource = this.poslovniPartnerBindingSource;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E - mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // check
            // 
            this.check.HeaderText = "Označi";
            this.check.Name = "check";
            this.check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // formaOdabirProdavaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 402);
            this.Controls.Add(this.dgvProdavaci);
            this.Controls.Add(this.btnDalje);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.lblNaslovniText);
            this.Controls.Add(this.picDjelatnici);
            this.Name = "formaOdabirProdavaca";
            this.Text = "Odabir Prodavača";
            this.Load += new System.EventHandler(this.formaOdabirProdavaca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDjelatnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdavaci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniPartnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_Enigma2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslovniText;
        private System.Windows.Forms.PictureBox picDjelatnici;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDalje;
        private System.Windows.Forms.DataGridView dgvProdavaci;
        private T23_Enigma2DataSet t23_Enigma2DataSet;
        private System.Windows.Forms.BindingSource poslovniPartnerBindingSource;
        private T23_Enigma2DataSetTableAdapters.poslovniPartnerTableAdapter poslovniPartnerTableAdapter;
        private T23_Enigma2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private T23_Enigma2DataSetTableAdapters.NarudzbenicaTableAdapter narudzbenicaTableAdapter;
        private System.Windows.Forms.BindingSource narudzbenicaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
    }
}