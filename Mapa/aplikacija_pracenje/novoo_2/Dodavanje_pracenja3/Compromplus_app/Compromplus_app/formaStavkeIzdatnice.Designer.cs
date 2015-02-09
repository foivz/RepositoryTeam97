namespace Compromplus_app
{
    partial class formaStavkeIzdatnice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formaStavkeIzdatnice));
            this.lblNaslovniText = new System.Windows.Forms.Label();
            this.picDjelatnici = new System.Windows.Forms.PictureBox();
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.btnPretrazivanjeSifra = new System.Windows.Forms.Button();
            this.txtPretrazivanjeSifra = new System.Windows.Forms.TextBox();
            this.lblPretrazivanjeSifra = new System.Windows.Forms.Label();
            this.txtPretrazivanje = new System.Windows.Forms.TextBox();
            this.lblPretrazivanje = new System.Windows.Forms.Label();
            this.lblIzlaz = new System.Windows.Forms.Label();
            this.picIzlaz = new System.Windows.Forms.PictureBox();
            this.lblSpremi = new System.Windows.Forms.Label();
            this.picSpremi = new System.Windows.Forms.PictureBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idArtiklDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeDokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pracenjeProizvodnjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeIzdatniceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeOtpremniceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkePrimkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picDjelatnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpremi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslovniText
            // 
            this.lblNaslovniText.AutoSize = true;
            this.lblNaslovniText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.lblNaslovniText.Location = new System.Drawing.Point(98, 27);
            this.lblNaslovniText.Name = "lblNaslovniText";
            this.lblNaslovniText.Size = new System.Drawing.Size(256, 38);
            this.lblNaslovniText.TabIndex = 41;
            this.lblNaslovniText.Text = "Stavke izdatnice";
            // 
            // picDjelatnici
            // 
            this.picDjelatnici.Image = ((System.Drawing.Image)(resources.GetObject("picDjelatnici.Image")));
            this.picDjelatnici.Location = new System.Drawing.Point(22, 12);
            this.picDjelatnici.Name = "picDjelatnici";
            this.picDjelatnici.Size = new System.Drawing.Size(70, 67);
            this.picDjelatnici.TabIndex = 40;
            this.picDjelatnici.TabStop = false;
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.AllowUserToAddRows = false;
            this.dgvArtikli.AllowUserToDeleteRows = false;
            this.dgvArtikli.AutoGenerateColumns = false;
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArtiklDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.bojaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.klasaDataGridViewTextBoxColumn,
            this.barkodDataGridViewTextBoxColumn,
            this.tipDataGridViewTextBoxColumn,
            this.stavkeDokumentaDataGridViewTextBoxColumn,
            this.pracenjeProizvodnjeDataGridViewTextBoxColumn,
            this.stavkeIzdatniceDataGridViewTextBoxColumn,
            this.stavkeOtpremniceDataGridViewTextBoxColumn,
            this.stavkePrimkeDataGridViewTextBoxColumn});
            this.dgvArtikli.DataSource = this.artiklBindingSource;
            this.dgvArtikli.Location = new System.Drawing.Point(32, 148);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.Size = new System.Drawing.Size(693, 212);
            this.dgvArtikli.TabIndex = 39;
            this.dgvArtikli.SelectionChanged += new System.EventHandler(this.dgvArtikli_SelectionChanged);
            // 
            // btnPretrazivanjeSifra
            // 
            this.btnPretrazivanjeSifra.Location = new System.Drawing.Point(609, 110);
            this.btnPretrazivanjeSifra.Name = "btnPretrazivanjeSifra";
            this.btnPretrazivanjeSifra.Size = new System.Drawing.Size(75, 26);
            this.btnPretrazivanjeSifra.TabIndex = 38;
            this.btnPretrazivanjeSifra.Text = "Traži";
            this.btnPretrazivanjeSifra.UseVisualStyleBackColor = true;
            this.btnPretrazivanjeSifra.Click += new System.EventHandler(this.btnPretrazivanjeSifra_Click);
            // 
            // txtPretrazivanjeSifra
            // 
            this.txtPretrazivanjeSifra.Location = new System.Drawing.Point(493, 109);
            this.txtPretrazivanjeSifra.Name = "txtPretrazivanjeSifra";
            this.txtPretrazivanjeSifra.Size = new System.Drawing.Size(100, 20);
            this.txtPretrazivanjeSifra.TabIndex = 37;
            // 
            // lblPretrazivanjeSifra
            // 
            this.lblPretrazivanjeSifra.AutoSize = true;
            this.lblPretrazivanjeSifra.Location = new System.Drawing.Point(369, 116);
            this.lblPretrazivanjeSifra.Name = "lblPretrazivanjeSifra";
            this.lblPretrazivanjeSifra.Size = new System.Drawing.Size(118, 13);
            this.lblPretrazivanjeSifra.TabIndex = 36;
            this.lblPretrazivanjeSifra.Text = "Pretraživanje prema šifri";
            // 
            // txtPretrazivanje
            // 
            this.txtPretrazivanje.Location = new System.Drawing.Point(117, 113);
            this.txtPretrazivanje.Name = "txtPretrazivanje";
            this.txtPretrazivanje.Size = new System.Drawing.Size(178, 20);
            this.txtPretrazivanje.TabIndex = 35;
            this.txtPretrazivanje.TextChanged += new System.EventHandler(this.txtPretrazivanje_TextChanged);
            // 
            // lblPretrazivanje
            // 
            this.lblPretrazivanje.AutoSize = true;
            this.lblPretrazivanje.Location = new System.Drawing.Point(29, 116);
            this.lblPretrazivanje.Name = "lblPretrazivanje";
            this.lblPretrazivanje.Size = new System.Drawing.Size(68, 13);
            this.lblPretrazivanje.TabIndex = 34;
            this.lblPretrazivanje.Text = "Pretraživanje";
            // 
            // lblIzlaz
            // 
            this.lblIzlaz.AutoSize = true;
            this.lblIzlaz.Location = new System.Drawing.Point(570, 456);
            this.lblIzlaz.Name = "lblIzlaz";
            this.lblIzlaz.Size = new System.Drawing.Size(28, 13);
            this.lblIzlaz.TabIndex = 47;
            this.lblIzlaz.Text = "Izlaz";
            // 
            // picIzlaz
            // 
            this.picIzlaz.Image = ((System.Drawing.Image)(resources.GetObject("picIzlaz.Image")));
            this.picIzlaz.Location = new System.Drawing.Point(543, 377);
            this.picIzlaz.Name = "picIzlaz";
            this.picIzlaz.Size = new System.Drawing.Size(76, 71);
            this.picIzlaz.TabIndex = 46;
            this.picIzlaz.TabStop = false;
            this.picIzlaz.Click += new System.EventHandler(this.picIzlaz_Click);
            // 
            // lblSpremi
            // 
            this.lblSpremi.AutoSize = true;
            this.lblSpremi.Location = new System.Drawing.Point(446, 456);
            this.lblSpremi.Name = "lblSpremi";
            this.lblSpremi.Size = new System.Drawing.Size(74, 13);
            this.lblSpremi.TabIndex = 45;
            this.lblSpremi.Text = "Spremi stavku";
            // 
            // picSpremi
            // 
            this.picSpremi.Image = ((System.Drawing.Image)(resources.GetObject("picSpremi.Image")));
            this.picSpremi.Location = new System.Drawing.Point(449, 377);
            this.picSpremi.Name = "picSpremi";
            this.picSpremi.Size = new System.Drawing.Size(76, 71);
            this.picSpremi.TabIndex = 44;
            this.picSpremi.TabStop = false;
            this.picSpremi.Click += new System.EventHandler(this.picSpremi_Click);
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblKolicina.Location = new System.Drawing.Point(83, 391);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(68, 20);
            this.lblKolicina.TabIndex = 43;
            this.lblKolicina.Text = "Količina";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtKolicina.Location = new System.Drawing.Point(167, 388);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(227, 26);
            this.txtKolicina.TabIndex = 42;
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataSource = typeof(Compromplus_app.Artikl);
            // 
            // idArtiklDataGridViewTextBoxColumn
            // 
            this.idArtiklDataGridViewTextBoxColumn.DataPropertyName = "IdArtikl";
            this.idArtiklDataGridViewTextBoxColumn.HeaderText = "IdArtikl";
            this.idArtiklDataGridViewTextBoxColumn.Name = "idArtiklDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // bojaDataGridViewTextBoxColumn
            // 
            this.bojaDataGridViewTextBoxColumn.DataPropertyName = "boja";
            this.bojaDataGridViewTextBoxColumn.HeaderText = "boja";
            this.bojaDataGridViewTextBoxColumn.Name = "bojaDataGridViewTextBoxColumn";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // klasaDataGridViewTextBoxColumn
            // 
            this.klasaDataGridViewTextBoxColumn.DataPropertyName = "klasa";
            this.klasaDataGridViewTextBoxColumn.HeaderText = "klasa";
            this.klasaDataGridViewTextBoxColumn.Name = "klasaDataGridViewTextBoxColumn";
            // 
            // barkodDataGridViewTextBoxColumn
            // 
            this.barkodDataGridViewTextBoxColumn.DataPropertyName = "barkod";
            this.barkodDataGridViewTextBoxColumn.HeaderText = "barkod";
            this.barkodDataGridViewTextBoxColumn.Name = "barkodDataGridViewTextBoxColumn";
            // 
            // tipDataGridViewTextBoxColumn
            // 
            this.tipDataGridViewTextBoxColumn.DataPropertyName = "tip";
            this.tipDataGridViewTextBoxColumn.HeaderText = "tip";
            this.tipDataGridViewTextBoxColumn.Name = "tipDataGridViewTextBoxColumn";
            // 
            // stavkeDokumentaDataGridViewTextBoxColumn
            // 
            this.stavkeDokumentaDataGridViewTextBoxColumn.DataPropertyName = "StavkeDokumenta";
            this.stavkeDokumentaDataGridViewTextBoxColumn.HeaderText = "StavkeDokumenta";
            this.stavkeDokumentaDataGridViewTextBoxColumn.Name = "stavkeDokumentaDataGridViewTextBoxColumn";
            // 
            // pracenjeProizvodnjeDataGridViewTextBoxColumn
            // 
            this.pracenjeProizvodnjeDataGridViewTextBoxColumn.DataPropertyName = "PracenjeProizvodnje";
            this.pracenjeProizvodnjeDataGridViewTextBoxColumn.HeaderText = "PracenjeProizvodnje";
            this.pracenjeProizvodnjeDataGridViewTextBoxColumn.Name = "pracenjeProizvodnjeDataGridViewTextBoxColumn";
            // 
            // stavkeIzdatniceDataGridViewTextBoxColumn
            // 
            this.stavkeIzdatniceDataGridViewTextBoxColumn.DataPropertyName = "stavkeIzdatnice";
            this.stavkeIzdatniceDataGridViewTextBoxColumn.HeaderText = "stavkeIzdatnice";
            this.stavkeIzdatniceDataGridViewTextBoxColumn.Name = "stavkeIzdatniceDataGridViewTextBoxColumn";
            // 
            // stavkeOtpremniceDataGridViewTextBoxColumn
            // 
            this.stavkeOtpremniceDataGridViewTextBoxColumn.DataPropertyName = "stavkeOtpremnice";
            this.stavkeOtpremniceDataGridViewTextBoxColumn.HeaderText = "stavkeOtpremnice";
            this.stavkeOtpremniceDataGridViewTextBoxColumn.Name = "stavkeOtpremniceDataGridViewTextBoxColumn";
            // 
            // stavkePrimkeDataGridViewTextBoxColumn
            // 
            this.stavkePrimkeDataGridViewTextBoxColumn.DataPropertyName = "stavkePrimke";
            this.stavkePrimkeDataGridViewTextBoxColumn.HeaderText = "stavkePrimke";
            this.stavkePrimkeDataGridViewTextBoxColumn.Name = "stavkePrimkeDataGridViewTextBoxColumn";
            // 
            // formaStavkeIzdatnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 478);
            this.Controls.Add(this.lblIzlaz);
            this.Controls.Add(this.picIzlaz);
            this.Controls.Add(this.lblSpremi);
            this.Controls.Add(this.picSpremi);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.lblNaslovniText);
            this.Controls.Add(this.picDjelatnici);
            this.Controls.Add(this.dgvArtikli);
            this.Controls.Add(this.btnPretrazivanjeSifra);
            this.Controls.Add(this.txtPretrazivanjeSifra);
            this.Controls.Add(this.lblPretrazivanjeSifra);
            this.Controls.Add(this.txtPretrazivanje);
            this.Controls.Add(this.lblPretrazivanje);
            this.Name = "formaStavkeIzdatnice";
            this.Text = "formaStavkeIzdatnice";
            this.Load += new System.EventHandler(this.formaStavkeIzdatnice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDjelatnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpremi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslovniText;
        private System.Windows.Forms.PictureBox picDjelatnici;
        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.Button btnPretrazivanjeSifra;
        private System.Windows.Forms.TextBox txtPretrazivanjeSifra;
        private System.Windows.Forms.Label lblPretrazivanjeSifra;
        private System.Windows.Forms.TextBox txtPretrazivanje;
        private System.Windows.Forms.Label lblPretrazivanje;
        private System.Windows.Forms.Label lblIzlaz;
        private System.Windows.Forms.PictureBox picIzlaz;
        private System.Windows.Forms.Label lblSpremi;
        private System.Windows.Forms.PictureBox picSpremi;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArtiklDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bojaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkeDokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pracenjeProizvodnjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkeIzdatniceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkeOtpremniceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkePrimkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource artiklBindingSource;
    }
}