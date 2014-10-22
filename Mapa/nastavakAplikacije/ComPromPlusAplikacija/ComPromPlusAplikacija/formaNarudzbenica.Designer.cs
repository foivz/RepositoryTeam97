namespace ComPromPlusAplikacija
{
    partial class formaNarudzbenica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formaNarudzbenica));
            this.btnObrisi = new System.Windows.Forms.Button();
            this.picIzlaz = new System.Windows.Forms.PictureBox();
            this.btnNovaStavka = new System.Windows.Forms.Button();
            this.dgvStavkeDokumenata = new System.Windows.Forms.DataGridView();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNarudzbeniceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRepromaterijalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeNarudzbeniceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.narudzbenicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t23_Enigma2DataSet = new ComPromPlusAplikacija.T23_Enigma2DataSet();
            this.dgvDokumenti = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poslovniPartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knjizDokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNaslovniText = new System.Windows.Forms.Label();
            this.picDjelatnici = new System.Windows.Forms.PictureBox();
            this.btnPretrazivanjeSifra = new System.Windows.Forms.Button();
            this.txtPretrazivanjeSifra = new System.Windows.Forms.TextBox();
            this.lblPretrazivanjeSifra = new System.Windows.Forms.Label();
            this.txtPretrazivanje = new System.Windows.Forms.TextBox();
            this.lblPretrazivanje = new System.Windows.Forms.Label();
            this.lblObrisi = new System.Windows.Forms.Label();
            this.picObrisi = new System.Windows.Forms.PictureBox();
            this.lblProknjizi = new System.Windows.Forms.Label();
            this.picProknjizi = new System.Windows.Forms.PictureBox();
            this.lblIzmjeni = new System.Windows.Forms.Label();
            this.picIzmjeni = new System.Windows.Forms.PictureBox();
            this.lblDodaj = new System.Windows.Forms.Label();
            this.picDodaj = new System.Windows.Forms.PictureBox();
            this.narudzbenicaTableAdapter = new ComPromPlusAplikacija.T23_Enigma2DataSetTableAdapters.NarudzbenicaTableAdapter();
            this.tableAdapterManager = new ComPromPlusAplikacija.T23_Enigma2DataSetTableAdapters.TableAdapterManager();
            this.stavkeNarudzbeniceTableAdapter = new ComPromPlusAplikacija.T23_Enigma2DataSetTableAdapters.stavkeNarudzbeniceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeDokumenata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeNarudzbeniceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_Enigma2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDokumenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDjelatnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObrisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProknjizi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzmjeni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDodaj)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnObrisi.Location = new System.Drawing.Point(574, 510);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(108, 40);
            this.btnObrisi.TabIndex = 66;
            this.btnObrisi.Text = "Obriši stavku";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // picIzlaz
            // 
            this.picIzlaz.Image = ((System.Drawing.Image)(resources.GetObject("picIzlaz.Image")));
            this.picIzlaz.Location = new System.Drawing.Point(731, 456);
            this.picIzlaz.Name = "picIzlaz";
            this.picIzlaz.Size = new System.Drawing.Size(79, 72);
            this.picIzlaz.TabIndex = 65;
            this.picIzlaz.TabStop = false;
            this.picIzlaz.Click += new System.EventHandler(this.picIzlaz_Click);
            // 
            // btnNovaStavka
            // 
            this.btnNovaStavka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNovaStavka.Location = new System.Drawing.Point(574, 443);
            this.btnNovaStavka.Name = "btnNovaStavka";
            this.btnNovaStavka.Size = new System.Drawing.Size(108, 40);
            this.btnNovaStavka.TabIndex = 64;
            this.btnNovaStavka.Text = "Nova stavka";
            this.btnNovaStavka.UseVisualStyleBackColor = true;
            this.btnNovaStavka.Click += new System.EventHandler(this.btnNovaStavka_Click);
            // 
            // dgvStavkeDokumenata
            // 
            this.dgvStavkeDokumenata.AllowUserToAddRows = false;
            this.dgvStavkeDokumenata.AllowUserToDeleteRows = false;
            this.dgvStavkeDokumenata.AutoGenerateColumns = false;
            this.dgvStavkeDokumenata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeDokumenata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kolicinaDataGridViewTextBoxColumn,
            this.idNarudzbeniceDataGridViewTextBoxColumn,
            this.idRepromaterijalaDataGridViewTextBoxColumn});
            this.dgvStavkeDokumenata.DataSource = this.stavkeNarudzbeniceBindingSource;
            this.dgvStavkeDokumenata.Location = new System.Drawing.Point(19, 406);
            this.dgvStavkeDokumenata.Name = "dgvStavkeDokumenata";
            this.dgvStavkeDokumenata.Size = new System.Drawing.Size(445, 175);
            this.dgvStavkeDokumenata.TabIndex = 63;
            this.dgvStavkeDokumenata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStavkeDokumenata_CellContentClick);
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // idNarudzbeniceDataGridViewTextBoxColumn
            // 
            this.idNarudzbeniceDataGridViewTextBoxColumn.DataPropertyName = "idNarudzbenice";
            this.idNarudzbeniceDataGridViewTextBoxColumn.HeaderText = "Šifra narudžbenice";
            this.idNarudzbeniceDataGridViewTextBoxColumn.Name = "idNarudzbeniceDataGridViewTextBoxColumn";
            this.idNarudzbeniceDataGridViewTextBoxColumn.Width = 150;
            // 
            // idRepromaterijalaDataGridViewTextBoxColumn
            // 
            this.idRepromaterijalaDataGridViewTextBoxColumn.DataPropertyName = "idRepromaterijala";
            this.idRepromaterijalaDataGridViewTextBoxColumn.HeaderText = "Šifra repromaterijala";
            this.idRepromaterijalaDataGridViewTextBoxColumn.Name = "idRepromaterijalaDataGridViewTextBoxColumn";
            this.idRepromaterijalaDataGridViewTextBoxColumn.Width = 150;
            // 
            // stavkeNarudzbeniceBindingSource
            // 
            this.stavkeNarudzbeniceBindingSource.DataMember = "FK_stavkeNarudzbenice_ToTable";
            this.stavkeNarudzbeniceBindingSource.DataSource = this.narudzbenicaBindingSource;
            // 
            // narudzbenicaBindingSource
            // 
            this.narudzbenicaBindingSource.DataMember = "Narudzbenica";
            this.narudzbenicaBindingSource.DataSource = this.t23_Enigma2DataSet;
            // 
            // t23_Enigma2DataSet
            // 
            this.t23_Enigma2DataSet.DataSetName = "T23_Enigma2DataSet";
            this.t23_Enigma2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvDokumenti
            // 
            this.dgvDokumenti.AllowUserToAddRows = false;
            this.dgvDokumenti.AllowUserToDeleteRows = false;
            this.dgvDokumenti.AutoGenerateColumns = false;
            this.dgvDokumenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDokumenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.poslovniPartDataGridViewTextBoxColumn,
            this.knjizDokDataGridViewTextBoxColumn});
            this.dgvDokumenti.DataSource = this.narudzbenicaBindingSource;
            this.dgvDokumenti.Location = new System.Drawing.Point(12, 180);
            this.dgvDokumenti.Name = "dgvDokumenti";
            this.dgvDokumenti.Size = new System.Drawing.Size(745, 206);
            this.dgvDokumenti.TabIndex = 62;
            this.dgvDokumenti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDokumenti_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
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
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // poslovniPartDataGridViewTextBoxColumn
            // 
            this.poslovniPartDataGridViewTextBoxColumn.DataPropertyName = "poslovniPart";
            this.poslovniPartDataGridViewTextBoxColumn.HeaderText = "Poslovni partner";
            this.poslovniPartDataGridViewTextBoxColumn.Name = "poslovniPartDataGridViewTextBoxColumn";
            this.poslovniPartDataGridViewTextBoxColumn.Width = 150;
            // 
            // knjizDokDataGridViewTextBoxColumn
            // 
            this.knjizDokDataGridViewTextBoxColumn.DataPropertyName = "knjizDok";
            this.knjizDokDataGridViewTextBoxColumn.HeaderText = "Knjiženje Dokumenta";
            this.knjizDokDataGridViewTextBoxColumn.Name = "knjizDokDataGridViewTextBoxColumn";
            this.knjizDokDataGridViewTextBoxColumn.Width = 150;
            // 
            // lblNaslovniText
            // 
            this.lblNaslovniText.AutoSize = true;
            this.lblNaslovniText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.lblNaslovniText.Location = new System.Drawing.Point(90, 27);
            this.lblNaslovniText.Name = "lblNaslovniText";
            this.lblNaslovniText.Size = new System.Drawing.Size(219, 38);
            this.lblNaslovniText.TabIndex = 81;
            this.lblNaslovniText.Text = "Narudžbenica";
            // 
            // picDjelatnici
            // 
            this.picDjelatnici.Image = ((System.Drawing.Image)(resources.GetObject("picDjelatnici.Image")));
            this.picDjelatnici.Location = new System.Drawing.Point(14, 12);
            this.picDjelatnici.Name = "picDjelatnici";
            this.picDjelatnici.Size = new System.Drawing.Size(70, 67);
            this.picDjelatnici.TabIndex = 80;
            this.picDjelatnici.TabStop = false;
            // 
            // btnPretrazivanjeSifra
            // 
            this.btnPretrazivanjeSifra.Location = new System.Drawing.Point(770, 130);
            this.btnPretrazivanjeSifra.Name = "btnPretrazivanjeSifra";
            this.btnPretrazivanjeSifra.Size = new System.Drawing.Size(75, 26);
            this.btnPretrazivanjeSifra.TabIndex = 79;
            this.btnPretrazivanjeSifra.Text = "Traži";
            this.btnPretrazivanjeSifra.UseVisualStyleBackColor = true;
            // 
            // txtPretrazivanjeSifra
            // 
            this.txtPretrazivanjeSifra.Location = new System.Drawing.Point(657, 136);
            this.txtPretrazivanjeSifra.Name = "txtPretrazivanjeSifra";
            this.txtPretrazivanjeSifra.Size = new System.Drawing.Size(100, 20);
            this.txtPretrazivanjeSifra.TabIndex = 78;
            // 
            // lblPretrazivanjeSifra
            // 
            this.lblPretrazivanjeSifra.AutoSize = true;
            this.lblPretrazivanjeSifra.Location = new System.Drawing.Point(530, 136);
            this.lblPretrazivanjeSifra.Name = "lblPretrazivanjeSifra";
            this.lblPretrazivanjeSifra.Size = new System.Drawing.Size(118, 13);
            this.lblPretrazivanjeSifra.TabIndex = 77;
            this.lblPretrazivanjeSifra.Text = "Pretraživanje prema šifri";
            // 
            // txtPretrazivanje
            // 
            this.txtPretrazivanje.Location = new System.Drawing.Point(104, 133);
            this.txtPretrazivanje.Name = "txtPretrazivanje";
            this.txtPretrazivanje.Size = new System.Drawing.Size(261, 20);
            this.txtPretrazivanje.TabIndex = 76;
            // 
            // lblPretrazivanje
            // 
            this.lblPretrazivanje.AutoSize = true;
            this.lblPretrazivanje.Location = new System.Drawing.Point(16, 136);
            this.lblPretrazivanje.Name = "lblPretrazivanje";
            this.lblPretrazivanje.Size = new System.Drawing.Size(68, 13);
            this.lblPretrazivanje.TabIndex = 75;
            this.lblPretrazivanje.Text = "Pretraživanje";
            // 
            // lblObrisi
            // 
            this.lblObrisi.AutoSize = true;
            this.lblObrisi.Location = new System.Drawing.Point(762, 95);
            this.lblObrisi.Name = "lblObrisi";
            this.lblObrisi.Size = new System.Drawing.Size(83, 13);
            this.lblObrisi.TabIndex = 74;
            this.lblObrisi.Text = "Obriši dokument";
            // 
            // picObrisi
            // 
            this.picObrisi.Image = ((System.Drawing.Image)(resources.GetObject("picObrisi.Image")));
            this.picObrisi.Location = new System.Drawing.Point(769, 12);
            this.picObrisi.Name = "picObrisi";
            this.picObrisi.Size = new System.Drawing.Size(76, 71);
            this.picObrisi.TabIndex = 73;
            this.picObrisi.TabStop = false;
            // 
            // lblProknjizi
            // 
            this.lblProknjizi.AutoSize = true;
            this.lblProknjizi.Location = new System.Drawing.Point(646, 95);
            this.lblProknjizi.Name = "lblProknjizi";
            this.lblProknjizi.Size = new System.Drawing.Size(96, 13);
            this.lblProknjizi.TabIndex = 72;
            this.lblProknjizi.Text = "Proknjiži dokument";
            // 
            // picProknjizi
            // 
            this.picProknjizi.Image = ((System.Drawing.Image)(resources.GetObject("picProknjizi.Image")));
            this.picProknjizi.Location = new System.Drawing.Point(657, 16);
            this.picProknjizi.Name = "picProknjizi";
            this.picProknjizi.Size = new System.Drawing.Size(76, 71);
            this.picProknjizi.TabIndex = 71;
            this.picProknjizi.TabStop = false;
            // 
            // lblIzmjeni
            // 
            this.lblIzmjeni.AutoSize = true;
            this.lblIzmjeni.Location = new System.Drawing.Point(536, 95);
            this.lblIzmjeni.Name = "lblIzmjeni";
            this.lblIzmjeni.Size = new System.Drawing.Size(89, 13);
            this.lblIzmjeni.TabIndex = 70;
            this.lblIzmjeni.Text = "Izmjeni dokument";
            // 
            // picIzmjeni
            // 
            this.picIzmjeni.Image = ((System.Drawing.Image)(resources.GetObject("picIzmjeni.Image")));
            this.picIzmjeni.Location = new System.Drawing.Point(547, 16);
            this.picIzmjeni.Name = "picIzmjeni";
            this.picIzmjeni.Size = new System.Drawing.Size(76, 71);
            this.picIzmjeni.TabIndex = 69;
            this.picIzmjeni.TabStop = false;
            this.picIzmjeni.Click += new System.EventHandler(this.picIzmjeni_Click);
            // 
            // lblDodaj
            // 
            this.lblDodaj.AutoSize = true;
            this.lblDodaj.Location = new System.Drawing.Point(414, 95);
            this.lblDodaj.Name = "lblDodaj";
            this.lblDodaj.Size = new System.Drawing.Size(109, 13);
            this.lblDodaj.TabIndex = 68;
            this.lblDodaj.Text = "Naruči repromaterijale";
            this.lblDodaj.Click += new System.EventHandler(this.lblDodaj_Click);
            // 
            // picDodaj
            // 
            this.picDodaj.Image = ((System.Drawing.Image)(resources.GetObject("picDodaj.Image")));
            this.picDodaj.Location = new System.Drawing.Point(417, 16);
            this.picDodaj.Name = "picDodaj";
            this.picDodaj.Size = new System.Drawing.Size(76, 71);
            this.picDodaj.TabIndex = 67;
            this.picDodaj.TabStop = false;
            this.picDodaj.Click += new System.EventHandler(this.picDodaj_Click);
            // 
            // narudzbenicaTableAdapter
            // 
            this.narudzbenicaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.poslovniPartnerTableAdapter = null;
            this.tableAdapterManager.pracenjeProizvodnjeTableAdapter = null;
            this.tableAdapterManager.PrimkaTableAdapter = null;
            this.tableAdapterManager.RepromaterijaliTableAdapter = null;
            this.tableAdapterManager.stavkeIzdatniceTableAdapter = null;
            this.tableAdapterManager.stavkeNarudzbeniceTableAdapter = this.stavkeNarudzbeniceTableAdapter;
            this.tableAdapterManager.stavkeOtpremniceTableAdapter = null;
            this.tableAdapterManager.stavkePrimkeTableAdapter = null;
            this.tableAdapterManager.StrojTableAdapter = null;
            this.tableAdapterManager.tipKorisnikaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ComPromPlusAplikacija.T23_Enigma2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtrosakTableAdapter = null;
            // 
            // stavkeNarudzbeniceTableAdapter
            // 
            this.stavkeNarudzbeniceTableAdapter.ClearBeforeFill = true;
            // 
            // formaNarudzbenica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 616);
            this.Controls.Add(this.lblNaslovniText);
            this.Controls.Add(this.picDjelatnici);
            this.Controls.Add(this.btnPretrazivanjeSifra);
            this.Controls.Add(this.txtPretrazivanjeSifra);
            this.Controls.Add(this.lblPretrazivanjeSifra);
            this.Controls.Add(this.txtPretrazivanje);
            this.Controls.Add(this.lblPretrazivanje);
            this.Controls.Add(this.lblObrisi);
            this.Controls.Add(this.picObrisi);
            this.Controls.Add(this.lblProknjizi);
            this.Controls.Add(this.picProknjizi);
            this.Controls.Add(this.lblIzmjeni);
            this.Controls.Add(this.picIzmjeni);
            this.Controls.Add(this.lblDodaj);
            this.Controls.Add(this.picDodaj);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.picIzlaz);
            this.Controls.Add(this.btnNovaStavka);
            this.Controls.Add(this.dgvStavkeDokumenata);
            this.Controls.Add(this.dgvDokumenti);
            this.Name = "formaNarudzbenica";
            this.Text = "Narudžbenica";
            this.Load += new System.EventHandler(this.formaNarudzbenica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeDokumenata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeNarudzbeniceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_Enigma2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDokumenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDjelatnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObrisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProknjizi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzmjeni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDodaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.PictureBox picIzlaz;
        private System.Windows.Forms.Button btnNovaStavka;
        private System.Windows.Forms.DataGridView dgvStavkeDokumenata;
        private System.Windows.Forms.DataGridView dgvDokumenti;
        private System.Windows.Forms.Label lblNaslovniText;
        private System.Windows.Forms.PictureBox picDjelatnici;
        private System.Windows.Forms.Button btnPretrazivanjeSifra;
        private System.Windows.Forms.TextBox txtPretrazivanjeSifra;
        private System.Windows.Forms.Label lblPretrazivanjeSifra;
        private System.Windows.Forms.TextBox txtPretrazivanje;
        private System.Windows.Forms.Label lblPretrazivanje;
        private System.Windows.Forms.Label lblObrisi;
        private System.Windows.Forms.PictureBox picObrisi;
        private System.Windows.Forms.Label lblProknjizi;
        private System.Windows.Forms.PictureBox picProknjizi;
        private System.Windows.Forms.Label lblIzmjeni;
        private System.Windows.Forms.PictureBox picIzmjeni;
        private System.Windows.Forms.Label lblDodaj;
        private System.Windows.Forms.PictureBox picDodaj;
        private T23_Enigma2DataSet t23_Enigma2DataSet;
        private System.Windows.Forms.BindingSource narudzbenicaBindingSource;
        private T23_Enigma2DataSetTableAdapters.NarudzbenicaTableAdapter narudzbenicaTableAdapter;
        private T23_Enigma2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poslovniPartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn knjizDokDataGridViewTextBoxColumn;
        private T23_Enigma2DataSetTableAdapters.stavkeNarudzbeniceTableAdapter stavkeNarudzbeniceTableAdapter;
        private System.Windows.Forms.BindingSource stavkeNarudzbeniceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNarudzbeniceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRepromaterijalaDataGridViewTextBoxColumn;
    }
}