namespace aplikacija
{
    partial class formaArtikliPregled
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formaArtikliPregled));
            this.lblArtikliIkona = new System.Windows.Forms.Label();
            this.picArtikliIkona = new System.Windows.Forms.PictureBox();
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.lblPretrazivanje = new System.Windows.Forms.Label();
            this.txtPretrazivanje = new System.Windows.Forms.TextBox();
            this.lblPretrazivanjeSifra = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.lblObrisi = new System.Windows.Forms.Label();
            this.lblSpremi = new System.Windows.Forms.Label();
            this.lblUnos = new System.Windows.Forms.Label();
            this.picObrisi = new System.Windows.Forms.PictureBox();
            this.picUnos = new System.Windows.Forms.PictureBox();
            this.picIzmjeni = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idArtikliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaNaSkladistuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evidencijaKontroleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkedokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkerepromaterijalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picArtikliIkona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObrisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzmjeni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArtikliIkona
            // 
            this.lblArtikliIkona.AutoSize = true;
            this.lblArtikliIkona.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblArtikliIkona.Location = new System.Drawing.Point(99, 27);
            this.lblArtikliIkona.Name = "lblArtikliIkona";
            this.lblArtikliIkona.Size = new System.Drawing.Size(258, 39);
            this.lblArtikliIkona.TabIndex = 84;
            this.lblArtikliIkona.Text = "Pregled artikala";
            // 
            // picArtikliIkona
            // 
            this.picArtikliIkona.Image = ((System.Drawing.Image)(resources.GetObject("picArtikliIkona.Image")));
            this.picArtikliIkona.Location = new System.Drawing.Point(25, 18);
            this.picArtikliIkona.Name = "picArtikliIkona";
            this.picArtikliIkona.Size = new System.Drawing.Size(68, 58);
            this.picArtikliIkona.TabIndex = 83;
            this.picArtikliIkona.TabStop = false;
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.AllowUserToAddRows = false;
            this.dgvArtikli.AllowUserToDeleteRows = false;
            this.dgvArtikli.AllowUserToResizeColumns = false;
            this.dgvArtikli.AllowUserToResizeRows = false;
            this.dgvArtikli.AutoGenerateColumns = false;
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArtikliDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.bojaDataGridViewTextBoxColumn,
            this.kolicinaNaSkladistuDataGridViewTextBoxColumn,
            this.evidencijaKontroleDataGridViewTextBoxColumn,
            this.stavkedokumentaDataGridViewTextBoxColumn,
            this.stavkerepromaterijalaDataGridViewTextBoxColumn});
            this.dgvArtikli.DataSource = this.artikliBindingSource;
            this.dgvArtikli.Location = new System.Drawing.Point(25, 171);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.Size = new System.Drawing.Size(693, 400);
            this.dgvArtikli.TabIndex = 85;
            // 
            // lblPretrazivanje
            // 
            this.lblPretrazivanje.AutoSize = true;
            this.lblPretrazivanje.Location = new System.Drawing.Point(22, 140);
            this.lblPretrazivanje.Name = "lblPretrazivanje";
            this.lblPretrazivanje.Size = new System.Drawing.Size(68, 13);
            this.lblPretrazivanje.TabIndex = 86;
            this.lblPretrazivanje.Text = "Pretraživanje";
            // 
            // txtPretrazivanje
            // 
            this.txtPretrazivanje.Location = new System.Drawing.Point(96, 137);
            this.txtPretrazivanje.Name = "txtPretrazivanje";
            this.txtPretrazivanje.Size = new System.Drawing.Size(227, 20);
            this.txtPretrazivanje.TabIndex = 87;
            this.txtPretrazivanje.TextChanged += new System.EventHandler(this.txtPretrazivanje_TextChanged);
            // 
            // lblPretrazivanjeSifra
            // 
            this.lblPretrazivanjeSifra.AutoSize = true;
            this.lblPretrazivanjeSifra.Location = new System.Drawing.Point(375, 140);
            this.lblPretrazivanjeSifra.Name = "lblPretrazivanjeSifra";
            this.lblPretrazivanjeSifra.Size = new System.Drawing.Size(118, 13);
            this.lblPretrazivanjeSifra.TabIndex = 88;
            this.lblPretrazivanjeSifra.Text = "Pretraživanje prema šifri";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(512, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(723, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 134;
            this.label1.Text = "Izlaz";
            // 
            // picExit
            // 
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(699, 27);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(68, 70);
            this.picExit.TabIndex = 133;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // lblObrisi
            // 
            this.lblObrisi.AutoSize = true;
            this.lblObrisi.Location = new System.Drawing.Point(588, 100);
            this.lblObrisi.Name = "lblObrisi";
            this.lblObrisi.Size = new System.Drawing.Size(33, 13);
            this.lblObrisi.TabIndex = 132;
            this.lblObrisi.Text = "Obriši";
            // 
            // lblSpremi
            // 
            this.lblSpremi.AutoSize = true;
            this.lblSpremi.Location = new System.Drawing.Point(491, 100);
            this.lblSpremi.Name = "lblSpremi";
            this.lblSpremi.Size = new System.Drawing.Size(39, 13);
            this.lblSpremi.TabIndex = 131;
            this.lblSpremi.Text = "Izmjeni";
            // 
            // lblUnos
            // 
            this.lblUnos.AutoSize = true;
            this.lblUnos.Location = new System.Drawing.Point(391, 100);
            this.lblUnos.Name = "lblUnos";
            this.lblUnos.Size = new System.Drawing.Size(58, 13);
            this.lblUnos.TabIndex = 130;
            this.lblUnos.Text = "Dodaj novi";
            // 
            // picObrisi
            // 
            this.picObrisi.Image = ((System.Drawing.Image)(resources.GetObject("picObrisi.Image")));
            this.picObrisi.Location = new System.Drawing.Point(574, 27);
            this.picObrisi.Name = "picObrisi";
            this.picObrisi.Size = new System.Drawing.Size(68, 70);
            this.picObrisi.TabIndex = 129;
            this.picObrisi.TabStop = false;
            this.picObrisi.Click += new System.EventHandler(this.picObrisi_Click);
            // 
            // picUnos
            // 
            this.picUnos.Image = ((System.Drawing.Image)(resources.GetObject("picUnos.Image")));
            this.picUnos.Location = new System.Drawing.Point(384, 27);
            this.picUnos.Name = "picUnos";
            this.picUnos.Size = new System.Drawing.Size(68, 70);
            this.picUnos.TabIndex = 128;
            this.picUnos.TabStop = false;
            this.picUnos.Click += new System.EventHandler(this.picUnos_Click);
            // 
            // picIzmjeni
            // 
            this.picIzmjeni.Image = ((System.Drawing.Image)(resources.GetObject("picIzmjeni.Image")));
            this.picIzmjeni.InitialImage = ((System.Drawing.Image)(resources.GetObject("picIzmjeni.InitialImage")));
            this.picIzmjeni.Location = new System.Drawing.Point(478, 27);
            this.picIzmjeni.Name = "picIzmjeni";
            this.picIzmjeni.Size = new System.Drawing.Size(68, 70);
            this.picIzmjeni.TabIndex = 127;
            this.picIzmjeni.TabStop = false;
            this.picIzmjeni.Click += new System.EventHandler(this.picIzmjeni_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(677, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 135;
            this.button1.Text = "Pretraži";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // artikliBindingSource
            // 
            this.artikliBindingSource.DataSource = typeof(aplikacija.Artikli);
            // 
            // idArtikliDataGridViewTextBoxColumn
            // 
            this.idArtikliDataGridViewTextBoxColumn.DataPropertyName = "IdArtikli";
            this.idArtikliDataGridViewTextBoxColumn.HeaderText = "Šifra artikla";
            this.idArtikliDataGridViewTextBoxColumn.Name = "idArtikliDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // bojaDataGridViewTextBoxColumn
            // 
            this.bojaDataGridViewTextBoxColumn.DataPropertyName = "boja";
            this.bojaDataGridViewTextBoxColumn.HeaderText = "Boja";
            this.bojaDataGridViewTextBoxColumn.Name = "bojaDataGridViewTextBoxColumn";
            // 
            // kolicinaNaSkladistuDataGridViewTextBoxColumn
            // 
            this.kolicinaNaSkladistuDataGridViewTextBoxColumn.DataPropertyName = "kolicinaNaSkladistu";
            this.kolicinaNaSkladistuDataGridViewTextBoxColumn.HeaderText = "Količina na skladištu";
            this.kolicinaNaSkladistuDataGridViewTextBoxColumn.Name = "kolicinaNaSkladistuDataGridViewTextBoxColumn";
            this.kolicinaNaSkladistuDataGridViewTextBoxColumn.Width = 150;
            // 
            // evidencijaKontroleDataGridViewTextBoxColumn
            // 
            this.evidencijaKontroleDataGridViewTextBoxColumn.DataPropertyName = "evidencijaKontrole";
            this.evidencijaKontroleDataGridViewTextBoxColumn.HeaderText = "Klasa";
            this.evidencijaKontroleDataGridViewTextBoxColumn.Name = "evidencijaKontroleDataGridViewTextBoxColumn";
            // 
            // stavkedokumentaDataGridViewTextBoxColumn
            // 
            this.stavkedokumentaDataGridViewTextBoxColumn.DataPropertyName = "stavke_dokumenta";
            this.stavkedokumentaDataGridViewTextBoxColumn.HeaderText = "stavke_dokumenta";
            this.stavkedokumentaDataGridViewTextBoxColumn.Name = "stavkedokumentaDataGridViewTextBoxColumn";
            this.stavkedokumentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkerepromaterijalaDataGridViewTextBoxColumn
            // 
            this.stavkerepromaterijalaDataGridViewTextBoxColumn.DataPropertyName = "stavke_repromaterijala";
            this.stavkerepromaterijalaDataGridViewTextBoxColumn.HeaderText = "stavke_repromaterijala";
            this.stavkerepromaterijalaDataGridViewTextBoxColumn.Name = "stavkerepromaterijalaDataGridViewTextBoxColumn";
            this.stavkerepromaterijalaDataGridViewTextBoxColumn.Visible = false;
            // 
            // formaArtikliPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(799, 595);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.lblObrisi);
            this.Controls.Add(this.lblSpremi);
            this.Controls.Add(this.lblUnos);
            this.Controls.Add(this.picObrisi);
            this.Controls.Add(this.picUnos);
            this.Controls.Add(this.picIzmjeni);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPretrazivanjeSifra);
            this.Controls.Add(this.txtPretrazivanje);
            this.Controls.Add(this.lblPretrazivanje);
            this.Controls.Add(this.dgvArtikli);
            this.Controls.Add(this.lblArtikliIkona);
            this.Controls.Add(this.picArtikliIkona);
            this.Name = "formaArtikliPregled";
            this.Text = "formaArtikliPregled";
            this.Load += new System.EventHandler(this.formaArtikliPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picArtikliIkona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObrisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzmjeni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArtikliIkona;
        private System.Windows.Forms.PictureBox picArtikliIkona;
        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private System.Windows.Forms.Label lblPretrazivanje;
        private System.Windows.Forms.TextBox txtPretrazivanje;
        private System.Windows.Forms.Label lblPretrazivanjeSifra;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label lblObrisi;
        private System.Windows.Forms.Label lblSpremi;
        private System.Windows.Forms.Label lblUnos;
        private System.Windows.Forms.PictureBox picObrisi;
        private System.Windows.Forms.PictureBox picUnos;
        private System.Windows.Forms.PictureBox picIzmjeni;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArtikliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bojaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaNaSkladistuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evidencijaKontroleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkedokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkerepromaterijalaDataGridViewTextBoxColumn;
    }
}