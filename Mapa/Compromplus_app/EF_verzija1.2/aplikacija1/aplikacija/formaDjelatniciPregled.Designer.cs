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
            this.dgvDjelatnici = new System.Windows.Forms.DataGridView();
            this.idDjelatnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strucnaSpremaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.djelatnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPretrazivanje = new System.Windows.Forms.Label();
            this.txtPretrazivanje = new System.Windows.Forms.TextBox();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.btnNovi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDjelatnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.djelatnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDjelatnici
            // 
            this.dgvDjelatnici.AutoGenerateColumns = false;
            this.dgvDjelatnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDjelatnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDjelatnikDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.strucnaSpremaDataGridViewTextBoxColumn});
            this.dgvDjelatnici.DataSource = this.djelatnikBindingSource;
            this.dgvDjelatnici.Location = new System.Drawing.Point(21, 82);
            this.dgvDjelatnici.Name = "dgvDjelatnici";
            this.dgvDjelatnici.Size = new System.Drawing.Size(578, 252);
            this.dgvDjelatnici.TabIndex = 96;
            // 
            // idDjelatnikDataGridViewTextBoxColumn
            // 
            this.idDjelatnikDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDjelatnikDataGridViewTextBoxColumn.DataPropertyName = "IdDjelatnik";
            this.idDjelatnikDataGridViewTextBoxColumn.HeaderText = "Šifra djelatnika";
            this.idDjelatnikDataGridViewTextBoxColumn.Name = "idDjelatnikDataGridViewTextBoxColumn";
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
            this.strucnaSpremaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.strucnaSpremaDataGridViewTextBoxColumn.DataPropertyName = "strucnaSprema";
            this.strucnaSpremaDataGridViewTextBoxColumn.HeaderText = "Stručna sprema";
            this.strucnaSpremaDataGridViewTextBoxColumn.Name = "strucnaSpremaDataGridViewTextBoxColumn";
            // 
            // djelatnikBindingSource
            // 
            this.djelatnikBindingSource.DataSource = typeof(aplikacija.Djelatnik);
            // 
            // lblPretrazivanje
            // 
            this.lblPretrazivanje.AutoSize = true;
            this.lblPretrazivanje.Location = new System.Drawing.Point(532, 26);
            this.lblPretrazivanje.Name = "lblPretrazivanje";
            this.lblPretrazivanje.Size = new System.Drawing.Size(68, 13);
            this.lblPretrazivanje.TabIndex = 102;
            this.lblPretrazivanje.Text = "Pretraživanje";
            // 
            // txtPretrazivanje
            // 
            this.txtPretrazivanje.Location = new System.Drawing.Point(606, 23);
            this.txtPretrazivanje.Name = "txtPretrazivanje";
            this.txtPretrazivanje.Size = new System.Drawing.Size(212, 20);
            this.txtPretrazivanje.TabIndex = 101;
            this.txtPretrazivanje.TextChanged += new System.EventHandler(this.txtPretrazivanje_TextChanged);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(391, 26);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 100;
            this.btnIzlaz.Text = "&Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(292, 26);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 99;
            this.btnObrisi.Text = "&Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.Location = new System.Drawing.Point(195, 26);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(75, 23);
            this.btnIzmjeni.TabIndex = 98;
            this.btnIzmjeni.Text = "&Izmjeni";
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            // 
            // btnNovi
            // 
            this.btnNovi.Location = new System.Drawing.Point(97, 26);
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Size = new System.Drawing.Size(75, 23);
            this.btnNovi.TabIndex = 97;
            this.btnNovi.Text = "&Novi";
            this.btnNovi.UseVisualStyleBackColor = true;
            // 
            // formaDjelatniciPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 449);
            this.Controls.Add(this.lblPretrazivanje);
            this.Controls.Add(this.txtPretrazivanje);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.btnNovi);
            this.Controls.Add(this.dgvDjelatnici);
            this.Name = "formaDjelatniciPregled";
            this.Text = "formaDjelatniciPregled";
            this.Load += new System.EventHandler(this.formaDjelatniciPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDjelatnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.djelatnikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDjelatnici;
        private System.Windows.Forms.BindingSource djelatnikBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDjelatnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strucnaSpremaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblPretrazivanje;
        private System.Windows.Forms.TextBox txtPretrazivanje;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.Button btnNovi;
    }
}