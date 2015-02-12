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
            this.dgvPracenje = new System.Windows.Forms.DataGridView();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStroj = new System.Windows.Forms.DataGridView();
            this.barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDjelatnik = new System.Windows.Forms.DataGridView();
            this.dgvArtikl = new System.Windows.Forms.DataGridView();
            this.lblNaslovniText = new System.Windows.Forms.Label();
            this.lblIzlaz = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPretrazivanjeSifra = new System.Windows.Forms.Button();
            this.txtPretrazivanjeSifra = new System.Windows.Forms.TextBox();
            this.lblPretrazivanjeSifra = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picIzvjestaj = new System.Windows.Forms.PictureBox();
            this.picIzlaz = new System.Windows.Forms.PictureBox();
            this.picPracenje = new System.Windows.Forms.PictureBox();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t23_EnigmaDataSet2 = new Compromplus_app.T23_EnigmaDataSet2();
            this.idDjelatnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strucnaSpremaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.djelatnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idStrojDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strojBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idPracenjeProizvodnjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idArtiklDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDjelatniciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStrojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pracenjeProizvodnjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pracenjeProizvodnjeTableAdapter = new Compromplus_app.T23_EnigmaDataSet2TableAdapters.PracenjeProizvodnjeTableAdapter();
            this.strojTableAdapter = new Compromplus_app.T23_EnigmaDataSet2TableAdapters.StrojTableAdapter();
            this.djelatnikTableAdapter = new Compromplus_app.T23_EnigmaDataSet2TableAdapters.DjelatnikTableAdapter();
            this.artiklTableAdapter = new Compromplus_app.T23_EnigmaDataSet2TableAdapters.ArtiklTableAdapter();
            this.tableAdapterManager1 = new Compromplus_app.T23_EnigmaDataSet2TableAdapters.TableAdapterManager();
            this.idArtiklDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracenje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStroj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDjelatnik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzvjestaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPracenje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_EnigmaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.djelatnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strojBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracenjeProizvodnjeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPracenje
            // 
            this.dgvPracenje.AutoGenerateColumns = false;
            this.dgvPracenje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPracenje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPracenjeProizvodnjeDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.velicinaDataGridViewTextBoxColumn,
            this.idArtiklDataGridViewTextBoxColumn,
            this.idDjelatniciDataGridViewTextBoxColumn,
            this.idStrojDataGridViewTextBoxColumn,
            this.datum});
            this.dgvPracenje.DataSource = this.pracenjeProizvodnjeBindingSource;
            this.dgvPracenje.Location = new System.Drawing.Point(149, 192);
            this.dgvPracenje.Name = "dgvPracenje";
            this.dgvPracenje.Size = new System.Drawing.Size(800, 248);
            this.dgvPracenje.TabIndex = 0;
            this.dgvPracenje.SelectionChanged += new System.EventHandler(this.dgvPracenje_SelectionChanged);
            // 
            // datum
            // 
            this.datum.DataPropertyName = "datum";
            this.datum.HeaderText = "datum";
            this.datum.Name = "datum";
            // 
            // dgvStroj
            // 
            this.dgvStroj.AutoGenerateColumns = false;
            this.dgvStroj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStroj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStrojDataGridViewTextBoxColumn1,
            this.nazivDataGridViewTextBoxColumn,
            this.barkod});
            this.dgvStroj.DataSource = this.strojBindingSource;
            this.dgvStroj.Location = new System.Drawing.Point(149, 592);
            this.dgvStroj.Name = "dgvStroj";
            this.dgvStroj.Size = new System.Drawing.Size(347, 78);
            this.dgvStroj.TabIndex = 1;
            this.dgvStroj.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStroj_CellContentClick);
            // 
            // barkod
            // 
            this.barkod.DataPropertyName = "barkod";
            this.barkod.HeaderText = "barkod";
            this.barkod.Name = "barkod";
            // 
            // dgvDjelatnik
            // 
            this.dgvDjelatnik.AutoGenerateColumns = false;
            this.dgvDjelatnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDjelatnik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDjelatnikDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.strucnaSpremaDataGridViewTextBoxColumn});
            this.dgvDjelatnik.DataSource = this.djelatnikBindingSource;
            this.dgvDjelatnik.Location = new System.Drawing.Point(149, 472);
            this.dgvDjelatnik.Name = "dgvDjelatnik";
            this.dgvDjelatnik.Size = new System.Drawing.Size(545, 80);
            this.dgvDjelatnik.TabIndex = 2;
            // 
            // dgvArtikl
            // 
            this.dgvArtikl.AutoGenerateColumns = false;
            this.dgvArtikl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArtiklDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.nazivDataGridViewTextBoxColumn1,
            this.opisDataGridViewTextBoxColumn,
            this.bojaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn1,
            this.klasaDataGridViewTextBoxColumn,
            this.velicina});
            this.dgvArtikl.DataSource = this.artiklBindingSource;
            this.dgvArtikl.Location = new System.Drawing.Point(149, 695);
            this.dgvArtikl.Name = "dgvArtikl";
            this.dgvArtikl.Size = new System.Drawing.Size(808, 66);
            this.dgvArtikl.TabIndex = 3;
            // 
            // lblNaslovniText
            // 
            this.lblNaslovniText.AutoSize = true;
            this.lblNaslovniText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.lblNaslovniText.Location = new System.Drawing.Point(103, 70);
            this.lblNaslovniText.Name = "lblNaslovniText";
            this.lblNaslovniText.Size = new System.Drawing.Size(322, 38);
            this.lblNaslovniText.TabIndex = 24;
            this.lblNaslovniText.Text = "Praćenje proizvodnje";
            // 
            // lblIzlaz
            // 
            this.lblIzlaz.AutoSize = true;
            this.lblIzlaz.Location = new System.Drawing.Point(899, 111);
            this.lblIzlaz.Name = "lblIzlaz";
            this.lblIzlaz.Size = new System.Drawing.Size(28, 13);
            this.lblIzlaz.TabIndex = 33;
            this.lblIzlaz.Text = "Izlaz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Izvještaj prema IdPraćenja";
            // 
            // btnPretrazivanjeSifra
            // 
            this.btnPretrazivanjeSifra.Location = new System.Drawing.Point(777, 137);
            this.btnPretrazivanjeSifra.Name = "btnPretrazivanjeSifra";
            this.btnPretrazivanjeSifra.Size = new System.Drawing.Size(75, 26);
            this.btnPretrazivanjeSifra.TabIndex = 40;
            this.btnPretrazivanjeSifra.Text = "Traži";
            this.btnPretrazivanjeSifra.UseVisualStyleBackColor = true;
            this.btnPretrazivanjeSifra.Click += new System.EventHandler(this.btnPretrazivanjeSifra_Click);
            // 
            // txtPretrazivanjeSifra
            // 
            this.txtPretrazivanjeSifra.Location = new System.Drawing.Point(659, 141);
            this.txtPretrazivanjeSifra.Name = "txtPretrazivanjeSifra";
            this.txtPretrazivanjeSifra.Size = new System.Drawing.Size(100, 20);
            this.txtPretrazivanjeSifra.TabIndex = 39;
            // 
            // lblPretrazivanjeSifra
            // 
            this.lblPretrazivanjeSifra.AutoSize = true;
            this.lblPretrazivanjeSifra.Location = new System.Drawing.Point(535, 148);
            this.lblPretrazivanjeSifra.Name = "lblPretrazivanjeSifra";
            this.lblPretrazivanjeSifra.Size = new System.Drawing.Size(118, 13);
            this.lblPretrazivanjeSifra.TabIndex = 38;
            this.lblPretrazivanjeSifra.Text = "Pretraživanje prema šifri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Izvještaj prema djelatniku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 539);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Izvještaj prema stroju";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Compromplus_app.Properties.Resources.machine;
            this.pictureBox2.Location = new System.Drawing.Point(33, 445);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Compromplus_app.Properties.Resources.picDjelatnik;
            this.pictureBox1.Location = new System.Drawing.Point(33, 318);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picIzvjestaj
            // 
            this.picIzvjestaj.BackColor = System.Drawing.Color.Transparent;
            this.picIzvjestaj.Image = global::Compromplus_app.Properties.Resources.grey_new_seo_43_512;
            this.picIzvjestaj.Location = new System.Drawing.Point(33, 192);
            this.picIzvjestaj.Name = "picIzvjestaj";
            this.picIzvjestaj.Size = new System.Drawing.Size(83, 71);
            this.picIzvjestaj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIzvjestaj.TabIndex = 34;
            this.picIzvjestaj.TabStop = false;
            this.picIzvjestaj.Click += new System.EventHandler(this.picIzvjestaj_Click);
            // 
            // picIzlaz
            // 
            this.picIzlaz.Image = ((System.Drawing.Image)(resources.GetObject("picIzlaz.Image")));
            this.picIzlaz.Location = new System.Drawing.Point(873, 37);
            this.picIzlaz.Name = "picIzlaz";
            this.picIzlaz.Size = new System.Drawing.Size(76, 71);
            this.picIzlaz.TabIndex = 32;
            this.picIzlaz.TabStop = false;
            this.picIzlaz.Click += new System.EventHandler(this.picIzlaz_Click);
            // 
            // picPracenje
            // 
            this.picPracenje.Image = ((System.Drawing.Image)(resources.GetObject("picPracenje.Image")));
            this.picPracenje.Location = new System.Drawing.Point(27, 57);
            this.picPracenje.Name = "picPracenje";
            this.picPracenje.Size = new System.Drawing.Size(70, 67);
            this.picPracenje.TabIndex = 25;
            this.picPracenje.TabStop = false;
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataMember = "Artikl";
            this.artiklBindingSource.DataSource = this.t23_EnigmaDataSet2;
            // 
            // t23_EnigmaDataSet2
            // 
            this.t23_EnigmaDataSet2.DataSetName = "T23_EnigmaDataSet2";
            this.t23_EnigmaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idDjelatnikDataGridViewTextBoxColumn
            // 
            this.idDjelatnikDataGridViewTextBoxColumn.DataPropertyName = "IdDjelatnik";
            this.idDjelatnikDataGridViewTextBoxColumn.FillWeight = 1000F;
            this.idDjelatnikDataGridViewTextBoxColumn.HeaderText = "IdDjelatnik";
            this.idDjelatnikDataGridViewTextBoxColumn.MaxInputLength = 327670;
            this.idDjelatnikDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.idDjelatnikDataGridViewTextBoxColumn.Name = "idDjelatnikDataGridViewTextBoxColumn";
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
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // strucnaSpremaDataGridViewTextBoxColumn
            // 
            this.strucnaSpremaDataGridViewTextBoxColumn.DataPropertyName = "strucnaSprema";
            this.strucnaSpremaDataGridViewTextBoxColumn.FillWeight = 1000F;
            this.strucnaSpremaDataGridViewTextBoxColumn.HeaderText = "Strucna sprema";
            this.strucnaSpremaDataGridViewTextBoxColumn.MaxInputLength = 3276788;
            this.strucnaSpremaDataGridViewTextBoxColumn.Name = "strucnaSpremaDataGridViewTextBoxColumn";
            // 
            // djelatnikBindingSource
            // 
            this.djelatnikBindingSource.DataMember = "Djelatnik";
            this.djelatnikBindingSource.DataSource = this.t23_EnigmaDataSet2;
            // 
            // idStrojDataGridViewTextBoxColumn1
            // 
            this.idStrojDataGridViewTextBoxColumn1.DataPropertyName = "IdStroj";
            this.idStrojDataGridViewTextBoxColumn1.HeaderText = "IdStroj";
            this.idStrojDataGridViewTextBoxColumn1.Name = "idStrojDataGridViewTextBoxColumn1";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // strojBindingSource
            // 
            this.strojBindingSource.DataMember = "Stroj";
            this.strojBindingSource.DataSource = this.t23_EnigmaDataSet2;
            // 
            // idPracenjeProizvodnjeDataGridViewTextBoxColumn
            // 
            this.idPracenjeProizvodnjeDataGridViewTextBoxColumn.DataPropertyName = "IdPracenjeProizvodnje";
            this.idPracenjeProizvodnjeDataGridViewTextBoxColumn.FillWeight = 10000F;
            this.idPracenjeProizvodnjeDataGridViewTextBoxColumn.HeaderText = "IdPracenjeProizvodnje";
            this.idPracenjeProizvodnjeDataGridViewTextBoxColumn.MaxInputLength = 327670;
            this.idPracenjeProizvodnjeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idPracenjeProizvodnjeDataGridViewTextBoxColumn.Name = "idPracenjeProizvodnjeDataGridViewTextBoxColumn";
            this.idPracenjeProizvodnjeDataGridViewTextBoxColumn.Width = 150;
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
            // idArtiklDataGridViewTextBoxColumn
            // 
            this.idArtiklDataGridViewTextBoxColumn.DataPropertyName = "IdArtikl";
            this.idArtiklDataGridViewTextBoxColumn.HeaderText = "IdArtikl";
            this.idArtiklDataGridViewTextBoxColumn.Name = "idArtiklDataGridViewTextBoxColumn";
            // 
            // idDjelatniciDataGridViewTextBoxColumn
            // 
            this.idDjelatniciDataGridViewTextBoxColumn.DataPropertyName = "IdDjelatnici";
            this.idDjelatniciDataGridViewTextBoxColumn.HeaderText = "IdDjelatnici";
            this.idDjelatniciDataGridViewTextBoxColumn.Name = "idDjelatniciDataGridViewTextBoxColumn";
            // 
            // idStrojDataGridViewTextBoxColumn
            // 
            this.idStrojDataGridViewTextBoxColumn.DataPropertyName = "IdStroj";
            this.idStrojDataGridViewTextBoxColumn.HeaderText = "IdStroj";
            this.idStrojDataGridViewTextBoxColumn.Name = "idStrojDataGridViewTextBoxColumn";
            // 
            // pracenjeProizvodnjeBindingSource
            // 
            this.pracenjeProizvodnjeBindingSource.DataMember = "PracenjeProizvodnje";
            this.pracenjeProizvodnjeBindingSource.DataSource = this.t23_EnigmaDataSet2;
            // 
            // pracenjeProizvodnjeTableAdapter
            // 
            this.pracenjeProizvodnjeTableAdapter.ClearBeforeFill = true;
            // 
            // strojTableAdapter
            // 
            this.strojTableAdapter.ClearBeforeFill = true;
            // 
            // djelatnikTableAdapter
            // 
            this.djelatnikTableAdapter.ClearBeforeFill = true;
            // 
            // artiklTableAdapter
            // 
            this.artiklTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.ArtiklTableAdapter = this.artiklTableAdapter;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.DjelatnikTableAdapter = this.djelatnikTableAdapter;
            this.tableAdapterManager1.PracenjeProizvodnjeTableAdapter = this.pracenjeProizvodnjeTableAdapter;
            this.tableAdapterManager1.StrojTableAdapter = this.strojTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Compromplus_app.T23_EnigmaDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idArtiklDataGridViewTextBoxColumn1
            // 
            this.idArtiklDataGridViewTextBoxColumn1.DataPropertyName = "IdArtikl";
            this.idArtiklDataGridViewTextBoxColumn1.HeaderText = "IdArtikl";
            this.idArtiklDataGridViewTextBoxColumn1.Name = "idArtiklDataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "barkod";
            this.dataGridViewTextBoxColumn1.HeaderText = "barkod";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // nazivDataGridViewTextBoxColumn1
            // 
            this.nazivDataGridViewTextBoxColumn1.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn1.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn1.Name = "nazivDataGridViewTextBoxColumn1";
            this.nazivDataGridViewTextBoxColumn1.Width = 80;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.Width = 200;
            // 
            // bojaDataGridViewTextBoxColumn
            // 
            this.bojaDataGridViewTextBoxColumn.DataPropertyName = "boja";
            this.bojaDataGridViewTextBoxColumn.HeaderText = "Boja";
            this.bojaDataGridViewTextBoxColumn.Name = "bojaDataGridViewTextBoxColumn";
            this.bojaDataGridViewTextBoxColumn.Width = 80;
            // 
            // kolicinaDataGridViewTextBoxColumn1
            // 
            this.kolicinaDataGridViewTextBoxColumn1.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn1.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn1.Name = "kolicinaDataGridViewTextBoxColumn1";
            this.kolicinaDataGridViewTextBoxColumn1.Width = 80;
            // 
            // klasaDataGridViewTextBoxColumn
            // 
            this.klasaDataGridViewTextBoxColumn.DataPropertyName = "klasa";
            this.klasaDataGridViewTextBoxColumn.HeaderText = "Klasa";
            this.klasaDataGridViewTextBoxColumn.Name = "klasaDataGridViewTextBoxColumn";
            this.klasaDataGridViewTextBoxColumn.Width = 40;
            // 
            // velicina
            // 
            this.velicina.DataPropertyName = "velicina";
            this.velicina.HeaderText = "velicina";
            this.velicina.Name = "velicina";
            this.velicina.Width = 70;
            // 
            // formaPracenjeProizvodnjePregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 788);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPretrazivanjeSifra);
            this.Controls.Add(this.txtPretrazivanjeSifra);
            this.Controls.Add(this.lblPretrazivanjeSifra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picIzvjestaj);
            this.Controls.Add(this.lblIzlaz);
            this.Controls.Add(this.picIzlaz);
            this.Controls.Add(this.picPracenje);
            this.Controls.Add(this.lblNaslovniText);
            this.Controls.Add(this.dgvArtikl);
            this.Controls.Add(this.dgvDjelatnik);
            this.Controls.Add(this.dgvStroj);
            this.Controls.Add(this.dgvPracenje);
            this.Name = "formaPracenjeProizvodnjePregled";
            this.Text = "formaPracenjeProizvodnjePregled";
            this.Load += new System.EventHandler(this.formaPracenjeProizvodnjePregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracenje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStroj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDjelatnik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzvjestaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPracenje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_EnigmaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.djelatnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strojBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracenjeProizvodnjeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPracenje;
        private System.Windows.Forms.DataGridView dgvStroj;
        private System.Windows.Forms.DataGridView dgvDjelatnik;
        private System.Windows.Forms.DataGridView dgvArtikl;
        private System.Windows.Forms.Label lblNaslovniText;
        private T23_EnigmaDataSet2 t23_EnigmaDataSet2;
        private System.Windows.Forms.BindingSource pracenjeProizvodnjeBindingSource;
        private T23_EnigmaDataSet2TableAdapters.PracenjeProizvodnjeTableAdapter pracenjeProizvodnjeTableAdapter;
        private System.Windows.Forms.BindingSource strojBindingSource;
        private T23_EnigmaDataSet2TableAdapters.StrojTableAdapter strojTableAdapter;
        private System.Windows.Forms.BindingSource djelatnikBindingSource;
        private T23_EnigmaDataSet2TableAdapters.DjelatnikTableAdapter djelatnikTableAdapter;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private T23_EnigmaDataSet2TableAdapters.ArtiklTableAdapter artiklTableAdapter;
        private System.Windows.Forms.PictureBox picPracenje;
        private System.Windows.Forms.Label lblIzlaz;
        private System.Windows.Forms.PictureBox picIzlaz;
        private System.Windows.Forms.PictureBox picIzvjestaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDjelatnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strucnaSpremaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPretrazivanjeSifra;
        private System.Windows.Forms.TextBox txtPretrazivanjeSifra;
        private System.Windows.Forms.Label lblPretrazivanjeSifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPracenjeProizvodnjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn velicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArtiklDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDjelatniciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStrojDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStrojDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private T23_EnigmaDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArtiklDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bojaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn klasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn velicina;
    }
}