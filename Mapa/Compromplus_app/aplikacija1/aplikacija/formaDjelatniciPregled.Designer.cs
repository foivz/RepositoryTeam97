namespace aplikacija
{
    partial class formaDjelatniciPregled
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formaDjelatniciPregled));
            this.dgvDjelatnici = new System.Windows.Forms.DataGridView();
            this.idDjelatnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strucnaSpremaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.djelatnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPretrazivanje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.lblIzmjeni = new System.Windows.Forms.Label();
            this.picSpremi = new System.Windows.Forms.PictureBox();
            this.lblUnos = new System.Windows.Forms.Label();
            this.picUnos = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.artikliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosIAžuriranjeArtikalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ažurirajArtikleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPretrazivanje = new System.Windows.Forms.Label();
            this.lblDjelatniciIkona = new System.Windows.Forms.Label();
            this.picDjelatniciIkona = new System.Windows.Forms.PictureBox();
            this.lblPretrazivanjeSifra = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPretrazivanje2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDjelatnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.djelatnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpremi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUnos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDjelatniciIkona)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDjelatnici
            // 
            this.dgvDjelatnici.AutoGenerateColumns = false;
            this.dgvDjelatnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDjelatnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDjelatnikDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.strucnaSpremaDataGridViewTextBoxColumn});
            this.dgvDjelatnici.DataSource = this.djelatnikBindingSource;
            this.dgvDjelatnici.Location = new System.Drawing.Point(44, 194);
            this.dgvDjelatnici.Name = "dgvDjelatnici";
            this.dgvDjelatnici.Size = new System.Drawing.Size(772, 352);
            this.dgvDjelatnici.TabIndex = 96;
            // 
            // idDjelatnikDataGridViewTextBoxColumn
            // 
            this.idDjelatnikDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDjelatnikDataGridViewTextBoxColumn.DataPropertyName = "IdDjelatnik";
            this.idDjelatnikDataGridViewTextBoxColumn.HeaderText = "Šifra djelatnika";
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
            this.strucnaSpremaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.strucnaSpremaDataGridViewTextBoxColumn.DataPropertyName = "strucnaSprema";
            this.strucnaSpremaDataGridViewTextBoxColumn.HeaderText = "Stručna sprema";
            this.strucnaSpremaDataGridViewTextBoxColumn.Name = "strucnaSpremaDataGridViewTextBoxColumn";
            // 
            // djelatnikBindingSource
            // 
            this.djelatnikBindingSource.DataSource = typeof(aplikacija.Djelatnik);
            // 
            // txtPretrazivanje
            // 
            this.txtPretrazivanje.Location = new System.Drawing.Point(120, 163);
            this.txtPretrazivanje.Name = "txtPretrazivanje";
            this.txtPretrazivanje.Size = new System.Drawing.Size(266, 20);
            this.txtPretrazivanje.TabIndex = 101;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 153;
            this.label2.Text = "Izlaz";
            // 
            // picExit
            // 
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(222, 35);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(68, 70);
            this.picExit.TabIndex = 152;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // lblIzmjeni
            // 
            this.lblIzmjeni.AutoSize = true;
            this.lblIzmjeni.Location = new System.Drawing.Point(149, 114);
            this.lblIzmjeni.Name = "lblIzmjeni";
            this.lblIzmjeni.Size = new System.Drawing.Size(39, 13);
            this.lblIzmjeni.TabIndex = 151;
            this.lblIzmjeni.Text = "Izmjeni";
            // 
            // picSpremi
            // 
            this.picSpremi.Image = ((System.Drawing.Image)(resources.GetObject("picSpremi.Image")));
            this.picSpremi.Location = new System.Drawing.Point(135, 35);
            this.picSpremi.Name = "picSpremi";
            this.picSpremi.Size = new System.Drawing.Size(68, 70);
            this.picSpremi.TabIndex = 150;
            this.picSpremi.TabStop = false;
            this.picSpremi.Click += new System.EventHandler(this.picSpremi_Click);
            // 
            // lblUnos
            // 
            this.lblUnos.AutoSize = true;
            this.lblUnos.Location = new System.Drawing.Point(54, 114);
            this.lblUnos.Name = "lblUnos";
            this.lblUnos.Size = new System.Drawing.Size(58, 13);
            this.lblUnos.TabIndex = 149;
            this.lblUnos.Text = "Dodaj novi";
            // 
            // picUnos
            // 
            this.picUnos.Image = ((System.Drawing.Image)(resources.GetObject("picUnos.Image")));
            this.picUnos.Location = new System.Drawing.Point(44, 35);
            this.picUnos.Name = "picUnos";
            this.picUnos.Size = new System.Drawing.Size(68, 70);
            this.picUnos.TabIndex = 148;
            this.picUnos.TabStop = false;
            this.picUnos.Click += new System.EventHandler(this.picUnos_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artikliToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(887, 24);
            this.menuStrip1.TabIndex = 147;
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
            // lblPretrazivanje
            // 
            this.lblPretrazivanje.AutoSize = true;
            this.lblPretrazivanje.Location = new System.Drawing.Point(42, 166);
            this.lblPretrazivanje.Name = "lblPretrazivanje";
            this.lblPretrazivanje.Size = new System.Drawing.Size(68, 13);
            this.lblPretrazivanje.TabIndex = 154;
            this.lblPretrazivanje.Text = "Pretraživanje";
            // 
            // lblDjelatniciIkona
            // 
            this.lblDjelatniciIkona.AutoSize = true;
            this.lblDjelatniciIkona.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDjelatniciIkona.Location = new System.Drawing.Point(549, 46);
            this.lblDjelatniciIkona.Name = "lblDjelatniciIkona";
            this.lblDjelatniciIkona.Size = new System.Drawing.Size(292, 39);
            this.lblDjelatniciIkona.TabIndex = 156;
            this.lblDjelatniciIkona.Text = "Pregled djelatnika";
            // 
            // picDjelatniciIkona
            // 
            this.picDjelatniciIkona.Image = ((System.Drawing.Image)(resources.GetObject("picDjelatniciIkona.Image")));
            this.picDjelatniciIkona.Location = new System.Drawing.Point(475, 37);
            this.picDjelatniciIkona.Name = "picDjelatniciIkona";
            this.picDjelatniciIkona.Size = new System.Drawing.Size(68, 62);
            this.picDjelatniciIkona.TabIndex = 155;
            this.picDjelatniciIkona.TabStop = false;
            // 
            // lblPretrazivanjeSifra
            // 
            this.lblPretrazivanjeSifra.AutoSize = true;
            this.lblPretrazivanjeSifra.Location = new System.Drawing.Point(432, 164);
            this.lblPretrazivanjeSifra.Name = "lblPretrazivanjeSifra";
            this.lblPretrazivanjeSifra.Size = new System.Drawing.Size(118, 13);
            this.lblPretrazivanjeSifra.TabIndex = 159;
            this.lblPretrazivanjeSifra.Text = "Pretraživanje prema šifri";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(686, 159);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 158;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPretrazivanje2
            // 
            this.txtPretrazivanje2.Location = new System.Drawing.Point(556, 159);
            this.txtPretrazivanje2.Name = "txtPretrazivanje2";
            this.txtPretrazivanje2.Size = new System.Drawing.Size(124, 20);
            this.txtPretrazivanje2.TabIndex = 157;
            // 
            // formaDjelatniciPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 571);
            this.Controls.Add(this.lblPretrazivanjeSifra);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPretrazivanje2);
            this.Controls.Add(this.lblDjelatniciIkona);
            this.Controls.Add(this.picDjelatniciIkona);
            this.Controls.Add(this.lblPretrazivanje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.lblIzmjeni);
            this.Controls.Add(this.picSpremi);
            this.Controls.Add(this.lblUnos);
            this.Controls.Add(this.picUnos);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtPretrazivanje);
            this.Controls.Add(this.dgvDjelatnici);
            this.Name = "formaDjelatniciPregled";
            this.Text = "formaDjelatniciPregled";
            this.Load += new System.EventHandler(this.formaDjelatniciPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDjelatnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.djelatnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpremi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUnos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDjelatniciIkona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDjelatnici;
        private System.Windows.Forms.BindingSource djelatnikBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDjelatnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strucnaSpremaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtPretrazivanje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label lblIzmjeni;
        private System.Windows.Forms.PictureBox picSpremi;
        private System.Windows.Forms.Label lblUnos;
        private System.Windows.Forms.PictureBox picUnos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem artikliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosIAžuriranjeArtikalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ažurirajArtikleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.Label lblPretrazivanje;
        private System.Windows.Forms.Label lblDjelatniciIkona;
        private System.Windows.Forms.PictureBox picDjelatniciIkona;
        private System.Windows.Forms.Label lblPretrazivanjeSifra;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPretrazivanje2;
    }
}