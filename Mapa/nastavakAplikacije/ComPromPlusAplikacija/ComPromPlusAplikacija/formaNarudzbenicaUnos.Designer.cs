namespace ComPromPlusAplikacija
{
    partial class formaNarudzbenicaUnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formaNarudzbenicaUnos));
            this.txtNazivDokumenta = new System.Windows.Forms.TextBox();
            this.lblNaslovniText = new System.Windows.Forms.Label();
            this.picDjelatnici = new System.Windows.Forms.PictureBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.lblDatum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdDokument = new System.Windows.Forms.TextBox();
            this.btnDalje = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDjelatnici)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNazivDokumenta
            // 
            this.txtNazivDokumenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtNazivDokumenta.Location = new System.Drawing.Point(249, 179);
            this.txtNazivDokumenta.Name = "txtNazivDokumenta";
            this.txtNazivDokumenta.Size = new System.Drawing.Size(200, 26);
            this.txtNazivDokumenta.TabIndex = 67;
            // 
            // lblNaslovniText
            // 
            this.lblNaslovniText.AutoSize = true;
            this.lblNaslovniText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.lblNaslovniText.Location = new System.Drawing.Point(106, 27);
            this.lblNaslovniText.Name = "lblNaslovniText";
            this.lblNaslovniText.Size = new System.Drawing.Size(219, 38);
            this.lblNaslovniText.TabIndex = 66;
            this.lblNaslovniText.Text = "Narudžbenica";
            // 
            // picDjelatnici
            // 
            this.picDjelatnici.Image = ((System.Drawing.Image)(resources.GetObject("picDjelatnici.Image")));
            this.picDjelatnici.Location = new System.Drawing.Point(30, 12);
            this.picDjelatnici.Name = "picDjelatnici";
            this.picDjelatnici.Size = new System.Drawing.Size(70, 67);
            this.picDjelatnici.TabIndex = 65;
            this.picDjelatnici.TabStop = false;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dtpDatum.Location = new System.Drawing.Point(249, 224);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 26);
            this.dtpDatum.TabIndex = 62;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblDatum.Location = new System.Drawing.Point(94, 224);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(59, 20);
            this.lblDatum.TabIndex = 61;
            this.lblDatum.Text = "Datum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(94, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Naziv dokumenta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(94, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "Šifra dokumenta";
            // 
            // txtIdDokument
            // 
            this.txtIdDokument.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtIdDokument.Location = new System.Drawing.Point(249, 135);
            this.txtIdDokument.Name = "txtIdDokument";
            this.txtIdDokument.Size = new System.Drawing.Size(200, 26);
            this.txtIdDokument.TabIndex = 58;
            // 
            // btnDalje
            // 
            this.btnDalje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDalje.Location = new System.Drawing.Point(559, 145);
            this.btnDalje.Name = "btnDalje";
            this.btnDalje.Size = new System.Drawing.Size(115, 39);
            this.btnDalje.TabIndex = 87;
            this.btnDalje.Text = "Dalje";
            this.btnDalje.UseVisualStyleBackColor = true;
            this.btnDalje.Click += new System.EventHandler(this.btnDalje_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.Location = new System.Drawing.Point(559, 202);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(115, 35);
            this.btnOdustani.TabIndex = 86;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(94, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 88;
            this.label3.Text = "Opis dokumenta";
            // 
            // txtOpis
            // 
            this.txtOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtOpis.Location = new System.Drawing.Point(249, 282);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(200, 26);
            this.txtOpis.TabIndex = 89;
            // 
            // formaNarudzbenicaUnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 351);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDalje);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtNazivDokumenta);
            this.Controls.Add(this.lblNaslovniText);
            this.Controls.Add(this.picDjelatnici);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdDokument);
            this.Name = "formaNarudzbenicaUnos";
            this.Text = "Narudžbenica Unos";
            ((System.ComponentModel.ISupportInitialize)(this.picDjelatnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNazivDokumenta;
        private System.Windows.Forms.Label lblNaslovniText;
        private System.Windows.Forms.PictureBox picDjelatnici;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdDokument;
        private System.Windows.Forms.Button btnDalje;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOpis;
    }
}