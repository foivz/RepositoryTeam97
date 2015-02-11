namespace Compromplus_app
{
    partial class formaPracenjeProizvodnjeIzvjestaj
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ArtiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.T23_EnigmaDataSet2 = new Compromplus_app.T23_EnigmaDataSet2();
            this.DjelatnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PracenjeProizvodnjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StrojBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.izvjestajPracenja = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ArtiklTableAdapter = new Compromplus_app.T23_EnigmaDataSet2TableAdapters.ArtiklTableAdapter();
            this.DjelatnikTableAdapter = new Compromplus_app.T23_EnigmaDataSet2TableAdapters.DjelatnikTableAdapter();
            this.PracenjeProizvodnjeTableAdapter = new Compromplus_app.T23_EnigmaDataSet2TableAdapters.PracenjeProizvodnjeTableAdapter();
            this.StrojTableAdapter = new Compromplus_app.T23_EnigmaDataSet2TableAdapters.StrojTableAdapter();
            this.cboIdPracenje = new System.Windows.Forms.ComboBox();
            this.pracenjeProizvodnjeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pracenjeProizvodnjeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ArtiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T23_EnigmaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DjelatnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PracenjeProizvodnjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StrojBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracenjeProizvodnjeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracenjeProizvodnjeBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // ArtiklBindingSource
            // 
            this.ArtiklBindingSource.DataMember = "Artikl";
            this.ArtiklBindingSource.DataSource = this.T23_EnigmaDataSet2;
            // 
            // T23_EnigmaDataSet2
            // 
            this.T23_EnigmaDataSet2.DataSetName = "T23_EnigmaDataSet2";
            this.T23_EnigmaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DjelatnikBindingSource
            // 
            this.DjelatnikBindingSource.DataMember = "Djelatnik";
            this.DjelatnikBindingSource.DataSource = this.T23_EnigmaDataSet2;
            // 
            // PracenjeProizvodnjeBindingSource
            // 
            this.PracenjeProizvodnjeBindingSource.DataMember = "PracenjeProizvodnje";
            this.PracenjeProizvodnjeBindingSource.DataSource = this.T23_EnigmaDataSet2;
            // 
            // StrojBindingSource
            // 
            this.StrojBindingSource.DataMember = "Stroj";
            this.StrojBindingSource.DataSource = this.T23_EnigmaDataSet2;
            // 
            // izvjestajPracenja
            // 
            reportDataSource1.Name = "Artikl";
            reportDataSource1.Value = this.ArtiklBindingSource;
            reportDataSource2.Name = "Djelatnik";
            reportDataSource2.Value = this.DjelatnikBindingSource;
            reportDataSource3.Name = "PracenjeProizvodnje";
            reportDataSource3.Value = this.PracenjeProizvodnjeBindingSource;
            reportDataSource4.Name = "Stroj";
            reportDataSource4.Value = this.StrojBindingSource;
            this.izvjestajPracenja.LocalReport.DataSources.Add(reportDataSource1);
            this.izvjestajPracenja.LocalReport.DataSources.Add(reportDataSource2);
            this.izvjestajPracenja.LocalReport.DataSources.Add(reportDataSource3);
            this.izvjestajPracenja.LocalReport.DataSources.Add(reportDataSource4);
            this.izvjestajPracenja.LocalReport.ReportEmbeddedResource = "Compromplus_app.rptPracenjeProizvodnje.rdlc";
            this.izvjestajPracenja.Location = new System.Drawing.Point(12, 70);
            this.izvjestajPracenja.Name = "izvjestajPracenja";
            this.izvjestajPracenja.Size = new System.Drawing.Size(1144, 368);
            this.izvjestajPracenja.TabIndex = 0;
            // 
            // ArtiklTableAdapter
            // 
            this.ArtiklTableAdapter.ClearBeforeFill = true;
            // 
            // DjelatnikTableAdapter
            // 
            this.DjelatnikTableAdapter.ClearBeforeFill = true;
            // 
            // PracenjeProizvodnjeTableAdapter
            // 
            this.PracenjeProizvodnjeTableAdapter.ClearBeforeFill = true;
            // 
            // StrojTableAdapter
            // 
            this.StrojTableAdapter.ClearBeforeFill = true;
            // 
            // cboIdPracenje
            // 
            this.cboIdPracenje.DataSource = this.PracenjeProizvodnjeBindingSource;
            this.cboIdPracenje.DisplayMember = "IdPracenjeProizvodnje";
            this.cboIdPracenje.FormattingEnabled = true;
            this.cboIdPracenje.Location = new System.Drawing.Point(153, 26);
            this.cboIdPracenje.Name = "cboIdPracenje";
            this.cboIdPracenje.Size = new System.Drawing.Size(121, 21);
            this.cboIdPracenje.TabIndex = 1;
            this.cboIdPracenje.ValueMember = "IdPracenjeProizvodnje";
            this.cboIdPracenje.SelectedValueChanged += new System.EventHandler(this.cboIdPracenje_SelectedValueChanged);
            // 
            // pracenjeProizvodnjeBindingSource1
            // 
            this.pracenjeProizvodnjeBindingSource1.DataMember = "PracenjeProizvodnje";
            this.pracenjeProizvodnjeBindingSource1.DataSource = this.T23_EnigmaDataSet2;
            // 
            // pracenjeProizvodnjeBindingSource2
            // 
            this.pracenjeProizvodnjeBindingSource2.DataMember = "PracenjeProizvodnje";
            this.pracenjeProizvodnjeBindingSource2.DataSource = this.T23_EnigmaDataSet2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Odaberite IdPraćenja: ";
            // 
            // formaPracenjeProizvodnjeIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 440);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboIdPracenje);
            this.Controls.Add(this.izvjestajPracenja);
            this.Name = "formaPracenjeProizvodnjeIzvjestaj";
            this.Text = "formaPracenjeProizvodnjeIzvjestaj";
            this.Load += new System.EventHandler(this.formaPracenjeProizvodnjeIzvjestaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArtiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T23_EnigmaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DjelatnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PracenjeProizvodnjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StrojBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracenjeProizvodnjeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracenjeProizvodnjeBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer izvjestajPracenja;
        private System.Windows.Forms.BindingSource ArtiklBindingSource;
        private T23_EnigmaDataSet2 T23_EnigmaDataSet2;
        private System.Windows.Forms.BindingSource DjelatnikBindingSource;
        private System.Windows.Forms.BindingSource PracenjeProizvodnjeBindingSource;
        private System.Windows.Forms.BindingSource StrojBindingSource;
        private T23_EnigmaDataSet2TableAdapters.ArtiklTableAdapter ArtiklTableAdapter;
        private T23_EnigmaDataSet2TableAdapters.DjelatnikTableAdapter DjelatnikTableAdapter;
        private T23_EnigmaDataSet2TableAdapters.PracenjeProizvodnjeTableAdapter PracenjeProizvodnjeTableAdapter;
        private T23_EnigmaDataSet2TableAdapters.StrojTableAdapter StrojTableAdapter;
        private System.Windows.Forms.ComboBox cboIdPracenje;
        private System.Windows.Forms.BindingSource pracenjeProizvodnjeBindingSource1;
        private System.Windows.Forms.BindingSource pracenjeProizvodnjeBindingSource2;
        private System.Windows.Forms.Label label1;
    }
}