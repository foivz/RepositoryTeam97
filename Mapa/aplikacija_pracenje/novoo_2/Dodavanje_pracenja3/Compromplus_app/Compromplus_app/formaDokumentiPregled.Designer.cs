namespace Compromplus_app
{
    partial class formaDokumentiPregled
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formaDokumentiPregled));
            this.dgvDokumenti = new System.Windows.Forms.DataGridView();
            this.idDokumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knjizenjeDokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knjizenjeDokumenta1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDokumenta1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeDokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvStavkeDokumenata = new System.Windows.Forms.DataGridView();
            this.artiklDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikl1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokument1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeDokumentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.picDodaj = new System.Windows.Forms.PictureBox();
            this.lblDodaj = new System.Windows.Forms.Label();
            this.lblIzmjeni = new System.Windows.Forms.Label();
            this.picIzmjeni = new System.Windows.Forms.PictureBox();
            this.lblProknjizi = new System.Windows.Forms.Label();
            this.picProknjizi = new System.Windows.Forms.PictureBox();
            this.lblObrisi = new System.Windows.Forms.Label();
            this.picObrisi = new System.Windows.Forms.PictureBox();
            this.btnNovaStavka = new System.Windows.Forms.Button();
            this.lblIzlaz = new System.Windows.Forms.Label();
            this.picIzlaz = new System.Windows.Forms.PictureBox();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnPretrazivanjeSifra = new System.Windows.Forms.Button();
            this.txtPretrazivanjeSifra = new System.Windows.Forms.TextBox();
            this.lblPretrazivanjeSifra = new System.Windows.Forms.Label();
            this.txtPretrazivanje = new System.Windows.Forms.TextBox();
            this.lblPretrazivanje = new System.Windows.Forms.Label();
            this.lblNaslovniText = new System.Windows.Forms.Label();
            this.picDjelatnici = new System.Windows.Forms.PictureBox();
            this.knjizenjeDokumentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDokumenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeDokumenata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeDokumentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDodaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzmjeni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProknjizi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObrisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDjelatnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjizenjeDokumentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDokumenti
            // 
            this.dgvDokumenti.AllowUserToAddRows = false;
            this.dgvDokumenti.AllowUserToDeleteRows = false;
            this.dgvDokumenti.AutoGenerateColumns = false;
            this.dgvDokumenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDokumenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDokumentDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.tipDokumentaDataGridViewTextBoxColumn,
            this.knjizenjeDokumentaDataGridViewTextBoxColumn,
            this.knjizenjeDokumenta1DataGridViewTextBoxColumn,
            this.tipDokumenta1DataGridViewTextBoxColumn,
            this.stavkeDokumentaDataGridViewTextBoxColumn});
            this.dgvDokumenti.DataSource = this.dokumentBindingSource;
            this.dgvDokumenti.Location = new System.Drawing.Point(51, 187);
            this.dgvDokumenti.Name = "dgvDokumenti";
            this.dgvDokumenti.Size = new System.Drawing.Size(828, 205);
            this.dgvDokumenti.TabIndex = 0;
            this.dgvDokumenti.SelectionChanged += new System.EventHandler(this.dgvDokumenti_SelectionChanged);
            // 
            // idDokumentDataGridViewTextBoxColumn
            // 
            this.idDokumentDataGridViewTextBoxColumn.DataPropertyName = "IdDokument";
            this.idDokumentDataGridViewTextBoxColumn.HeaderText = "Šifra dokumenta";
            this.idDokumentDataGridViewTextBoxColumn.Name = "idDokumentDataGridViewTextBoxColumn";
            this.idDokumentDataGridViewTextBoxColumn.Width = 130;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // tipDokumentaDataGridViewTextBoxColumn
            // 
            this.tipDokumentaDataGridViewTextBoxColumn.DataPropertyName = "tipDokumenta";
            this.tipDokumentaDataGridViewTextBoxColumn.HeaderText = "Vrsta dokumenta";
            this.tipDokumentaDataGridViewTextBoxColumn.Name = "tipDokumentaDataGridViewTextBoxColumn";
            this.tipDokumentaDataGridViewTextBoxColumn.Width = 130;
            // 
            // knjizenjeDokumentaDataGridViewTextBoxColumn
            // 
            this.knjizenjeDokumentaDataGridViewTextBoxColumn.DataPropertyName = "knjizenjeDokumenta";
            this.knjizenjeDokumentaDataGridViewTextBoxColumn.HeaderText = "Knjiženje";
            this.knjizenjeDokumentaDataGridViewTextBoxColumn.Name = "knjizenjeDokumentaDataGridViewTextBoxColumn";
            this.knjizenjeDokumentaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // knjizenjeDokumenta1DataGridViewTextBoxColumn
            // 
            this.knjizenjeDokumenta1DataGridViewTextBoxColumn.DataPropertyName = "KnjizenjeDokumenta1";
            this.knjizenjeDokumenta1DataGridViewTextBoxColumn.HeaderText = "KnjizenjeDokumenta1";
            this.knjizenjeDokumenta1DataGridViewTextBoxColumn.Name = "knjizenjeDokumenta1DataGridViewTextBoxColumn";
            this.knjizenjeDokumenta1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.knjizenjeDokumenta1DataGridViewTextBoxColumn.Visible = false;
            // 
            // tipDokumenta1DataGridViewTextBoxColumn
            // 
            this.tipDokumenta1DataGridViewTextBoxColumn.DataPropertyName = "TipDokumenta1";
            this.tipDokumenta1DataGridViewTextBoxColumn.HeaderText = "TipDokumenta1";
            this.tipDokumenta1DataGridViewTextBoxColumn.Name = "tipDokumenta1DataGridViewTextBoxColumn";
            this.tipDokumenta1DataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkeDokumentaDataGridViewTextBoxColumn
            // 
            this.stavkeDokumentaDataGridViewTextBoxColumn.DataPropertyName = "StavkeDokumenta";
            this.stavkeDokumentaDataGridViewTextBoxColumn.HeaderText = "StavkeDokumenta";
            this.stavkeDokumentaDataGridViewTextBoxColumn.Name = "stavkeDokumentaDataGridViewTextBoxColumn";
            this.stavkeDokumentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // dokumentBindingSource
            // 
            this.dokumentBindingSource.DataSource = typeof(Compromplus_app.Dokument);
            // 
            // dgvStavkeDokumenata
            // 
            this.dgvStavkeDokumenata.AllowUserToAddRows = false;
            this.dgvStavkeDokumenata.AllowUserToDeleteRows = false;
            this.dgvStavkeDokumenata.AutoGenerateColumns = false;
            this.dgvStavkeDokumenata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeDokumenata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artiklDataGridViewTextBoxColumn,
            this.dokumentDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.artikl1DataGridViewTextBoxColumn,
            this.dokument1DataGridViewTextBoxColumn});
            this.dgvStavkeDokumenata.DataSource = this.stavkeDokumentaBindingSource;
            this.dgvStavkeDokumenata.Location = new System.Drawing.Point(51, 432);
            this.dgvStavkeDokumenata.Name = "dgvStavkeDokumenata";
            this.dgvStavkeDokumenata.Size = new System.Drawing.Size(454, 174);
            this.dgvStavkeDokumenata.TabIndex = 1;
            // 
            // artiklDataGridViewTextBoxColumn
            // 
            this.artiklDataGridViewTextBoxColumn.DataPropertyName = "artikl";
            this.artiklDataGridViewTextBoxColumn.HeaderText = "Šifra artikla";
            this.artiklDataGridViewTextBoxColumn.Name = "artiklDataGridViewTextBoxColumn";
            // 
            // dokumentDataGridViewTextBoxColumn
            // 
            this.dokumentDataGridViewTextBoxColumn.DataPropertyName = "dokument";
            this.dokumentDataGridViewTextBoxColumn.HeaderText = "dokument";
            this.dokumentDataGridViewTextBoxColumn.Name = "dokumentDataGridViewTextBoxColumn";
            this.dokumentDataGridViewTextBoxColumn.Visible = false;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // artikl1DataGridViewTextBoxColumn
            // 
            this.artikl1DataGridViewTextBoxColumn.DataPropertyName = "Artikl1";
            this.artikl1DataGridViewTextBoxColumn.HeaderText = "Artikl1";
            this.artikl1DataGridViewTextBoxColumn.Name = "artikl1DataGridViewTextBoxColumn";
            this.artikl1DataGridViewTextBoxColumn.Visible = false;
            // 
            // dokument1DataGridViewTextBoxColumn
            // 
            this.dokument1DataGridViewTextBoxColumn.DataPropertyName = "Dokument1";
            this.dokument1DataGridViewTextBoxColumn.HeaderText = "Dokument1";
            this.dokument1DataGridViewTextBoxColumn.Name = "dokument1DataGridViewTextBoxColumn";
            this.dokument1DataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkeDokumentaBindingSource
            // 
            this.stavkeDokumentaBindingSource.DataSource = typeof(Compromplus_app.StavkeDokumenta);
            // 
            // picDodaj
            // 
            this.picDodaj.Image = ((System.Drawing.Image)(resources.GetObject("picDodaj.Image")));
            this.picDodaj.Location = new System.Drawing.Point(466, 37);
            this.picDodaj.Name = "picDodaj";
            this.picDodaj.Size = new System.Drawing.Size(76, 71);
            this.picDodaj.TabIndex = 2;
            this.picDodaj.TabStop = false;
            this.picDodaj.Click += new System.EventHandler(this.picDodaj_Click);
            // 
            // lblDodaj
            // 
            this.lblDodaj.AutoSize = true;
            this.lblDodaj.Location = new System.Drawing.Point(463, 120);
            this.lblDodaj.Name = "lblDodaj";
            this.lblDodaj.Size = new System.Drawing.Size(85, 13);
            this.lblDodaj.TabIndex = 3;
            this.lblDodaj.Text = "Dodaj dokument";
            // 
            // lblIzmjeni
            // 
            this.lblIzmjeni.AutoSize = true;
            this.lblIzmjeni.Location = new System.Drawing.Point(570, 120);
            this.lblIzmjeni.Name = "lblIzmjeni";
            this.lblIzmjeni.Size = new System.Drawing.Size(89, 13);
            this.lblIzmjeni.TabIndex = 5;
            this.lblIzmjeni.Text = "Izmjeni dokument";
            // 
            // picIzmjeni
            // 
            this.picIzmjeni.Image = ((System.Drawing.Image)(resources.GetObject("picIzmjeni.Image")));
            this.picIzmjeni.Location = new System.Drawing.Point(581, 41);
            this.picIzmjeni.Name = "picIzmjeni";
            this.picIzmjeni.Size = new System.Drawing.Size(76, 71);
            this.picIzmjeni.TabIndex = 4;
            this.picIzmjeni.TabStop = false;
            this.picIzmjeni.Click += new System.EventHandler(this.picIzmjeni_Click);
            // 
            // lblProknjizi
            // 
            this.lblProknjizi.AutoSize = true;
            this.lblProknjizi.Location = new System.Drawing.Point(680, 120);
            this.lblProknjizi.Name = "lblProknjizi";
            this.lblProknjizi.Size = new System.Drawing.Size(96, 13);
            this.lblProknjizi.TabIndex = 7;
            this.lblProknjizi.Text = "Proknjiži dokument";
            // 
            // picProknjizi
            // 
            this.picProknjizi.Image = ((System.Drawing.Image)(resources.GetObject("picProknjizi.Image")));
            this.picProknjizi.Location = new System.Drawing.Point(691, 41);
            this.picProknjizi.Name = "picProknjizi";
            this.picProknjizi.Size = new System.Drawing.Size(76, 71);
            this.picProknjizi.TabIndex = 6;
            this.picProknjizi.TabStop = false;
            this.picProknjizi.Click += new System.EventHandler(this.picProknjizi_Click);
            // 
            // lblObrisi
            // 
            this.lblObrisi.AutoSize = true;
            this.lblObrisi.Location = new System.Drawing.Point(796, 120);
            this.lblObrisi.Name = "lblObrisi";
            this.lblObrisi.Size = new System.Drawing.Size(83, 13);
            this.lblObrisi.TabIndex = 9;
            this.lblObrisi.Text = "Obriši dokument";
            // 
            // picObrisi
            // 
            this.picObrisi.Image = ((System.Drawing.Image)(resources.GetObject("picObrisi.Image")));
            this.picObrisi.Location = new System.Drawing.Point(803, 37);
            this.picObrisi.Name = "picObrisi";
            this.picObrisi.Size = new System.Drawing.Size(76, 71);
            this.picObrisi.TabIndex = 8;
            this.picObrisi.TabStop = false;
            this.picObrisi.Click += new System.EventHandler(this.picObrisi_Click);
            // 
            // btnNovaStavka
            // 
            this.btnNovaStavka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNovaStavka.Location = new System.Drawing.Point(590, 465);
            this.btnNovaStavka.Name = "btnNovaStavka";
            this.btnNovaStavka.Size = new System.Drawing.Size(105, 39);
            this.btnNovaStavka.TabIndex = 10;
            this.btnNovaStavka.Text = "Nova stavka";
            this.btnNovaStavka.UseVisualStyleBackColor = true;
            this.btnNovaStavka.Click += new System.EventHandler(this.btnNovaStavka_Click);
            // 
            // lblIzlaz
            // 
            this.lblIzlaz.AutoSize = true;
            this.lblIzlaz.Location = new System.Drawing.Point(773, 561);
            this.lblIzlaz.Name = "lblIzlaz";
            this.lblIzlaz.Size = new System.Drawing.Size(28, 13);
            this.lblIzlaz.TabIndex = 14;
            this.lblIzlaz.Text = "Izlaz";
            // 
            // picIzlaz
            // 
            this.picIzlaz.Image = ((System.Drawing.Image)(resources.GetObject("picIzlaz.Image")));
            this.picIzlaz.Location = new System.Drawing.Point(747, 478);
            this.picIzlaz.Name = "picIzlaz";
            this.picIzlaz.Size = new System.Drawing.Size(76, 71);
            this.picIzlaz.TabIndex = 13;
            this.picIzlaz.TabStop = false;
            this.picIzlaz.Click += new System.EventHandler(this.picIzlaz_Click);
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DataPropertyName = "KnjizenjeDokumenta1";
            this.dataGridViewComboBoxColumn1.HeaderText = "Knjiženje";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnObrisi.Location = new System.Drawing.Point(590, 530);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(105, 39);
            this.btnObrisi.TabIndex = 15;
            this.btnObrisi.Text = "Obriši stavku";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnPretrazivanjeSifra
            // 
            this.btnPretrazivanjeSifra.Location = new System.Drawing.Point(804, 155);
            this.btnPretrazivanjeSifra.Name = "btnPretrazivanjeSifra";
            this.btnPretrazivanjeSifra.Size = new System.Drawing.Size(75, 26);
            this.btnPretrazivanjeSifra.TabIndex = 20;
            this.btnPretrazivanjeSifra.Text = "Traži";
            this.btnPretrazivanjeSifra.UseVisualStyleBackColor = true;
            this.btnPretrazivanjeSifra.Click += new System.EventHandler(this.btnPretrazivanjeSifra_Click);
            // 
            // txtPretrazivanjeSifra
            // 
            this.txtPretrazivanjeSifra.Location = new System.Drawing.Point(688, 154);
            this.txtPretrazivanjeSifra.Name = "txtPretrazivanjeSifra";
            this.txtPretrazivanjeSifra.Size = new System.Drawing.Size(100, 20);
            this.txtPretrazivanjeSifra.TabIndex = 19;
            // 
            // lblPretrazivanjeSifra
            // 
            this.lblPretrazivanjeSifra.AutoSize = true;
            this.lblPretrazivanjeSifra.Location = new System.Drawing.Point(564, 161);
            this.lblPretrazivanjeSifra.Name = "lblPretrazivanjeSifra";
            this.lblPretrazivanjeSifra.Size = new System.Drawing.Size(118, 13);
            this.lblPretrazivanjeSifra.TabIndex = 18;
            this.lblPretrazivanjeSifra.Text = "Pretraživanje prema šifri";
            // 
            // txtPretrazivanje
            // 
            this.txtPretrazivanje.Location = new System.Drawing.Point(138, 158);
            this.txtPretrazivanje.Name = "txtPretrazivanje";
            this.txtPretrazivanje.Size = new System.Drawing.Size(261, 20);
            this.txtPretrazivanje.TabIndex = 17;
            this.txtPretrazivanje.TextChanged += new System.EventHandler(this.txtPretrazivanje_TextChanged);
            // 
            // lblPretrazivanje
            // 
            this.lblPretrazivanje.AutoSize = true;
            this.lblPretrazivanje.Location = new System.Drawing.Point(50, 161);
            this.lblPretrazivanje.Name = "lblPretrazivanje";
            this.lblPretrazivanje.Size = new System.Drawing.Size(68, 13);
            this.lblPretrazivanje.TabIndex = 16;
            this.lblPretrazivanje.Text = "Pretraživanje";
            // 
            // lblNaslovniText
            // 
            this.lblNaslovniText.AutoSize = true;
            this.lblNaslovniText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.lblNaslovniText.Location = new System.Drawing.Point(124, 52);
            this.lblNaslovniText.Name = "lblNaslovniText";
            this.lblNaslovniText.Size = new System.Drawing.Size(173, 38);
            this.lblNaslovniText.TabIndex = 22;
            this.lblNaslovniText.Text = "Dokumenti";
            // 
            // picDjelatnici
            // 
            this.picDjelatnici.Image = ((System.Drawing.Image)(resources.GetObject("picDjelatnici.Image")));
            this.picDjelatnici.Location = new System.Drawing.Point(48, 37);
            this.picDjelatnici.Name = "picDjelatnici";
            this.picDjelatnici.Size = new System.Drawing.Size(70, 67);
            this.picDjelatnici.TabIndex = 21;
            this.picDjelatnici.TabStop = false;
            // 
            // knjizenjeDokumentaBindingSource
            // 
            this.knjizenjeDokumentaBindingSource.DataSource = typeof(Compromplus_app.KnjizenjeDokumenta);
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataSource = typeof(Compromplus_app.Artikl);
            // 
            // formaDokumentiPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(998, 627);
            this.Controls.Add(this.lblNaslovniText);
            this.Controls.Add(this.picDjelatnici);
            this.Controls.Add(this.btnPretrazivanjeSifra);
            this.Controls.Add(this.txtPretrazivanjeSifra);
            this.Controls.Add(this.lblPretrazivanjeSifra);
            this.Controls.Add(this.txtPretrazivanje);
            this.Controls.Add(this.lblPretrazivanje);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.lblIzlaz);
            this.Controls.Add(this.picIzlaz);
            this.Controls.Add(this.btnNovaStavka);
            this.Controls.Add(this.lblObrisi);
            this.Controls.Add(this.picObrisi);
            this.Controls.Add(this.lblProknjizi);
            this.Controls.Add(this.picProknjizi);
            this.Controls.Add(this.lblIzmjeni);
            this.Controls.Add(this.picIzmjeni);
            this.Controls.Add(this.lblDodaj);
            this.Controls.Add(this.picDodaj);
            this.Controls.Add(this.dgvStavkeDokumenata);
            this.Controls.Add(this.dgvDokumenti);
            this.Name = "formaDokumentiPregled";
            this.Text = "Dokumenti";
            this.Load += new System.EventHandler(this.formaDokumentiPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDokumenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeDokumenata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeDokumentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDodaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzmjeni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProknjizi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObrisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDjelatnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjizenjeDokumentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDokumenti;
        private System.Windows.Forms.BindingSource dokumentBindingSource;
        private System.Windows.Forms.DataGridView dgvStavkeDokumenata;
        private System.Windows.Forms.BindingSource stavkeDokumentaBindingSource;
        private System.Windows.Forms.PictureBox picDodaj;
        private System.Windows.Forms.Label lblDodaj;
        private System.Windows.Forms.Label lblIzmjeni;
        private System.Windows.Forms.PictureBox picIzmjeni;
        private System.Windows.Forms.Label lblProknjizi;
        private System.Windows.Forms.PictureBox picProknjizi;
        private System.Windows.Forms.Label lblObrisi;
        private System.Windows.Forms.PictureBox picObrisi;
        private System.Windows.Forms.Button btnNovaStavka;
        private System.Windows.Forms.Label lblIzlaz;
        private System.Windows.Forms.PictureBox picIzlaz;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private System.Windows.Forms.BindingSource knjizenjeDokumentaBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDokumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn knjizenjeDokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn knjizenjeDokumenta1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDokumenta1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkeDokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artiklDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artikl1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokument1DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPretrazivanjeSifra;
        private System.Windows.Forms.TextBox txtPretrazivanjeSifra;
        private System.Windows.Forms.Label lblPretrazivanjeSifra;
        private System.Windows.Forms.TextBox txtPretrazivanje;
        private System.Windows.Forms.Label lblPretrazivanje;
        private System.Windows.Forms.Label lblNaslovniText;
        private System.Windows.Forms.PictureBox picDjelatnici;
    }
}