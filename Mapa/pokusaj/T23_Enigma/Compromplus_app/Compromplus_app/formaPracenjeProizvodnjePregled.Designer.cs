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
            this.dgvPracenje = new System.Windows.Forms.DataGridView();
            this.dgvStroj = new System.Windows.Forms.DataGridView();
            this.dgvDjelatnik = new System.Windows.Forms.DataGridView();
            this.dgvArtikl = new System.Windows.Forms.DataGridView();
            this.lblNaslovniText = new System.Windows.Forms.Label();
            this.t23_EnigmaDataSet2 = new Compromplus_app.T23_EnigmaDataSet2();
            this.pracenjeProizvodnjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pracenjeProizvodnjeTableAdapter = new Compromplus_app.T23_EnigmaDataSet2TableAdapters.PracenjeProizvodnjeTableAdapter();
            this.strojBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.strojTableAdapter = new Compromplus_app.T23_EnigmaDataSet2TableAdapters.StrojTableAdapter();
            this.idStrojDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.djelatnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.djelatnikTableAdapter = new Compromplus_app.T23_EnigmaDataSet2TableAdapters.DjelatnikTableAdapter();
            this.idDjelatnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strucnaSpremaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artiklTableAdapter = new Compromplus_app.T23_EnigmaDataSet2TableAdapters.ArtiklTableAdapter();
            this.idArtiklDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPracenjeProizvodnjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idArtiklDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDjelatniciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStrojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracenje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStroj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDjelatnik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_EnigmaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracenjeProizvodnjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strojBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.djelatnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
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
            this.idStrojDataGridViewTextBoxColumn});
            this.dgvPracenje.DataSource = this.pracenjeProizvodnjeBindingSource;
            this.dgvPracenje.Location = new System.Drawing.Point(118, 111);
            this.dgvPracenje.Name = "dgvPracenje";
            this.dgvPracenje.Size = new System.Drawing.Size(641, 184);
            this.dgvPracenje.TabIndex = 0;
            this.dgvPracenje.SelectionChanged += new System.EventHandler(this.dgvPracenje_SelectionChanged);
            // 
            // dgvStroj
            // 
            this.dgvStroj.AutoGenerateColumns = false;
            this.dgvStroj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStroj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStrojDataGridViewTextBoxColumn1,
            this.nazivDataGridViewTextBoxColumn});
            this.dgvStroj.DataSource = this.strojBindingSource;
            this.dgvStroj.Location = new System.Drawing.Point(33, 319);
            this.dgvStroj.Name = "dgvStroj";
            this.dgvStroj.Size = new System.Drawing.Size(224, 184);
            this.dgvStroj.TabIndex = 1;
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
            this.strucnaSpremaDataGridViewTextBoxColumn,
            this.strojDataGridViewTextBoxColumn});
            this.dgvDjelatnik.DataSource = this.djelatnikBindingSource;
            this.dgvDjelatnik.Location = new System.Drawing.Point(297, 319);
            this.dgvDjelatnik.Name = "dgvDjelatnik";
            this.dgvDjelatnik.Size = new System.Drawing.Size(297, 184);
            this.dgvDjelatnik.TabIndex = 2;
            // 
            // dgvArtikl
            // 
            this.dgvArtikl.AutoGenerateColumns = false;
            this.dgvArtikl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArtiklDataGridViewTextBoxColumn1,
            this.nazivDataGridViewTextBoxColumn1,
            this.opisDataGridViewTextBoxColumn,
            this.bojaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn1,
            this.klasaDataGridViewTextBoxColumn});
            this.dgvArtikl.DataSource = this.artiklBindingSource;
            this.dgvArtikl.Location = new System.Drawing.Point(638, 319);
            this.dgvArtikl.Name = "dgvArtikl";
            this.dgvArtikl.Size = new System.Drawing.Size(224, 184);
            this.dgvArtikl.TabIndex = 3;
            // 
            // lblNaslovniText
            // 
            this.lblNaslovniText.AutoSize = true;
            this.lblNaslovniText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.lblNaslovniText.Location = new System.Drawing.Point(63, 28);
            this.lblNaslovniText.Name = "lblNaslovniText";
            this.lblNaslovniText.Size = new System.Drawing.Size(322, 38);
            this.lblNaslovniText.TabIndex = 24;
            this.lblNaslovniText.Text = "Praćenje proizvodnje";
            // 
            // t23_EnigmaDataSet2
            // 
            this.t23_EnigmaDataSet2.DataSetName = "T23_EnigmaDataSet2";
            this.t23_EnigmaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // strojBindingSource
            // 
            this.strojBindingSource.DataMember = "Stroj";
            this.strojBindingSource.DataSource = this.t23_EnigmaDataSet2;
            // 
            // strojTableAdapter
            // 
            this.strojTableAdapter.ClearBeforeFill = true;
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
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // djelatnikBindingSource
            // 
            this.djelatnikBindingSource.DataMember = "Djelatnik";
            this.djelatnikBindingSource.DataSource = this.t23_EnigmaDataSet2;
            // 
            // djelatnikTableAdapter
            // 
            this.djelatnikTableAdapter.ClearBeforeFill = true;
            // 
            // idDjelatnikDataGridViewTextBoxColumn
            // 
            this.idDjelatnikDataGridViewTextBoxColumn.DataPropertyName = "IdDjelatnik";
            this.idDjelatnikDataGridViewTextBoxColumn.HeaderText = "IdDjelatnik";
            this.idDjelatnikDataGridViewTextBoxColumn.Name = "idDjelatnikDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // strucnaSpremaDataGridViewTextBoxColumn
            // 
            this.strucnaSpremaDataGridViewTextBoxColumn.DataPropertyName = "strucnaSprema";
            this.strucnaSpremaDataGridViewTextBoxColumn.HeaderText = "strucnaSprema";
            this.strucnaSpremaDataGridViewTextBoxColumn.Name = "strucnaSpremaDataGridViewTextBoxColumn";
            // 
            // strojDataGridViewTextBoxColumn
            // 
            this.strojDataGridViewTextBoxColumn.DataPropertyName = "stroj";
            this.strojDataGridViewTextBoxColumn.HeaderText = "stroj";
            this.strojDataGridViewTextBoxColumn.Name = "strojDataGridViewTextBoxColumn";
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataMember = "Artikl";
            this.artiklBindingSource.DataSource = this.t23_EnigmaDataSet2;
            // 
            // artiklTableAdapter
            // 
            this.artiklTableAdapter.ClearBeforeFill = true;
            // 
            // idArtiklDataGridViewTextBoxColumn1
            // 
            this.idArtiklDataGridViewTextBoxColumn1.DataPropertyName = "IdArtikl";
            this.idArtiklDataGridViewTextBoxColumn1.HeaderText = "IdArtikl";
            this.idArtiklDataGridViewTextBoxColumn1.Name = "idArtiklDataGridViewTextBoxColumn1";
            // 
            // nazivDataGridViewTextBoxColumn1
            // 
            this.nazivDataGridViewTextBoxColumn1.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn1.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn1.Name = "nazivDataGridViewTextBoxColumn1";
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
            // kolicinaDataGridViewTextBoxColumn1
            // 
            this.kolicinaDataGridViewTextBoxColumn1.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn1.HeaderText = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn1.Name = "kolicinaDataGridViewTextBoxColumn1";
            // 
            // klasaDataGridViewTextBoxColumn
            // 
            this.klasaDataGridViewTextBoxColumn.DataPropertyName = "klasa";
            this.klasaDataGridViewTextBoxColumn.HeaderText = "klasa";
            this.klasaDataGridViewTextBoxColumn.Name = "klasaDataGridViewTextBoxColumn";
            // 
            // idPracenjeProizvodnjeDataGridViewTextBoxColumn
            // 
            this.idPracenjeProizvodnjeDataGridViewTextBoxColumn.DataPropertyName = "IdPracenjeProizvodnje";
            this.idPracenjeProizvodnjeDataGridViewTextBoxColumn.HeaderText = "IdPracenjeProizvodnje";
            this.idPracenjeProizvodnjeDataGridViewTextBoxColumn.Name = "idPracenjeProizvodnjeDataGridViewTextBoxColumn";
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
            // formaPracenjeProizvodnjePregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 515);
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
            ((System.ComponentModel.ISupportInitialize)(this.t23_EnigmaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracenjeProizvodnjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strojBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.djelatnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idStrojDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource djelatnikBindingSource;
        private T23_EnigmaDataSet2TableAdapters.DjelatnikTableAdapter djelatnikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDjelatnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strucnaSpremaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strojDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private T23_EnigmaDataSet2TableAdapters.ArtiklTableAdapter artiklTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArtiklDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bojaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn klasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPracenjeProizvodnjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn velicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArtiklDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDjelatniciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStrojDataGridViewTextBoxColumn;
    }
}