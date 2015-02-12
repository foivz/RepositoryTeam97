namespace Compromplus_app
{
    partial class formaStatistika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formaStatistika));
            this.picArtikli = new System.Windows.Forms.PictureBox();
            this.lblNaslovniText = new System.Windows.Forms.Label();
            this.lblIzlaz = new System.Windows.Forms.Label();
            this.picIzlaz = new System.Windows.Forms.PictureBox();
            this.btnKlase = new System.Windows.Forms.Button();
            this.btnDokumenti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).BeginInit();
            this.SuspendLayout();
            // 
            // picArtikli
            // 
            this.picArtikli.Image = ((System.Drawing.Image)(resources.GetObject("picArtikli.Image")));
            this.picArtikli.Location = new System.Drawing.Point(37, 35);
            this.picArtikli.Name = "picArtikli";
            this.picArtikli.Size = new System.Drawing.Size(70, 67);
            this.picArtikli.TabIndex = 24;
            this.picArtikli.TabStop = false;
            // 
            // lblNaslovniText
            // 
            this.lblNaslovniText.AutoSize = true;
            this.lblNaslovniText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.lblNaslovniText.Location = new System.Drawing.Point(113, 50);
            this.lblNaslovniText.Name = "lblNaslovniText";
            this.lblNaslovniText.Size = new System.Drawing.Size(150, 38);
            this.lblNaslovniText.TabIndex = 23;
            this.lblNaslovniText.Text = "Statistika";
            // 
            // lblIzlaz
            // 
            this.lblIzlaz.AutoSize = true;
            this.lblIzlaz.Location = new System.Drawing.Point(384, 383);
            this.lblIzlaz.Name = "lblIzlaz";
            this.lblIzlaz.Size = new System.Drawing.Size(28, 13);
            this.lblIzlaz.TabIndex = 26;
            this.lblIzlaz.Text = "Izlaz";
            // 
            // picIzlaz
            // 
            this.picIzlaz.Image = ((System.Drawing.Image)(resources.GetObject("picIzlaz.Image")));
            this.picIzlaz.Location = new System.Drawing.Point(357, 304);
            this.picIzlaz.Name = "picIzlaz";
            this.picIzlaz.Size = new System.Drawing.Size(76, 71);
            this.picIzlaz.TabIndex = 25;
            this.picIzlaz.TabStop = false;
            this.picIzlaz.Click += new System.EventHandler(this.picIzlaz_Click);
            // 
            // btnKlase
            // 
            this.btnKlase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnKlase.Location = new System.Drawing.Point(120, 151);
            this.btnKlase.Name = "btnKlase";
            this.btnKlase.Size = new System.Drawing.Size(218, 54);
            this.btnKlase.TabIndex = 27;
            this.btnKlase.Text = "Statistika po klasama";
            this.btnKlase.UseVisualStyleBackColor = true;
            this.btnKlase.Click += new System.EventHandler(this.btnKlase_Click);
            // 
            // btnDokumenti
            // 
            this.btnDokumenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnDokumenti.Location = new System.Drawing.Point(120, 229);
            this.btnDokumenti.Name = "btnDokumenti";
            this.btnDokumenti.Size = new System.Drawing.Size(218, 54);
            this.btnDokumenti.TabIndex = 28;
            this.btnDokumenti.Text = "Statistika po vrsti dokumenta";
            this.btnDokumenti.UseVisualStyleBackColor = true;
            this.btnDokumenti.Click += new System.EventHandler(this.btnDokumenti_Click);
            // 
            // formaStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(462, 403);
            this.Controls.Add(this.btnDokumenti);
            this.Controls.Add(this.btnKlase);
            this.Controls.Add(this.lblIzlaz);
            this.Controls.Add(this.picIzlaz);
            this.Controls.Add(this.picArtikli);
            this.Controls.Add(this.lblNaslovniText);
            this.Name = "formaStatistika";
            this.Text = "Statistika";
            ((System.ComponentModel.ISupportInitialize)(this.picArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picArtikli;
        private System.Windows.Forms.Label lblNaslovniText;
        private System.Windows.Forms.Label lblIzlaz;
        private System.Windows.Forms.PictureBox picIzlaz;
        private System.Windows.Forms.Button btnKlase;
        private System.Windows.Forms.Button btnDokumenti;
    }
}