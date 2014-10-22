namespace ComPromPlusAplikacija
{
    partial class formaOtpremnica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formaOtpremnica));
            this.picIzlaz = new System.Windows.Forms.PictureBox();
            this.btnNovaStavka = new System.Windows.Forms.Button();
            this.dgvStavkeDokumenata = new System.Windows.Forms.DataGridView();
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
            this.dgvDokumenti = new System.Windows.Forms.DataGridView();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.t23_Enigma2DataSet = new ComPromPlusAplikacija.T23_Enigma2DataSet();
            this.otpremnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otpremnicaTableAdapter = new ComPromPlusAplikacija.T23_Enigma2DataSetTableAdapters.OtpremnicaTableAdapter();
            this.tableAdapterManager = new ComPromPlusAplikacija.T23_Enigma2DataSetTableAdapters.TableAdapterManager();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odredisteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumOtpremeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knjizenjeDokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poslPartnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeOtpremniceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavkeOtpremniceTableAdapter = new ComPromPlusAplikacija.T23_Enigma2DataSetTableAdapters.stavkeOtpremniceTableAdapter();
            this.idArtiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOtpremniceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeDokumenata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDjelatnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObrisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProknjizi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzmjeni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDodaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDokumenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_Enigma2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otpremnicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeOtpremniceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // picIzlaz
            // 
            this.picIzlaz.Image = ((System.Drawing.Image)(resources.GetObject("picIzlaz.Image")));
            this.picIzlaz.Location = new System.Drawing.Point(745, 456);
            this.picIzlaz.Name = "picIzlaz";
            this.picIzlaz.Size = new System.Drawing.Size(76, 71);
            this.picIzlaz.TabIndex = 60;
            this.picIzlaz.TabStop = false;
            this.picIzlaz.Click += new System.EventHandler(this.picIzlaz_Click);
            // 
            // btnNovaStavka
            // 
            this.btnNovaStavka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNovaStavka.Location = new System.Drawing.Point(588, 443);
            this.btnNovaStavka.Name = "btnNovaStavka";
            this.btnNovaStavka.Size = new System.Drawing.Size(105, 39);
            this.btnNovaStavka.TabIndex = 59;
            this.btnNovaStavka.Text = "Nova stavka";
            this.btnNovaStavka.UseVisualStyleBackColor = true;
            // 
            // dgvStavkeDokumenata
            // 
            this.dgvStavkeDokumenata.AllowUserToAddRows = false;
            this.dgvStavkeDokumenata.AllowUserToDeleteRows = false;
            this.dgvStavkeDokumenata.AutoGenerateColumns = false;
            this.dgvStavkeDokumenata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeDokumenata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArtiklaDataGridViewTextBoxColumn,
            this.idOtpremniceDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn});
            this.dgvStavkeDokumenata.DataSource = this.stavkeOtpremniceBindingSource;
            this.dgvStavkeDokumenata.Location = new System.Drawing.Point(26, 404);
            this.dgvStavkeDokumenata.Name = "dgvStavkeDokumenata";
            this.dgvStavkeDokumenata.Size = new System.Drawing.Size(454, 174);
            this.dgvStavkeDokumenata.TabIndex = 58;
            // 
            // lblNaslovniText
            // 
            this.lblNaslovniText.AutoSize = true;
            this.lblNaslovniText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.lblNaslovniText.Location = new System.Drawing.Point(97, 27);
            this.lblNaslovniText.Name = "lblNaslovniText";
            this.lblNaslovniText.Size = new System.Drawing.Size(186, 38);
            this.lblNaslovniText.TabIndex = 57;
            this.lblNaslovniText.Text = "Otpremnica";
            // 
            // picDjelatnici
            // 
            this.picDjelatnici.Image = ((System.Drawing.Image)(resources.GetObject("picDjelatnici.Image")));
            this.picDjelatnici.Location = new System.Drawing.Point(21, 12);
            this.picDjelatnici.Name = "picDjelatnici";
            this.picDjelatnici.Size = new System.Drawing.Size(70, 67);
            this.picDjelatnici.TabIndex = 56;
            this.picDjelatnici.TabStop = false;
            // 
            // btnPretrazivanjeSifra
            // 
            this.btnPretrazivanjeSifra.Location = new System.Drawing.Point(777, 130);
            this.btnPretrazivanjeSifra.Name = "btnPretrazivanjeSifra";
            this.btnPretrazivanjeSifra.Size = new System.Drawing.Size(75, 26);
            this.btnPretrazivanjeSifra.TabIndex = 55;
            this.btnPretrazivanjeSifra.Text = "Traži";
            this.btnPretrazivanjeSifra.UseVisualStyleBackColor = true;
            // 
            // txtPretrazivanjeSifra
            // 
            this.txtPretrazivanjeSifra.Location = new System.Drawing.Point(664, 136);
            this.txtPretrazivanjeSifra.Name = "txtPretrazivanjeSifra";
            this.txtPretrazivanjeSifra.Size = new System.Drawing.Size(100, 20);
            this.txtPretrazivanjeSifra.TabIndex = 54;
            // 
            // lblPretrazivanjeSifra
            // 
            this.lblPretrazivanjeSifra.AutoSize = true;
            this.lblPretrazivanjeSifra.Location = new System.Drawing.Point(537, 136);
            this.lblPretrazivanjeSifra.Name = "lblPretrazivanjeSifra";
            this.lblPretrazivanjeSifra.Size = new System.Drawing.Size(118, 13);
            this.lblPretrazivanjeSifra.TabIndex = 53;
            this.lblPretrazivanjeSifra.Text = "Pretraživanje prema šifri";
            // 
            // txtPretrazivanje
            // 
            this.txtPretrazivanje.Location = new System.Drawing.Point(111, 133);
            this.txtPretrazivanje.Name = "txtPretrazivanje";
            this.txtPretrazivanje.Size = new System.Drawing.Size(261, 20);
            this.txtPretrazivanje.TabIndex = 52;
            // 
            // lblPretrazivanje
            // 
            this.lblPretrazivanje.AutoSize = true;
            this.lblPretrazivanje.Location = new System.Drawing.Point(23, 136);
            this.lblPretrazivanje.Name = "lblPretrazivanje";
            this.lblPretrazivanje.Size = new System.Drawing.Size(68, 13);
            this.lblPretrazivanje.TabIndex = 51;
            this.lblPretrazivanje.Text = "Pretraživanje";
            // 
            // lblObrisi
            // 
            this.lblObrisi.AutoSize = true;
            this.lblObrisi.Location = new System.Drawing.Point(769, 95);
            this.lblObrisi.Name = "lblObrisi";
            this.lblObrisi.Size = new System.Drawing.Size(83, 13);
            this.lblObrisi.TabIndex = 50;
            this.lblObrisi.Text = "Obriši dokument";
            // 
            // picObrisi
            // 
            this.picObrisi.Image = ((System.Drawing.Image)(resources.GetObject("picObrisi.Image")));
            this.picObrisi.Location = new System.Drawing.Point(776, 12);
            this.picObrisi.Name = "picObrisi";
            this.picObrisi.Size = new System.Drawing.Size(76, 71);
            this.picObrisi.TabIndex = 49;
            this.picObrisi.TabStop = false;
            // 
            // lblProknjizi
            // 
            this.lblProknjizi.AutoSize = true;
            this.lblProknjizi.Location = new System.Drawing.Point(653, 95);
            this.lblProknjizi.Name = "lblProknjizi";
            this.lblProknjizi.Size = new System.Drawing.Size(96, 13);
            this.lblProknjizi.TabIndex = 48;
            this.lblProknjizi.Text = "Proknjiži dokument";
            // 
            // picProknjizi
            // 
            this.picProknjizi.Image = ((System.Drawing.Image)(resources.GetObject("picProknjizi.Image")));
            this.picProknjizi.Location = new System.Drawing.Point(664, 16);
            this.picProknjizi.Name = "picProknjizi";
            this.picProknjizi.Size = new System.Drawing.Size(76, 71);
            this.picProknjizi.TabIndex = 47;
            this.picProknjizi.TabStop = false;
            // 
            // lblIzmjeni
            // 
            this.lblIzmjeni.AutoSize = true;
            this.lblIzmjeni.Location = new System.Drawing.Point(543, 95);
            this.lblIzmjeni.Name = "lblIzmjeni";
            this.lblIzmjeni.Size = new System.Drawing.Size(89, 13);
            this.lblIzmjeni.TabIndex = 46;
            this.lblIzmjeni.Text = "Izmjeni dokument";
            // 
            // picIzmjeni
            // 
            this.picIzmjeni.Image = ((System.Drawing.Image)(resources.GetObject("picIzmjeni.Image")));
            this.picIzmjeni.Location = new System.Drawing.Point(554, 16);
            this.picIzmjeni.Name = "picIzmjeni";
            this.picIzmjeni.Size = new System.Drawing.Size(76, 71);
            this.picIzmjeni.TabIndex = 45;
            this.picIzmjeni.TabStop = false;
            // 
            // lblDodaj
            // 
            this.lblDodaj.AutoSize = true;
            this.lblDodaj.Location = new System.Drawing.Point(436, 95);
            this.lblDodaj.Name = "lblDodaj";
            this.lblDodaj.Size = new System.Drawing.Size(85, 13);
            this.lblDodaj.TabIndex = 44;
            this.lblDodaj.Text = "Dodaj dokument";
            // 
            // picDodaj
            // 
            this.picDodaj.Image = ((System.Drawing.Image)(resources.GetObject("picDodaj.Image")));
            this.picDodaj.Location = new System.Drawing.Point(439, 12);
            this.picDodaj.Name = "picDodaj";
            this.picDodaj.Size = new System.Drawing.Size(76, 71);
            this.picDodaj.TabIndex = 43;
            this.picDodaj.TabStop = false;
            this.picDodaj.Click += new System.EventHandler(this.picDodaj_Click);
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
            this.odredisteDataGridViewTextBoxColumn,
            this.datumOtpremeDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.knjizenjeDokDataGridViewTextBoxColumn,
            this.poslPartnerDataGridViewTextBoxColumn});
            this.dgvDokumenti.DataSource = this.otpremnicaBindingSource;
            this.dgvDokumenti.Location = new System.Drawing.Point(12, 180);
            this.dgvDokumenti.Name = "dgvDokumenti";
            this.dgvDokumenti.Size = new System.Drawing.Size(852, 205);
            this.dgvDokumenti.TabIndex = 42;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnObrisi.Location = new System.Drawing.Point(588, 519);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(105, 39);
            this.btnObrisi.TabIndex = 61;
            this.btnObrisi.Text = "Obriši stavku";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // t23_Enigma2DataSet
            // 
            this.t23_Enigma2DataSet.DataSetName = "T23_Enigma2DataSet";
            this.t23_Enigma2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // otpremnicaBindingSource
            // 
            this.otpremnicaBindingSource.DataMember = "Otpremnica";
            this.otpremnicaBindingSource.DataSource = this.t23_Enigma2DataSet;
            // 
            // otpremnicaTableAdapter
            // 
            this.otpremnicaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.OtpremnicaTableAdapter = this.otpremnicaTableAdapter;
            this.tableAdapterManager.poslovniPartnerTableAdapter = null;
            this.tableAdapterManager.pracenjeProizvodnjeTableAdapter = null;
            this.tableAdapterManager.PrimkaTableAdapter = null;
            this.tableAdapterManager.RepromaterijaliTableAdapter = null;
            this.tableAdapterManager.stavkeIzdatniceTableAdapter = null;
            this.tableAdapterManager.stavkeNarudzbeniceTableAdapter = null;
            this.tableAdapterManager.stavkeOtpremniceTableAdapter = this.stavkeOtpremniceTableAdapter;
            this.tableAdapterManager.stavkePrimkeTableAdapter = null;
            this.tableAdapterManager.StrojTableAdapter = null;
            this.tableAdapterManager.tipKorisnikaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ComPromPlusAplikacija.T23_Enigma2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtrosakTableAdapter = null;
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
            // odredisteDataGridViewTextBoxColumn
            // 
            this.odredisteDataGridViewTextBoxColumn.DataPropertyName = "odrediste";
            this.odredisteDataGridViewTextBoxColumn.HeaderText = "Odredište";
            this.odredisteDataGridViewTextBoxColumn.Name = "odredisteDataGridViewTextBoxColumn";
            // 
            // datumOtpremeDataGridViewTextBoxColumn
            // 
            this.datumOtpremeDataGridViewTextBoxColumn.DataPropertyName = "datumOtpreme";
            this.datumOtpremeDataGridViewTextBoxColumn.HeaderText = "Datum otpreme";
            this.datumOtpremeDataGridViewTextBoxColumn.Name = "datumOtpremeDataGridViewTextBoxColumn";
            this.datumOtpremeDataGridViewTextBoxColumn.Width = 150;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // knjizenjeDokDataGridViewTextBoxColumn
            // 
            this.knjizenjeDokDataGridViewTextBoxColumn.DataPropertyName = "knjizenjeDok";
            this.knjizenjeDokDataGridViewTextBoxColumn.HeaderText = "Knjiženje Dokumenta";
            this.knjizenjeDokDataGridViewTextBoxColumn.Name = "knjizenjeDokDataGridViewTextBoxColumn";
            this.knjizenjeDokDataGridViewTextBoxColumn.Width = 150;
            // 
            // poslPartnerDataGridViewTextBoxColumn
            // 
            this.poslPartnerDataGridViewTextBoxColumn.DataPropertyName = "poslPartner";
            this.poslPartnerDataGridViewTextBoxColumn.HeaderText = "Poslovni partner";
            this.poslPartnerDataGridViewTextBoxColumn.Name = "poslPartnerDataGridViewTextBoxColumn";
            this.poslPartnerDataGridViewTextBoxColumn.Width = 150;
            // 
            // stavkeOtpremniceBindingSource
            // 
            this.stavkeOtpremniceBindingSource.DataMember = "FK_stavkeOtpremnice_Otpremnica";
            this.stavkeOtpremniceBindingSource.DataSource = this.otpremnicaBindingSource;
            // 
            // stavkeOtpremniceTableAdapter
            // 
            this.stavkeOtpremniceTableAdapter.ClearBeforeFill = true;
            // 
            // idArtiklaDataGridViewTextBoxColumn
            // 
            this.idArtiklaDataGridViewTextBoxColumn.DataPropertyName = "idArtikla";
            this.idArtiklaDataGridViewTextBoxColumn.HeaderText = "Šifra artikla";
            this.idArtiklaDataGridViewTextBoxColumn.Name = "idArtiklaDataGridViewTextBoxColumn";
            // 
            // idOtpremniceDataGridViewTextBoxColumn
            // 
            this.idOtpremniceDataGridViewTextBoxColumn.DataPropertyName = "idOtpremnice";
            this.idOtpremniceDataGridViewTextBoxColumn.HeaderText = "Šifra otpremnice";
            this.idOtpremniceDataGridViewTextBoxColumn.Name = "idOtpremniceDataGridViewTextBoxColumn";
            this.idOtpremniceDataGridViewTextBoxColumn.Width = 150;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // formaOtpremnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 597);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.picIzlaz);
            this.Controls.Add(this.btnNovaStavka);
            this.Controls.Add(this.dgvStavkeDokumenata);
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
            this.Controls.Add(this.dgvDokumenti);
            this.Name = "formaOtpremnica";
            this.Text = "Otpremnica";
            this.Load += new System.EventHandler(this.formaOtpremnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeDokumenata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDjelatnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObrisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProknjizi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzmjeni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDodaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDokumenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_Enigma2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otpremnicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeOtpremniceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIzlaz;
        private System.Windows.Forms.Button btnNovaStavka;
        private System.Windows.Forms.DataGridView dgvStavkeDokumenata;
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
        private System.Windows.Forms.DataGridView dgvDokumenti;
        private System.Windows.Forms.Button btnObrisi;
        private T23_Enigma2DataSet t23_Enigma2DataSet;
        private System.Windows.Forms.BindingSource otpremnicaBindingSource;
        private T23_Enigma2DataSetTableAdapters.OtpremnicaTableAdapter otpremnicaTableAdapter;
        private T23_Enigma2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odredisteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumOtpremeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn knjizenjeDokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poslPartnerDataGridViewTextBoxColumn;
        private T23_Enigma2DataSetTableAdapters.stavkeOtpremniceTableAdapter stavkeOtpremniceTableAdapter;
        private System.Windows.Forms.BindingSource stavkeOtpremniceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArtiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOtpremniceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
    }
}