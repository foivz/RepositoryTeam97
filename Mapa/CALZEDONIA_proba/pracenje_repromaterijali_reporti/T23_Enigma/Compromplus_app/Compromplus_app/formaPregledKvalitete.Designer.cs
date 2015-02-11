namespace Compromplus_app
{
    partial class formaPregledKvalitete
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
            System.Windows.Forms.Label label9;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formaPregledKvalitete));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idArtiklDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t23_EnigmaDataSet2 = new Compromplus_app.T23_EnigmaDataSet2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picIzlaz = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idStrojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strojBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKPracenjeProizvodnjeDjelatnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.djelatnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artiklTableAdapter = new Compromplus_app.T23_EnigmaDataSet2TableAdapters.ArtiklTableAdapter();
            this.strojTableAdapter = new Compromplus_app.T23_EnigmaDataSet2TableAdapters.StrojTableAdapter();
            this.pracenjeProizvodnjeTableAdapter = new Compromplus_app.T23_EnigmaDataSet2TableAdapters.PracenjeProizvodnjeTableAdapter();
            this.djelatnikTableAdapter = new Compromplus_app.T23_EnigmaDataSet2TableAdapters.DjelatnikTableAdapter();
            label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_EnigmaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strojBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPracenjeProizvodnjeDjelatnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.djelatnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            label9.Location = new System.Drawing.Point(149, 59);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(469, 29);
            label9.TabIndex = 23;
            label9.Text = "Pregled proizvoda za popravak (B klasa)";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArtiklDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.bojaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.klasaDataGridViewTextBoxColumn,
            this.barkod});
            this.dataGridView1.DataSource = this.artiklBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(846, 153);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
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
            this.opisDataGridViewTextBoxColumn.Width = 200;
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
            // barkod
            // 
            this.barkod.DataPropertyName = "barkod";
            this.barkod.HeaderText = "barkod";
            this.barkod.Name = "barkod";
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Compromplus_app.Properties.Resources._8715062_high_resolution_graphic_of_100_customer_satisfaction_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(25, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 99);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(913, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Izlaz";
            // 
            // picIzlaz
            // 
            this.picIzlaz.Image = ((System.Drawing.Image)(resources.GetObject("picIzlaz.Image")));
            this.picIzlaz.Location = new System.Drawing.Point(893, 42);
            this.picIzlaz.Name = "picIzlaz";
            this.picIzlaz.Size = new System.Drawing.Size(70, 67);
            this.picIzlaz.TabIndex = 24;
            this.picIzlaz.TabStop = false;
            this.picIzlaz.Click += new System.EventHandler(this.picIzlaz_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStrojDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.strojBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(35, 342);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(343, 112);
            this.dataGridView2.TabIndex = 26;
            // 
            // idStrojDataGridViewTextBoxColumn
            // 
            this.idStrojDataGridViewTextBoxColumn.DataPropertyName = "IdStroj";
            this.idStrojDataGridViewTextBoxColumn.HeaderText = "IdStroj";
            this.idStrojDataGridViewTextBoxColumn.Name = "idStrojDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn1
            // 
            this.nazivDataGridViewTextBoxColumn1.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn1.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn1.Name = "nazivDataGridViewTextBoxColumn1";
            // 
            // strojBindingSource
            // 
            this.strojBindingSource.DataMember = "Stroj";
            this.strojBindingSource.DataSource = this.t23_EnigmaDataSet2;
            // 
            // djelatnikBindingSource
            // 
            this.djelatnikBindingSource.DataMember = "Djelatnik";
            this.djelatnikBindingSource.DataSource = this.t23_EnigmaDataSet2;
            // 
            // artiklTableAdapter
            // 
            this.artiklTableAdapter.ClearBeforeFill = true;
            // 
            // strojTableAdapter
            // 
            this.strojTableAdapter.ClearBeforeFill = true;
            // 
            // pracenjeProizvodnjeTableAdapter
            // 
            this.pracenjeProizvodnjeTableAdapter.ClearBeforeFill = true;
            // 
            // djelatnikTableAdapter
            // 
            this.djelatnikTableAdapter.ClearBeforeFill = true;
            // 
            // formaPregledKvalitete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 587);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picIzlaz);
            this.Controls.Add(label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "formaPregledKvalitete";
            this.Text = "formaPregledKvalitete";
            this.Load += new System.EventHandler(this.formaPregledKvalitete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_EnigmaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strojBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPracenjeProizvodnjeDjelatnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.djelatnikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private T23_EnigmaDataSet2 t23_EnigmaDataSet2;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private T23_EnigmaDataSet2TableAdapters.ArtiklTableAdapter artiklTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picIzlaz;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource strojBindingSource;
        private T23_EnigmaDataSet2TableAdapters.StrojTableAdapter strojTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStrojDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArtiklDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bojaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkod;
        private System.Windows.Forms.BindingSource fKPracenjeProizvodnjeDjelatnikBindingSource;
        private T23_EnigmaDataSet2TableAdapters.PracenjeProizvodnjeTableAdapter pracenjeProizvodnjeTableAdapter;
        private System.Windows.Forms.BindingSource djelatnikBindingSource;
        private T23_EnigmaDataSet2TableAdapters.DjelatnikTableAdapter djelatnikTableAdapter;
    }
}