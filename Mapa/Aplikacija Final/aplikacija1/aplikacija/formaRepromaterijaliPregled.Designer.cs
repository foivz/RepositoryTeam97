namespace aplikacija
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
            this.dgvRepromaterijal = new System.Windows.Forms.DataGridView();
            this.idRepromaterijalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstamaterijalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repromaterijalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPretrazivanje = new System.Windows.Forms.TextBox();
            this.lblPretrazivanje = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.lblIzmjeni = new System.Windows.Forms.Label();
            this.picSpremi = new System.Windows.Forms.PictureBox();
            this.lblUnos = new System.Windows.Forms.Label();
            this.picUnos = new System.Windows.Forms.PictureBox();
            this.lblArtikliIkona = new System.Windows.Forms.Label();
            this.picArtikliIkona = new System.Windows.Forms.PictureBox();
            this.lblPretrazivanjeSifra = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPretrazivanje2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepromaterijal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repromaterijalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpremi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArtikliIkona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRepromaterijal
            // 
            this.dgvRepromaterijal.AutoGenerateColumns = false;
            this.dgvRepromaterijal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepromaterijal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRepromaterijalDataGridViewTextBoxColumn,
            this.vrstamaterijalaDataGridViewTextBoxColumn,
            this.bojaDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn});
            this.dgvRepromaterijal.DataSource = this.repromaterijalBindingSource;
            this.dgvRepromaterijal.Location = new System.Drawing.Point(59, 216);
            this.dgvRepromaterijal.Name = "dgvRepromaterijal";
            this.dgvRepromaterijal.Size = new System.Drawing.Size(690, 278);
            this.dgvRepromaterijal.TabIndex = 0;
            // 
            // idRepromaterijalDataGridViewTextBoxColumn
            // 
            this.idRepromaterijalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idRepromaterijalDataGridViewTextBoxColumn.DataPropertyName = "IdRepromaterijal";
            this.idRepromaterijalDataGridViewTextBoxColumn.HeaderText = "Šifra";
            this.idRepromaterijalDataGridViewTextBoxColumn.Name = "idRepromaterijalDataGridViewTextBoxColumn";
            this.idRepromaterijalDataGridViewTextBoxColumn.Width = 130;
            // 
            // vrstamaterijalaDataGridViewTextBoxColumn
            // 
            this.vrstamaterijalaDataGridViewTextBoxColumn.DataPropertyName = "vrsta_materijala";
            this.vrstamaterijalaDataGridViewTextBoxColumn.HeaderText = "Vrsta materijala";
            this.vrstamaterijalaDataGridViewTextBoxColumn.Name = "vrstamaterijalaDataGridViewTextBoxColumn";
            this.vrstamaterijalaDataGridViewTextBoxColumn.Width = 150;
            // 
            // bojaDataGridViewTextBoxColumn
            // 
            this.bojaDataGridViewTextBoxColumn.DataPropertyName = "boja";
            this.bojaDataGridViewTextBoxColumn.HeaderText = "Boja";
            this.bojaDataGridViewTextBoxColumn.Name = "bojaDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // repromaterijalBindingSource
            // 
            this.repromaterijalBindingSource.DataSource = typeof(aplikacija.Repromaterijal);
            // 
            // txtPretrazivanje
            // 
            this.txtPretrazivanje.Location = new System.Drawing.Point(130, 181);
            this.txtPretrazivanje.Name = "txtPretrazivanje";
            this.txtPretrazivanje.Size = new System.Drawing.Size(269, 20);
            this.txtPretrazivanje.TabIndex = 3;
            this.txtPretrazivanje.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblPretrazivanje
            // 
            this.lblPretrazivanje.AutoSize = true;
            this.lblPretrazivanje.Location = new System.Drawing.Point(61, 184);
            this.lblPretrazivanje.Name = "lblPretrazivanje";
            this.lblPretrazivanje.Size = new System.Drawing.Size(68, 13);
            this.lblPretrazivanje.TabIndex = 4;
            this.lblPretrazivanje.Text = "Pretraživanje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 159;
            this.label2.Text = "Izlaz";
            // 
            // picExit
            // 
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(331, 39);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(68, 70);
            this.picExit.TabIndex = 158;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // lblIzmjeni
            // 
            this.lblIzmjeni.AutoSize = true;
            this.lblIzmjeni.Location = new System.Drawing.Point(164, 118);
            this.lblIzmjeni.Name = "lblIzmjeni";
            this.lblIzmjeni.Size = new System.Drawing.Size(39, 13);
            this.lblIzmjeni.TabIndex = 157;
            this.lblIzmjeni.Text = "Izmjeni";
            // 
            // picSpremi
            // 
            this.picSpremi.Image = ((System.Drawing.Image)(resources.GetObject("picSpremi.Image")));
            this.picSpremi.Location = new System.Drawing.Point(150, 39);
            this.picSpremi.Name = "picSpremi";
            this.picSpremi.Size = new System.Drawing.Size(68, 70);
            this.picSpremi.TabIndex = 156;
            this.picSpremi.TabStop = false;
            this.picSpremi.Click += new System.EventHandler(this.picSpremi_Click);
            // 
            // lblUnos
            // 
            this.lblUnos.AutoSize = true;
            this.lblUnos.Location = new System.Drawing.Point(69, 118);
            this.lblUnos.Name = "lblUnos";
            this.lblUnos.Size = new System.Drawing.Size(58, 13);
            this.lblUnos.TabIndex = 155;
            this.lblUnos.Text = "Dodaj novi";
            // 
            // picUnos
            // 
            this.picUnos.Image = ((System.Drawing.Image)(resources.GetObject("picUnos.Image")));
            this.picUnos.Location = new System.Drawing.Point(59, 39);
            this.picUnos.Name = "picUnos";
            this.picUnos.Size = new System.Drawing.Size(68, 70);
            this.picUnos.TabIndex = 154;
            this.picUnos.TabStop = false;
            this.picUnos.Click += new System.EventHandler(this.picUnos_Click);
            // 
            // lblArtikliIkona
            // 
            this.lblArtikliIkona.AutoSize = true;
            this.lblArtikliIkona.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblArtikliIkona.Location = new System.Drawing.Point(514, 52);
            this.lblArtikliIkona.Name = "lblArtikliIkona";
            this.lblArtikliIkona.Size = new System.Drawing.Size(252, 39);
            this.lblArtikliIkona.TabIndex = 161;
            this.lblArtikliIkona.Text = "Repromaterijali";
            // 
            // picArtikliIkona
            // 
            this.picArtikliIkona.Image = ((System.Drawing.Image)(resources.GetObject("picArtikliIkona.Image")));
            this.picArtikliIkona.Location = new System.Drawing.Point(440, 39);
            this.picArtikliIkona.Name = "picArtikliIkona";
            this.picArtikliIkona.Size = new System.Drawing.Size(68, 71);
            this.picArtikliIkona.TabIndex = 160;
            this.picArtikliIkona.TabStop = false;
            // 
            // lblPretrazivanjeSifra
            // 
            this.lblPretrazivanjeSifra.AutoSize = true;
            this.lblPretrazivanjeSifra.Location = new System.Drawing.Point(420, 182);
            this.lblPretrazivanjeSifra.Name = "lblPretrazivanjeSifra";
            this.lblPretrazivanjeSifra.Size = new System.Drawing.Size(118, 13);
            this.lblPretrazivanjeSifra.TabIndex = 164;
            this.lblPretrazivanjeSifra.Text = "Pretraživanje prema šifri";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(674, 177);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 163;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPretrazivanje2
            // 
            this.txtPretrazivanje2.Location = new System.Drawing.Point(544, 177);
            this.txtPretrazivanje2.Name = "txtPretrazivanje2";
            this.txtPretrazivanje2.Size = new System.Drawing.Size(124, 20);
            this.txtPretrazivanje2.TabIndex = 162;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 167;
            this.label1.Text = "Obriši";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(241, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 70);
            this.pictureBox1.TabIndex = 166;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // formaRepromaterijaliPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(803, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPretrazivanjeSifra);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPretrazivanje2);
            this.Controls.Add(this.lblArtikliIkona);
            this.Controls.Add(this.picArtikliIkona);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.lblIzmjeni);
            this.Controls.Add(this.picSpremi);
            this.Controls.Add(this.lblUnos);
            this.Controls.Add(this.picUnos);
            this.Controls.Add(this.lblPretrazivanje);
            this.Controls.Add(this.txtPretrazivanje);
            this.Controls.Add(this.dgvRepromaterijal);
            this.Name = "formaRepromaterijaliPregled";
            this.Text = "formaRepromaterijaliPregled";
            this.Load += new System.EventHandler(this.formaRepromaterijaliPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepromaterijal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repromaterijalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpremi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArtikliIkona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRepromaterijal;
        private System.Windows.Forms.BindingSource repromaterijalBindingSource;
        private System.Windows.Forms.TextBox txtPretrazivanje;
        private System.Windows.Forms.Label lblPretrazivanje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label lblIzmjeni;
        private System.Windows.Forms.PictureBox picSpremi;
        private System.Windows.Forms.Label lblUnos;
        private System.Windows.Forms.PictureBox picUnos;
        private System.Windows.Forms.Label lblArtikliIkona;
        private System.Windows.Forms.PictureBox picArtikliIkona;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRepromaterijalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstamaterijalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bojaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblPretrazivanjeSifra;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPretrazivanje2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}