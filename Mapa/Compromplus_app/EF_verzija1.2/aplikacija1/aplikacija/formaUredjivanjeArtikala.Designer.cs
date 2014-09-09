namespace aplikacija
{
    partial class formaUredjivanjeArtikala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formaUredjivanjeArtikala));
            this.txtBoja = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtIdArtikli = new System.Windows.Forms.TextBox();
            this.lblEvidencijaKontroleID = new System.Windows.Forms.Label();
            this.lblBoja = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblIdArtikli = new System.Windows.Forms.Label();
            this.lblSpremi = new System.Windows.Forms.Label();
            this.picSpremi = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.artikliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosIAžuriranjeArtikalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ažurirajArtikleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.txtEvidencijaKontrole = new System.Windows.Forms.TextBox();
            this.t28EnigmaDataSet = new aplikacija.T28EnigmaDataSet();
            this.artikliTableAdapter = new aplikacija.T28EnigmaDataSetTableAdapters.ArtikliTableAdapter();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picSpremi)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t28EnigmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoja
            // 
            this.txtBoja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtBoja.Location = new System.Drawing.Point(88, 177);
            this.txtBoja.Name = "txtBoja";
            this.txtBoja.Size = new System.Drawing.Size(251, 26);
            this.txtBoja.TabIndex = 100;
            // 
            // txtOpis
            // 
            this.txtOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtOpis.Location = new System.Drawing.Point(88, 119);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(251, 38);
            this.txtOpis.TabIndex = 99;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtNaziv.Location = new System.Drawing.Point(88, 77);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(251, 26);
            this.txtNaziv.TabIndex = 98;
            // 
            // txtIdArtikli
            // 
            this.txtIdArtikli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtIdArtikli.Location = new System.Drawing.Point(88, 36);
            this.txtIdArtikli.Name = "txtIdArtikli";
            this.txtIdArtikli.Size = new System.Drawing.Size(251, 26);
            this.txtIdArtikli.TabIndex = 97;
            // 
            // lblEvidencijaKontroleID
            // 
            this.lblEvidencijaKontroleID.AutoSize = true;
            this.lblEvidencijaKontroleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblEvidencijaKontroleID.Location = new System.Drawing.Point(14, 224);
            this.lblEvidencijaKontroleID.Name = "lblEvidencijaKontroleID";
            this.lblEvidencijaKontroleID.Size = new System.Drawing.Size(51, 20);
            this.lblEvidencijaKontroleID.TabIndex = 96;
            this.lblEvidencijaKontroleID.Text = "Klasa";
            // 
            // lblBoja
            // 
            this.lblBoja.AutoSize = true;
            this.lblBoja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblBoja.Location = new System.Drawing.Point(14, 177);
            this.lblBoja.Name = "lblBoja";
            this.lblBoja.Size = new System.Drawing.Size(43, 20);
            this.lblBoja.TabIndex = 95;
            this.lblBoja.Text = "Boja";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblOpis.Location = new System.Drawing.Point(14, 119);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(44, 20);
            this.lblOpis.TabIndex = 94;
            this.lblOpis.Text = "Opis";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNaziv.Location = new System.Drawing.Point(14, 77);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(51, 20);
            this.lblNaziv.TabIndex = 93;
            this.lblNaziv.Text = "Naziv";
            // 
            // lblIdArtikli
            // 
            this.lblIdArtikli.AutoSize = true;
            this.lblIdArtikli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblIdArtikli.Location = new System.Drawing.Point(14, 36);
            this.lblIdArtikli.Name = "lblIdArtikli";
            this.lblIdArtikli.Size = new System.Drawing.Size(44, 20);
            this.lblIdArtikli.TabIndex = 92;
            this.lblIdArtikli.Text = "Šifra";
            // 
            // lblSpremi
            // 
            this.lblSpremi.AutoSize = true;
            this.lblSpremi.Location = new System.Drawing.Point(436, 144);
            this.lblSpremi.Name = "lblSpremi";
            this.lblSpremi.Size = new System.Drawing.Size(39, 13);
            this.lblSpremi.TabIndex = 126;
            this.lblSpremi.Text = "Spremi";
            // 
            // picSpremi
            // 
            this.picSpremi.Image = ((System.Drawing.Image)(resources.GetObject("picSpremi.Image")));
            this.picSpremi.Location = new System.Drawing.Point(423, 71);
            this.picSpremi.Name = "picSpremi";
            this.picSpremi.Size = new System.Drawing.Size(68, 70);
            this.picSpremi.TabIndex = 125;
            this.picSpremi.TabStop = false;
            this.picSpremi.Click += new System.EventHandler(this.picSpremi_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artikliToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(605, 24);
            this.menuStrip1.TabIndex = 124;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 129;
            this.label1.Text = "Izlaz";
            // 
            // picExit
            // 
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(423, 177);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(68, 70);
            this.picExit.TabIndex = 128;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // txtEvidencijaKontrole
            // 
            this.txtEvidencijaKontrole.Location = new System.Drawing.Point(88, 227);
            this.txtEvidencijaKontrole.Name = "txtEvidencijaKontrole";
            this.txtEvidencijaKontrole.Size = new System.Drawing.Size(251, 20);
            this.txtEvidencijaKontrole.TabIndex = 130;
            // 
            // t28EnigmaDataSet
            // 
            this.t28EnigmaDataSet.DataSetName = "T28EnigmaDataSet";
            this.t28EnigmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artikliTableAdapter
            // 
            this.artikliTableAdapter.ClearBeforeFill = true;
            // 
            // artikliBindingSource
            // 
            this.artikliBindingSource.DataMember = "Artikli";
            this.artikliBindingSource.DataSource = this.t28EnigmaDataSet;
            // 
            // formaUredjivanjeArtikala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 463);
            this.Controls.Add(this.txtEvidencijaKontrole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.lblSpremi);
            this.Controls.Add(this.picSpremi);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtBoja);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtIdArtikli);
            this.Controls.Add(this.lblEvidencijaKontroleID);
            this.Controls.Add(this.lblBoja);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblIdArtikli);
            this.Name = "formaUredjivanjeArtikala";
            this.Text = "formaUredjivanjeArtikala";
            ((System.ComponentModel.ISupportInitialize)(this.picSpremi)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t28EnigmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoja;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtIdArtikli;
        private System.Windows.Forms.Label lblEvidencijaKontroleID;
        private System.Windows.Forms.Label lblBoja;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblIdArtikli;
        private System.Windows.Forms.Label lblSpremi;
        private System.Windows.Forms.PictureBox picSpremi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem artikliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosIAžuriranjeArtikalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ažurirajArtikleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.TextBox txtEvidencijaKontrole;
        private T28EnigmaDataSet t28EnigmaDataSet;
        private T28EnigmaDataSetTableAdapters.ArtikliTableAdapter artikliTableAdapter;
        private System.Windows.Forms.BindingSource artikliBindingSource;
    }
}