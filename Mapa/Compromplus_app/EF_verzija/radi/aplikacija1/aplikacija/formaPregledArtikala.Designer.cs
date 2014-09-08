namespace aplikacija
{
    partial class formaPregledArtikala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formaPregledArtikala));
            this.label1 = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.lblObrisi = new System.Windows.Forms.Label();
            this.lblSpremi = new System.Windows.Forms.Label();
            this.lblUnos = new System.Windows.Forms.Label();
            this.picObrisi = new System.Windows.Forms.PictureBox();
            this.picUnos = new System.Windows.Forms.PictureBox();
            this.picSpremi = new System.Windows.Forms.PictureBox();
            this.lblArtikliIkona = new System.Windows.Forms.Label();
            this.picArtikliIkona = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.artikliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosIAžuriranjeArtikalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ažurirajArtikleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artikliDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxIdArtikl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxOpis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxBoja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evidencijaKontrole = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.evidencijaKontroleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t28EnigmaDataSet = new aplikacija.T28EnigmaDataSet();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPretrazivanje = new System.Windows.Forms.Label();
            this.txtPretrazivanje = new System.Windows.Forms.TextBox();
            this.artikliTableAdapter = new aplikacija.T28EnigmaDataSetTableAdapters.ArtikliTableAdapter();
            this.tableAdapterManager = new aplikacija.T28EnigmaDataSetTableAdapters.TableAdapterManager();
            this.evidencijaKontroleTableAdapter = new aplikacija.T28EnigmaDataSetTableAdapters.EvidencijaKontroleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObrisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpremi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArtikliIkona)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artikliDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evidencijaKontroleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t28EnigmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 137;
            this.label1.Text = "Izlaz";
            // 
            // picExit
            // 
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(388, 64);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(68, 70);
            this.picExit.TabIndex = 136;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // lblObrisi
            // 
            this.lblObrisi.AutoSize = true;
            this.lblObrisi.Location = new System.Drawing.Point(229, 137);
            this.lblObrisi.Name = "lblObrisi";
            this.lblObrisi.Size = new System.Drawing.Size(33, 13);
            this.lblObrisi.TabIndex = 135;
            this.lblObrisi.Text = "Obriši";
            // 
            // lblSpremi
            // 
            this.lblSpremi.AutoSize = true;
            this.lblSpremi.Location = new System.Drawing.Point(132, 137);
            this.lblSpremi.Name = "lblSpremi";
            this.lblSpremi.Size = new System.Drawing.Size(41, 13);
            this.lblSpremi.TabIndex = 134;
            this.lblSpremi.Text = "Ažuriraj";
            // 
            // lblUnos
            // 
            this.lblUnos.AutoSize = true;
            this.lblUnos.Location = new System.Drawing.Point(32, 137);
            this.lblUnos.Name = "lblUnos";
            this.lblUnos.Size = new System.Drawing.Size(58, 13);
            this.lblUnos.TabIndex = 133;
            this.lblUnos.Text = "Dodaj novi";
            // 
            // picObrisi
            // 
            this.picObrisi.Image = ((System.Drawing.Image)(resources.GetObject("picObrisi.Image")));
            this.picObrisi.Location = new System.Drawing.Point(215, 64);
            this.picObrisi.Name = "picObrisi";
            this.picObrisi.Size = new System.Drawing.Size(68, 70);
            this.picObrisi.TabIndex = 132;
            this.picObrisi.TabStop = false;
            this.picObrisi.Click += new System.EventHandler(this.picObrisi_Click);
            // 
            // picUnos
            // 
            this.picUnos.Image = ((System.Drawing.Image)(resources.GetObject("picUnos.Image")));
            this.picUnos.Location = new System.Drawing.Point(25, 64);
            this.picUnos.Name = "picUnos";
            this.picUnos.Size = new System.Drawing.Size(68, 70);
            this.picUnos.TabIndex = 131;
            this.picUnos.TabStop = false;
            this.picUnos.Click += new System.EventHandler(this.picUnos_Click);
            // 
            // picSpremi
            // 
            this.picSpremi.Image = ((System.Drawing.Image)(resources.GetObject("picSpremi.Image")));
            this.picSpremi.Location = new System.Drawing.Point(119, 64);
            this.picSpremi.Name = "picSpremi";
            this.picSpremi.Size = new System.Drawing.Size(68, 70);
            this.picSpremi.TabIndex = 130;
            this.picSpremi.TabStop = false;
            this.picSpremi.Click += new System.EventHandler(this.picSpremi_Click);
            // 
            // lblArtikliIkona
            // 
            this.lblArtikliIkona.AutoSize = true;
            this.lblArtikliIkona.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblArtikliIkona.Location = new System.Drawing.Point(-123, 129);
            this.lblArtikliIkona.Name = "lblArtikliIkona";
            this.lblArtikliIkona.Size = new System.Drawing.Size(104, 39);
            this.lblArtikliIkona.TabIndex = 129;
            this.lblArtikliIkona.Text = "Artikli";
            // 
            // picArtikliIkona
            // 
            this.picArtikliIkona.Image = ((System.Drawing.Image)(resources.GetObject("picArtikliIkona.Image")));
            this.picArtikliIkona.Location = new System.Drawing.Point(-197, 120);
            this.picArtikliIkona.Name = "picArtikliIkona";
            this.picArtikliIkona.Size = new System.Drawing.Size(68, 58);
            this.picArtikliIkona.TabIndex = 128;
            this.picArtikliIkona.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artikliToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(881, 24);
            this.menuStrip1.TabIndex = 127;
            this.menuStrip1.Text = "mnuArtikli";
            // 
            // artikliToolStripMenuItem
            // 
            this.artikliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosIAžuriranjeArtikalaToolStripMenuItem,
            this.ažurirajArtikleToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.artikliToolStripMenuItem.Name = "artikliToolStripMenuItem";
            this.artikliToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.artikliToolStripMenuItem.Text = "Artikli";
            // 
            // unosIAžuriranjeArtikalaToolStripMenuItem
            // 
            this.unosIAžuriranjeArtikalaToolStripMenuItem.Name = "unosIAžuriranjeArtikalaToolStripMenuItem";
            this.unosIAžuriranjeArtikalaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.unosIAžuriranjeArtikalaToolStripMenuItem.Text = "Novi unos";
            // 
            // ažurirajArtikleToolStripMenuItem
            // 
            this.ažurirajArtikleToolStripMenuItem.Name = "ažurirajArtikleToolStripMenuItem";
            this.ažurirajArtikleToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ažurirajArtikleToolStripMenuItem.Text = "Spremi promjene";
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            // 
            // artikliDataGridView
            // 
            this.artikliDataGridView.AutoGenerateColumns = false;
            this.artikliDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.artikliDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxIdArtikl,
            this.dataGridViewTextBoxNaziv,
            this.dataGridViewTextBoxOpis,
            this.dataGridViewTextBoxBoja,
            this.evidencijaKontrole});
            this.artikliDataGridView.DataSource = this.artikliBindingSource;
            this.artikliDataGridView.Location = new System.Drawing.Point(25, 172);
            this.artikliDataGridView.Name = "artikliDataGridView";
            this.artikliDataGridView.Size = new System.Drawing.Size(782, 236);
            this.artikliDataGridView.TabIndex = 138;
            this.artikliDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.artikliDataGridView_CellMouseDown);
            // 
            // dataGridViewTextBoxIdArtikl
            // 
            this.dataGridViewTextBoxIdArtikl.DataPropertyName = "IdArtikli";
            this.dataGridViewTextBoxIdArtikl.HeaderText = "Šifra artikla";
            this.dataGridViewTextBoxIdArtikl.Name = "dataGridViewTextBoxIdArtikl";
            // 
            // dataGridViewTextBoxNaziv
            // 
            this.dataGridViewTextBoxNaziv.DataPropertyName = "naziv";
            this.dataGridViewTextBoxNaziv.HeaderText = "Naziv";
            this.dataGridViewTextBoxNaziv.Name = "dataGridViewTextBoxNaziv";
            // 
            // dataGridViewTextBoxOpis
            // 
            this.dataGridViewTextBoxOpis.DataPropertyName = "opis";
            this.dataGridViewTextBoxOpis.HeaderText = "Opis";
            this.dataGridViewTextBoxOpis.Name = "dataGridViewTextBoxOpis";
            // 
            // dataGridViewTextBoxBoja
            // 
            this.dataGridViewTextBoxBoja.DataPropertyName = "boja";
            this.dataGridViewTextBoxBoja.HeaderText = "Boja";
            this.dataGridViewTextBoxBoja.Name = "dataGridViewTextBoxBoja";
            // 
            // evidencijaKontrole
            // 
            this.evidencijaKontrole.DataPropertyName = "evidencijaKontrole";
            this.evidencijaKontrole.DataSource = this.evidencijaKontroleBindingSource;
            this.evidencijaKontrole.DisplayMember = "klasa";
            this.evidencijaKontrole.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.evidencijaKontrole.HeaderText = "Klasa";
            this.evidencijaKontrole.Name = "evidencijaKontrole";
            this.evidencijaKontrole.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.evidencijaKontrole.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.evidencijaKontrole.ValueMember = "IdEvidencijaKontrole";
            // 
            // evidencijaKontroleBindingSource
            // 
            this.evidencijaKontroleBindingSource.DataMember = "EvidencijaKontrole";
            this.evidencijaKontroleBindingSource.DataSource = this.t28EnigmaDataSet;
            // 
            // t28EnigmaDataSet
            // 
            this.t28EnigmaDataSet.DataSetName = "T28EnigmaDataSet";
            this.t28EnigmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artikliBindingSource
            // 
            this.artikliBindingSource.DataMember = "Artikli";
            this.artikliBindingSource.DataSource = this.t28EnigmaDataSet;
            // 
            // lblPretrazivanje
            // 
            this.lblPretrazivanje.AutoSize = true;
            this.lblPretrazivanje.Location = new System.Drawing.Point(517, 47);
            this.lblPretrazivanje.Name = "lblPretrazivanje";
            this.lblPretrazivanje.Size = new System.Drawing.Size(68, 13);
            this.lblPretrazivanje.TabIndex = 139;
            this.lblPretrazivanje.Text = "Pretraživanje";
            // 
            // txtPretrazivanje
            // 
            this.txtPretrazivanje.Location = new System.Drawing.Point(520, 64);
            this.txtPretrazivanje.Name = "txtPretrazivanje";
            this.txtPretrazivanje.Size = new System.Drawing.Size(278, 20);
            this.txtPretrazivanje.TabIndex = 140;
            this.txtPretrazivanje.TextChanged += new System.EventHandler(this.txtPretrazivanje_TextChanged);
            // 
            // artikliTableAdapter
            // 
            this.artikliTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArtikliTableAdapter = this.artikliTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DjelatnikTableAdapter = null;
            this.tableAdapterManager.DokumentTableAdapter = null;
            this.tableAdapterManager.EvidencijaKontroleTableAdapter = null;
            this.tableAdapterManager.KorisnikTableAdapter = null;
            this.tableAdapterManager.PoslovniPartnerTableAdapter = null;
            this.tableAdapterManager.RepromaterijalTableAdapter = null;
            this.tableAdapterManager.stavke_dokumentaTableAdapter = null;
            this.tableAdapterManager.stavke_repromaterijalaTableAdapter = null;
            this.tableAdapterManager.StrojTableAdapter = null;
            this.tableAdapterManager.TipDokumentaTableAdapter = null;
            this.tableAdapterManager.TipKorisnikaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = aplikacija.T28EnigmaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // evidencijaKontroleTableAdapter
            // 
            this.evidencijaKontroleTableAdapter.ClearBeforeFill = true;
            // 
            // formaPregledArtikala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 487);
            this.Controls.Add(this.txtPretrazivanje);
            this.Controls.Add(this.lblPretrazivanje);
            this.Controls.Add(this.artikliDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.lblObrisi);
            this.Controls.Add(this.lblSpremi);
            this.Controls.Add(this.lblUnos);
            this.Controls.Add(this.picObrisi);
            this.Controls.Add(this.picUnos);
            this.Controls.Add(this.picSpremi);
            this.Controls.Add(this.lblArtikliIkona);
            this.Controls.Add(this.picArtikliIkona);
            this.Controls.Add(this.menuStrip1);
            this.Name = "formaPregledArtikala";
            this.Text = "pregledArtikala";
            this.Load += new System.EventHandler(this.pregledArtikala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObrisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpremi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArtikliIkona)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artikliDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evidencijaKontroleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t28EnigmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label lblObrisi;
        private System.Windows.Forms.Label lblSpremi;
        private System.Windows.Forms.Label lblUnos;
        private System.Windows.Forms.PictureBox picObrisi;
        private System.Windows.Forms.PictureBox picUnos;
        private System.Windows.Forms.PictureBox picSpremi;
        private System.Windows.Forms.Label lblArtikliIkona;
        private System.Windows.Forms.PictureBox picArtikliIkona;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem artikliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosIAžuriranjeArtikalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ažurirajArtikleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private T28EnigmaDataSet t28EnigmaDataSet;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private T28EnigmaDataSetTableAdapters.ArtikliTableAdapter artikliTableAdapter;
        private T28EnigmaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView artikliDataGridView;
        private System.Windows.Forms.Label lblPretrazivanje;
        private System.Windows.Forms.TextBox txtPretrazivanje;
        private System.Windows.Forms.BindingSource evidencijaKontroleBindingSource;
        private T28EnigmaDataSetTableAdapters.EvidencijaKontroleTableAdapter evidencijaKontroleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxIdArtikl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxOpis;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxBoja;
        private System.Windows.Forms.DataGridViewComboBoxColumn evidencijaKontrole;
    }
}