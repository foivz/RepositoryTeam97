namespace aplikacija
{
    partial class formaGlavniIzbornikAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formaGlavniIzbornikAdmin));
            this.mnuGlavniIzbornik = new System.Windows.Forms.MenuStrip();
            this.početnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oNamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picLogoVeliki = new System.Windows.Forms.PictureBox();
            this.grpOpcije = new System.Windows.Forms.GroupBox();
            this.lblIzlaz = new System.Windows.Forms.Label();
            this.lblRepromaterijal = new System.Windows.Forms.Label();
            this.picIzlaz = new System.Windows.Forms.PictureBox();
            this.picRepromaterijal = new System.Windows.Forms.PictureBox();
            this.picDokumenti = new System.Windows.Forms.PictureBox();
            this.lblDokumenti = new System.Windows.Forms.Label();
            this.mnuGlavniIzbornik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVeliki)).BeginInit();
            this.grpOpcije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepromaterijal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDokumenti)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuGlavniIzbornik
            // 
            this.mnuGlavniIzbornik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.početnaToolStripMenuItem,
            this.pomoćToolStripMenuItem});
            this.mnuGlavniIzbornik.Location = new System.Drawing.Point(0, 0);
            this.mnuGlavniIzbornik.Name = "mnuGlavniIzbornik";
            this.mnuGlavniIzbornik.Size = new System.Drawing.Size(841, 24);
            this.mnuGlavniIzbornik.TabIndex = 0;
            this.mnuGlavniIzbornik.Text = "menuStrip1";
            // 
            // početnaToolStripMenuItem
            // 
            this.početnaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odjavaToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.početnaToolStripMenuItem.Name = "početnaToolStripMenuItem";
            this.početnaToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.početnaToolStripMenuItem.Text = "Početna";
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oNamaToolStripMenuItem});
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomoćToolStripMenuItem.Text = "Pomoć";
            // 
            // oNamaToolStripMenuItem
            // 
            this.oNamaToolStripMenuItem.Name = "oNamaToolStripMenuItem";
            this.oNamaToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.oNamaToolStripMenuItem.Text = "O nama";
            // 
            // picLogoVeliki
            // 
            this.picLogoVeliki.Image = ((System.Drawing.Image)(resources.GetObject("picLogoVeliki.Image")));
            this.picLogoVeliki.Location = new System.Drawing.Point(80, 200);
            this.picLogoVeliki.Name = "picLogoVeliki";
            this.picLogoVeliki.Size = new System.Drawing.Size(660, 129);
            this.picLogoVeliki.TabIndex = 1;
            this.picLogoVeliki.TabStop = false;
            this.picLogoVeliki.Click += new System.EventHandler(this.picLogoVeliki_Click);
            // 
            // grpOpcije
            // 
            this.grpOpcije.Controls.Add(this.lblIzlaz);
            this.grpOpcije.Controls.Add(this.lblRepromaterijal);
            this.grpOpcije.Controls.Add(this.lblDokumenti);
            this.grpOpcije.Controls.Add(this.picIzlaz);
            this.grpOpcije.Controls.Add(this.picRepromaterijal);
            this.grpOpcije.Controls.Add(this.picDokumenti);
            this.grpOpcije.Location = new System.Drawing.Point(12, 27);
            this.grpOpcije.Name = "grpOpcije";
            this.grpOpcije.Size = new System.Drawing.Size(768, 131);
            this.grpOpcije.TabIndex = 3;
            this.grpOpcije.TabStop = false;
            this.grpOpcije.Text = "Opcije";
            // 
            // lblIzlaz
            // 
            this.lblIzlaz.AutoSize = true;
            this.lblIzlaz.Location = new System.Drawing.Point(700, 26);
            this.lblIzlaz.Name = "lblIzlaz";
            this.lblIzlaz.Size = new System.Drawing.Size(28, 13);
            this.lblIzlaz.TabIndex = 15;
            this.lblIzlaz.Text = "Izlaz";
            // 
            // lblRepromaterijal
            // 
            this.lblRepromaterijal.AutoSize = true;
            this.lblRepromaterijal.Location = new System.Drawing.Point(82, 26);
            this.lblRepromaterijal.Name = "lblRepromaterijal";
            this.lblRepromaterijal.Size = new System.Drawing.Size(74, 13);
            this.lblRepromaterijal.TabIndex = 11;
            this.lblRepromaterijal.Text = "Repromaterijal";
            // 
            // picIzlaz
            // 
            this.picIzlaz.Image = ((System.Drawing.Image)(resources.GetObject("picIzlaz.Image")));
            this.picIzlaz.Location = new System.Drawing.Point(675, 45);
            this.picIzlaz.Name = "picIzlaz";
            this.picIzlaz.Size = new System.Drawing.Size(78, 66);
            this.picIzlaz.TabIndex = 7;
            this.picIzlaz.TabStop = false;
            this.picIzlaz.Click += new System.EventHandler(this.picIzlaz_Click);
            // 
            // picRepromaterijal
            // 
            this.picRepromaterijal.Image = ((System.Drawing.Image)(resources.GetObject("picRepromaterijal.Image")));
            this.picRepromaterijal.Location = new System.Drawing.Point(88, 45);
            this.picRepromaterijal.Name = "picRepromaterijal";
            this.picRepromaterijal.Size = new System.Drawing.Size(65, 66);
            this.picRepromaterijal.TabIndex = 3;
            this.picRepromaterijal.TabStop = false;
            this.picRepromaterijal.Click += new System.EventHandler(this.picRepromaterijal_Click);
            // 
            // picDokumenti
            // 
            this.picDokumenti.Image = ((System.Drawing.Image)(resources.GetObject("picDokumenti.Image")));
            this.picDokumenti.Location = new System.Drawing.Point(6, 45);
            this.picDokumenti.Name = "picDokumenti";
            this.picDokumenti.Size = new System.Drawing.Size(61, 66);
            this.picDokumenti.TabIndex = 0;
            this.picDokumenti.TabStop = false;
            this.picDokumenti.Click += new System.EventHandler(this.picDokumenti_Click);
            // 
            // lblDokumenti
            // 
            this.lblDokumenti.AutoSize = true;
            this.lblDokumenti.Location = new System.Drawing.Point(9, 26);
            this.lblDokumenti.Name = "lblDokumenti";
            this.lblDokumenti.Size = new System.Drawing.Size(58, 13);
            this.lblDokumenti.TabIndex = 8;
            this.lblDokumenti.Text = "Dokumenti";
            // 
            // formaGlavniIzbornikAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(841, 353);
            this.Controls.Add(this.grpOpcije);
            this.Controls.Add(this.picLogoVeliki);
            this.Controls.Add(this.mnuGlavniIzbornik);
            this.MainMenuStrip = this.mnuGlavniIzbornik;
            this.Name = "formaGlavniIzbornikAdmin";
            this.Text = "Glavni izbornik";
            this.mnuGlavniIzbornik.ResumeLayout(false);
            this.mnuGlavniIzbornik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVeliki)).EndInit();
            this.grpOpcije.ResumeLayout(false);
            this.grpOpcije.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepromaterijal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDokumenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuGlavniIzbornik;
        private System.Windows.Forms.ToolStripMenuItem početnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.PictureBox picLogoVeliki;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oNamaToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpOpcije;
        private System.Windows.Forms.PictureBox picRepromaterijal;
        private System.Windows.Forms.PictureBox picIzlaz;
        private System.Windows.Forms.Label lblRepromaterijal;
        private System.Windows.Forms.Label lblIzlaz;
        private System.Windows.Forms.Label lblDokumenti;
        private System.Windows.Forms.PictureBox picDokumenti;

    }
}