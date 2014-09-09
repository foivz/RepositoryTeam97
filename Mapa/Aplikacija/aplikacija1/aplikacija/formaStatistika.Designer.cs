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
            this.lblStatistika = new System.Windows.Forms.Label();
            this.picStatistikaIkona = new System.Windows.Forms.PictureBox();
            this.btnKlaseStatistika = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picStatistikaIkona)).BeginInit();
            this.SuspendLayout();
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
            // btnKlaseStatistika
            // 
            this.btnKlaseStatistika.Location = new System.Drawing.Point(73, 164);
            this.btnKlaseStatistika.Name = "btnKlaseStatistika";
            this.btnKlaseStatistika.Size = new System.Drawing.Size(156, 47);
            this.btnKlaseStatistika.TabIndex = 146;
            this.btnKlaseStatistika.Text = "Klase kvalitete";
            this.btnKlaseStatistika.UseVisualStyleBackColor = true;
            this.btnKlaseStatistika.Click += new System.EventHandler(this.btnKlaseStatistika_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 47);
            this.button1.TabIndex = 147;
            this.button1.Text = "Vrste dokumenata";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formaStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 547);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKlaseStatistika);
            this.Controls.Add(this.lblStatistika);
            this.Controls.Add(this.picStatistikaIkona);
            this.Name = "formaStatistika";
            this.Text = "Statistika";
            ((System.ComponentModel.ISupportInitialize)(this.picStatistikaIkona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatistika;
        private System.Windows.Forms.PictureBox picStatistikaIkona;
        private System.Windows.Forms.Button btnKlaseStatistika;
        private System.Windows.Forms.Button button1;
    }
}