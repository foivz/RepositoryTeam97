namespace ComPromPlusAplikacija
{
    partial class formaRepromaterijaliPregled
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formaRepromaterijaliPregled));
            this.lblNaslovniText = new System.Windows.Forms.Label();
            this.picArtikli = new System.Windows.Forms.PictureBox();
            this.lblIzlaz = new System.Windows.Forms.Label();
            this.lblObrisi = new System.Windows.Forms.Label();
            this.picIzlaz = new System.Windows.Forms.PictureBox();
            this.picObrisi = new System.Windows.Forms.PictureBox();
            this.lblIzmjeni = new System.Windows.Forms.Label();
            this.picIzmjeni = new System.Windows.Forms.PictureBox();
            this.lblDodaj = new System.Windows.Forms.Label();
            this.picDodaj = new System.Windows.Forms.PictureBox();
            this.btnPretrazivanjeSifra = new System.Windows.Forms.Button();
            this.txtPretrazivanjeSifra = new System.Windows.Forms.TextBox();
            this.lblPretrazivanjeSifra = new System.Windows.Forms.Label();
            this.txtPretrazivanje = new System.Windows.Forms.TextBox();
            this.lblPretrazivanje = new System.Windows.Forms.Label();
            this.dgvRepromaterijali = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repromaterijaliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t23_Enigma2DataSet = new ComPromPlusAplikacija.T23_Enigma2DataSet();
            this.repromaterijaliTableAdapter = new ComPromPlusAplikacija.T23_Enigma2DataSetTableAdapters.RepromaterijaliTableAdapter();
            this.tableAdapterManager = new ComPromPlusAplikacija.T23_Enigma2DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.picArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObrisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzmjeni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDodaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepromaterijali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repromaterijaliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_Enigma2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslovniText
            // 
            this.lblNaslovniText.AutoSize = true;
            this.lblNaslovniText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.lblNaslovniText.Location = new System.Drawing.Point(92, 22);
            this.lblNaslovniText.Name = "lblNaslovniText";
            this.lblNaslovniText.Size = new System.Drawing.Size(235, 38);
            this.lblNaslovniText.TabIndex = 94;
            this.lblNaslovniText.Text = "Repromaterijali";
            // 
            // picArtikli
            // 
            this.picArtikli.Image = ((System.Drawing.Image)(resources.GetObject("picArtikli.Image")));
            this.picArtikli.Location = new System.Drawing.Point(9, 8);
            this.picArtikli.Name = "picArtikli";
            this.picArtikli.Size = new System.Drawing.Size(70, 67);
            this.picArtikli.TabIndex = 93;
            this.picArtikli.TabStop = false;
            // 
            // lblIzlaz
            // 
            this.lblIzlaz.AutoSize = true;
            this.lblIzlaz.Location = new System.Drawing.Point(746, 79);
            this.lblIzlaz.Name = "lblIzlaz";
            this.lblIzlaz.Size = new System.Drawing.Size(28, 13);
            this.lblIzlaz.TabIndex = 92;
            this.lblIzlaz.Text = "Izlaz";
            // 
            // lblObrisi
            // 
            this.lblObrisi.AutoSize = true;
            this.lblObrisi.Location = new System.Drawing.Point(622, 82);
            this.lblObrisi.Name = "lblObrisi";
            this.lblObrisi.Size = new System.Drawing.Size(98, 13);
            this.lblObrisi.TabIndex = 91;
            this.lblObrisi.Text = "Obriši repromaterijal";
            // 
            // picIzlaz
            // 
            this.picIzlaz.Image = ((System.Drawing.Image)(resources.GetObject("picIzlaz.Image")));
            this.picIzlaz.Location = new System.Drawing.Point(720, 5);
            this.picIzlaz.Name = "picIzlaz";
            this.picIzlaz.Size = new System.Drawing.Size(76, 71);
            this.picIzlaz.TabIndex = 90;
            this.picIzlaz.TabStop = false;
            this.picIzlaz.Click += new System.EventHandler(this.picIzlaz_Click);
            // 
            // picObrisi
            // 
            this.picObrisi.Image = ((System.Drawing.Image)(resources.GetObject("picObrisi.Image")));
            this.picObrisi.Location = new System.Drawing.Point(625, 8);
            this.picObrisi.Name = "picObrisi";
            this.picObrisi.Size = new System.Drawing.Size(76, 71);
            this.picObrisi.TabIndex = 89;
            this.picObrisi.TabStop = false;
            this.picObrisi.Click += new System.EventHandler(this.picObrisi_Click);
            // 
            // lblIzmjeni
            // 
            this.lblIzmjeni.AutoSize = true;
            this.lblIzmjeni.Location = new System.Drawing.Point(504, 82);
            this.lblIzmjeni.Name = "lblIzmjeni";
            this.lblIzmjeni.Size = new System.Drawing.Size(104, 13);
            this.lblIzmjeni.TabIndex = 88;
            this.lblIzmjeni.Text = "Izmjeni repromaterijal";
            // 
            // picIzmjeni
            // 
            this.picIzmjeni.Image = ((System.Drawing.Image)(resources.GetObject("picIzmjeni.Image")));
            this.picIzmjeni.Location = new System.Drawing.Point(522, 8);
            this.picIzmjeni.Name = "picIzmjeni";
            this.picIzmjeni.Size = new System.Drawing.Size(76, 71);
            this.picIzmjeni.TabIndex = 87;
            this.picIzmjeni.TabStop = false;
            this.picIzmjeni.Click += new System.EventHandler(this.picIzmjeni_Click);
            // 
            // lblDodaj
            // 
            this.lblDodaj.AutoSize = true;
            this.lblDodaj.Location = new System.Drawing.Point(398, 82);
            this.lblDodaj.Name = "lblDodaj";
            this.lblDodaj.Size = new System.Drawing.Size(100, 13);
            this.lblDodaj.TabIndex = 86;
            this.lblDodaj.Text = "Dodaj repromaterijal";
            // 
            // picDodaj
            // 
            this.picDodaj.Image = ((System.Drawing.Image)(resources.GetObject("picDodaj.Image")));
            this.picDodaj.Location = new System.Drawing.Point(410, 8);
            this.picDodaj.Name = "picDodaj";
            this.picDodaj.Size = new System.Drawing.Size(76, 71);
            this.picDodaj.TabIndex = 85;
            this.picDodaj.TabStop = false;
            this.picDodaj.Click += new System.EventHandler(this.picDodaj_Click);
            // 
            // btnPretrazivanjeSifra
            // 
            this.btnPretrazivanjeSifra.Location = new System.Drawing.Point(714, 103);
            this.btnPretrazivanjeSifra.Name = "btnPretrazivanjeSifra";
            this.btnPretrazivanjeSifra.Size = new System.Drawing.Size(75, 26);
            this.btnPretrazivanjeSifra.TabIndex = 84;
            this.btnPretrazivanjeSifra.Text = "Traži";
            this.btnPretrazivanjeSifra.UseVisualStyleBackColor = true;
            this.btnPretrazivanjeSifra.Click += new System.EventHandler(this.btnPretrazivanjeSifra_Click_1);
            // 
            // txtPretrazivanjeSifra
            // 
            this.txtPretrazivanjeSifra.Location = new System.Drawing.Point(596, 107);
            this.txtPretrazivanjeSifra.Name = "txtPretrazivanjeSifra";
            this.txtPretrazivanjeSifra.Size = new System.Drawing.Size(100, 20);
            this.txtPretrazivanjeSifra.TabIndex = 83;
            // 
            // lblPretrazivanjeSifra
            // 
            this.lblPretrazivanjeSifra.AutoSize = true;
            this.lblPretrazivanjeSifra.Location = new System.Drawing.Point(452, 112);
            this.lblPretrazivanjeSifra.Name = "lblPretrazivanjeSifra";
            this.lblPretrazivanjeSifra.Size = new System.Drawing.Size(118, 13);
            this.lblPretrazivanjeSifra.TabIndex = 82;
            this.lblPretrazivanjeSifra.Text = "Pretraživanje prema šifri";
            // 
            // txtPretrazivanje
            // 
            this.txtPretrazivanje.Location = new System.Drawing.Point(99, 105);
            this.txtPretrazivanje.Name = "txtPretrazivanje";
            this.txtPretrazivanje.Size = new System.Drawing.Size(178, 20);
            this.txtPretrazivanje.TabIndex = 81;
            this.txtPretrazivanje.TextChanged += new System.EventHandler(this.txtPretrazivanje_TextChanged_1);
            // 
            // lblPretrazivanje
            // 
            this.lblPretrazivanje.AutoSize = true;
            this.lblPretrazivanje.Location = new System.Drawing.Point(11, 105);
            this.lblPretrazivanje.Name = "lblPretrazivanje";
            this.lblPretrazivanje.Size = new System.Drawing.Size(68, 13);
            this.lblPretrazivanje.TabIndex = 80;
            this.lblPretrazivanje.Text = "Pretraživanje";
            // 
            // dgvRepromaterijali
            // 
            this.dgvRepromaterijali.AllowUserToAddRows = false;
            this.dgvRepromaterijali.AllowUserToDeleteRows = false;
            this.dgvRepromaterijali.AutoGenerateColumns = false;
            this.dgvRepromaterijali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepromaterijali.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.bojaDataGridViewTextBoxColumn});
            this.dgvRepromaterijali.DataSource = this.repromaterijaliBindingSource;
            this.dgvRepromaterijali.Location = new System.Drawing.Point(113, 152);
            this.dgvRepromaterijali.Name = "dgvRepromaterijali";
            this.dgvRepromaterijali.Size = new System.Drawing.Size(543, 287);
            this.dgvRepromaterijali.TabIndex = 79;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // bojaDataGridViewTextBoxColumn
            // 
            this.bojaDataGridViewTextBoxColumn.DataPropertyName = "boja";
            this.bojaDataGridViewTextBoxColumn.HeaderText = "boja";
            this.bojaDataGridViewTextBoxColumn.Name = "bojaDataGridViewTextBoxColumn";
            // 
            // repromaterijaliBindingSource
            // 
            this.repromaterijaliBindingSource.DataMember = "Repromaterijali";
            this.repromaterijaliBindingSource.DataSource = this.t23_Enigma2DataSet;
            // 
            // t23_Enigma2DataSet
            // 
            this.t23_Enigma2DataSet.DataSetName = "T23_Enigma2DataSet";
            this.t23_Enigma2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repromaterijaliTableAdapter
            // 
            this.repromaterijaliTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArtikliTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DjelatnikTableAdapter = null;
            this.tableAdapterManager.IzdatnicaTableAdapter = null;
            this.tableAdapterManager.knjizenjeDokumentaTableAdapter = null;
            this.tableAdapterManager.KorisnikTableAdapter = null;
            this.tableAdapterManager.NarudzbenicaTableAdapter = null;
            this.tableAdapterManager.OtpremnicaTableAdapter = null;
            this.tableAdapterManager.poslovniPartnerTableAdapter = null;
            this.tableAdapterManager.pracenjeProizvodnjeTableAdapter = null;
            this.tableAdapterManager.PrimkaTableAdapter = null;
            this.tableAdapterManager.RepromaterijaliTableAdapter = this.repromaterijaliTableAdapter;
            this.tableAdapterManager.stavkeIzdatniceTableAdapter = null;
            this.tableAdapterManager.stavkeNarudzbeniceTableAdapter = null;
            this.tableAdapterManager.stavkeOtpremniceTableAdapter = null;
            this.tableAdapterManager.stavkePrimkeTableAdapter = null;
            this.tableAdapterManager.StrojTableAdapter = null;
            this.tableAdapterManager.tipKorisnikaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ComPromPlusAplikacija.T23_Enigma2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtrosakTableAdapter = null;
            // 
            // formaRepromaterijaliPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 441);
            this.Controls.Add(this.lblNaslovniText);
            this.Controls.Add(this.picArtikli);
            this.Controls.Add(this.lblIzlaz);
            this.Controls.Add(this.lblObrisi);
            this.Controls.Add(this.picIzlaz);
            this.Controls.Add(this.picObrisi);
            this.Controls.Add(this.lblIzmjeni);
            this.Controls.Add(this.picIzmjeni);
            this.Controls.Add(this.lblDodaj);
            this.Controls.Add(this.picDodaj);
            this.Controls.Add(this.btnPretrazivanjeSifra);
            this.Controls.Add(this.txtPretrazivanjeSifra);
            this.Controls.Add(this.lblPretrazivanjeSifra);
            this.Controls.Add(this.txtPretrazivanje);
            this.Controls.Add(this.lblPretrazivanje);
            this.Controls.Add(this.dgvRepromaterijali);
            this.Name = "formaRepromaterijaliPregled";
            this.Text = "Repromaterijali Pregled";
            this.Load += new System.EventHandler(this.formaRepromaterijaliPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzlaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObrisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzmjeni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDodaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepromaterijali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repromaterijaliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_Enigma2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslovniText;
        private System.Windows.Forms.PictureBox picArtikli;
        private System.Windows.Forms.Label lblIzlaz;
        private System.Windows.Forms.Label lblObrisi;
        private System.Windows.Forms.PictureBox picIzlaz;
        private System.Windows.Forms.PictureBox picObrisi;
        private System.Windows.Forms.Label lblIzmjeni;
        private System.Windows.Forms.PictureBox picIzmjeni;
        private System.Windows.Forms.Label lblDodaj;
        private System.Windows.Forms.PictureBox picDodaj;
        private System.Windows.Forms.Button btnPretrazivanjeSifra;
        private System.Windows.Forms.TextBox txtPretrazivanjeSifra;
        private System.Windows.Forms.Label lblPretrazivanjeSifra;
        private System.Windows.Forms.TextBox txtPretrazivanje;
        private System.Windows.Forms.Label lblPretrazivanje;
        private System.Windows.Forms.DataGridView dgvRepromaterijali;
        private T23_Enigma2DataSet t23_Enigma2DataSet;
        private System.Windows.Forms.BindingSource repromaterijaliBindingSource;
        private T23_Enigma2DataSetTableAdapters.RepromaterijaliTableAdapter repromaterijaliTableAdapter;
        private T23_Enigma2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bojaDataGridViewTextBoxColumn;
    }
}