namespace aplikacija
{
    partial class formaDjelatniciPregled
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formaDjelatniciPregled));
            this.lblDjelatniciIkona = new System.Windows.Forms.Label();
            this.picDjelatniciIkona = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.lblObrisi = new System.Windows.Forms.Label();
            this.lblSpremi = new System.Windows.Forms.Label();
            this.lblUnos = new System.Windows.Forms.Label();
            this.picObrisi = new System.Windows.Forms.PictureBox();
            this.picUnos = new System.Windows.Forms.PictureBox();
            this.picIzmjeni = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPretrazivanje2 = new System.Windows.Forms.TextBox();
            this.lblPretrazivanjeSifra = new System.Windows.Forms.Label();
            this.txtPretrazivanje = new System.Windows.Forms.TextBox();
            this.lblPretrazivanje = new System.Windows.Forms.Label();
            this.dgvDjelatnici = new System.Windows.Forms.DataGridView();
            this.djelatnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDjelatnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strucnaSpremaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picDjelatniciIkona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObrisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzmjeni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDjelatnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.djelatnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDjelatniciIkona
            // 
            this.lblDjelatniciIkona.AutoSize = true;
            this.lblDjelatniciIkona.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDjelatniciIkona.Location = new System.Drawing.Point(95, 29);
            this.lblDjelatniciIkona.Name = "lblDjelatniciIkona";
            this.lblDjelatniciIkona.Size = new System.Drawing.Size(292, 39);
            this.lblDjelatniciIkona.TabIndex = 79;
            this.lblDjelatniciIkona.Text = "Pregled djelatnika";
            // 
            // picDjelatniciIkona
            // 
            this.picDjelatniciIkona.Image = ((System.Drawing.Image)(resources.GetObject("picDjelatniciIkona.Image")));
            this.picDjelatniciIkona.Location = new System.Drawing.Point(21, 20);
            this.picDjelatniciIkona.Name = "picDjelatniciIkona";
            this.picDjelatniciIkona.Size = new System.Drawing.Size(68, 62);
            this.picDjelatniciIkona.TabIndex = 78;
            this.picDjelatniciIkona.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(785, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 142;
            this.label1.Text = "Izlaz";
            // 
            // picExit
            // 
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(761, 20);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(68, 70);
            this.picExit.TabIndex = 141;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // lblObrisi
            // 
            this.lblObrisi.AutoSize = true;
            this.lblObrisi.Location = new System.Drawing.Point(650, 93);
            this.lblObrisi.Name = "lblObrisi";
            this.lblObrisi.Size = new System.Drawing.Size(33, 13);
            this.lblObrisi.TabIndex = 140;
            this.lblObrisi.Text = "Obriši";
            // 
            // lblSpremi
            // 
            this.lblSpremi.AutoSize = true;
            this.lblSpremi.Location = new System.Drawing.Point(553, 93);
            this.lblSpremi.Name = "lblSpremi";
            this.lblSpremi.Size = new System.Drawing.Size(39, 13);
            this.lblSpremi.TabIndex = 139;
            this.lblSpremi.Text = "Izmjeni";
            // 
            // lblUnos
            // 
            this.lblUnos.AutoSize = true;
            this.lblUnos.Location = new System.Drawing.Point(453, 93);
            this.lblUnos.Name = "lblUnos";
            this.lblUnos.Size = new System.Drawing.Size(58, 13);
            this.lblUnos.TabIndex = 138;
            this.lblUnos.Text = "Dodaj novi";
            // 
            // picObrisi
            // 
            this.picObrisi.Image = ((System.Drawing.Image)(resources.GetObject("picObrisi.Image")));
            this.picObrisi.Location = new System.Drawing.Point(636, 20);
            this.picObrisi.Name = "picObrisi";
            this.picObrisi.Size = new System.Drawing.Size(68, 70);
            this.picObrisi.TabIndex = 137;
            this.picObrisi.TabStop = false;
            this.picObrisi.Click += new System.EventHandler(this.picObrisi_Click);
            // 
            // picUnos
            // 
            this.picUnos.Image = ((System.Drawing.Image)(resources.GetObject("picUnos.Image")));
            this.picUnos.Location = new System.Drawing.Point(446, 20);
            this.picUnos.Name = "picUnos";
            this.picUnos.Size = new System.Drawing.Size(68, 70);
            this.picUnos.TabIndex = 136;
            this.picUnos.TabStop = false;
            this.picUnos.Click += new System.EventHandler(this.picUnos_Click);
            // 
            // picIzmjeni
            // 
            this.picIzmjeni.Image = ((System.Drawing.Image)(resources.GetObject("picIzmjeni.Image")));
            this.picIzmjeni.InitialImage = ((System.Drawing.Image)(resources.GetObject("picIzmjeni.InitialImage")));
            this.picIzmjeni.Location = new System.Drawing.Point(540, 20);
            this.picIzmjeni.Name = "picIzmjeni";
            this.picIzmjeni.Size = new System.Drawing.Size(68, 70);
            this.picIzmjeni.TabIndex = 135;
            this.picIzmjeni.TabStop = false;
            this.picIzmjeni.Click += new System.EventHandler(this.picIzmjeni_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(677, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 147;
            this.button1.Text = "Pretraži";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPretrazivanje2
            // 
            this.txtPretrazivanje2.Location = new System.Drawing.Point(512, 145);
            this.txtPretrazivanje2.Name = "txtPretrazivanje2";
            this.txtPretrazivanje2.Size = new System.Drawing.Size(159, 20);
            this.txtPretrazivanje2.TabIndex = 146;
            // 
            // lblPretrazivanjeSifra
            // 
            this.lblPretrazivanjeSifra.AutoSize = true;
            this.lblPretrazivanjeSifra.Location = new System.Drawing.Point(375, 148);
            this.lblPretrazivanjeSifra.Name = "lblPretrazivanjeSifra";
            this.lblPretrazivanjeSifra.Size = new System.Drawing.Size(118, 13);
            this.lblPretrazivanjeSifra.TabIndex = 145;
            this.lblPretrazivanjeSifra.Text = "Pretraživanje prema šifri";
            // 
            // txtPretrazivanje
            // 
            this.txtPretrazivanje.Location = new System.Drawing.Point(96, 145);
            this.txtPretrazivanje.Name = "txtPretrazivanje";
            this.txtPretrazivanje.Size = new System.Drawing.Size(227, 20);
            this.txtPretrazivanje.TabIndex = 144;
            this.txtPretrazivanje.TextChanged += new System.EventHandler(this.txtPretrazivanje_TextChanged);
            // 
            // lblPretrazivanje
            // 
            this.lblPretrazivanje.AutoSize = true;
            this.lblPretrazivanje.Location = new System.Drawing.Point(22, 148);
            this.lblPretrazivanje.Name = "lblPretrazivanje";
            this.lblPretrazivanje.Size = new System.Drawing.Size(68, 13);
            this.lblPretrazivanje.TabIndex = 143;
            this.lblPretrazivanje.Text = "Pretraživanje";
            // 
            // dgvDjelatnici
            // 
            this.dgvDjelatnici.AllowUserToAddRows = false;
            this.dgvDjelatnici.AutoGenerateColumns = false;
            this.dgvDjelatnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDjelatnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDjelatnikDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.strucnaSpremaDataGridViewTextBoxColumn,
            this.strojDataGridViewTextBoxColumn});
            this.dgvDjelatnici.DataSource = this.djelatnikBindingSource;
            this.dgvDjelatnici.Location = new System.Drawing.Point(25, 183);
            this.dgvDjelatnici.Name = "dgvDjelatnici";
            this.dgvDjelatnici.Size = new System.Drawing.Size(727, 328);
            this.dgvDjelatnici.TabIndex = 148;
            // 
            // djelatnikBindingSource
            // 
            this.djelatnikBindingSource.DataSource = typeof(aplikacija.Djelatnik);
            // 
            // idDjelatnikDataGridViewTextBoxColumn
            // 
            this.idDjelatnikDataGridViewTextBoxColumn.DataPropertyName = "IdDjelatnik";
            this.idDjelatnikDataGridViewTextBoxColumn.HeaderText = "Šifra djelatnika";
            this.idDjelatnikDataGridViewTextBoxColumn.Name = "idDjelatnikDataGridViewTextBoxColumn";
            this.idDjelatnikDataGridViewTextBoxColumn.Width = 130;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // strucnaSpremaDataGridViewTextBoxColumn
            // 
            this.strucnaSpremaDataGridViewTextBoxColumn.DataPropertyName = "strucnaSprema";
            this.strucnaSpremaDataGridViewTextBoxColumn.HeaderText = "Stručna sprema";
            this.strucnaSpremaDataGridViewTextBoxColumn.Name = "strucnaSpremaDataGridViewTextBoxColumn";
            this.strucnaSpremaDataGridViewTextBoxColumn.Width = 130;
            // 
            // strojDataGridViewTextBoxColumn
            // 
            this.strojDataGridViewTextBoxColumn.DataPropertyName = "Stroj";
            this.strojDataGridViewTextBoxColumn.HeaderText = "Stroj";
            this.strojDataGridViewTextBoxColumn.Name = "strojDataGridViewTextBoxColumn";
            this.strojDataGridViewTextBoxColumn.Visible = false;
            // 
            // formaDjelatniciPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(869, 574);
            this.Controls.Add(this.dgvDjelatnici);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPretrazivanje2);
            this.Controls.Add(this.lblPretrazivanjeSifra);
            this.Controls.Add(this.txtPretrazivanje);
            this.Controls.Add(this.lblPretrazivanje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.lblObrisi);
            this.Controls.Add(this.lblSpremi);
            this.Controls.Add(this.lblUnos);
            this.Controls.Add(this.picObrisi);
            this.Controls.Add(this.picUnos);
            this.Controls.Add(this.picIzmjeni);
            this.Controls.Add(this.lblDjelatniciIkona);
            this.Controls.Add(this.picDjelatniciIkona);
            this.Name = "formaDjelatniciPregled";
            this.Text = "formaDjelatniciPregled";
            this.Load += new System.EventHandler(this.formaDjelatniciPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDjelatniciIkona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObrisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzmjeni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDjelatnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.djelatnikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDjelatniciIkona;
        private System.Windows.Forms.PictureBox picDjelatniciIkona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label lblObrisi;
        private System.Windows.Forms.Label lblSpremi;
        private System.Windows.Forms.Label lblUnos;
        private System.Windows.Forms.PictureBox picObrisi;
        private System.Windows.Forms.PictureBox picUnos;
        private System.Windows.Forms.PictureBox picIzmjeni;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPretrazivanje2;
        private System.Windows.Forms.Label lblPretrazivanjeSifra;
        private System.Windows.Forms.TextBox txtPretrazivanje;
        private System.Windows.Forms.Label lblPretrazivanje;
        private System.Windows.Forms.DataGridView dgvDjelatnici;
        private System.Windows.Forms.BindingSource djelatnikBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDjelatnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strucnaSpremaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strojDataGridViewTextBoxColumn;

    }
}