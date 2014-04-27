namespace aplikacija
{
    partial class formaDokumenti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formaDokumenti));
            this.btnIzdatnica = new System.Windows.Forms.Button();
            this.btnPrimka = new System.Windows.Forms.Button();
            this.btnNarudzbenica = new System.Windows.Forms.Button();
            this.btnOtpremnica = new System.Windows.Forms.Button();
            this.picDokumentiIkona = new System.Windows.Forms.PictureBox();
            this.grpDokumenti = new System.Windows.Forms.GroupBox();
            this.lblDokumentiIkona = new System.Windows.Forms.Label();
            this.btnIzlaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDokumentiIkona)).BeginInit();
            this.grpDokumenti.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIzdatnica
            // 
            this.btnIzdatnica.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnIzdatnica.Location = new System.Drawing.Point(37, 36);
            this.btnIzdatnica.Name = "btnIzdatnica";
            this.btnIzdatnica.Size = new System.Drawing.Size(179, 49);
            this.btnIzdatnica.TabIndex = 0;
            this.btnIzdatnica.Text = "Izdatnica";
            this.btnIzdatnica.UseVisualStyleBackColor = true;
            this.btnIzdatnica.Click += new System.EventHandler(this.btnIzdatnica_Click);
            // 
            // btnPrimka
            // 
            this.btnPrimka.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnPrimka.Location = new System.Drawing.Point(37, 108);
            this.btnPrimka.Name = "btnPrimka";
            this.btnPrimka.Size = new System.Drawing.Size(179, 49);
            this.btnPrimka.TabIndex = 1;
            this.btnPrimka.Text = "Primka";
            this.btnPrimka.UseVisualStyleBackColor = true;
            this.btnPrimka.Click += new System.EventHandler(this.btnPrimka_Click);
            // 
            // btnNarudzbenica
            // 
            this.btnNarudzbenica.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnNarudzbenica.Location = new System.Drawing.Point(273, 36);
            this.btnNarudzbenica.Name = "btnNarudzbenica";
            this.btnNarudzbenica.Size = new System.Drawing.Size(179, 49);
            this.btnNarudzbenica.TabIndex = 2;
            this.btnNarudzbenica.Text = "Narudžbenica";
            this.btnNarudzbenica.UseVisualStyleBackColor = true;
            this.btnNarudzbenica.Click += new System.EventHandler(this.btnNarudzbenica_Click);
            // 
            // btnOtpremnica
            // 
            this.btnOtpremnica.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnOtpremnica.Location = new System.Drawing.Point(273, 108);
            this.btnOtpremnica.Name = "btnOtpremnica";
            this.btnOtpremnica.Size = new System.Drawing.Size(179, 49);
            this.btnOtpremnica.TabIndex = 3;
            this.btnOtpremnica.Text = "Otpremnica";
            this.btnOtpremnica.UseVisualStyleBackColor = true;
            this.btnOtpremnica.Click += new System.EventHandler(this.btnOtpremnica_Click);
            // 
            // picDokumentiIkona
            // 
            this.picDokumentiIkona.Image = ((System.Drawing.Image)(resources.GetObject("picDokumentiIkona.Image")));
            this.picDokumentiIkona.Location = new System.Drawing.Point(13, 33);
            this.picDokumentiIkona.Name = "picDokumentiIkona";
            this.picDokumentiIkona.Size = new System.Drawing.Size(63, 66);
            this.picDokumentiIkona.TabIndex = 4;
            this.picDokumentiIkona.TabStop = false;
            // 
            // grpDokumenti
            // 
            this.grpDokumenti.Controls.Add(this.btnIzdatnica);
            this.grpDokumenti.Controls.Add(this.btnNarudzbenica);
            this.grpDokumenti.Controls.Add(this.btnOtpremnica);
            this.grpDokumenti.Controls.Add(this.btnPrimka);
            this.grpDokumenti.Location = new System.Drawing.Point(37, 142);
            this.grpDokumenti.Name = "grpDokumenti";
            this.grpDokumenti.Size = new System.Drawing.Size(493, 196);
            this.grpDokumenti.TabIndex = 5;
            this.grpDokumenti.TabStop = false;
            this.grpDokumenti.Text = "Dokumenti";
            // 
            // lblDokumentiIkona
            // 
            this.lblDokumentiIkona.AutoSize = true;
            this.lblDokumentiIkona.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDokumentiIkona.Location = new System.Drawing.Point(91, 45);
            this.lblDokumentiIkona.Name = "lblDokumentiIkona";
            this.lblDokumentiIkona.Size = new System.Drawing.Size(184, 39);
            this.lblDokumentiIkona.TabIndex = 16;
            this.lblDokumentiIkona.Text = "Dokumenti";
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnIzlaz.Location = new System.Drawing.Point(37, 380);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(175, 41);
            this.btnIzlaz.TabIndex = 69;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // formaDokumenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(571, 471);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.lblDokumentiIkona);
            this.Controls.Add(this.grpDokumenti);
            this.Controls.Add(this.picDokumentiIkona);
            this.Name = "formaDokumenti";
            this.Text = "Dokumenti";
            ((System.ComponentModel.ISupportInitialize)(this.picDokumentiIkona)).EndInit();
            this.grpDokumenti.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzdatnica;
        private System.Windows.Forms.Button btnPrimka;
        private System.Windows.Forms.Button btnNarudzbenica;
        private System.Windows.Forms.Button btnOtpremnica;
        private System.Windows.Forms.PictureBox picDokumentiIkona;
        private System.Windows.Forms.GroupBox grpDokumenti;
        private System.Windows.Forms.Label lblDokumentiIkona;
        private System.Windows.Forms.Button btnIzlaz;
    }
}