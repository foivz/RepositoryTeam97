namespace ComPromPlusAplikacija
{
    partial class formaDjelatniciPregled
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formaDjelatniciPregled));
            this.dgvDjelatnici = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strucnaSpremaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.djelatnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t23_Enigma2DataSet = new ComPromPlusAplikacija.T23_Enigma2DataSet();
            this.btnPretrazivanjeSifra = new System.Windows.Forms.Button();
            this.txtPretrazivanjeSifra = new System.Windows.Forms.TextBox();
            this.lblPretrazivanjeSifra = new System.Windows.Forms.Label();
            this.txtPretrazivanje = new System.Windows.Forms.TextBox();
            this.lblPretrazivanje = new System.Windows.Forms.Label();
            this.lblIzlaz = new System.Windows.Forms.Label();
            this.lblObrisi = new System.Windows.Forms.Label();
            this.lblIzmjeni = new System.Windows.Forms.Label();
            this.lblDodaj = new System.Windows.Forms.Label();
            this.picIzlaz = new System.Windows.Forms.PictureBox();
            this.picObrisi = new System.Windows.Forms.PictureBox();
            this.picIzmjeni = new System.Windows.Forms.PictureBox();
            this.picDodaj = new System.Windows.Forms.PictureBox();
            this.lblNaslovniText = new System.Windows.Forms.Label();
            this.picDjelatnici = new System.Windows.Forms.PictureBox();
            this.djelatnikTableAdapter = new ComPromPlusAplikacija.T23_Enigma2DataSetTableAdapters.DjelatnikTableAdapter();
            this.tableAdapterManager = new ComPromPlusAplikacija.T23_Enigma2DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDjelatnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.djelatnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_Enigma2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObrisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzmjeni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDodaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDjelatnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDjelatnici
            // 
            this.dgvDjelatnici.AllowUserToAddRows = false;
            this.dgvDjelatnici.AllowUserToDeleteRows = false;
            this.dgvDjelatnici.AutoGenerateColumns = false;
            this.dgvDjelatnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDjelatnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.strucnaSpremaDataGridViewTextBoxColumn,
            this.strojDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn});
            this.dgvDjelatnici.DataSource = this.djelatnikBindingSource;
            this.dgvDjelatnici.Location = new System.Drawing.Point(26, 213);
            this.dgvDjelatnici.Name = "dgvDjelatnici";
            this.dgvDjelatnici.Size = new System.Drawing.Size(756, 255);
            this.dgvDjelatnici.TabIndex = 53;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // strucnaSpremaDataGridViewTextBoxColumn
            // 
            this.strucnaSpremaDataGridViewTextBoxColumn.DataPropertyName = "strucnaSprema";
            this.strucnaSpremaDataGridViewTextBoxColumn.HeaderText = "Strucna sprema";
            this.strucnaSpremaDataGridViewTextBoxColumn.MaxInputLength = 3276788;
            this.strucnaSpremaDataGridViewTextBoxColumn.Name = "strucnaSpremaDataGridViewTextBoxColumn";
            this.strucnaSpremaDataGridViewTextBoxColumn.Width = 200;
            // 
            // strojDataGridViewTextBoxColumn
            // 
            this.strojDataGridViewTextBoxColumn.DataPropertyName = "stroj";
            this.strojDataGridViewTextBoxColumn.HeaderText = "Stroj";
            this.strojDataGridViewTextBoxColumn.Name = "strojDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // djelatnikBindingSource
            // 
            this.djelatnikBindingSource.DataMember = "Djelatnik";
            this.djelatnikBindingSource.DataSource = this.t23_Enigma2DataSet;
            // 
            // t23_Enigma2DataSet
            // 
            this.t23_Enigma2DataSet.DataSetName = "T23_Enigma2DataSet";
            this.t23_Enigma2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPretrazivanjeSifra
            // 
            this.btnPretrazivanjeSifra.Location = new System.Drawing.Point(632, 150);
            this.btnPretrazivanjeSifra.Name = "btnPretrazivanjeSifra";
            this.btnPretrazivanjeSifra.Size = new System.Drawing.Size(75, 26);
            this.btnPretrazivanjeSifra.TabIndex = 52;
            this.btnPretrazivanjeSifra.Text = "Traži";
            this.btnPretrazivanjeSifra.UseVisualStyleBackColor = true;
            this.btnPretrazivanjeSifra.Click += new System.EventHandler(this.btnPretrazivanjeSifra_Click_1);
            // 
            // txtPretrazivanjeSifra
            // 
            this.txtPretrazivanjeSifra.Location = new System.Drawing.Point(490, 154);
            this.txtPretrazivanjeSifra.Name = "txtPretrazivanjeSifra";
            this.txtPretrazivanjeSifra.Size = new System.Drawing.Size(100, 20);
            this.txtPretrazivanjeSifra.TabIndex = 51;
            // 
            // lblPretrazivanjeSifra
            // 
            this.lblPretrazivanjeSifra.AutoSize = true;
            this.lblPretrazivanjeSifra.Location = new System.Drawing.Point(351, 157);
            this.lblPretrazivanjeSifra.Name = "lblPretrazivanjeSifra";
            this.lblPretrazivanjeSifra.Size = new System.Drawing.Size(118, 13);
            this.lblPretrazivanjeSifra.TabIndex = 50;
            this.lblPretrazivanjeSifra.Text = "Pretraživanje prema šifri";
            // 
            // txtPretrazivanje
            // 
            this.txtPretrazivanje.Location = new System.Drawing.Point(107, 154);
            this.txtPretrazivanje.Name = "txtPretrazivanje";
            this.txtPretrazivanje.Size = new System.Drawing.Size(178, 20);
            this.txtPretrazivanje.TabIndex = 49;
            this.txtPretrazivanje.TextChanged += new System.EventHandler(this.txtPretrazivanje_TextChanged_1);
            // 
            // lblPretrazivanje
            // 
            this.lblPretrazivanje.AutoSize = true;
            this.lblPretrazivanje.Location = new System.Drawing.Point(14, 154);
            this.lblPretrazivanje.Name = "lblPretrazivanje";
            this.lblPretrazivanje.Size = new System.Drawing.Size(68, 13);
            this.lblPretrazivanje.TabIndex = 48;
            this.lblPretrazivanje.Text = "Pretraživanje";
            // 
            // lblIzlaz
            // 
            this.lblIzlaz.AutoSize = true;
            this.lblIzlaz.Location = new System.Drawing.Point(670, 99);
            this.lblIzlaz.Name = "lblIzlaz";
            this.lblIzlaz.Size = new System.Drawing.Size(28, 13);
            this.lblIzlaz.TabIndex = 47;
            this.lblIzlaz.Text = "Izlaz";
            // 
            // lblObrisi
            // 
            this.lblObrisi.AutoSize = true;
            this.lblObrisi.Location = new System.Drawing.Point(549, 99);
            this.lblObrisi.Name = "lblObrisi";
            this.lblObrisi.Size = new System.Drawing.Size(81, 13);
            this.lblObrisi.TabIndex = 46;
            this.lblObrisi.Text = "Obriši djelatnika";
            // 
            // lblIzmjeni
            // 
            this.lblIzmjeni.AutoSize = true;
            this.lblIzmjeni.Location = new System.Drawing.Point(449, 99);
            this.lblIzmjeni.Name = "lblIzmjeni";
            this.lblIzmjeni.Size = new System.Drawing.Size(87, 13);
            this.lblIzmjeni.TabIndex = 45;
            this.lblIzmjeni.Text = "Izmjeni djelatnika";
            // 
            // lblDodaj
            // 
            this.lblDodaj.AutoSize = true;
            this.lblDodaj.Location = new System.Drawing.Point(351, 99);
            this.lblDodaj.Name = "lblDodaj";
            this.lblDodaj.Size = new System.Drawing.Size(83, 13);
            this.lblDodaj.TabIndex = 44;
            this.lblDodaj.Text = "Dodaj djelatnika";
            // 
            // picIzlaz
            // 
            this.picIzlaz.Image = ((System.Drawing.Image)(resources.GetObject("picIzlaz.Image")));
            this.picIzlaz.Location = new System.Drawing.Point(650, 16);
            this.picIzlaz.Name = "picIzlaz";
            this.picIzlaz.Size = new System.Drawing.Size(76, 71);
            this.picIzlaz.TabIndex = 43;
            this.picIzlaz.TabStop = false;
            this.picIzlaz.Click += new System.EventHandler(this.picIzlaz_Click);
            // 
            // picObrisi
            // 
            this.picObrisi.Image = ((System.Drawing.Image)(resources.GetObject("picObrisi.Image")));
            this.picObrisi.Location = new System.Drawing.Point(552, 16);
            this.picObrisi.Name = "picObrisi";
            this.picObrisi.Size = new System.Drawing.Size(76, 71);
            this.picObrisi.TabIndex = 42;
            this.picObrisi.TabStop = false;
            this.picObrisi.Click += new System.EventHandler(this.picObrisi_Click);
            // 
            // picIzmjeni
            // 
            this.picIzmjeni.Image = ((System.Drawing.Image)(resources.GetObject("picIzmjeni.Image")));
            this.picIzmjeni.Location = new System.Drawing.Point(452, 16);
            this.picIzmjeni.Name = "picIzmjeni";
            this.picIzmjeni.Size = new System.Drawing.Size(76, 71);
            this.picIzmjeni.TabIndex = 41;
            this.picIzmjeni.TabStop = false;
            this.picIzmjeni.Click += new System.EventHandler(this.picIzmjeni_Click_1);
            // 
            // picDodaj
            // 
            this.picDodaj.Image = ((System.Drawing.Image)(resources.GetObject("picDodaj.Image")));
            this.picDodaj.Location = new System.Drawing.Point(354, 16);
            this.picDodaj.Name = "picDodaj";
            this.picDodaj.Size = new System.Drawing.Size(76, 71);
            this.picDodaj.TabIndex = 40;
            this.picDodaj.TabStop = false;
            this.picDodaj.Click += new System.EventHandler(this.picDodaj_Click);
            // 
            // lblNaslovniText
            // 
            this.lblNaslovniText.AutoSize = true;
            this.lblNaslovniText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.lblNaslovniText.Location = new System.Drawing.Point(119, 49);
            this.lblNaslovniText.Name = "lblNaslovniText";
            this.lblNaslovniText.Size = new System.Drawing.Size(149, 38);
            this.lblNaslovniText.TabIndex = 39;
            this.lblNaslovniText.Text = "Djelatnici";
            // 
            // picDjelatnici
            // 
            this.picDjelatnici.Image = ((System.Drawing.Image)(resources.GetObject("picDjelatnici.Image")));
            this.picDjelatnici.Location = new System.Drawing.Point(26, 36);
            this.picDjelatnici.Name = "picDjelatnici";
            this.picDjelatnici.Size = new System.Drawing.Size(70, 67);
            this.picDjelatnici.TabIndex = 38;
            this.picDjelatnici.TabStop = false;
            // 
            // djelatnikTableAdapter
            // 
            this.djelatnikTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArtikliTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DjelatnikTableAdapter = this.djelatnikTableAdapter;
            this.tableAdapterManager.IzdatnicaTableAdapter = null;
            this.tableAdapterManager.knjizenjeDokumentaTableAdapter = null;
            this.tableAdapterManager.KorisnikTableAdapter = null;
            this.tableAdapterManager.NarudzbenicaTableAdapter = null;
            this.tableAdapterManager.OtpremnicaTableAdapter = null;
            this.tableAdapterManager.poslovniPartnerTableAdapter = null;
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
            // formaDjelatniciPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 480);
            this.Controls.Add(this.dgvDjelatnici);
            this.Controls.Add(this.btnPretrazivanjeSifra);
            this.Controls.Add(this.txtPretrazivanjeSifra);
            this.Controls.Add(this.lblPretrazivanjeSifra);
            this.Controls.Add(this.txtPretrazivanje);
            this.Controls.Add(this.lblPretrazivanje);
            this.Controls.Add(this.lblIzlaz);
            this.Controls.Add(this.lblObrisi);
            this.Controls.Add(this.lblIzmjeni);
            this.Controls.Add(this.lblDodaj);
            this.Controls.Add(this.picIzlaz);
            this.Controls.Add(this.picObrisi);
            this.Controls.Add(this.picIzmjeni);
            this.Controls.Add(this.picDodaj);
            this.Controls.Add(this.lblNaslovniText);
            this.Controls.Add(this.picDjelatnici);
            this.Name = "formaDjelatniciPregled";
            this.Text = "Pregled djelatnika";
            this.Load += new System.EventHandler(this.formaDjelatniciPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDjelatnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.djelatnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_Enigma2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObrisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzmjeni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDodaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDjelatnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDjelatnici;
        private System.Windows.Forms.Button btnPretrazivanjeSifra;
        private System.Windows.Forms.TextBox txtPretrazivanjeSifra;
        private System.Windows.Forms.Label lblPretrazivanjeSifra;
        private System.Windows.Forms.TextBox txtPretrazivanje;
        private System.Windows.Forms.Label lblPretrazivanje;
        private System.Windows.Forms.Label lblIzlaz;
        private System.Windows.Forms.Label lblObrisi;
        private System.Windows.Forms.Label lblIzmjeni;
        private System.Windows.Forms.Label lblDodaj;
        private System.Windows.Forms.PictureBox picIzlaz;
        private System.Windows.Forms.PictureBox picObrisi;
        private System.Windows.Forms.PictureBox picIzmjeni;
        private System.Windows.Forms.PictureBox picDodaj;
        private System.Windows.Forms.Label lblNaslovniText;
        private System.Windows.Forms.PictureBox picDjelatnici;
        private T23_Enigma2DataSet t23_Enigma2DataSet;
        private System.Windows.Forms.BindingSource djelatnikBindingSource;
        private T23_Enigma2DataSetTableAdapters.DjelatnikTableAdapter djelatnikTableAdapter;
        private T23_Enigma2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strucnaSpremaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strojDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
    }
}