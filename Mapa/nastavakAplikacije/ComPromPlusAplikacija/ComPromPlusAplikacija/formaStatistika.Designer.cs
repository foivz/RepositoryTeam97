namespace ComPromPlusAplikacija
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
            this.btnDokumenti = new System.Windows.Forms.Button();
            this.btnKlase = new System.Windows.Forms.Button();
            this.lblIzlaz = new System.Windows.Forms.Label();
            this.picIzlaz = new System.Windows.Forms.PictureBox();
            this.picArtikli = new System.Windows.Forms.PictureBox();
            this.lblNaslovniText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArtikli)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDokumenti
            // 
            this.btnDokumenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnDokumenti.Location = new System.Drawing.Point(133, 206);
            this.btnDokumenti.Name = "btnDokumenti";
            this.btnDokumenti.Size = new System.Drawing.Size(218, 54);
            this.btnDokumenti.TabIndex = 34;
            this.btnDokumenti.Text = "Statistika po vrsti dokumenta";
            this.btnDokumenti.UseVisualStyleBackColor = true;
            // 
            // btnKlase
            // 
            this.btnKlase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnKlase.Location = new System.Drawing.Point(133, 128);
            this.btnKlase.Name = "btnKlase";
            this.btnKlase.Size = new System.Drawing.Size(218, 54);
            this.btnKlase.TabIndex = 33;
            this.btnKlase.Text = "Statistika po klasama";
            this.btnKlase.UseVisualStyleBackColor = true;
            // 
            // lblIzlaz
            // 
            this.lblIzlaz.AutoSize = true;
            this.lblIzlaz.Location = new System.Drawing.Point(447, 359);
            this.lblIzlaz.Name = "lblIzlaz";
            this.lblIzlaz.Size = new System.Drawing.Size(28, 13);
            this.lblIzlaz.TabIndex = 32;
            this.lblIzlaz.Text = "Izlaz";
            // 
            // picIzlaz
            // 
            this.picIzlaz.Image = ((System.Drawing.Image)(resources.GetObject("picIzlaz.Image")));
            this.picIzlaz.Location = new System.Drawing.Point(420, 280);
            this.picIzlaz.Name = "picIzlaz";
            this.picIzlaz.Size = new System.Drawing.Size(76, 71);
            this.picIzlaz.TabIndex = 31;
            this.picIzlaz.TabStop = false;
            // 
            // picArtikli
            // 
            this.picArtikli.Image = ((System.Drawing.Image)(resources.GetObject("picArtikli.Image")));
            this.picArtikli.Location = new System.Drawing.Point(50, 12);
            this.picArtikli.Name = "picArtikli";
            this.picArtikli.Size = new System.Drawing.Size(70, 67);
            this.picArtikli.TabIndex = 30;
            this.picArtikli.TabStop = false;
            // 
            // lblNaslovniText
            // 
            this.lblNaslovniText.AutoSize = true;
            this.lblNaslovniText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.lblNaslovniText.Location = new System.Drawing.Point(126, 27);
            this.lblNaslovniText.Name = "lblNaslovniText";
            this.lblNaslovniText.Size = new System.Drawing.Size(150, 38);
            this.lblNaslovniText.TabIndex = 29;
            this.lblNaslovniText.Text = "Statistika";
            // 
            // formaStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 381);
            this.Controls.Add(this.btnDokumenti);
            this.Controls.Add(this.btnKlase);
            this.Controls.Add(this.lblIzlaz);
            this.Controls.Add(this.picIzlaz);
            this.Controls.Add(this.picArtikli);
            this.Controls.Add(this.lblNaslovniText);
            this.Name = "formaStatistika";
            this.Text = "Statistika";
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArtikli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDokumenti;
        private System.Windows.Forms.Button btnKlase;
        private System.Windows.Forms.Label lblIzlaz;
        private System.Windows.Forms.PictureBox picIzlaz;
        private System.Windows.Forms.PictureBox picArtikli;
        private System.Windows.Forms.Label lblNaslovniText;
    }
}