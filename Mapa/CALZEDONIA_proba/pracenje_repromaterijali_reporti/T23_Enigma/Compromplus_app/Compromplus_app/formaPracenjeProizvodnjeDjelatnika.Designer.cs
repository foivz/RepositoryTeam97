namespace Compromplus_app
{
    partial class formaPracenjeProizvodnjeDjelatnika
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ArtiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.T23_EnigmaDataSet2 = new Compromplus_app.T23_EnigmaDataSet2();
            this.DjelatnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PracenjeProizvodnjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StrojBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboDjelatnik = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DjelatnikTableAdapter = new Compromplus_app.T23_EnigmaDataSet2TableAdapters.DjelatnikTableAdapter();
            this.PracenjeProizvodnjeTableAdapter = new Compromplus_app.T23_EnigmaDataSet2TableAdapters.PracenjeProizvodnjeTableAdapter();
            this.StrojTableAdapter = new Compromplus_app.T23_EnigmaDataSet2TableAdapters.StrojTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.ArtiklTableAdapter = new Compromplus_app.T23_EnigmaDataSet2TableAdapters.ArtiklTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ArtiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T23_EnigmaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DjelatnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PracenjeProizvodnjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StrojBindingSource)).BeginInit();
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
            // cboDjelatnik
            // 
            this.cboDjelatnik.DataSource = this.PracenjeProizvodnjeBindingSource;
            this.cboDjelatnik.DisplayMember = "IdDjelatnici";
            this.cboDjelatnik.FormattingEnabled = true;
            this.cboDjelatnik.Location = new System.Drawing.Point(164, 48);
            this.cboDjelatnik.Name = "cboDjelatnik";
            this.cboDjelatnik.Size = new System.Drawing.Size(121, 21);
            this.cboDjelatnik.TabIndex = 0;
            this.cboDjelatnik.ValueMember = "IdDjelatnici";
            this.cboDjelatnik.SelectedIndexChanged += new System.EventHandler(this.cboDjelatnik_SelectedIndexChanged);
            this.cboDjelatnik.SelectedValueChanged += new System.EventHandler(this.cboDjelatnik_SelectedValueChanged);
            // 
            // reportViewer1
            // 
            reportDataSource5.Name = "Artikl";
            reportDataSource5.Value = this.ArtiklBindingSource;
            reportDataSource6.Name = "Djelatnik";
            reportDataSource6.Value = this.DjelatnikBindingSource;
            reportDataSource7.Name = "PracenjeProizvodnje";
            reportDataSource7.Value = this.PracenjeProizvodnjeBindingSource;
            reportDataSource8.Name = "Stroj";
            reportDataSource8.Value = this.StrojBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Compromplus_app.rptDjelatnik.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 90);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(929, 533);
            this.reportViewer1.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Odaberite ID djelatnika";
            // 
            // ArtiklTableAdapter
            // 
            this.ArtiklTableAdapter.ClearBeforeFill = true;
            // 
            // formaPracenjeProizvodnjeDjelatnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 635);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.cboDjelatnik);
            this.Name = "formaPracenjeProizvodnjeDjelatnika";
            this.Text = "formaPracenjeProizvodnjeDjelatnika";
            this.Load += new System.EventHandler(this.formaPracenjeProizvodnjeDjelatnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArtiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T23_EnigmaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DjelatnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PracenjeProizvodnjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StrojBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDjelatnik;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ArtiklBindingSource;
        private T23_EnigmaDataSet2 T23_EnigmaDataSet2;
        private System.Windows.Forms.BindingSource DjelatnikBindingSource;
        private System.Windows.Forms.BindingSource PracenjeProizvodnjeBindingSource;
        private System.Windows.Forms.BindingSource StrojBindingSource;
        private T23_EnigmaDataSet2TableAdapters.DjelatnikTableAdapter DjelatnikTableAdapter;
        private T23_EnigmaDataSet2TableAdapters.PracenjeProizvodnjeTableAdapter PracenjeProizvodnjeTableAdapter;
        private T23_EnigmaDataSet2TableAdapters.StrojTableAdapter StrojTableAdapter;
        private System.Windows.Forms.Label label1;
        private T23_EnigmaDataSet2TableAdapters.ArtiklTableAdapter ArtiklTableAdapter;
    }
}