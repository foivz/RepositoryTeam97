namespace aplikacija
{
    partial class formaStavkeDokumentaUnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formaStavkeDokumentaUnos));
            this.cboArtikl = new System.Windows.Forms.ComboBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.lblSpremi = new System.Windows.Forms.Label();
            this.picSpremi = new System.Windows.Forms.PictureBox();
            this.txtKolicinaNaSkladistu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpremi)).BeginInit();
            this.SuspendLayout();
            // 
            // cboArtikl
            // 
            this.cboArtikl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cboArtikl.FormattingEnabled = true;
            this.cboArtikl.Location = new System.Drawing.Point(146, 59);
            this.cboArtikl.Name = "cboArtikl";
            this.cboArtikl.Size = new System.Drawing.Size(233, 28);
            this.cboArtikl.TabIndex = 0;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNaziv.Location = new System.Drawing.Point(39, 62);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(101, 20);
            this.lblNaziv.TabIndex = 94;
            this.lblNaziv.Text = "Naziv artikla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 142;
            this.label2.Text = "Izlaz";
            // 
            // picExit
            // 
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(273, 281);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(68, 70);
            this.picExit.TabIndex = 141;
            this.picExit.TabStop = false;
            // 
            // lblSpremi
            // 
            this.lblSpremi.AutoSize = true;
            this.lblSpremi.Location = new System.Drawing.Point(197, 354);
            this.lblSpremi.Name = "lblSpremi";
            this.lblSpremi.Size = new System.Drawing.Size(39, 13);
            this.lblSpremi.TabIndex = 140;
            this.lblSpremi.Text = "Spremi";
            // 
            // picSpremi
            // 
            this.picSpremi.Image = ((System.Drawing.Image)(resources.GetObject("picSpremi.Image")));
            this.picSpremi.Location = new System.Drawing.Point(184, 281);
            this.picSpremi.Name = "picSpremi";
            this.picSpremi.Size = new System.Drawing.Size(68, 70);
            this.picSpremi.TabIndex = 139;
            this.picSpremi.TabStop = false;
            this.picSpremi.Click += new System.EventHandler(this.picSpremi_Click);
            // 
            // txtKolicinaNaSkladistu
            // 
            this.txtKolicinaNaSkladistu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtKolicinaNaSkladistu.Location = new System.Drawing.Point(146, 135);
            this.txtKolicinaNaSkladistu.Name = "txtKolicinaNaSkladistu";
            this.txtKolicinaNaSkladistu.Size = new System.Drawing.Size(233, 26);
            this.txtKolicinaNaSkladistu.TabIndex = 145;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(39, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 144;
            this.label1.Text = "Količina";
            // 
            // formaStavkeDokumentaUnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(592, 413);
            this.Controls.Add(this.txtKolicinaNaSkladistu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.lblSpremi);
            this.Controls.Add(this.picSpremi);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.cboArtikl);
            this.Name = "formaStavkeDokumentaUnos";
            this.Text = "formaStavkeDokumentaUnos";
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpremi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboArtikl;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label lblSpremi;
        private System.Windows.Forms.PictureBox picSpremi;
        private System.Windows.Forms.TextBox txtKolicinaNaSkladistu;
        private System.Windows.Forms.Label label1;
    }
}