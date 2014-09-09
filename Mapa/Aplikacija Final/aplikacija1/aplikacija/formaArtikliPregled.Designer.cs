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
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.txtPretrazivanje = new System.Windows.Forms.TextBox();
            this.lblPretrazivanje = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPretrazivanjeSifra = new System.Windows.Forms.Label();
            this.lblUnos = new System.Windows.Forms.Label();
            this.picUnos = new System.Windows.Forms.PictureBox();
            this.lblIzmjeni = new System.Windows.Forms.Label();
            this.picSpremi = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.lblDjelatniciIkona = new System.Windows.Forms.Label();
            this.picDjelatniciIkona = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.idArtikliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evidencijaKontroleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpremi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDjelatniciIkona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.AutoGenerateColumns = false;
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArtikliDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.bojaDataGridViewTextBoxColumn,
            this.evidencijaKontroleDataGridViewTextBoxColumn});
            this.dgvArtikli.DataSource = this.artikliBindingSource;
            this.dgvArtikli.Location = new System.Drawing.Point(43, 201);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.Size = new System.Drawing.Size(777, 379);
            this.dgvArtikli.TabIndex = 0;
            // 
            // txtPretrazivanje
            // 
            this.txtPretrazivanje.Location = new System.Drawing.Point(116, 156);
            this.txtPretrazivanje.Name = "txtPretrazivanje";
            this.txtPretrazivanje.Size = new System.Drawing.Size(288, 20);
            this.txtPretrazivanje.TabIndex = 92;
            this.txtPretrazivanje.TextChanged += new System.EventHandler(this.txtPretrazivanje_TextChanged);
            // 
            // lblPretrazivanje
            // 
            this.lblPretrazivanje.AutoSize = true;
            this.lblPretrazivanje.Location = new System.Drawing.Point(42, 159);
            this.lblPretrazivanje.Name = "lblPretrazivanje";
            this.lblPretrazivanje.Size = new System.Drawing.Size(68, 13);
            this.lblPretrazivanje.TabIndex = 93;
            this.lblPretrazivanje.Text = "Pretraživanje";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(594, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 94;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(724, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 95;
            this.button1.Text = "Pretraži";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPretrazivanjeSifra
            // 
            this.lblPretrazivanjeSifra.AutoSize = true;
            this.lblPretrazivanjeSifra.Location = new System.Drawing.Point(470, 159);
            this.lblPretrazivanjeSifra.Name = "lblPretrazivanjeSifra";
            this.lblPretrazivanjeSifra.Size = new System.Drawing.Size(118, 13);
            this.lblPretrazivanjeSifra.TabIndex = 96;
            this.lblPretrazivanjeSifra.Text = "Pretraživanje prema šifri";
            // 
            // lblUnos
            // 
            this.lblUnos.AutoSize = true;
            this.lblUnos.Location = new System.Drawing.Point(53, 112);
            this.lblUnos.Name = "lblUnos";
            this.lblUnos.Size = new System.Drawing.Size(58, 13);
            this.lblUnos.TabIndex = 132;
            this.lblUnos.Text = "Dodaj novi";
            // 
            // picUnos
            // 
            this.picUnos.Image = ((System.Drawing.Image)(resources.GetObject("picUnos.Image")));
            this.picUnos.Location = new System.Drawing.Point(43, 33);
            this.picUnos.Name = "picUnos";
            this.picUnos.Size = new System.Drawing.Size(68, 70);
            this.picUnos.TabIndex = 131;
            this.picUnos.TabStop = false;
            this.picUnos.Click += new System.EventHandler(this.picUnos_Click);
            // 
            // lblIzmjeni
            // 
            this.lblIzmjeni.AutoSize = true;
            this.lblIzmjeni.Location = new System.Drawing.Point(146, 112);
            this.lblIzmjeni.Name = "lblIzmjeni";
            this.lblIzmjeni.Size = new System.Drawing.Size(39, 13);
            this.lblIzmjeni.TabIndex = 134;
            this.lblIzmjeni.Text = "Izmjeni";
            // 
            // picSpremi
            // 
            this.picSpremi.Image = ((System.Drawing.Image)(resources.GetObject("picSpremi.Image")));
            this.picSpremi.Location = new System.Drawing.Point(132, 33);
            this.picSpremi.Name = "picSpremi";
            this.picSpremi.Size = new System.Drawing.Size(68, 70);
            this.picSpremi.TabIndex = 133;
            this.picSpremi.TabStop = false;
            this.picSpremi.Click += new System.EventHandler(this.picSpremi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 146;
            this.label2.Text = "Izlaz";
            // 
            // picExit
            // 
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(305, 32);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(68, 70);
            this.picExit.TabIndex = 145;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // lblDjelatniciIkona
            // 
            this.lblDjelatniciIkona.AutoSize = true;
            this.lblDjelatniciIkona.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDjelatniciIkona.Location = new System.Drawing.Point(507, 49);
            this.lblDjelatniciIkona.Name = "lblDjelatniciIkona";
            this.lblDjelatniciIkona.Size = new System.Drawing.Size(258, 39);
            this.lblDjelatniciIkona.TabIndex = 158;
            this.lblDjelatniciIkona.Text = "Pregled artikala";
            // 
            // picDjelatniciIkona
            // 
            this.picDjelatniciIkona.Image = ((System.Drawing.Image)(resources.GetObject("picDjelatniciIkona.Image")));
            this.picDjelatniciIkona.Location = new System.Drawing.Point(433, 40);
            this.picDjelatniciIkona.Name = "picDjelatniciIkona";
            this.picDjelatniciIkona.Size = new System.Drawing.Size(68, 62);
            this.picDjelatniciIkona.TabIndex = 157;
            this.picDjelatniciIkona.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(232, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 161;
            this.label1.Text = "Obriši";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(214, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 70);
            this.pictureBox1.TabIndex = 160;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // evidencijaKontroleDataGridViewTextBoxColumn
            // 
            this.evidencijaKontroleDataGridViewTextBoxColumn.DataPropertyName = "evidencijaKontrole";
            this.evidencijaKontroleDataGridViewTextBoxColumn.HeaderText = "Klasa";
            this.evidencijaKontroleDataGridViewTextBoxColumn.Name = "evidencijaKontroleDataGridViewTextBoxColumn";
            // 
            // artikliBindingSource
            // 
            this.artikliBindingSource.DataSource = typeof(aplikacija.Artikli);
            // 
            // formaArtikliPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(841, 592);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDjelatniciIkona);
            this.Controls.Add(this.picDjelatniciIkona);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.lblIzmjeni);
            this.Controls.Add(this.picSpremi);
            this.Controls.Add(this.lblUnos);
            this.Controls.Add(this.picUnos);
            this.Controls.Add(this.lblPretrazivanjeSifra);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPretrazivanje);
            this.Controls.Add(this.txtPretrazivanje);
            this.Controls.Add(this.dgvArtikli);
            this.Name = "formaArtikliPregled";
            this.Text = "Pregled artikala";
            this.Load += new System.EventHandler(this.formaArtikliPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpremi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDjelatniciIkona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArtikliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bojaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evidencijaKontroleDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtPretrazivanje;
        private System.Windows.Forms.Label lblPretrazivanje;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPretrazivanjeSifra;
        private System.Windows.Forms.Label lblUnos;
        private System.Windows.Forms.PictureBox picUnos;
        private System.Windows.Forms.Label lblIzmjeni;
        private System.Windows.Forms.PictureBox picSpremi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label lblDjelatniciIkona;
        private System.Windows.Forms.PictureBox picDjelatniciIkona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;


    }
}