namespace aplikacija
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
            this.label1 = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.lblStatistika = new System.Windows.Forms.Label();
            this.picStatistikaIkona = new System.Windows.Forms.PictureBox();
            this.btnKlase = new System.Windows.Forms.Button();
            this.btnDokumenti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStatistikaIkona)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 157;
            this.label1.Text = "Izlaz";
            // 
            // picExit
            // 
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(362, 35);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(68, 70);
            this.picExit.TabIndex = 156;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // lblStatistika
            // 
            this.lblStatistika.AutoSize = true;
            this.lblStatistika.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatistika.Location = new System.Drawing.Point(98, 44);
            this.lblStatistika.Name = "lblStatistika";
            this.lblStatistika.Size = new System.Drawing.Size(160, 39);
            this.lblStatistika.TabIndex = 145;
            this.lblStatistika.Text = "Statistika";
            // 
            // picStatistikaIkona
            // 
            this.picStatistikaIkona.Image = ((System.Drawing.Image)(resources.GetObject("picStatistikaIkona.Image")));
            this.picStatistikaIkona.Location = new System.Drawing.Point(24, 35);
            this.picStatistikaIkona.Name = "picStatistikaIkona";
            this.picStatistikaIkona.Size = new System.Drawing.Size(68, 71);
            this.picStatistikaIkona.TabIndex = 144;
            this.picStatistikaIkona.TabStop = false;
            // 
            // btnKlase
            // 
            this.btnKlase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnKlase.Location = new System.Drawing.Point(118, 136);
            this.btnKlase.Name = "btnKlase";
            this.btnKlase.Size = new System.Drawing.Size(182, 62);
            this.btnKlase.TabIndex = 158;
            this.btnKlase.Text = "Klase kvalitete";
            this.btnKlase.UseVisualStyleBackColor = true;
            this.btnKlase.Click += new System.EventHandler(this.btnKlase_Click);
            // 
            // btnDokumenti
            // 
            this.btnDokumenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnDokumenti.Location = new System.Drawing.Point(118, 228);
            this.btnDokumenti.Name = "btnDokumenti";
            this.btnDokumenti.Size = new System.Drawing.Size(182, 62);
            this.btnDokumenti.TabIndex = 159;
            this.btnDokumenti.Text = "Vrste dokumenata";
            this.btnDokumenti.UseVisualStyleBackColor = true;
            this.btnDokumenti.Click += new System.EventHandler(this.btnDokumenti_Click);
            // 
            // formaStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(479, 314);
            this.Controls.Add(this.btnDokumenti);
            this.Controls.Add(this.btnKlase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.lblStatistika);
            this.Controls.Add(this.picStatistikaIkona);
            this.Name = "formaStatistika";
            this.Text = "Statistika";
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStatistikaIkona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label lblStatistika;
        private System.Windows.Forms.PictureBox picStatistikaIkona;
        private System.Windows.Forms.Button btnKlase;
        private System.Windows.Forms.Button btnDokumenti;
    }
}