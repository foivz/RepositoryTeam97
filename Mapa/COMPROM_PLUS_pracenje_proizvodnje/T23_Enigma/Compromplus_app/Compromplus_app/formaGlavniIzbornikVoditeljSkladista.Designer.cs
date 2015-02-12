namespace Compromplus_app
{
    partial class formaGlavniIzbornikVoditeljSkladista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formaGlavniIzbornikVoditeljSkladista));
            this.label5 = new System.Windows.Forms.Label();
            this.picCompromplusLogo = new System.Windows.Forms.PictureBox();
            this.picIzlaz = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.početnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.picDokumenti = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.picRepromaterijali = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picArtikli = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCompromplusLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDokumenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepromaterijali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArtikli)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(651, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Izlaz";
            // 
            // picCompromplusLogo
            // 
            this.picCompromplusLogo.Image = ((System.Drawing.Image)(resources.GetObject("picCompromplusLogo.Image")));
            this.picCompromplusLogo.Location = new System.Drawing.Point(188, 212);
            this.picCompromplusLogo.Name = "picCompromplusLogo";
            this.picCompromplusLogo.Size = new System.Drawing.Size(392, 70);
            this.picCompromplusLogo.TabIndex = 29;
            this.picCompromplusLogo.TabStop = false;
            // 
            // picIzlaz
            // 
            this.picIzlaz.Image = ((System.Drawing.Image)(resources.GetObject("picIzlaz.Image")));
            this.picIzlaz.Location = new System.Drawing.Point(633, 50);
            this.picIzlaz.Name = "picIzlaz";
            this.picIzlaz.Size = new System.Drawing.Size(70, 67);
            this.picIzlaz.TabIndex = 28;
            this.picIzlaz.TabStop = false;
            this.picIzlaz.Click += new System.EventHandler(this.picIzlaz_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.početnaToolStripMenuItem,
            this.pomoćToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(741, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
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
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomoćToolStripMenuItem.Text = "Pomoć";
            this.pomoćToolStripMenuItem.Click += new System.EventHandler(this.pomoćToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Dokumenti";
            // 
            // picDokumenti
            // 
            this.picDokumenti.Image = ((System.Drawing.Image)(resources.GetObject("picDokumenti.Image")));
            this.picDokumenti.Location = new System.Drawing.Point(27, 50);
            this.picDokumenti.Name = "picDokumenti";
            this.picDokumenti.Size = new System.Drawing.Size(70, 67);
            this.picDokumenti.TabIndex = 35;
            this.picDokumenti.TabStop = false;
            this.picDokumenti.Click += new System.EventHandler(this.picDokumenti_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Repromaterijali";
            // 
            // picRepromaterijali
            // 
            this.picRepromaterijali.BackgroundImage = global::Compromplus_app.Properties.Resources._20714;
            this.picRepromaterijali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picRepromaterijali.Location = new System.Drawing.Point(140, 50);
            this.picRepromaterijali.Name = "picRepromaterijali";
            this.picRepromaterijali.Size = new System.Drawing.Size(69, 66);
            this.picRepromaterijali.TabIndex = 37;
            this.picRepromaterijali.TabStop = false;
            this.picRepromaterijali.Click += new System.EventHandler(this.picRepromaterijali_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Artikli";
            // 
            // picArtikli
            // 
            this.picArtikli.Image = ((System.Drawing.Image)(resources.GetObject("picArtikli.Image")));
            this.picArtikli.Location = new System.Drawing.Point(250, 50);
            this.picArtikli.Name = "picArtikli";
            this.picArtikli.Size = new System.Drawing.Size(70, 67);
            this.picArtikli.TabIndex = 39;
            this.picArtikli.TabStop = false;
            this.picArtikli.Click += new System.EventHandler(this.picArtikli_Click);
            // 
            // formaGlavniIzbornikVoditeljSkladista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(741, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picArtikli);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.picRepromaterijali);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picDokumenti);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picCompromplusLogo);
            this.Controls.Add(this.picIzlaz);
            this.Controls.Add(this.menuStrip1);
            this.Name = "formaGlavniIzbornikVoditeljSkladista";
            this.Text = "formaGlavniIzbornikVoditeljSkladista";
            ((System.ComponentModel.ISupportInitialize)(this.picCompromplusLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDokumenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepromaterijali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArtikli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picCompromplusLogo;
        private System.Windows.Forms.PictureBox picIzlaz;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem početnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picDokumenti;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picRepromaterijali;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picArtikli;
    }
}