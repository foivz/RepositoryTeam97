namespace Compromplus_app
{
    partial class formaUtrosakPregled
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formaUtrosakPregled));
            this.dgvArtikl = new System.Windows.Forms.DataGridView();
            this.artiklBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.t23_EnigmaDataSet1 = new Compromplus_app.T23_EnigmaDataSet1();
            this.dgvUtrosak = new System.Windows.Forms.DataGridView();
            this.idUtrosakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idArtiklDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRepromaterijalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utrosakBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.utrosakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t23_EnigmaDataSet = new Compromplus_app.T23_EnigmaDataSet();
            this.lblNaslovniText = new System.Windows.Forms.Label();
            this.utrosakTableAdapter = new Compromplus_app.T23_EnigmaDataSet1TableAdapters.UtrosakTableAdapter();
            this.artiklTableAdapter = new Compromplus_app.T23_EnigmaDataSet1TableAdapters.ArtiklTableAdapter();
            this.dgvRepromaterijal = new System.Windows.Forms.DataGridView();
            this.repromaterijalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repromaterijalTableAdapter = new Compromplus_app.T23_EnigmaDataSet1TableAdapters.RepromaterijalTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIzlaz = new System.Windows.Forms.Label();
            this.picIzlaz = new System.Windows.Forms.PictureBox();
            this.picIzvjestaj = new System.Windows.Forms.PictureBox();
            this.picUtrosak = new System.Windows.Forms.PictureBox();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idArtiklDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRepromaterijalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velicinaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bojaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_EnigmaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtrosak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utrosakBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utrosakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_EnigmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepromaterijal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repromaterijalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzvjestaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUtrosak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArtikl
            // 
            this.dgvArtikl.AutoGenerateColumns = false;
            this.dgvArtikl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArtiklDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.bojaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.klasaDataGridViewTextBoxColumn});
            this.dgvArtikl.DataSource = this.artiklBindingSource1;
            this.dgvArtikl.Location = new System.Drawing.Point(167, 161);
            this.dgvArtikl.Name = "dgvArtikl";
            this.dgvArtikl.Size = new System.Drawing.Size(828, 157);
            this.dgvArtikl.TabIndex = 0;
            this.dgvArtikl.SelectionChanged += new System.EventHandler(this.dgvArtikl_SelectionChanged);
            // 
            // artiklBindingSource1
            // 
            this.artiklBindingSource1.DataMember = "Artikl";
            this.artiklBindingSource1.DataSource = this.t23_EnigmaDataSet1;
            // 
            // t23_EnigmaDataSet1
            // 
            this.t23_EnigmaDataSet1.DataSetName = "T23_EnigmaDataSet1";
            this.t23_EnigmaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvUtrosak
            // 
            this.dgvUtrosak.AutoGenerateColumns = false;
            this.dgvUtrosak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtrosak.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUtrosakDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn1,
            this.velicinaDataGridViewTextBoxColumn,
            this.idArtiklDataGridViewTextBoxColumn1,
            this.idRepromaterijalDataGridViewTextBoxColumn});
            this.dgvUtrosak.DataSource = this.utrosakBindingSource1;
            this.dgvUtrosak.Location = new System.Drawing.Point(167, 341);
            this.dgvUtrosak.Name = "dgvUtrosak";
            this.dgvUtrosak.Size = new System.Drawing.Size(575, 113);
            this.dgvUtrosak.TabIndex = 1;
            // 
            // idUtrosakDataGridViewTextBoxColumn
            // 
            this.idUtrosakDataGridViewTextBoxColumn.DataPropertyName = "IdUtrosak";
            this.idUtrosakDataGridViewTextBoxColumn.HeaderText = "IdUtrosak";
            this.idUtrosakDataGridViewTextBoxColumn.Name = "idUtrosakDataGridViewTextBoxColumn";
            // 
            // kolicinaDataGridViewTextBoxColumn1
            // 
            this.kolicinaDataGridViewTextBoxColumn1.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn1.HeaderText = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn1.Name = "kolicinaDataGridViewTextBoxColumn1";
            // 
            // velicinaDataGridViewTextBoxColumn
            // 
            this.velicinaDataGridViewTextBoxColumn.DataPropertyName = "velicina";
            this.velicinaDataGridViewTextBoxColumn.HeaderText = "velicina";
            this.velicinaDataGridViewTextBoxColumn.Name = "velicinaDataGridViewTextBoxColumn";
            // 
            // idArtiklDataGridViewTextBoxColumn1
            // 
            this.idArtiklDataGridViewTextBoxColumn1.DataPropertyName = "IdArtikl";
            this.idArtiklDataGridViewTextBoxColumn1.HeaderText = "IdArtikl";
            this.idArtiklDataGridViewTextBoxColumn1.Name = "idArtiklDataGridViewTextBoxColumn1";
            // 
            // idRepromaterijalDataGridViewTextBoxColumn
            // 
            this.idRepromaterijalDataGridViewTextBoxColumn.DataPropertyName = "IdRepromaterijal";
            this.idRepromaterijalDataGridViewTextBoxColumn.HeaderText = "IdRepromaterijal";
            this.idRepromaterijalDataGridViewTextBoxColumn.Name = "idRepromaterijalDataGridViewTextBoxColumn";
            // 
            // utrosakBindingSource1
            // 
            this.utrosakBindingSource1.DataMember = "Utrosak";
            this.utrosakBindingSource1.DataSource = this.utrosakBindingSource;
            // 
            // utrosakBindingSource
            // 
            this.utrosakBindingSource.DataSource = this.t23_EnigmaDataSet1;
            this.utrosakBindingSource.Position = 0;
            // 
            // t23_EnigmaDataSet
            // 
            this.t23_EnigmaDataSet.DataSetName = "T23_EnigmaDataSet";
            this.t23_EnigmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblNaslovniText
            // 
            this.lblNaslovniText.AutoSize = true;
            this.lblNaslovniText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.lblNaslovniText.Location = new System.Drawing.Point(100, 62);
            this.lblNaslovniText.Name = "lblNaslovniText";
            this.lblNaslovniText.Size = new System.Drawing.Size(131, 38);
            this.lblNaslovniText.TabIndex = 23;
            this.lblNaslovniText.Text = "Utrošak";
            // 
            // utrosakTableAdapter
            // 
            this.utrosakTableAdapter.ClearBeforeFill = true;
            // 
            // artiklTableAdapter
            // 
            this.artiklTableAdapter.ClearBeforeFill = true;
            // 
            // dgvRepromaterijal
            // 
            this.dgvRepromaterijal.AutoGenerateColumns = false;
            this.dgvRepromaterijal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepromaterijal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRepromaterijalDataGridViewTextBoxColumn1,
            this.nazivDataGridViewTextBoxColumn1,
            this.opisDataGridViewTextBoxColumn1,
            this.kolicinaDataGridViewTextBoxColumn2,
            this.velicinaDataGridViewTextBoxColumn1,
            this.barkodDataGridViewTextBoxColumn,
            this.bojaDataGridViewTextBoxColumn1});
            this.dgvRepromaterijal.DataSource = this.repromaterijalBindingSource;
            this.dgvRepromaterijal.Location = new System.Drawing.Point(167, 471);
            this.dgvRepromaterijal.Name = "dgvRepromaterijal";
            this.dgvRepromaterijal.Size = new System.Drawing.Size(809, 119);
            this.dgvRepromaterijal.TabIndex = 24;
            // 
            // repromaterijalBindingSource
            // 
            this.repromaterijalBindingSource.DataMember = "Repromaterijal";
            this.repromaterijalBindingSource.DataSource = this.utrosakBindingSource;
            // 
            // repromaterijalTableAdapter
            // 
            this.repromaterijalTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Izvještaj";
            // 
            // lblIzlaz
            // 
            this.lblIzlaz.AutoSize = true;
            this.lblIzlaz.Location = new System.Drawing.Point(970, 103);
            this.lblIzlaz.Name = "lblIzlaz";
            this.lblIzlaz.Size = new System.Drawing.Size(28, 13);
            this.lblIzlaz.TabIndex = 55;
            this.lblIzlaz.Text = "Izlaz";
            // 
            // picIzlaz
            // 
            this.picIzlaz.Image = ((System.Drawing.Image)(resources.GetObject("picIzlaz.Image")));
            this.picIzlaz.Location = new System.Drawing.Point(944, 29);
            this.picIzlaz.Name = "picIzlaz";
            this.picIzlaz.Size = new System.Drawing.Size(76, 71);
            this.picIzlaz.TabIndex = 54;
            this.picIzlaz.TabStop = false;
            this.picIzlaz.Click += new System.EventHandler(this.picIzlaz_Click);
            // 
            // picIzvjestaj
            // 
            this.picIzvjestaj.BackColor = System.Drawing.Color.Transparent;
            this.picIzvjestaj.Image = global::Compromplus_app.Properties.Resources.grey_new_seo_43_512;
            this.picIzvjestaj.Location = new System.Drawing.Point(40, 175);
            this.picIzvjestaj.Name = "picIzvjestaj";
            this.picIzvjestaj.Size = new System.Drawing.Size(83, 71);
            this.picIzvjestaj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIzvjestaj.TabIndex = 52;
            this.picIzvjestaj.TabStop = false;
            this.picIzvjestaj.Click += new System.EventHandler(this.picIzvjestaj_Click);
            // 
            // picUtrosak
            // 
            this.picUtrosak.BackgroundImage = global::Compromplus_app.Properties.Resources.Text_Document_icon;
            this.picUtrosak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUtrosak.ErrorImage = global::Compromplus_app.Properties.Resources.Text_Document_icon;
            this.picUtrosak.Image = global::Compromplus_app.Properties.Resources.Text_Document_icon;
            this.picUtrosak.Location = new System.Drawing.Point(12, 45);
            this.picUtrosak.Name = "picUtrosak";
            this.picUtrosak.Size = new System.Drawing.Size(70, 67);
            this.picUtrosak.TabIndex = 25;
            this.picUtrosak.TabStop = false;
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
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.Width = 250;
            // 
            // bojaDataGridViewTextBoxColumn
            // 
            this.bojaDataGridViewTextBoxColumn.DataPropertyName = "boja";
            this.bojaDataGridViewTextBoxColumn.HeaderText = "Boja";
            this.bojaDataGridViewTextBoxColumn.Name = "bojaDataGridViewTextBoxColumn";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // klasaDataGridViewTextBoxColumn
            // 
            this.klasaDataGridViewTextBoxColumn.DataPropertyName = "klasa";
            this.klasaDataGridViewTextBoxColumn.HeaderText = "Klasa";
            this.klasaDataGridViewTextBoxColumn.Name = "klasaDataGridViewTextBoxColumn";
            // 
            // idRepromaterijalDataGridViewTextBoxColumn1
            // 
            this.idRepromaterijalDataGridViewTextBoxColumn1.DataPropertyName = "IdRepromaterijal";
            this.idRepromaterijalDataGridViewTextBoxColumn1.HeaderText = "IdRepromaterijal";
            this.idRepromaterijalDataGridViewTextBoxColumn1.Name = "idRepromaterijalDataGridViewTextBoxColumn1";
            // 
            // nazivDataGridViewTextBoxColumn1
            // 
            this.nazivDataGridViewTextBoxColumn1.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn1.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn1.Name = "nazivDataGridViewTextBoxColumn1";
            // 
            // opisDataGridViewTextBoxColumn1
            // 
            this.opisDataGridViewTextBoxColumn1.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn1.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn1.Name = "opisDataGridViewTextBoxColumn1";
            this.opisDataGridViewTextBoxColumn1.Width = 150;
            // 
            // kolicinaDataGridViewTextBoxColumn2
            // 
            this.kolicinaDataGridViewTextBoxColumn2.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn2.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn2.Name = "kolicinaDataGridViewTextBoxColumn2";
            // 
            // velicinaDataGridViewTextBoxColumn1
            // 
            this.velicinaDataGridViewTextBoxColumn1.DataPropertyName = "velicina";
            this.velicinaDataGridViewTextBoxColumn1.HeaderText = "Velicina";
            this.velicinaDataGridViewTextBoxColumn1.Name = "velicinaDataGridViewTextBoxColumn1";
            // 
            // barkodDataGridViewTextBoxColumn
            // 
            this.barkodDataGridViewTextBoxColumn.DataPropertyName = "barkod";
            this.barkodDataGridViewTextBoxColumn.HeaderText = "Barkod";
            this.barkodDataGridViewTextBoxColumn.Name = "barkodDataGridViewTextBoxColumn";
            // 
            // bojaDataGridViewTextBoxColumn1
            // 
            this.bojaDataGridViewTextBoxColumn1.DataPropertyName = "boja";
            this.bojaDataGridViewTextBoxColumn1.HeaderText = "Boja";
            this.bojaDataGridViewTextBoxColumn1.Name = "bojaDataGridViewTextBoxColumn1";
            // 
            // formaUtrosakPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 602);
            this.Controls.Add(this.lblIzlaz);
            this.Controls.Add(this.picIzlaz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picIzvjestaj);
            this.Controls.Add(this.picUtrosak);
            this.Controls.Add(this.dgvRepromaterijal);
            this.Controls.Add(this.lblNaslovniText);
            this.Controls.Add(this.dgvUtrosak);
            this.Controls.Add(this.dgvArtikl);
            this.Name = "formaUtrosakPregled";
            this.Text = "formaUtrosakPregled";
            this.Load += new System.EventHandler(this.formaUtrosakPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_EnigmaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtrosak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utrosakBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utrosakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_EnigmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepromaterijal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repromaterijalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzvjestaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUtrosak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArtikl;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private System.Windows.Forms.DataGridView dgvUtrosak;
        private System.Windows.Forms.BindingSource utrosakBindingSource;
        private T23_EnigmaDataSet1 t23_EnigmaDataSet1;
        private T23_EnigmaDataSet t23_EnigmaDataSet;
        private System.Windows.Forms.BindingSource utrosakBindingSource1;
        private T23_EnigmaDataSet1TableAdapters.UtrosakTableAdapter utrosakTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUtrosakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn velicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArtiklDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRepromaterijalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblNaslovniText;
        private System.Windows.Forms.BindingSource artiklBindingSource1;
        private T23_EnigmaDataSet1TableAdapters.ArtiklTableAdapter artiklTableAdapter;
        private System.Windows.Forms.DataGridView dgvRepromaterijal;
        private System.Windows.Forms.BindingSource repromaterijalBindingSource;
        private T23_EnigmaDataSet1TableAdapters.RepromaterijalTableAdapter repromaterijalTableAdapter;
        private System.Windows.Forms.PictureBox picUtrosak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picIzvjestaj;
        private System.Windows.Forms.Label lblIzlaz;
        private System.Windows.Forms.PictureBox picIzlaz;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArtiklDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bojaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRepromaterijalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn velicinaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bojaDataGridViewTextBoxColumn1;
    }
}