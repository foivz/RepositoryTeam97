namespace aplikacija
{
    partial class formaPrijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formaPrijava));
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.btnPrijaviSe = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.picEnigma = new System.Windows.Forms.PictureBox();
            this.picLozinka = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLozinka)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblKorisnickoIme.Location = new System.Drawing.Point(120, 135);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(149, 22);
            this.lblKorisnickoIme.TabIndex = 0;
            this.lblKorisnickoIme.Text = "Korisničko ime";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Font = new System.Drawing.Font("Arial", 16F);
            this.txtKorisnickoIme.Location = new System.Drawing.Point(124, 157);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(289, 32);
            this.txtKorisnickoIme.TabIndex = 1;
            this.txtKorisnickoIme.TextChanged += new System.EventHandler(this.txtKorisnickoIme_TextChanged);
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblLozinka.Location = new System.Drawing.Point(120, 225);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(83, 22);
            this.lblLozinka.TabIndex = 2;
            this.lblLozinka.Text = "Lozinka";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Font = new System.Drawing.Font("Arial", 16F);
            this.txtLozinka.Location = new System.Drawing.Point(124, 247);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(289, 32);
            this.txtLozinka.TabIndex = 3;
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.Font = new System.Drawing.Font("Arial", 12.25F);
            this.btnPrijaviSe.Location = new System.Drawing.Point(142, 318);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(111, 37);
            this.btnPrijaviSe.TabIndex = 4;
            this.btnPrijaviSe.Text = "Prijavi se";
            this.btnPrijaviSe.UseVisualStyleBackColor = true;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Font = new System.Drawing.Font("Arial", 12.25F);
            this.btnIzlaz.Location = new System.Drawing.Point(269, 318);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(111, 37);
            this.btnIzlaz.TabIndex = 5;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(59, 25);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(382, 67);
            this.picLogo.TabIndex = 6;
            this.picLogo.TabStop = false;
            // 
            // picLogin
            // 
            this.picLogin.Image = ((System.Drawing.Image)(resources.GetObject("picLogin.Image")));
            this.picLogin.Location = new System.Drawing.Point(79, 153);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(33, 35);
            this.picLogin.TabIndex = 7;
            this.picLogin.TabStop = false;
            // 
            // picEnigma
            // 
            this.picEnigma.Image = ((System.Drawing.Image)(resources.GetObject("picEnigma.Image")));
            this.picEnigma.Location = new System.Drawing.Point(388, 371);
            this.picEnigma.Name = "picEnigma";
            this.picEnigma.Size = new System.Drawing.Size(91, 45);
            this.picEnigma.TabIndex = 8;
            this.picEnigma.TabStop = false;
            // 
            // picLozinka
            // 
            this.picLozinka.Image = ((System.Drawing.Image)(resources.GetObject("picLozinka.Image")));
            this.picLozinka.Location = new System.Drawing.Point(79, 243);
            this.picLozinka.Name = "picLozinka";
            this.picLozinka.Size = new System.Drawing.Size(33, 35);
            this.picLozinka.TabIndex = 9;
            this.picLozinka.TabStop = false;
            // 
            // formaPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(482, 417);
            this.Controls.Add(this.picLozinka);
            this.Controls.Add(this.picEnigma);
            this.Controls.Add(this.picLogin);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnPrijaviSe);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Name = "formaPrijava";
            this.Text = "Prijava";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLozinka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Button btnPrijaviSe;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.PictureBox picEnigma;
        private System.Windows.Forms.PictureBox picLozinka;
    }
}

