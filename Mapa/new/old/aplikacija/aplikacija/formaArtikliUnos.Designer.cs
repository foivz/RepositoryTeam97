namespace aplikacija
{
    partial class formaArtikliUnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formaArtikliUnos));
            this.lblArtikliIkona = new System.Windows.Forms.Label();
            this.picArtikliIkona = new System.Windows.Forms.PictureBox();
            this.cboEvidencijaKvaliteteId = new System.Windows.Forms.ComboBox();
            this.txtBoja = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtIdArtikli = new System.Windows.Forms.TextBox();
            this.lblEvidencijaKontroleID = new System.Windows.Forms.Label();
            this.lblBoja = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblIdArtikli = new System.Windows.Forms.Label();
            this.txtKolicinaNaSkladistu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEvidencijaKontrole = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.lblSpremi = new System.Windows.Forms.Label();
            this.picSpremi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picArtikliIkona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpremi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArtikliIkona
            // 
            this.lblArtikliIkona.AutoSize = true;
            this.lblArtikliIkona.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblArtikliIkona.Location = new System.Drawing.Point(94, 30);
            this.lblArtikliIkona.Name = "lblArtikliIkona";
            this.lblArtikliIkona.Size = new System.Drawing.Size(352, 39);
            this.lblArtikliIkona.TabIndex = 86;
            this.lblArtikliIkona.Text = "Unos/Izmjena artikala";
            // 
            // picArtikliIkona
            // 
            this.picArtikliIkona.Image = ((System.Drawing.Image)(resources.GetObject("picArtikliIkona.Image")));
            this.picArtikliIkona.Location = new System.Drawing.Point(20, 21);
            this.picArtikliIkona.Name = "picArtikliIkona";
            this.picArtikliIkona.Size = new System.Drawing.Size(68, 58);
            this.picArtikliIkona.TabIndex = 85;
            this.picArtikliIkona.TabStop = false;
            // 
            // cboEvidencijaKvaliteteId
            // 
            this.cboEvidencijaKvaliteteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cboEvidencijaKvaliteteId.FormattingEnabled = true;
            this.cboEvidencijaKvaliteteId.Items.AddRange(new object[] {
            "Klasa A",
            "Klasa B",
            "Klasa C"});
            this.cboEvidencijaKvaliteteId.Location = new System.Drawing.Point(101, 292);
            this.cboEvidencijaKvaliteteId.Name = "cboEvidencijaKvaliteteId";
            this.cboEvidencijaKvaliteteId.Size = new System.Drawing.Size(345, 28);
            this.cboEvidencijaKvaliteteId.TabIndex = 101;
            this.cboEvidencijaKvaliteteId.SelectedIndexChanged += new System.EventHandler(this.cboEvidencijaKvaliteteId_SelectedIndexChanged);
            // 
            // txtBoja
            // 
            this.txtBoja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtBoja.Location = new System.Drawing.Point(101, 246);
            this.txtBoja.Name = "txtBoja";
            this.txtBoja.Size = new System.Drawing.Size(345, 26);
            this.txtBoja.TabIndex = 100;
            // 
            // txtOpis
            // 
            this.txtOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtOpis.Location = new System.Drawing.Point(101, 199);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(345, 26);
            this.txtOpis.TabIndex = 99;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtNaziv.Location = new System.Drawing.Point(101, 157);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(345, 26);
            this.txtNaziv.TabIndex = 98;
            // 
            // txtIdArtikli
            // 
            this.txtIdArtikli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtIdArtikli.Location = new System.Drawing.Point(101, 116);
            this.txtIdArtikli.Name = "txtIdArtikli";
            this.txtIdArtikli.Size = new System.Drawing.Size(345, 26);
            this.txtIdArtikli.TabIndex = 97;
            // 
            // lblEvidencijaKontroleID
            // 
            this.lblEvidencijaKontroleID.AutoSize = true;
            this.lblEvidencijaKontroleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblEvidencijaKontroleID.Location = new System.Drawing.Point(27, 292);
            this.lblEvidencijaKontroleID.Name = "lblEvidencijaKontroleID";
            this.lblEvidencijaKontroleID.Size = new System.Drawing.Size(51, 20);
            this.lblEvidencijaKontroleID.TabIndex = 96;
            this.lblEvidencijaKontroleID.Text = "Klasa";
            // 
            // lblBoja
            // 
            this.lblBoja.AutoSize = true;
            this.lblBoja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblBoja.Location = new System.Drawing.Point(27, 246);
            this.lblBoja.Name = "lblBoja";
            this.lblBoja.Size = new System.Drawing.Size(43, 20);
            this.lblBoja.TabIndex = 95;
            this.lblBoja.Text = "Boja";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblOpis.Location = new System.Drawing.Point(27, 199);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(44, 20);
            this.lblOpis.TabIndex = 94;
            this.lblOpis.Text = "Opis";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNaziv.Location = new System.Drawing.Point(27, 157);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(51, 20);
            this.lblNaziv.TabIndex = 93;
            this.lblNaziv.Text = "Naziv";
            // 
            // lblIdArtikli
            // 
            this.lblIdArtikli.AutoSize = true;
            this.lblIdArtikli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblIdArtikli.Location = new System.Drawing.Point(27, 116);
            this.lblIdArtikli.Name = "lblIdArtikli";
            this.lblIdArtikli.Size = new System.Drawing.Size(44, 20);
            this.lblIdArtikli.TabIndex = 92;
            this.lblIdArtikli.Text = "Šifra";
            // 
            // txtKolicinaNaSkladistu
            // 
            this.txtKolicinaNaSkladistu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtKolicinaNaSkladistu.Location = new System.Drawing.Point(195, 336);
            this.txtKolicinaNaSkladistu.Name = "txtKolicinaNaSkladistu";
            this.txtKolicinaNaSkladistu.Size = new System.Drawing.Size(251, 26);
            this.txtKolicinaNaSkladistu.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(27, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 102;
            this.label1.Text = "Količina na skladištu";
            // 
            // txtEvidencijaKontrole
            // 
            this.txtEvidencijaKontrole.Location = new System.Drawing.Point(31, 403);
            this.txtEvidencijaKontrole.Name = "txtEvidencijaKontrole";
            this.txtEvidencijaKontrole.Size = new System.Drawing.Size(100, 20);
            this.txtEvidencijaKontrole.TabIndex = 104;
            this.txtEvidencijaKontrole.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 138;
            this.label2.Text = "Izlaz";
            // 
            // picExit
            // 
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(285, 378);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(68, 70);
            this.picExit.TabIndex = 137;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // lblSpremi
            // 
            this.lblSpremi.AutoSize = true;
            this.lblSpremi.Location = new System.Drawing.Point(209, 451);
            this.lblSpremi.Name = "lblSpremi";
            this.lblSpremi.Size = new System.Drawing.Size(39, 13);
            this.lblSpremi.TabIndex = 136;
            this.lblSpremi.Text = "Spremi";
            // 
            // picSpremi
            // 
            this.picSpremi.Image = ((System.Drawing.Image)(resources.GetObject("picSpremi.Image")));
            this.picSpremi.Location = new System.Drawing.Point(196, 378);
            this.picSpremi.Name = "picSpremi";
            this.picSpremi.Size = new System.Drawing.Size(68, 70);
            this.picSpremi.TabIndex = 135;
            this.picSpremi.TabStop = false;
            this.picSpremi.Click += new System.EventHandler(this.picSpremi_Click);
            // 
            // formaArtikliUnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(505, 482);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.lblSpremi);
            this.Controls.Add(this.picSpremi);
            this.Controls.Add(this.txtEvidencijaKontrole);
            this.Controls.Add(this.txtKolicinaNaSkladistu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboEvidencijaKvaliteteId);
            this.Controls.Add(this.txtBoja);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtIdArtikli);
            this.Controls.Add(this.lblEvidencijaKontroleID);
            this.Controls.Add(this.lblBoja);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblIdArtikli);
            this.Controls.Add(this.lblArtikliIkona);
            this.Controls.Add(this.picArtikliIkona);
            this.Name = "formaArtikliUnos";
            this.Text = "formaArtikliUnos";
            this.Load += new System.EventHandler(this.formaArtikliUnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picArtikliIkona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpremi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArtikliIkona;
        private System.Windows.Forms.PictureBox picArtikliIkona;
        private System.Windows.Forms.ComboBox cboEvidencijaKvaliteteId;
        private System.Windows.Forms.TextBox txtBoja;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtIdArtikli;
        private System.Windows.Forms.Label lblEvidencijaKontroleID;
        private System.Windows.Forms.Label lblBoja;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblIdArtikli;
        private System.Windows.Forms.TextBox txtKolicinaNaSkladistu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEvidencijaKontrole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label lblSpremi;
        private System.Windows.Forms.PictureBox picSpremi;

    }
}