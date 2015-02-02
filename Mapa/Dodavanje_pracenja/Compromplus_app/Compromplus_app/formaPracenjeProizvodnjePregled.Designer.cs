namespace Compromplus_app
{
    partial class formaPracenjeProizvodnjePregled
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formaPracenjeProizvodnjePregled));
            this.lblNaslovniText = new System.Windows.Forms.Label();
            this.dvgPracenje = new System.Windows.Forms.DataGridView();
            this.txtPretrazivanje = new System.Windows.Forms.TextBox();
            this.lblPretrazivanje = new System.Windows.Forms.Label();
            this.dvgArtikli = new System.Windows.Forms.DataGridView();
            this.dvgStroj = new System.Windows.Forms.DataGridView();
            this.dvgDjelatnici = new System.Windows.Forms.DataGridView();
            this.picDodaj = new System.Windows.Forms.PictureBox();
            this.lblIzlaz = new System.Windows.Forms.Label();
            this.picIzlaz = new System.Windows.Forms.PictureBox();
            this.lblObrisi = new System.Windows.Forms.Label();
            this.picObrisi = new System.Windows.Forms.PictureBox();
            this.lblIzmjeni = new System.Windows.Forms.Label();
            this.picIzmjeni = new System.Windows.Forms.PictureBox();
            this.lblDodaj = new System.Windows.Forms.Label();
            this.t23_EnigmaDataSet1 = new Compromplus_app.T23_EnigmaDataSet1();
            this.pracenjeProizvodnjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pracenjeProizvodnjeTableAdapter = new Compromplus_app.T23_EnigmaDataSet1TableAdapters.PracenjeProizvodnjeTableAdapter();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strojidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.djelatnikidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artiklidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picPracenje = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPracenje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgStroj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDjelatnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDodaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObrisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzmjeni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_EnigmaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracenjeProizvodnjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPracenje)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslovniText
            // 
            this.lblNaslovniText.AutoSize = true;
            this.lblNaslovniText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.lblNaslovniText.Location = new System.Drawing.Point(102, 35);
            this.lblNaslovniText.Name = "lblNaslovniText";
            this.lblNaslovniText.Size = new System.Drawing.Size(322, 38);
            this.lblNaslovniText.TabIndex = 38;
            this.lblNaslovniText.Text = "Praćenje proizvodnje";
            // 
            // dvgPracenje
            // 
            this.dvgPracenje.AutoGenerateColumns = false;
            this.dvgPracenje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPracenje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.strojidDataGridViewTextBoxColumn,
            this.djelatnikidDataGridViewTextBoxColumn,
            this.artiklidDataGridViewTextBoxColumn});
            this.dvgPracenje.DataSource = this.pracenjeProizvodnjeBindingSource;
            this.dvgPracenje.Location = new System.Drawing.Point(55, 166);
            this.dvgPracenje.Name = "dvgPracenje";
            this.dvgPracenje.Size = new System.Drawing.Size(744, 185);
            this.dvgPracenje.TabIndex = 39;
            // 
            // txtPretrazivanje
            // 
            this.txtPretrazivanje.Location = new System.Drawing.Point(153, 120);
            this.txtPretrazivanje.Name = "txtPretrazivanje";
            this.txtPretrazivanje.Size = new System.Drawing.Size(178, 20);
            this.txtPretrazivanje.TabIndex = 41;
            // 
            // lblPretrazivanje
            // 
            this.lblPretrazivanje.AutoSize = true;
            this.lblPretrazivanje.Location = new System.Drawing.Point(52, 120);
            this.lblPretrazivanje.Name = "lblPretrazivanje";
            this.lblPretrazivanje.Size = new System.Drawing.Size(68, 13);
            this.lblPretrazivanje.TabIndex = 40;
            this.lblPretrazivanje.Text = "Pretraživanje";
            // 
            // dvgArtikli
            // 
            this.dvgArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgArtikli.Location = new System.Drawing.Point(36, 382);
            this.dvgArtikli.Name = "dvgArtikli";
            this.dvgArtikli.Size = new System.Drawing.Size(240, 126);
            this.dvgArtikli.TabIndex = 42;
            // 
            // dvgStroj
            // 
            this.dvgStroj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgStroj.Location = new System.Drawing.Point(569, 382);
            this.dvgStroj.Name = "dvgStroj";
            this.dvgStroj.Size = new System.Drawing.Size(240, 126);
            this.dvgStroj.TabIndex = 43;
            // 
            // dvgDjelatnici
            // 
            this.dvgDjelatnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDjelatnici.Location = new System.Drawing.Point(308, 382);
            this.dvgDjelatnici.Name = "dvgDjelatnici";
            this.dvgDjelatnici.Size = new System.Drawing.Size(240, 126);
            this.dvgDjelatnici.TabIndex = 44;
            // 
            // picDodaj
            // 
            this.picDodaj.Image = ((System.Drawing.Image)(resources.GetObject("picDodaj.Image")));
            this.picDodaj.Location = new System.Drawing.Point(448, 18);
            this.picDodaj.Name = "picDodaj";
            this.picDodaj.Size = new System.Drawing.Size(76, 71);
            this.picDodaj.TabIndex = 45;
            this.picDodaj.TabStop = false;
            this.picDodaj.Click += new System.EventHandler(this.picDodaj_Click);
            // 
            // lblIzlaz
            // 
            this.lblIzlaz.AutoSize = true;
            this.lblIzlaz.Location = new System.Drawing.Point(771, 92);
            this.lblIzlaz.Name = "lblIzlaz";
            this.lblIzlaz.Size = new System.Drawing.Size(28, 13);
            this.lblIzlaz.TabIndex = 51;
            this.lblIzlaz.Text = "Izlaz";
            // 
            // picIzlaz
            // 
            this.picIzlaz.Image = ((System.Drawing.Image)(resources.GetObject("picIzlaz.Image")));
            this.picIzlaz.Location = new System.Drawing.Point(748, 18);
            this.picIzlaz.Name = "picIzlaz";
            this.picIzlaz.Size = new System.Drawing.Size(76, 71);
            this.picIzlaz.TabIndex = 50;
            this.picIzlaz.TabStop = false;
            // 
            // lblObrisi
            // 
            this.lblObrisi.AutoSize = true;
            this.lblObrisi.Location = new System.Drawing.Point(657, 92);
            this.lblObrisi.Name = "lblObrisi";
            this.lblObrisi.Size = new System.Drawing.Size(36, 13);
            this.lblObrisi.TabIndex = 49;
            this.lblObrisi.Text = "Obriši ";
            // 
            // picObrisi
            // 
            this.picObrisi.Image = ((System.Drawing.Image)(resources.GetObject("picObrisi.Image")));
            this.picObrisi.Location = new System.Drawing.Point(643, 18);
            this.picObrisi.Name = "picObrisi";
            this.picObrisi.Size = new System.Drawing.Size(76, 71);
            this.picObrisi.TabIndex = 48;
            this.picObrisi.TabStop = false;
            // 
            // lblIzmjeni
            // 
            this.lblIzmjeni.AutoSize = true;
            this.lblIzmjeni.Location = new System.Drawing.Point(562, 92);
            this.lblIzmjeni.Name = "lblIzmjeni";
            this.lblIzmjeni.Size = new System.Drawing.Size(42, 13);
            this.lblIzmjeni.TabIndex = 47;
            this.lblIzmjeni.Text = "Izmjeni ";
            // 
            // picIzmjeni
            // 
            this.picIzmjeni.Image = ((System.Drawing.Image)(resources.GetObject("picIzmjeni.Image")));
            this.picIzmjeni.Location = new System.Drawing.Point(547, 18);
            this.picIzmjeni.Name = "picIzmjeni";
            this.picIzmjeni.Size = new System.Drawing.Size(76, 71);
            this.picIzmjeni.TabIndex = 46;
            this.picIzmjeni.TabStop = false;
            // 
            // lblDodaj
            // 
            this.lblDodaj.AutoSize = true;
            this.lblDodaj.Location = new System.Drawing.Point(467, 92);
            this.lblDodaj.Name = "lblDodaj";
            this.lblDodaj.Size = new System.Drawing.Size(38, 13);
            this.lblDodaj.TabIndex = 52;
            this.lblDodaj.Text = "Dodaj ";
            // 
            // t23_EnigmaDataSet1
            // 
            this.t23_EnigmaDataSet1.DataSetName = "T23_EnigmaDataSet1";
            this.t23_EnigmaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pracenjeProizvodnjeBindingSource
            // 
            this.pracenjeProizvodnjeBindingSource.DataMember = "PracenjeProizvodnje";
            this.pracenjeProizvodnjeBindingSource.DataSource = this.t23_EnigmaDataSet1;
            // 
            // pracenjeProizvodnjeTableAdapter
            // 
            this.pracenjeProizvodnjeTableAdapter.ClearBeforeFill = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
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
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // strojidDataGridViewTextBoxColumn
            // 
            this.strojidDataGridViewTextBoxColumn.DataPropertyName = "stroj_id";
            this.strojidDataGridViewTextBoxColumn.HeaderText = "stroj_id";
            this.strojidDataGridViewTextBoxColumn.Name = "strojidDataGridViewTextBoxColumn";
            // 
            // djelatnikidDataGridViewTextBoxColumn
            // 
            this.djelatnikidDataGridViewTextBoxColumn.DataPropertyName = "djelatnik_id";
            this.djelatnikidDataGridViewTextBoxColumn.HeaderText = "djelatnik_id";
            this.djelatnikidDataGridViewTextBoxColumn.Name = "djelatnikidDataGridViewTextBoxColumn";
            // 
            // artiklidDataGridViewTextBoxColumn
            // 
            this.artiklidDataGridViewTextBoxColumn.DataPropertyName = "artikl_id";
            this.artiklidDataGridViewTextBoxColumn.HeaderText = "artikl_id";
            this.artiklidDataGridViewTextBoxColumn.Name = "artiklidDataGridViewTextBoxColumn";
            // 
            // picPracenje
            // 
            this.picPracenje.Image = ((System.Drawing.Image)(resources.GetObject("picPracenje.Image")));
            this.picPracenje.Location = new System.Drawing.Point(26, 22);
            this.picPracenje.Name = "picPracenje";
            this.picPracenje.Size = new System.Drawing.Size(70, 67);
            this.picPracenje.TabIndex = 53;
            this.picPracenje.TabStop = false;
            // 
            // formaPracenjeProizvodnjePregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 520);
            this.Controls.Add(this.picPracenje);
            this.Controls.Add(this.lblDodaj);
            this.Controls.Add(this.lblIzlaz);
            this.Controls.Add(this.picIzlaz);
            this.Controls.Add(this.lblObrisi);
            this.Controls.Add(this.picObrisi);
            this.Controls.Add(this.lblIzmjeni);
            this.Controls.Add(this.picIzmjeni);
            this.Controls.Add(this.picDodaj);
            this.Controls.Add(this.dvgDjelatnici);
            this.Controls.Add(this.dvgStroj);
            this.Controls.Add(this.dvgArtikli);
            this.Controls.Add(this.txtPretrazivanje);
            this.Controls.Add(this.lblPretrazivanje);
            this.Controls.Add(this.dvgPracenje);
            this.Controls.Add(this.lblNaslovniText);
            this.Name = "formaPracenjeProizvodnjePregled";
            this.Text = "formaPracenjeProizvodnjePregled";
            this.Load += new System.EventHandler(this.formaPracenjeProizvodnjePregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgPracenje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgStroj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDjelatnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDodaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObrisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzmjeni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_EnigmaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracenjeProizvodnjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPracenje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslovniText;
        private System.Windows.Forms.DataGridView dvgPracenje;
        private System.Windows.Forms.TextBox txtPretrazivanje;
        private System.Windows.Forms.Label lblPretrazivanje;
        private System.Windows.Forms.DataGridView dvgArtikli;
        private System.Windows.Forms.DataGridView dvgStroj;
        private System.Windows.Forms.DataGridView dvgDjelatnici;
        private System.Windows.Forms.PictureBox picDodaj;
        private System.Windows.Forms.Label lblIzlaz;
        private System.Windows.Forms.PictureBox picIzlaz;
        private System.Windows.Forms.Label lblObrisi;
        private System.Windows.Forms.PictureBox picObrisi;
        private System.Windows.Forms.Label lblIzmjeni;
        private System.Windows.Forms.PictureBox picIzmjeni;
        private System.Windows.Forms.Label lblDodaj;
        private T23_EnigmaDataSet1 t23_EnigmaDataSet1;
        private System.Windows.Forms.BindingSource pracenjeProizvodnjeBindingSource;
        private T23_EnigmaDataSet1TableAdapters.PracenjeProizvodnjeTableAdapter pracenjeProizvodnjeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strojidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn djelatnikidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artiklidDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox picPracenje;
    }
}