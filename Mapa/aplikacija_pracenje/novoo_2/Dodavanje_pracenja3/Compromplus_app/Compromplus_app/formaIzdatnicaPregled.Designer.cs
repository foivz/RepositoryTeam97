namespace Compromplus_app
{
    partial class formaIzdatnicaPregled
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formaIzdatnicaPregled));
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
            this.lblDodaj = new System.Windows.Forms.Label();
            this.picDodaj = new System.Windows.Forms.PictureBox();
            this.dgvIzdatnice = new System.Windows.Forms.DataGridView();
            this.idIzdatnicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knjizenjeDokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izdatnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t23_EnigmaDataSet7 = new Compromplus_app.T23_EnigmaDataSet7();
            this.izdatnicaTableAdapter = new Compromplus_app.T23_EnigmaDataSet7TableAdapters.IzdatnicaTableAdapter();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.lblIzlaz = new System.Windows.Forms.Label();
            this.picIzlaz = new System.Windows.Forms.PictureBox();
            this.btnNovaStavka = new System.Windows.Forms.Button();
            this.dgvStavkeIzdatnice = new System.Windows.Forms.DataGridView();
            this.idArtiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idIzdatniceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeIzdatniceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t23_EnigmaDataSet8 = new Compromplus_app.T23_EnigmaDataSet8();
            this.stavkeIzdatniceTableAdapter = new Compromplus_app.T23_EnigmaDataSet8TableAdapters.stavkeIzdatniceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.picDjelatnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObrisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProknjizi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDodaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzdatnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdatnicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_EnigmaDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeIzdatnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeIzdatniceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_EnigmaDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslovniText
            // 
            this.lblNaslovniText.AutoSize = true;
            this.lblNaslovniText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.lblNaslovniText.Location = new System.Drawing.Point(96, 31);
            this.lblNaslovniText.Name = "lblNaslovniText";
            this.lblNaslovniText.Size = new System.Drawing.Size(147, 38);
            this.lblNaslovniText.TabIndex = 38;
            this.lblNaslovniText.Text = "Izdatnica";
            // 
            // picDjelatnici
            // 
            this.picDjelatnici.Image = ((System.Drawing.Image)(resources.GetObject("picDjelatnici.Image")));
            this.picDjelatnici.Location = new System.Drawing.Point(20, 16);
            this.picDjelatnici.Name = "picDjelatnici";
            this.picDjelatnici.Size = new System.Drawing.Size(70, 67);
            this.picDjelatnici.TabIndex = 37;
            this.picDjelatnici.TabStop = false;
            // 
            // btnPretrazivanjeSifra
            // 
            this.btnPretrazivanjeSifra.Location = new System.Drawing.Point(755, 126);
            this.btnPretrazivanjeSifra.Name = "btnPretrazivanjeSifra";
            this.btnPretrazivanjeSifra.Size = new System.Drawing.Size(75, 26);
            this.btnPretrazivanjeSifra.TabIndex = 36;
            this.btnPretrazivanjeSifra.Text = "Traži";
            this.btnPretrazivanjeSifra.UseVisualStyleBackColor = true;
            this.btnPretrazivanjeSifra.Click += new System.EventHandler(this.btnPretrazivanjeSifra_Click);
            // 
            // txtPretrazivanjeSifra
            // 
            this.txtPretrazivanjeSifra.Location = new System.Drawing.Point(639, 125);
            this.txtPretrazivanjeSifra.Name = "txtPretrazivanjeSifra";
            this.txtPretrazivanjeSifra.Size = new System.Drawing.Size(100, 20);
            this.txtPretrazivanjeSifra.TabIndex = 35;
            // 
            // lblPretrazivanjeSifra
            // 
            this.lblPretrazivanjeSifra.AutoSize = true;
            this.lblPretrazivanjeSifra.Location = new System.Drawing.Point(515, 132);
            this.lblPretrazivanjeSifra.Name = "lblPretrazivanjeSifra";
            this.lblPretrazivanjeSifra.Size = new System.Drawing.Size(118, 13);
            this.lblPretrazivanjeSifra.TabIndex = 34;
            this.lblPretrazivanjeSifra.Text = "Pretraživanje prema šifri";
            // 
            // txtPretrazivanje
            // 
            this.txtPretrazivanje.Location = new System.Drawing.Point(110, 130);
            this.txtPretrazivanje.Name = "txtPretrazivanje";
            this.txtPretrazivanje.Size = new System.Drawing.Size(261, 20);
            this.txtPretrazivanje.TabIndex = 33;
            this.txtPretrazivanje.TextChanged += new System.EventHandler(this.txtPretrazivanje_TextChanged);
            // 
            // lblPretrazivanje
            // 
            this.lblPretrazivanje.AutoSize = true;
            this.lblPretrazivanje.Location = new System.Drawing.Point(22, 133);
            this.lblPretrazivanje.Name = "lblPretrazivanje";
            this.lblPretrazivanje.Size = new System.Drawing.Size(68, 13);
            this.lblPretrazivanje.TabIndex = 32;
            this.lblPretrazivanje.Text = "Pretraživanje";
            // 
            // lblObrisi
            // 
            this.lblObrisi.AutoSize = true;
            this.lblObrisi.Location = new System.Drawing.Point(747, 91);
            this.lblObrisi.Name = "lblObrisi";
            this.lblObrisi.Size = new System.Drawing.Size(83, 13);
            this.lblObrisi.TabIndex = 31;
            this.lblObrisi.Text = "Obriši dokument";
            // 
            // picObrisi
            // 
            this.picObrisi.Image = ((System.Drawing.Image)(resources.GetObject("picObrisi.Image")));
            this.picObrisi.Location = new System.Drawing.Point(754, 8);
            this.picObrisi.Name = "picObrisi";
            this.picObrisi.Size = new System.Drawing.Size(76, 71);
            this.picObrisi.TabIndex = 30;
            this.picObrisi.TabStop = false;
            this.picObrisi.Click += new System.EventHandler(this.picObrisi_Click);
            // 
            // lblProknjizi
            // 
            this.lblProknjizi.AutoSize = true;
            this.lblProknjizi.Location = new System.Drawing.Point(631, 91);
            this.lblProknjizi.Name = "lblProknjizi";
            this.lblProknjizi.Size = new System.Drawing.Size(96, 13);
            this.lblProknjizi.TabIndex = 29;
            this.lblProknjizi.Text = "Proknjiži dokument";
            // 
            // picProknjizi
            // 
            this.picProknjizi.Image = ((System.Drawing.Image)(resources.GetObject("picProknjizi.Image")));
            this.picProknjizi.Location = new System.Drawing.Point(642, 12);
            this.picProknjizi.Name = "picProknjizi";
            this.picProknjizi.Size = new System.Drawing.Size(76, 71);
            this.picProknjizi.TabIndex = 28;
            this.picProknjizi.TabStop = false;
            this.picProknjizi.Click += new System.EventHandler(this.picProknjizi_Click);
            // 
            // lblDodaj
            // 
            this.lblDodaj.AutoSize = true;
            this.lblDodaj.Location = new System.Drawing.Point(532, 91);
            this.lblDodaj.Name = "lblDodaj";
            this.lblDodaj.Size = new System.Drawing.Size(85, 13);
            this.lblDodaj.TabIndex = 25;
            this.lblDodaj.Text = "Dodaj dokument";
            // 
            // picDodaj
            // 
            this.picDodaj.Image = ((System.Drawing.Image)(resources.GetObject("picDodaj.Image")));
            this.picDodaj.Location = new System.Drawing.Point(535, 8);
            this.picDodaj.Name = "picDodaj";
            this.picDodaj.Size = new System.Drawing.Size(76, 71);
            this.picDodaj.TabIndex = 24;
            this.picDodaj.TabStop = false;
            this.picDodaj.Click += new System.EventHandler(this.picDodaj_Click);
            // 
            // dgvIzdatnice
            // 
            this.dgvIzdatnice.AllowUserToAddRows = false;
            this.dgvIzdatnice.AllowUserToDeleteRows = false;
            this.dgvIzdatnice.AutoGenerateColumns = false;
            this.dgvIzdatnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzdatnice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idIzdatnicaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.bojaDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.knjizenjeDokDataGridViewTextBoxColumn});
            this.dgvIzdatnice.DataSource = this.izdatnicaBindingSource;
            this.dgvIzdatnice.Location = new System.Drawing.Point(12, 164);
            this.dgvIzdatnice.Name = "dgvIzdatnice";
            this.dgvIzdatnice.Size = new System.Drawing.Size(828, 205);
            this.dgvIzdatnice.TabIndex = 23;
            this.dgvIzdatnice.SelectionChanged += new System.EventHandler(this.dgvIzdatnice_SelectionChanged);
            // 
            // idIzdatnicaDataGridViewTextBoxColumn
            // 
            this.idIzdatnicaDataGridViewTextBoxColumn.DataPropertyName = "IdIzdatnica";
            this.idIzdatnicaDataGridViewTextBoxColumn.HeaderText = "IdIzdatnica";
            this.idIzdatnicaDataGridViewTextBoxColumn.Name = "idIzdatnicaDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // bojaDataGridViewTextBoxColumn
            // 
            this.bojaDataGridViewTextBoxColumn.DataPropertyName = "boja";
            this.bojaDataGridViewTextBoxColumn.HeaderText = "boja";
            this.bojaDataGridViewTextBoxColumn.Name = "bojaDataGridViewTextBoxColumn";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // knjizenjeDokDataGridViewTextBoxColumn
            // 
            this.knjizenjeDokDataGridViewTextBoxColumn.DataPropertyName = "knjizenjeDok";
            this.knjizenjeDokDataGridViewTextBoxColumn.HeaderText = "knjizenjeDok";
            this.knjizenjeDokDataGridViewTextBoxColumn.Name = "knjizenjeDokDataGridViewTextBoxColumn";
            // 
            // izdatnicaBindingSource
            // 
            this.izdatnicaBindingSource.DataMember = "Izdatnica";
            this.izdatnicaBindingSource.DataSource = this.t23_EnigmaDataSet7;
            // 
            // t23_EnigmaDataSet7
            // 
            this.t23_EnigmaDataSet7.DataSetName = "T23_EnigmaDataSet7";
            this.t23_EnigmaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // izdatnicaTableAdapter
            // 
            this.izdatnicaTableAdapter.ClearBeforeFill = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnObrisi.Location = new System.Drawing.Point(564, 484);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(105, 39);
            this.btnObrisi.TabIndex = 43;
            this.btnObrisi.Text = "Obriši stavku";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // lblIzlaz
            // 
            this.lblIzlaz.AutoSize = true;
            this.lblIzlaz.Location = new System.Drawing.Point(747, 515);
            this.lblIzlaz.Name = "lblIzlaz";
            this.lblIzlaz.Size = new System.Drawing.Size(28, 13);
            this.lblIzlaz.TabIndex = 42;
            this.lblIzlaz.Text = "Izlaz";
            // 
            // picIzlaz
            // 
            this.picIzlaz.Image = ((System.Drawing.Image)(resources.GetObject("picIzlaz.Image")));
            this.picIzlaz.Location = new System.Drawing.Point(721, 432);
            this.picIzlaz.Name = "picIzlaz";
            this.picIzlaz.Size = new System.Drawing.Size(76, 71);
            this.picIzlaz.TabIndex = 41;
            this.picIzlaz.TabStop = false;
            this.picIzlaz.Click += new System.EventHandler(this.picIzlaz_Click);
            // 
            // btnNovaStavka
            // 
            this.btnNovaStavka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNovaStavka.Location = new System.Drawing.Point(564, 419);
            this.btnNovaStavka.Name = "btnNovaStavka";
            this.btnNovaStavka.Size = new System.Drawing.Size(105, 39);
            this.btnNovaStavka.TabIndex = 40;
            this.btnNovaStavka.Text = "Nova stavka";
            this.btnNovaStavka.UseVisualStyleBackColor = true;
            this.btnNovaStavka.Click += new System.EventHandler(this.btnNovaStavka_Click);
            // 
            // dgvStavkeIzdatnice
            // 
            this.dgvStavkeIzdatnice.AllowUserToAddRows = false;
            this.dgvStavkeIzdatnice.AllowUserToDeleteRows = false;
            this.dgvStavkeIzdatnice.AutoGenerateColumns = false;
            this.dgvStavkeIzdatnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeIzdatnice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArtiklaDataGridViewTextBoxColumn,
            this.idIzdatniceDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn});
            this.dgvStavkeIzdatnice.DataSource = this.stavkeIzdatniceBindingSource;
            this.dgvStavkeIzdatnice.Location = new System.Drawing.Point(25, 386);
            this.dgvStavkeIzdatnice.Name = "dgvStavkeIzdatnice";
            this.dgvStavkeIzdatnice.Size = new System.Drawing.Size(454, 174);
            this.dgvStavkeIzdatnice.TabIndex = 39;
            // 
            // idArtiklaDataGridViewTextBoxColumn
            // 
            this.idArtiklaDataGridViewTextBoxColumn.DataPropertyName = "idArtikla";
            this.idArtiklaDataGridViewTextBoxColumn.HeaderText = "idArtikla";
            this.idArtiklaDataGridViewTextBoxColumn.Name = "idArtiklaDataGridViewTextBoxColumn";
            // 
            // idIzdatniceDataGridViewTextBoxColumn
            // 
            this.idIzdatniceDataGridViewTextBoxColumn.DataPropertyName = "idIzdatnice";
            this.idIzdatniceDataGridViewTextBoxColumn.HeaderText = "idIzdatnice";
            this.idIzdatniceDataGridViewTextBoxColumn.Name = "idIzdatniceDataGridViewTextBoxColumn";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // stavkeIzdatniceBindingSource
            // 
            this.stavkeIzdatniceBindingSource.DataMember = "stavkeIzdatnice";
            this.stavkeIzdatniceBindingSource.DataSource = this.t23_EnigmaDataSet8;
            // 
            // t23_EnigmaDataSet8
            // 
            this.t23_EnigmaDataSet8.DataSetName = "T23_EnigmaDataSet8";
            this.t23_EnigmaDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stavkeIzdatniceTableAdapter
            // 
            this.stavkeIzdatniceTableAdapter.ClearBeforeFill = true;
            // 
            // formaIzdatnicaPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 572);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.lblIzlaz);
            this.Controls.Add(this.picIzlaz);
            this.Controls.Add(this.btnNovaStavka);
            this.Controls.Add(this.dgvStavkeIzdatnice);
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
            this.Controls.Add(this.lblDodaj);
            this.Controls.Add(this.picDodaj);
            this.Controls.Add(this.dgvIzdatnice);
            this.Name = "formaIzdatnicaPregled";
            this.Text = "formaIzdatnicaPregled";
            this.Load += new System.EventHandler(this.formaIzdatnicaPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDjelatnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObrisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProknjizi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDodaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzdatnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdatnicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_EnigmaDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeIzdatnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeIzdatniceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_EnigmaDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label lblDodaj;
        private System.Windows.Forms.PictureBox picDodaj;
        private System.Windows.Forms.DataGridView dgvIzdatnice;
        private T23_EnigmaDataSet7 t23_EnigmaDataSet7;
        private System.Windows.Forms.BindingSource izdatnicaBindingSource;
        private T23_EnigmaDataSet7TableAdapters.IzdatnicaTableAdapter izdatnicaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idIzdatnicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bojaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn knjizenjeDokDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label lblIzlaz;
        private System.Windows.Forms.PictureBox picIzlaz;
        private System.Windows.Forms.Button btnNovaStavka;
        private System.Windows.Forms.DataGridView dgvStavkeIzdatnice;
        private T23_EnigmaDataSet8 t23_EnigmaDataSet8;
        private System.Windows.Forms.BindingSource stavkeIzdatniceBindingSource;
        private T23_EnigmaDataSet8TableAdapters.stavkeIzdatniceTableAdapter stavkeIzdatniceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArtiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idIzdatniceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
    }
}