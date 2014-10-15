namespace ComPromPlusAplikacija
{
    partial class formaDokumentiPregled
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formaDokumentiPregled));
            this.btnPrimka = new System.Windows.Forms.Button();
            this.btnOtpremnica = new System.Windows.Forms.Button();
            this.btnIzdatnica = new System.Windows.Forms.Button();
            this.btnNarudzbenica = new System.Windows.Forms.Button();
            this.picCompromplusLogo = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picIzlaz = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCompromplusLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrimka
            // 
            this.btnPrimka.Location = new System.Drawing.Point(57, 249);
            this.btnPrimka.Name = "btnPrimka";
            this.btnPrimka.Size = new System.Drawing.Size(179, 56);
            this.btnPrimka.TabIndex = 24;
            this.btnPrimka.Text = "Primka";
            this.btnPrimka.UseVisualStyleBackColor = true;
            this.btnPrimka.Click += new System.EventHandler(this.btnPrimka_Click);
            // 
            // btnOtpremnica
            // 
            this.btnOtpremnica.Location = new System.Drawing.Point(332, 249);
            this.btnOtpremnica.Name = "btnOtpremnica";
            this.btnOtpremnica.Size = new System.Drawing.Size(179, 56);
            this.btnOtpremnica.TabIndex = 23;
            this.btnOtpremnica.Text = "Otpremnica";
            this.btnOtpremnica.UseVisualStyleBackColor = true;
            this.btnOtpremnica.Click += new System.EventHandler(this.btnOtpremnica_Click);
            // 
            // btnIzdatnica
            // 
            this.btnIzdatnica.Location = new System.Drawing.Point(332, 166);
            this.btnIzdatnica.Name = "btnIzdatnica";
            this.btnIzdatnica.Size = new System.Drawing.Size(179, 56);
            this.btnIzdatnica.TabIndex = 22;
            this.btnIzdatnica.Text = "Izdatnica";
            this.btnIzdatnica.UseVisualStyleBackColor = true;
            this.btnIzdatnica.Click += new System.EventHandler(this.btnIzdatnica_Click);
            // 
            // btnNarudzbenica
            // 
            this.btnNarudzbenica.Location = new System.Drawing.Point(57, 166);
            this.btnNarudzbenica.Name = "btnNarudzbenica";
            this.btnNarudzbenica.Size = new System.Drawing.Size(179, 56);
            this.btnNarudzbenica.TabIndex = 21;
            this.btnNarudzbenica.Text = "Narudžbenica";
            this.btnNarudzbenica.UseVisualStyleBackColor = true;
            this.btnNarudzbenica.Click += new System.EventHandler(this.btnNarudzbenica_Click);
            // 
            // picCompromplusLogo
            // 
            this.picCompromplusLogo.Image = ((System.Drawing.Image)(resources.GetObject("picCompromplusLogo.Image")));
            this.picCompromplusLogo.Location = new System.Drawing.Point(96, 33);
            this.picCompromplusLogo.Name = "picCompromplusLogo";
            this.picCompromplusLogo.Size = new System.Drawing.Size(392, 70);
            this.picCompromplusLogo.TabIndex = 20;
            this.picCompromplusLogo.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(530, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Izlaz";
            // 
            // picIzlaz
            // 
            this.picIzlaz.Image = ((System.Drawing.Image)(resources.GetObject("picIzlaz.Image")));
            this.picIzlaz.Location = new System.Drawing.Point(503, 330);
            this.picIzlaz.Name = "picIzlaz";
            this.picIzlaz.Size = new System.Drawing.Size(70, 67);
            this.picIzlaz.TabIndex = 37;
            this.picIzlaz.TabStop = false;
            this.picIzlaz.Click += new System.EventHandler(this.picIzlaz_Click);
            // 
            // formaDokumentiPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 423);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picIzlaz);
            this.Controls.Add(this.btnPrimka);
            this.Controls.Add(this.btnOtpremnica);
            this.Controls.Add(this.btnIzdatnica);
            this.Controls.Add(this.btnNarudzbenica);
            this.Controls.Add(this.picCompromplusLogo);
            this.Name = "formaDokumentiPregled";
            this.Text = "Pregled svih dokumenata";
            ((System.ComponentModel.ISupportInitialize)(this.picCompromplusLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrimka;
        private System.Windows.Forms.Button btnOtpremnica;
        private System.Windows.Forms.Button btnIzdatnica;
        private System.Windows.Forms.Button btnNarudzbenica;
        private System.Windows.Forms.PictureBox picCompromplusLogo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picIzlaz;
    }
}