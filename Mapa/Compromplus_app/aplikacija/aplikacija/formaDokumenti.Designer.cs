﻿namespace aplikacija
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
            this.cboPoslovniPartner = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.lblObrisi = new System.Windows.Forms.Label();
            this.lblSpremi = new System.Windows.Forms.Label();
            this.lblUnos = new System.Windows.Forms.Label();
            this.picObrisi = new System.Windows.Forms.PictureBox();
            this.picUnos = new System.Windows.Forms.PictureBox();
            this.picSpremi = new System.Windows.Forms.PictureBox();
            this.picRight = new System.Windows.Forms.PictureBox();
            this.picLeft = new System.Windows.Forms.PictureBox();
            this.txtUkupnaVrijednost = new System.Windows.Forms.TextBox();
            this.lblUkupnaVrijednost = new System.Windows.Forms.Label();
            this.lblPoslovniPartner = new System.Windows.Forms.Label();
            this.grpStavkeDokumenta = new System.Windows.Forms.GroupBox();
            this.dgdDokument = new System.Windows.Forms.DataGridView();
            this.colArtikl = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colSifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBoja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboKorisnikId = new System.Windows.Forms.ComboBox();
            this.cboTipDokumenta = new System.Windows.Forms.ComboBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtIdDokument = new System.Windows.Forms.TextBox();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblImeIPrezimeKorisnika = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblIdDokumenta = new System.Windows.Forms.Label();
            this.lblTipDokumenta = new System.Windows.Forms.Label();
            this.lblDokumentiIkona = new System.Windows.Forms.Label();
            this.picDokumentiIkona = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObrisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpremi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).BeginInit();
            this.grpStavkeDokumenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDokument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDokumentiIkona)).BeginInit();
            this.SuspendLayout();
            // 
            // cboPoslovniPartner
            // 
            this.cboPoslovniPartner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cboPoslovniPartner.FormattingEnabled = true;
            this.cboPoslovniPartner.Location = new System.Drawing.Point(482, 242);
            this.cboPoslovniPartner.Name = "cboPoslovniPartner";
            this.cboPoslovniPartner.Size = new System.Drawing.Size(229, 28);
            this.cboPoslovniPartner.TabIndex = 122;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(736, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 120;
            this.label1.Text = "Izlaz";
            // 
            // picExit
            // 
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(729, 318);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(68, 70);
            this.picExit.TabIndex = 119;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // lblObrisi
            // 
            this.lblObrisi.AutoSize = true;
            this.lblObrisi.Location = new System.Drawing.Point(686, 97);
            this.lblObrisi.Name = "lblObrisi";
            this.lblObrisi.Size = new System.Drawing.Size(33, 13);
            this.lblObrisi.TabIndex = 118;
            this.lblObrisi.Text = "Obriši";
            // 
            // lblSpremi
            // 
            this.lblSpremi.AutoSize = true;
            this.lblSpremi.Location = new System.Drawing.Point(589, 97);
            this.lblSpremi.Name = "lblSpremi";
            this.lblSpremi.Size = new System.Drawing.Size(39, 13);
            this.lblSpremi.TabIndex = 117;
            this.lblSpremi.Text = "Spremi";
            // 
            // lblUnos
            // 
            this.lblUnos.AutoSize = true;
            this.lblUnos.Location = new System.Drawing.Point(489, 97);
            this.lblUnos.Name = "lblUnos";
            this.lblUnos.Size = new System.Drawing.Size(58, 13);
            this.lblUnos.TabIndex = 116;
            this.lblUnos.Text = "Dodaj novi";
            // 
            // picObrisi
            // 
            this.picObrisi.Image = ((System.Drawing.Image)(resources.GetObject("picObrisi.Image")));
            this.picObrisi.Location = new System.Drawing.Point(672, 24);
            this.picObrisi.Name = "picObrisi";
            this.picObrisi.Size = new System.Drawing.Size(68, 70);
            this.picObrisi.TabIndex = 115;
            this.picObrisi.TabStop = false;
            // 
            // picUnos
            // 
            this.picUnos.Image = ((System.Drawing.Image)(resources.GetObject("picUnos.Image")));
            this.picUnos.Location = new System.Drawing.Point(482, 24);
            this.picUnos.Name = "picUnos";
            this.picUnos.Size = new System.Drawing.Size(68, 70);
            this.picUnos.TabIndex = 114;
            this.picUnos.TabStop = false;
            // 
            // picSpremi
            // 
            this.picSpremi.Image = ((System.Drawing.Image)(resources.GetObject("picSpremi.Image")));
            this.picSpremi.Location = new System.Drawing.Point(576, 24);
            this.picSpremi.Name = "picSpremi";
            this.picSpremi.Size = new System.Drawing.Size(68, 70);
            this.picSpremi.TabIndex = 113;
            this.picSpremi.TabStop = false;
            // 
            // picRight
            // 
            this.picRight.Image = ((System.Drawing.Image)(resources.GetObject("picRight.Image")));
            this.picRight.Location = new System.Drawing.Point(223, 304);
            this.picRight.Name = "picRight";
            this.picRight.Size = new System.Drawing.Size(69, 64);
            this.picRight.TabIndex = 112;
            this.picRight.TabStop = false;
            // 
            // picLeft
            // 
            this.picLeft.Image = ((System.Drawing.Image)(resources.GetObject("picLeft.Image")));
            this.picLeft.Location = new System.Drawing.Point(136, 304);
            this.picLeft.Name = "picLeft";
            this.picLeft.Size = new System.Drawing.Size(69, 64);
            this.picLeft.TabIndex = 111;
            this.picLeft.TabStop = false;
            // 
            // txtUkupnaVrijednost
            // 
            this.txtUkupnaVrijednost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtUkupnaVrijednost.Location = new System.Drawing.Point(482, 303);
            this.txtUkupnaVrijednost.Name = "txtUkupnaVrijednost";
            this.txtUkupnaVrijednost.Size = new System.Drawing.Size(229, 29);
            this.txtUkupnaVrijednost.TabIndex = 110;
            // 
            // lblUkupnaVrijednost
            // 
            this.lblUkupnaVrijednost.AutoSize = true;
            this.lblUkupnaVrijednost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUkupnaVrijednost.Location = new System.Drawing.Point(478, 280);
            this.lblUkupnaVrijednost.Name = "lblUkupnaVrijednost";
            this.lblUkupnaVrijednost.Size = new System.Drawing.Size(136, 20);
            this.lblUkupnaVrijednost.TabIndex = 109;
            this.lblUkupnaVrijednost.Text = "Ukupna vrijednost";
            // 
            // lblPoslovniPartner
            // 
            this.lblPoslovniPartner.AutoSize = true;
            this.lblPoslovniPartner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPoslovniPartner.Location = new System.Drawing.Point(478, 219);
            this.lblPoslovniPartner.Name = "lblPoslovniPartner";
            this.lblPoslovniPartner.Size = new System.Drawing.Size(122, 20);
            this.lblPoslovniPartner.TabIndex = 121;
            this.lblPoslovniPartner.Text = "Poslovni partner";
            // 
            // grpStavkeDokumenta
            // 
            this.grpStavkeDokumenta.Controls.Add(this.dgdDokument);
            this.grpStavkeDokumenta.Location = new System.Drawing.Point(86, 394);
            this.grpStavkeDokumenta.Name = "grpStavkeDokumenta";
            this.grpStavkeDokumenta.Size = new System.Drawing.Size(726, 249);
            this.grpStavkeDokumenta.TabIndex = 108;
            this.grpStavkeDokumenta.TabStop = false;
            this.grpStavkeDokumenta.Text = "Stavke dokumenta";
            // 
            // dgdDokument
            // 
            this.dgdDokument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdDokument.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colArtikl,
            this.colSifra,
            this.colBoja,
            this.colKolicina,
            this.colCijena,
            this.colIznos});
            this.dgdDokument.Location = new System.Drawing.Point(6, 30);
            this.dgdDokument.Name = "dgdDokument";
            this.dgdDokument.Size = new System.Drawing.Size(714, 203);
            this.dgdDokument.TabIndex = 0;
            // 
            // colArtikl
            // 
            this.colArtikl.HeaderText = "Naziv";
            this.colArtikl.Name = "colArtikl";
            // 
            // colSifra
            // 
            this.colSifra.HeaderText = "Šifra";
            this.colSifra.Name = "colSifra";
            this.colSifra.Width = 140;
            // 
            // colBoja
            // 
            this.colBoja.HeaderText = "Boja";
            this.colBoja.Name = "colBoja";
            // 
            // colKolicina
            // 
            this.colKolicina.HeaderText = "Količina";
            this.colKolicina.Name = "colKolicina";
            this.colKolicina.Width = 140;
            // 
            // colCijena
            // 
            this.colCijena.HeaderText = "Cijena";
            this.colCijena.Name = "colCijena";
            // 
            // colIznos
            // 
            this.colIznos.HeaderText = "Iznos";
            this.colIznos.Name = "colIznos";
            // 
            // cboKorisnikId
            // 
            this.cboKorisnikId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cboKorisnikId.FormattingEnabled = true;
            this.cboKorisnikId.Location = new System.Drawing.Point(248, 260);
            this.cboKorisnikId.Name = "cboKorisnikId";
            this.cboKorisnikId.Size = new System.Drawing.Size(192, 28);
            this.cboKorisnikId.TabIndex = 107;
            // 
            // cboTipDokumenta
            // 
            this.cboTipDokumenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cboTipDokumenta.FormattingEnabled = true;
            this.cboTipDokumenta.Location = new System.Drawing.Point(248, 176);
            this.cboTipDokumenta.Name = "cboTipDokumenta";
            this.cboTipDokumenta.Size = new System.Drawing.Size(192, 28);
            this.cboTipDokumenta.TabIndex = 106;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(552, 137);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(254, 74);
            this.txtOpis.TabIndex = 105;
            // 
            // txtDatum
            // 
            this.txtDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtDatum.Location = new System.Drawing.Point(248, 219);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(192, 26);
            this.txtDatum.TabIndex = 104;
            // 
            // txtIdDokument
            // 
            this.txtIdDokument.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtIdDokument.Location = new System.Drawing.Point(248, 137);
            this.txtIdDokument.Name = "txtIdDokument";
            this.txtIdDokument.Size = new System.Drawing.Size(192, 26);
            this.txtIdDokument.TabIndex = 103;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblOpis.Location = new System.Drawing.Point(478, 135);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(44, 20);
            this.lblOpis.TabIndex = 102;
            this.lblOpis.Text = "Opis";
            // 
            // lblImeIPrezimeKorisnika
            // 
            this.lblImeIPrezimeKorisnika.AutoSize = true;
            this.lblImeIPrezimeKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblImeIPrezimeKorisnika.Location = new System.Drawing.Point(82, 260);
            this.lblImeIPrezimeKorisnika.Name = "lblImeIPrezimeKorisnika";
            this.lblImeIPrezimeKorisnika.Size = new System.Drawing.Size(140, 20);
            this.lblImeIPrezimeKorisnika.TabIndex = 101;
            this.lblImeIPrezimeKorisnika.Text = "Odgovorna osoba";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblDatum.Location = new System.Drawing.Point(82, 219);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(134, 20);
            this.lblDatum.TabIndex = 100;
            this.lblDatum.Text = "Datum izdavanja";
            // 
            // lblIdDokumenta
            // 
            this.lblIdDokumenta.AutoSize = true;
            this.lblIdDokumenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblIdDokumenta.Location = new System.Drawing.Point(82, 137);
            this.lblIdDokumenta.Name = "lblIdDokumenta";
            this.lblIdDokumenta.Size = new System.Drawing.Size(130, 20);
            this.lblIdDokumenta.TabIndex = 99;
            this.lblIdDokumenta.Text = "Šifra dokumenta";
            // 
            // lblTipDokumenta
            // 
            this.lblTipDokumenta.AutoSize = true;
            this.lblTipDokumenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblTipDokumenta.Location = new System.Drawing.Point(82, 176);
            this.lblTipDokumenta.Name = "lblTipDokumenta";
            this.lblTipDokumenta.Size = new System.Drawing.Size(135, 20);
            this.lblTipDokumenta.TabIndex = 98;
            this.lblTipDokumenta.Text = "Vrsta dokumenta";
            // 
            // lblDokumentiIkona
            // 
            this.lblDokumentiIkona.AutoSize = true;
            this.lblDokumentiIkona.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDokumentiIkona.Location = new System.Drawing.Point(140, 36);
            this.lblDokumentiIkona.Name = "lblDokumentiIkona";
            this.lblDokumentiIkona.Size = new System.Drawing.Size(184, 39);
            this.lblDokumentiIkona.TabIndex = 97;
            this.lblDokumentiIkona.Text = "Dokumenti";
            // 
            // picDokumentiIkona
            // 
            this.picDokumentiIkona.Image = ((System.Drawing.Image)(resources.GetObject("picDokumentiIkona.Image")));
            this.picDokumentiIkona.Location = new System.Drawing.Point(62, 24);
            this.picDokumentiIkona.Name = "picDokumentiIkona";
            this.picDokumentiIkona.Size = new System.Drawing.Size(63, 66);
            this.picDokumentiIkona.TabIndex = 96;
            this.picDokumentiIkona.TabStop = false;
            // 
            // formaDokumenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 667);
            this.Controls.Add(this.cboPoslovniPartner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.lblObrisi);
            this.Controls.Add(this.lblSpremi);
            this.Controls.Add(this.lblUnos);
            this.Controls.Add(this.picObrisi);
            this.Controls.Add(this.picUnos);
            this.Controls.Add(this.picSpremi);
            this.Controls.Add(this.picRight);
            this.Controls.Add(this.picLeft);
            this.Controls.Add(this.txtUkupnaVrijednost);
            this.Controls.Add(this.lblUkupnaVrijednost);
            this.Controls.Add(this.lblPoslovniPartner);
            this.Controls.Add(this.grpStavkeDokumenta);
            this.Controls.Add(this.cboKorisnikId);
            this.Controls.Add(this.cboTipDokumenta);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtIdDokument);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblImeIPrezimeKorisnika);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblIdDokumenta);
            this.Controls.Add(this.lblTipDokumenta);
            this.Controls.Add(this.lblDokumentiIkona);
            this.Controls.Add(this.picDokumentiIkona);
            this.Name = "formaDokumenti";
            this.Text = "formaDokument";
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObrisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpremi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).EndInit();
            this.grpStavkeDokumenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdDokument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDokumentiIkona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPoslovniPartner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label lblObrisi;
        private System.Windows.Forms.Label lblSpremi;
        private System.Windows.Forms.Label lblUnos;
        private System.Windows.Forms.PictureBox picObrisi;
        private System.Windows.Forms.PictureBox picUnos;
        private System.Windows.Forms.PictureBox picSpremi;
        private System.Windows.Forms.PictureBox picRight;
        private System.Windows.Forms.PictureBox picLeft;
        private System.Windows.Forms.TextBox txtUkupnaVrijednost;
        private System.Windows.Forms.Label lblUkupnaVrijednost;
        private System.Windows.Forms.Label lblPoslovniPartner;
        private System.Windows.Forms.GroupBox grpStavkeDokumenta;
        private System.Windows.Forms.DataGridView dgdDokument;
        private System.Windows.Forms.ComboBox cboKorisnikId;
        private System.Windows.Forms.ComboBox cboTipDokumenta;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtIdDokument;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblImeIPrezimeKorisnika;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblIdDokumenta;
        private System.Windows.Forms.Label lblTipDokumenta;
        private System.Windows.Forms.Label lblDokumentiIkona;
        private System.Windows.Forms.PictureBox picDokumentiIkona;
        private System.Windows.Forms.DataGridViewComboBoxColumn colArtikl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBoja;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIznos;

    }
}