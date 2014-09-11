namespace aplikacija
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
            this.dgvDokumenti = new System.Windows.Forms.DataGridView();
            this.dokumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvStavkeDokumenata = new System.Windows.Forms.DataGridView();
            this.stavkedokumentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNoviDokument = new System.Windows.Forms.Button();
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNovaStavka = new System.Windows.Forms.Button();
            this.idDokumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivArtiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDokumenta1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkedokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikliIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokumentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDokumenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeDokumenata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkedokumentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDokumenti
            // 
            this.dgvDokumenti.AllowUserToAddRows = false;
            this.dgvDokumenti.AutoGenerateColumns = false;
            this.dgvDokumenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDokumenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDokumentDataGridViewTextBoxColumn,
            this.nazivArtiklaDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.tipDokumentaDataGridViewTextBoxColumn,
            this.tipDokumenta1DataGridViewTextBoxColumn,
            this.stavkedokumentaDataGridViewTextBoxColumn});
            this.dgvDokumenti.DataSource = this.dokumentBindingSource;
            this.dgvDokumenti.Location = new System.Drawing.Point(38, 25);
            this.dgvDokumenti.Name = "dgvDokumenti";
            this.dgvDokumenti.Size = new System.Drawing.Size(564, 188);
            this.dgvDokumenti.TabIndex = 0;
            this.dgvDokumenti.SelectionChanged += new System.EventHandler(this.dgvDokumenti_SelectionChanged);
            // 
            // dokumentBindingSource
            // 
            this.dokumentBindingSource.DataSource = typeof(aplikacija.Dokument);
            // 
            // dgvStavkeDokumenata
            // 
            this.dgvStavkeDokumenata.AllowUserToAddRows = false;
            this.dgvStavkeDokumenata.AutoGenerateColumns = false;
            this.dgvStavkeDokumenata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeDokumenata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artikliIdDataGridViewTextBoxColumn,
            this.dokumentIdDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.artikliDataGridViewTextBoxColumn,
            this.dokumentDataGridViewTextBoxColumn});
            this.dgvStavkeDokumenata.DataSource = this.stavkedokumentaBindingSource;
            this.dgvStavkeDokumenata.Location = new System.Drawing.Point(38, 246);
            this.dgvStavkeDokumenata.Name = "dgvStavkeDokumenata";
            this.dgvStavkeDokumenata.Size = new System.Drawing.Size(564, 150);
            this.dgvStavkeDokumenata.TabIndex = 1;
            // 
            // stavkedokumentaBindingSource
            // 
            this.stavkedokumentaBindingSource.DataSource = typeof(aplikacija.stavke_dokumenta);
            // 
            // btnNoviDokument
            // 
            this.btnNoviDokument.Location = new System.Drawing.Point(633, 25);
            this.btnNoviDokument.Name = "btnNoviDokument";
            this.btnNoviDokument.Size = new System.Drawing.Size(121, 23);
            this.btnNoviDokument.TabIndex = 2;
            this.btnNoviDokument.Text = "Novi dokument";
            this.btnNoviDokument.UseVisualStyleBackColor = true;
            this.btnNoviDokument.Click += new System.EventHandler(this.btnNoviDokument_Click);
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.Location = new System.Drawing.Point(633, 64);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(121, 23);
            this.btnIzmjeni.TabIndex = 3;
            this.btnIzmjeni.Text = "Izmjeni dokument";
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(633, 105);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(121, 23);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obriši dokument";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Obriši stavku";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(633, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Izmjeni stavku";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnNovaStavka
            // 
            this.btnNovaStavka.Location = new System.Drawing.Point(633, 246);
            this.btnNovaStavka.Name = "btnNovaStavka";
            this.btnNovaStavka.Size = new System.Drawing.Size(121, 23);
            this.btnNovaStavka.TabIndex = 5;
            this.btnNovaStavka.Text = "Nova stavka";
            this.btnNovaStavka.UseVisualStyleBackColor = true;
            this.btnNovaStavka.Click += new System.EventHandler(this.btnNovaStavka_Click);
            // 
            // idDokumentDataGridViewTextBoxColumn
            // 
            this.idDokumentDataGridViewTextBoxColumn.DataPropertyName = "IdDokument";
            this.idDokumentDataGridViewTextBoxColumn.HeaderText = "Šifra";
            this.idDokumentDataGridViewTextBoxColumn.Name = "idDokumentDataGridViewTextBoxColumn";
            // 
            // nazivArtiklaDataGridViewTextBoxColumn
            // 
            this.nazivArtiklaDataGridViewTextBoxColumn.DataPropertyName = "nazivArtikla";
            this.nazivArtiklaDataGridViewTextBoxColumn.HeaderText = "";
            this.nazivArtiklaDataGridViewTextBoxColumn.Name = "nazivArtiklaDataGridViewTextBoxColumn";
            this.nazivArtiklaDataGridViewTextBoxColumn.Visible = false;
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
            this.tipDokumentaDataGridViewTextBoxColumn.HeaderText = "Tip dokumenta";
            this.tipDokumentaDataGridViewTextBoxColumn.Name = "tipDokumentaDataGridViewTextBoxColumn";
            this.tipDokumentaDataGridViewTextBoxColumn.Width = 130;
            // 
            // tipDokumenta1DataGridViewTextBoxColumn
            // 
            this.tipDokumenta1DataGridViewTextBoxColumn.DataPropertyName = "TipDokumenta1";
            this.tipDokumenta1DataGridViewTextBoxColumn.HeaderText = "TipDokumenta1";
            this.tipDokumenta1DataGridViewTextBoxColumn.Name = "tipDokumenta1DataGridViewTextBoxColumn";
            this.tipDokumenta1DataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkedokumentaDataGridViewTextBoxColumn
            // 
            this.stavkedokumentaDataGridViewTextBoxColumn.DataPropertyName = "stavke_dokumenta";
            this.stavkedokumentaDataGridViewTextBoxColumn.HeaderText = "stavke_dokumenta";
            this.stavkedokumentaDataGridViewTextBoxColumn.Name = "stavkedokumentaDataGridViewTextBoxColumn";
            this.stavkedokumentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // artikliIdDataGridViewTextBoxColumn
            // 
            this.artikliIdDataGridViewTextBoxColumn.DataPropertyName = "artikliId";
            this.artikliIdDataGridViewTextBoxColumn.HeaderText = "Naziv artikla";
            this.artikliIdDataGridViewTextBoxColumn.Name = "artikliIdDataGridViewTextBoxColumn";
            this.artikliIdDataGridViewTextBoxColumn.Width = 140;
            // 
            // dokumentIdDataGridViewTextBoxColumn
            // 
            this.dokumentIdDataGridViewTextBoxColumn.DataPropertyName = "dokumentId";
            this.dokumentIdDataGridViewTextBoxColumn.HeaderText = "dokumentId";
            this.dokumentIdDataGridViewTextBoxColumn.Name = "dokumentIdDataGridViewTextBoxColumn";
            this.dokumentIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // artikliDataGridViewTextBoxColumn
            // 
            this.artikliDataGridViewTextBoxColumn.DataPropertyName = "Artikli";
            this.artikliDataGridViewTextBoxColumn.HeaderText = "Artikli";
            this.artikliDataGridViewTextBoxColumn.Name = "artikliDataGridViewTextBoxColumn";
            this.artikliDataGridViewTextBoxColumn.Visible = false;
            // 
            // dokumentDataGridViewTextBoxColumn
            // 
            this.dokumentDataGridViewTextBoxColumn.DataPropertyName = "Dokument";
            this.dokumentDataGridViewTextBoxColumn.HeaderText = "Dokument";
            this.dokumentDataGridViewTextBoxColumn.Name = "dokumentDataGridViewTextBoxColumn";
            this.dokumentDataGridViewTextBoxColumn.Visible = false;
            // 
            // formaDokumentiPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(870, 420);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnNovaStavka);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.btnNoviDokument);
            this.Controls.Add(this.dgvStavkeDokumenata);
            this.Controls.Add(this.dgvDokumenti);
            this.Name = "formaDokumentiPregled";
            this.Text = "formaDokumentiPregled";
            this.Load += new System.EventHandler(this.formaDokumentiPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDokumenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeDokumenata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkedokumentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDokumenti;
        private System.Windows.Forms.DataGridView dgvStavkeDokumenata;
        private System.Windows.Forms.BindingSource dokumentBindingSource;
        private System.Windows.Forms.BindingSource stavkedokumentaBindingSource;
        private System.Windows.Forms.Button btnNoviDokument;
        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNovaStavka;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDokumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivArtiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDokumenta1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkedokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artikliIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artikliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumentDataGridViewTextBoxColumn;
    }
}