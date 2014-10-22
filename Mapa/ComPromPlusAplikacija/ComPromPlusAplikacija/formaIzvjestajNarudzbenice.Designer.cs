namespace ComPromPlusAplikacija
{
    partial class formaIzvjestajNarudzbenice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formaIzvjestajNarudzbenice));
            this.datagridProdavac = new System.Windows.Forms.DataGridView();
            this.datagridrepromaterijali = new System.Windows.Forms.DataGridView();
            this.lblNaslovniText = new System.Windows.Forms.Label();
            this.picDjelatnici = new System.Windows.Forms.PictureBox();
            this.btnŠalji = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridProdavac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridrepromaterijali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDjelatnici)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridProdavac
            // 
            this.datagridProdavac.AllowUserToAddRows = false;
            this.datagridProdavac.AllowUserToDeleteRows = false;
            this.datagridProdavac.AllowUserToResizeRows = false;
            this.datagridProdavac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridProdavac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagridProdavac.Location = new System.Drawing.Point(12, 119);
            this.datagridProdavac.MultiSelect = false;
            this.datagridProdavac.Name = "datagridProdavac";
            this.datagridProdavac.ReadOnly = true;
            this.datagridProdavac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridProdavac.Size = new System.Drawing.Size(831, 71);
            this.datagridProdavac.TabIndex = 6;
            this.datagridProdavac.TabStop = false;
            
            // 
            // datagridrepromaterijali
            // 
            this.datagridrepromaterijali.AllowUserToAddRows = false;
            this.datagridrepromaterijali.AllowUserToDeleteRows = false;
            this.datagridrepromaterijali.AllowUserToResizeRows = false;
            this.datagridrepromaterijali.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridrepromaterijali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagridrepromaterijali.Location = new System.Drawing.Point(12, 211);
            this.datagridrepromaterijali.MultiSelect = false;
            this.datagridrepromaterijali.Name = "datagridrepromaterijali";
            this.datagridrepromaterijali.ReadOnly = true;
            this.datagridrepromaterijali.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridrepromaterijali.Size = new System.Drawing.Size(831, 123);
            this.datagridrepromaterijali.TabIndex = 7;
            this.datagridrepromaterijali.TabStop = false;
            // 
            // lblNaslovniText
            // 
            this.lblNaslovniText.AutoSize = true;
            this.lblNaslovniText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.lblNaslovniText.Location = new System.Drawing.Point(110, 37);
            this.lblNaslovniText.Name = "lblNaslovniText";
            this.lblNaslovniText.Size = new System.Drawing.Size(502, 38);
            this.lblNaslovniText.TabIndex = 83;
            this.lblNaslovniText.Text = "Narudžbenica - potvrda narudžbe";
            // 
            // picDjelatnici
            // 
            this.picDjelatnici.Image = ((System.Drawing.Image)(resources.GetObject("picDjelatnici.Image")));
            this.picDjelatnici.Location = new System.Drawing.Point(34, 22);
            this.picDjelatnici.Name = "picDjelatnici";
            this.picDjelatnici.Size = new System.Drawing.Size(70, 67);
            this.picDjelatnici.TabIndex = 82;
            this.picDjelatnici.TabStop = false;
            // 
            // btnŠalji
            // 
            this.btnŠalji.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnŠalji.Location = new System.Drawing.Point(592, 360);
            this.btnŠalji.Name = "btnŠalji";
            this.btnŠalji.Size = new System.Drawing.Size(115, 39);
            this.btnŠalji.TabIndex = 88;
            this.btnŠalji.Text = "Šalji";
            this.btnŠalji.UseVisualStyleBackColor = true;
            this.btnŠalji.Click += new System.EventHandler(this.btnŠalji_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.Location = new System.Drawing.Point(728, 362);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(115, 35);
            this.btnOdustani.TabIndex = 89;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            // 
            // formaIzvjestajNarudzbenice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 411);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnŠalji);
            this.Controls.Add(this.lblNaslovniText);
            this.Controls.Add(this.picDjelatnici);
            this.Controls.Add(this.datagridrepromaterijali);
            this.Controls.Add(this.datagridProdavac);
            this.Name = "formaIzvjestajNarudzbenice";
            this.Text = "Izvještaj narudžbenice";
            ((System.ComponentModel.ISupportInitialize)(this.datagridProdavac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridrepromaterijali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDjelatnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridProdavac;
        private System.Windows.Forms.DataGridView datagridrepromaterijali;
        private System.Windows.Forms.Label lblNaslovniText;
        private System.Windows.Forms.PictureBox picDjelatnici;
        private System.Windows.Forms.Button btnŠalji;
        private System.Windows.Forms.Button btnOdustani;
    }
}