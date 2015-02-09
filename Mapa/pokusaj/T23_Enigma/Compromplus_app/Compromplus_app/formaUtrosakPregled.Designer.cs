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
            this.dgvArtikl = new System.Windows.Forms.DataGridView();
            this.dgvUtrosak = new System.Windows.Forms.DataGridView();
            this.utrosakBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.t23_EnigmaDataSet = new Compromplus_app.T23_EnigmaDataSet();
            this.lblNaslovniText = new System.Windows.Forms.Label();
            this.idUtrosakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idArtiklDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRepromaterijalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utrosakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t23_EnigmaDataSet1 = new Compromplus_app.T23_EnigmaDataSet1();
            this.utrosakTableAdapter = new Compromplus_app.T23_EnigmaDataSet1TableAdapters.UtrosakTableAdapter();
            this.idArtiklDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artiklBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.artiklTableAdapter = new Compromplus_app.T23_EnigmaDataSet1TableAdapters.ArtiklTableAdapter();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvRepromaterijal = new System.Windows.Forms.DataGridView();
            this.repromaterijalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repromaterijalTableAdapter = new Compromplus_app.T23_EnigmaDataSet1TableAdapters.RepromaterijalTableAdapter();
            this.idRepromaterijalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velicinaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bojaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtrosak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utrosakBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_EnigmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utrosakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_EnigmaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepromaterijal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repromaterijalBindingSource)).BeginInit();
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
            this.dgvArtikl.Location = new System.Drawing.Point(137, 101);
            this.dgvArtikl.Name = "dgvArtikl";
            this.dgvArtikl.Size = new System.Drawing.Size(645, 173);
            this.dgvArtikl.TabIndex = 0;
            this.dgvArtikl.SelectionChanged += new System.EventHandler(this.dgvArtikl_SelectionChanged);
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
            this.dgvUtrosak.Location = new System.Drawing.Point(12, 297);
            this.dgvUtrosak.Name = "dgvUtrosak";
            this.dgvUtrosak.Size = new System.Drawing.Size(544, 194);
            this.dgvUtrosak.TabIndex = 1;
            // 
            // utrosakBindingSource1
            // 
            this.utrosakBindingSource1.DataMember = "Utrosak";
            this.utrosakBindingSource1.DataSource = this.utrosakBindingSource;
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
            this.lblNaslovniText.Location = new System.Drawing.Point(59, 37);
            this.lblNaslovniText.Name = "lblNaslovniText";
            this.lblNaslovniText.Size = new System.Drawing.Size(131, 38);
            this.lblNaslovniText.TabIndex = 23;
            this.lblNaslovniText.Text = "Utrošak";
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
            // utrosakBindingSource
            // 
            this.utrosakBindingSource.DataSource = this.t23_EnigmaDataSet1;
            this.utrosakBindingSource.Position = 0;
            // 
            // t23_EnigmaDataSet1
            // 
            this.t23_EnigmaDataSet1.DataSetName = "T23_EnigmaDataSet1";
            this.t23_EnigmaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utrosakTableAdapter
            // 
            this.utrosakTableAdapter.ClearBeforeFill = true;
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
            // artiklBindingSource1
            // 
            this.artiklBindingSource1.DataMember = "Artikl";
            this.artiklBindingSource1.DataSource = this.t23_EnigmaDataSet1;
            // 
            // artiklTableAdapter
            // 
            this.artiklTableAdapter.ClearBeforeFill = true;
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataSource = typeof(Compromplus_app.Artikl);
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
            this.dgvRepromaterijal.Location = new System.Drawing.Point(593, 297);
            this.dgvRepromaterijal.Name = "dgvRepromaterijal";
            this.dgvRepromaterijal.Size = new System.Drawing.Size(240, 150);
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
            // idRepromaterijalDataGridViewTextBoxColumn1
            // 
            this.idRepromaterijalDataGridViewTextBoxColumn1.DataPropertyName = "IdRepromaterijal";
            this.idRepromaterijalDataGridViewTextBoxColumn1.HeaderText = "IdRepromaterijal";
            this.idRepromaterijalDataGridViewTextBoxColumn1.Name = "idRepromaterijalDataGridViewTextBoxColumn1";
            // 
            // nazivDataGridViewTextBoxColumn1
            // 
            this.nazivDataGridViewTextBoxColumn1.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn1.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn1.Name = "nazivDataGridViewTextBoxColumn1";
            // 
            // opisDataGridViewTextBoxColumn1
            // 
            this.opisDataGridViewTextBoxColumn1.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn1.HeaderText = "opis";
            this.opisDataGridViewTextBoxColumn1.Name = "opisDataGridViewTextBoxColumn1";
            // 
            // kolicinaDataGridViewTextBoxColumn2
            // 
            this.kolicinaDataGridViewTextBoxColumn2.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn2.HeaderText = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn2.Name = "kolicinaDataGridViewTextBoxColumn2";
            // 
            // velicinaDataGridViewTextBoxColumn1
            // 
            this.velicinaDataGridViewTextBoxColumn1.DataPropertyName = "velicina";
            this.velicinaDataGridViewTextBoxColumn1.HeaderText = "velicina";
            this.velicinaDataGridViewTextBoxColumn1.Name = "velicinaDataGridViewTextBoxColumn1";
            // 
            // barkodDataGridViewTextBoxColumn
            // 
            this.barkodDataGridViewTextBoxColumn.DataPropertyName = "barkod";
            this.barkodDataGridViewTextBoxColumn.HeaderText = "barkod";
            this.barkodDataGridViewTextBoxColumn.Name = "barkodDataGridViewTextBoxColumn";
            // 
            // bojaDataGridViewTextBoxColumn1
            // 
            this.bojaDataGridViewTextBoxColumn1.DataPropertyName = "boja";
            this.bojaDataGridViewTextBoxColumn1.HeaderText = "boja";
            this.bojaDataGridViewTextBoxColumn1.Name = "bojaDataGridViewTextBoxColumn1";
            // 
            // formaUtrosakPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 520);
            this.Controls.Add(this.dgvRepromaterijal);
            this.Controls.Add(this.lblNaslovniText);
            this.Controls.Add(this.dgvUtrosak);
            this.Controls.Add(this.dgvArtikl);
            this.Name = "formaUtrosakPregled";
            this.Text = "formaUtrosakPregled";
            this.Load += new System.EventHandler(this.formaUtrosakPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtrosak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utrosakBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_EnigmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utrosakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_EnigmaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepromaterijal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repromaterijalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArtikl;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArtiklDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bojaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klasaDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idRepromaterijalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn velicinaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bojaDataGridViewTextBoxColumn1;
    }
}