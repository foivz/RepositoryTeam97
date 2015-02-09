namespace Compromplus_app
{
    partial class formaRepromaterijaliPregled
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formaRepromaterijaliPregled));
            this.lblNaslovniText = new System.Windows.Forms.Label();
            this.lblIzlaz = new System.Windows.Forms.Label();
            this.lblObrisi = new System.Windows.Forms.Label();
            this.lblIzmjeni = new System.Windows.Forms.Label();
            this.lblDodaj = new System.Windows.Forms.Label();
            this.dgvRepromaterijali = new System.Windows.Forms.DataGridView();
            this.btnPretrazivanjeSifra = new System.Windows.Forms.Button();
            this.txtPretrazivanjeSifra = new System.Windows.Forms.TextBox();
            this.lblPretrazivanjeSifra = new System.Windows.Forms.Label();
            this.txtPretrazivanje = new System.Windows.Forms.TextBox();
            this.lblPretrazivanje = new System.Windows.Forms.Label();
            this.t23_EnigmaDataSet = new Compromplus_app.T23_EnigmaDataSet();
            this.t23EnigmaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t23_EnigmaDataSet3 = new Compromplus_app.T23_EnigmaDataSet3();
            this.repromaterijalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repromaterijalTableAdapter = new Compromplus_app.T23_EnigmaDataSet3TableAdapters.RepromaterijalTableAdapter();
            this.idRepromaterijalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picArtikli = new System.Windows.Forms.PictureBox();
            this.picIzlaz = new System.Windows.Forms.PictureBox();
            this.picObrisi = new System.Windows.Forms.PictureBox();
            this.picIzmjeni = new System.Windows.Forms.PictureBox();
            this.picDodaj = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepromaterijali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_EnigmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23EnigmaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_EnigmaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repromaterijalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObrisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzmjeni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDodaj)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslovniText
            // 
            this.lblNaslovniText.AutoSize = true;
            this.lblNaslovniText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.lblNaslovniText.Location = new System.Drawing.Point(117, 60);
            this.lblNaslovniText.Name = "lblNaslovniText";
            this.lblNaslovniText.Size = new System.Drawing.Size(235, 38);
            this.lblNaslovniText.TabIndex = 37;
            this.lblNaslovniText.Text = "Repromaterijali";
            // 
            // lblIzlaz
            // 
            this.lblIzlaz.AutoSize = true;
            this.lblIzlaz.Location = new System.Drawing.Point(779, 147);
            this.lblIzlaz.Name = "lblIzlaz";
            this.lblIzlaz.Size = new System.Drawing.Size(28, 13);
            this.lblIzlaz.TabIndex = 36;
            this.lblIzlaz.Text = "Izlaz";
            // 
            // lblObrisi
            // 
            this.lblObrisi.AutoSize = true;
            this.lblObrisi.Location = new System.Drawing.Point(658, 147);
            this.lblObrisi.Name = "lblObrisi";
            this.lblObrisi.Size = new System.Drawing.Size(98, 13);
            this.lblObrisi.TabIndex = 34;
            this.lblObrisi.Text = "Obriši repromaterijal";
            // 
            // lblIzmjeni
            // 
            this.lblIzmjeni.AutoSize = true;
            this.lblIzmjeni.Location = new System.Drawing.Point(550, 147);
            this.lblIzmjeni.Name = "lblIzmjeni";
            this.lblIzmjeni.Size = new System.Drawing.Size(104, 13);
            this.lblIzmjeni.TabIndex = 32;
            this.lblIzmjeni.Text = "Izmjeni repromaterijal";
            // 
            // lblDodaj
            // 
            this.lblDodaj.AutoSize = true;
            this.lblDodaj.Location = new System.Drawing.Point(429, 147);
            this.lblDodaj.Name = "lblDodaj";
            this.lblDodaj.Size = new System.Drawing.Size(100, 13);
            this.lblDodaj.TabIndex = 30;
            this.lblDodaj.Text = "Dodaj repromaterijal";
            // 
            // dgvRepromaterijali
            // 
            this.dgvRepromaterijali.AllowUserToAddRows = false;
            this.dgvRepromaterijali.AllowUserToDeleteRows = false;
            this.dgvRepromaterijali.AutoGenerateColumns = false;
            this.dgvRepromaterijali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepromaterijali.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRepromaterijalDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.velicinaDataGridViewTextBoxColumn,
            this.barkodDataGridViewTextBoxColumn,
            this.bojaDataGridViewTextBoxColumn});
            this.dgvRepromaterijali.DataSource = this.repromaterijalBindingSource;
            this.dgvRepromaterijali.Location = new System.Drawing.Point(52, 224);
            this.dgvRepromaterijali.Name = "dgvRepromaterijali";
            this.dgvRepromaterijali.Size = new System.Drawing.Size(803, 212);
            this.dgvRepromaterijali.TabIndex = 28;
            // 
            // btnPretrazivanjeSifra
            // 
            this.btnPretrazivanjeSifra.Location = new System.Drawing.Point(753, 183);
            this.btnPretrazivanjeSifra.Name = "btnPretrazivanjeSifra";
            this.btnPretrazivanjeSifra.Size = new System.Drawing.Size(75, 26);
            this.btnPretrazivanjeSifra.TabIndex = 27;
            this.btnPretrazivanjeSifra.Text = "Traži";
            this.btnPretrazivanjeSifra.UseVisualStyleBackColor = true;
            this.btnPretrazivanjeSifra.Click += new System.EventHandler(this.btnPretrazivanjeSifra_Click);
            // 
            // txtPretrazivanjeSifra
            // 
            this.txtPretrazivanjeSifra.Location = new System.Drawing.Point(578, 186);
            this.txtPretrazivanjeSifra.Name = "txtPretrazivanjeSifra";
            this.txtPretrazivanjeSifra.Size = new System.Drawing.Size(100, 20);
            this.txtPretrazivanjeSifra.TabIndex = 26;
            // 
            // lblPretrazivanjeSifra
            // 
            this.lblPretrazivanjeSifra.AutoSize = true;
            this.lblPretrazivanjeSifra.Location = new System.Drawing.Point(443, 189);
            this.lblPretrazivanjeSifra.Name = "lblPretrazivanjeSifra";
            this.lblPretrazivanjeSifra.Size = new System.Drawing.Size(118, 13);
            this.lblPretrazivanjeSifra.TabIndex = 25;
            this.lblPretrazivanjeSifra.Text = "Pretraživanje prema šifri";
            // 
            // txtPretrazivanje
            // 
            this.txtPretrazivanje.Location = new System.Drawing.Point(137, 189);
            this.txtPretrazivanje.Name = "txtPretrazivanje";
            this.txtPretrazivanje.Size = new System.Drawing.Size(178, 20);
            this.txtPretrazivanje.TabIndex = 24;
            this.txtPretrazivanje.TextChanged += new System.EventHandler(this.txtPretrazivanje_TextChanged);
            // 
            // lblPretrazivanje
            // 
            this.lblPretrazivanje.AutoSize = true;
            this.lblPretrazivanje.Location = new System.Drawing.Point(49, 192);
            this.lblPretrazivanje.Name = "lblPretrazivanje";
            this.lblPretrazivanje.Size = new System.Drawing.Size(68, 13);
            this.lblPretrazivanje.TabIndex = 23;
            this.lblPretrazivanje.Text = "Pretraživanje";
            // 
            // t23_EnigmaDataSet
            // 
            this.t23_EnigmaDataSet.DataSetName = "T23_EnigmaDataSet";
            this.t23_EnigmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t23EnigmaDataSetBindingSource
            // 
            this.t23EnigmaDataSetBindingSource.DataSource = this.t23_EnigmaDataSet;
            this.t23EnigmaDataSetBindingSource.Position = 0;
            // 
            // t23_EnigmaDataSet3
            // 
            this.t23_EnigmaDataSet3.DataSetName = "T23_EnigmaDataSet3";
            this.t23_EnigmaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repromaterijalBindingSource
            // 
            this.repromaterijalBindingSource.DataMember = "Repromaterijal";
            this.repromaterijalBindingSource.DataSource = this.t23_EnigmaDataSet3;
            // 
            // repromaterijalTableAdapter
            // 
            this.repromaterijalTableAdapter.ClearBeforeFill = true;
            // 
            // idRepromaterijalDataGridViewTextBoxColumn
            // 
            this.idRepromaterijalDataGridViewTextBoxColumn.DataPropertyName = "IdRepromaterijal";
            this.idRepromaterijalDataGridViewTextBoxColumn.HeaderText = "IdRepromaterijal";
            this.idRepromaterijalDataGridViewTextBoxColumn.Name = "idRepromaterijalDataGridViewTextBoxColumn";
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
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // velicinaDataGridViewTextBoxColumn
            // 
            this.velicinaDataGridViewTextBoxColumn.DataPropertyName = "velicina";
            this.velicinaDataGridViewTextBoxColumn.HeaderText = "velicina";
            this.velicinaDataGridViewTextBoxColumn.Name = "velicinaDataGridViewTextBoxColumn";
            // 
            // barkodDataGridViewTextBoxColumn
            // 
            this.barkodDataGridViewTextBoxColumn.DataPropertyName = "barkod";
            this.barkodDataGridViewTextBoxColumn.HeaderText = "barkod";
            this.barkodDataGridViewTextBoxColumn.Name = "barkodDataGridViewTextBoxColumn";
            // 
            // bojaDataGridViewTextBoxColumn
            // 
            this.bojaDataGridViewTextBoxColumn.DataPropertyName = "boja";
            this.bojaDataGridViewTextBoxColumn.HeaderText = "boja";
            this.bojaDataGridViewTextBoxColumn.Name = "bojaDataGridViewTextBoxColumn";
            // 
            // picArtikli
            // 
            this.picArtikli.BackgroundImage = global::Compromplus_app.Properties.Resources._20714;
            this.picArtikli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picArtikli.Location = new System.Drawing.Point(31, 42);
            this.picArtikli.Name = "picArtikli";
            this.picArtikli.Size = new System.Drawing.Size(70, 67);
            this.picArtikli.TabIndex = 38;
            this.picArtikli.TabStop = false;
            // 
            // picIzlaz
            // 
            this.picIzlaz.Image = ((System.Drawing.Image)(resources.GetObject("picIzlaz.Image")));
            this.picIzlaz.Location = new System.Drawing.Point(768, 60);
            this.picIzlaz.Name = "picIzlaz";
            this.picIzlaz.Size = new System.Drawing.Size(76, 71);
            this.picIzlaz.TabIndex = 35;
            this.picIzlaz.TabStop = false;
            this.picIzlaz.Click += new System.EventHandler(this.picIzlaz_Click);
            // 
            // picObrisi
            // 
            this.picObrisi.Image = ((System.Drawing.Image)(resources.GetObject("picObrisi.Image")));
            this.picObrisi.Location = new System.Drawing.Point(661, 60);
            this.picObrisi.Name = "picObrisi";
            this.picObrisi.Size = new System.Drawing.Size(76, 71);
            this.picObrisi.TabIndex = 33;
            this.picObrisi.TabStop = false;
            // 
            // picIzmjeni
            // 
            this.picIzmjeni.Image = ((System.Drawing.Image)(resources.GetObject("picIzmjeni.Image")));
            this.picIzmjeni.Location = new System.Drawing.Point(553, 60);
            this.picIzmjeni.Name = "picIzmjeni";
            this.picIzmjeni.Size = new System.Drawing.Size(76, 71);
            this.picIzmjeni.TabIndex = 31;
            this.picIzmjeni.TabStop = false;
            this.picIzmjeni.Click += new System.EventHandler(this.picIzmjeni_Click);
            // 
            // picDodaj
            // 
            this.picDodaj.Image = ((System.Drawing.Image)(resources.GetObject("picDodaj.Image")));
            this.picDodaj.Location = new System.Drawing.Point(432, 60);
            this.picDodaj.Name = "picDodaj";
            this.picDodaj.Size = new System.Drawing.Size(76, 71);
            this.picDodaj.TabIndex = 29;
            this.picDodaj.TabStop = false;
            this.picDodaj.Click += new System.EventHandler(this.picDodaj_Click);
            // 
            // formaRepromaterijaliPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 477);
            this.Controls.Add(this.picArtikli);
            this.Controls.Add(this.lblNaslovniText);
            this.Controls.Add(this.lblIzlaz);
            this.Controls.Add(this.picIzlaz);
            this.Controls.Add(this.lblObrisi);
            this.Controls.Add(this.picObrisi);
            this.Controls.Add(this.lblIzmjeni);
            this.Controls.Add(this.picIzmjeni);
            this.Controls.Add(this.lblDodaj);
            this.Controls.Add(this.picDodaj);
            this.Controls.Add(this.dgvRepromaterijali);
            this.Controls.Add(this.btnPretrazivanjeSifra);
            this.Controls.Add(this.txtPretrazivanjeSifra);
            this.Controls.Add(this.lblPretrazivanjeSifra);
            this.Controls.Add(this.txtPretrazivanje);
            this.Controls.Add(this.lblPretrazivanje);
            this.Name = "formaRepromaterijaliPregled";
            this.Text = "formaRepromaterijaliPregled";
            this.Load += new System.EventHandler(this.formaRepromaterijaliPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepromaterijali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_EnigmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23EnigmaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_EnigmaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repromaterijalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObrisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzmjeni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDodaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picArtikli;
        private System.Windows.Forms.Label lblNaslovniText;
        private System.Windows.Forms.Label lblIzlaz;
        private System.Windows.Forms.PictureBox picIzlaz;
        private System.Windows.Forms.Label lblObrisi;
        private System.Windows.Forms.PictureBox picObrisi;
        private System.Windows.Forms.Label lblIzmjeni;
        private System.Windows.Forms.PictureBox picIzmjeni;
        private System.Windows.Forms.Label lblDodaj;
        private System.Windows.Forms.PictureBox picDodaj;
        private System.Windows.Forms.DataGridView dgvRepromaterijali;
        private System.Windows.Forms.BindingSource t23EnigmaDataSetBindingSource;
        private T23_EnigmaDataSet t23_EnigmaDataSet;
        private System.Windows.Forms.Button btnPretrazivanjeSifra;
        private System.Windows.Forms.TextBox txtPretrazivanjeSifra;
        private System.Windows.Forms.Label lblPretrazivanjeSifra;
        private System.Windows.Forms.TextBox txtPretrazivanje;
        private System.Windows.Forms.Label lblPretrazivanje;
        private T23_EnigmaDataSet3 t23_EnigmaDataSet3;
        private System.Windows.Forms.BindingSource repromaterijalBindingSource;
        private T23_EnigmaDataSet3TableAdapters.RepromaterijalTableAdapter repromaterijalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRepromaterijalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn velicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bojaDataGridViewTextBoxColumn;
    }
}