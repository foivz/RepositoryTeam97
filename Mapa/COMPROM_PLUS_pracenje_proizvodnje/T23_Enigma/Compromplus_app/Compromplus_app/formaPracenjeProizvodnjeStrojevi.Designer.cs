namespace Compromplus_app
{
    partial class formaPracenjeProizvodnjeStrojevi
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
            this.StrojBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PracenjeProizvodnjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboIdPracenje2 = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ArtiklTableAdapter = new Compromplus_app.T23_EnigmaDataSet2TableAdapters.ArtiklTableAdapter();
            this.DjelatnikTableAdapter = new Compromplus_app.T23_EnigmaDataSet2TableAdapters.DjelatnikTableAdapter();
            this.StrojTableAdapter = new Compromplus_app.T23_EnigmaDataSet2TableAdapters.StrojTableAdapter();
            this.PracenjeProizvodnjeTableAdapter = new Compromplus_app.T23_EnigmaDataSet2TableAdapters.PracenjeProizvodnjeTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ArtiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T23_EnigmaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DjelatnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StrojBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PracenjeProizvodnjeBindingSource)).BeginInit();
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
            // StrojBindingSource
            // 
            this.StrojBindingSource.DataMember = "Stroj";
            this.StrojBindingSource.DataSource = this.T23_EnigmaDataSet2;
            // 
            // PracenjeProizvodnjeBindingSource
            // 
            this.PracenjeProizvodnjeBindingSource.DataMember = "PracenjeProizvodnje";
            this.PracenjeProizvodnjeBindingSource.DataSource = this.T23_EnigmaDataSet2;
            // 
            // cboIdPracenje2
            // 
            this.cboIdPracenje2.DataSource = this.PracenjeProizvodnjeBindingSource;
            this.cboIdPracenje2.DisplayMember = "IdStroj";
            this.cboIdPracenje2.FormattingEnabled = true;
            this.cboIdPracenje2.Location = new System.Drawing.Point(146, 51);
            this.cboIdPracenje2.Name = "cboIdPracenje2";
            this.cboIdPracenje2.Size = new System.Drawing.Size(121, 21);
            this.cboIdPracenje2.TabIndex = 0;
            this.cboIdPracenje2.ValueMember = "IdStroj";
            this.cboIdPracenje2.SelectedValueChanged += new System.EventHandler(this.cboIdPracenje2_SelectedValueChanged);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Artikl";
            reportDataSource1.Value = this.ArtiklBindingSource;
            reportDataSource2.Name = "Djelatnik";
            reportDataSource2.Value = this.DjelatnikBindingSource;
            reportDataSource3.Name = "Stroj";
            reportDataSource3.Value = this.StrojBindingSource;
            reportDataSource4.Name = "PracenjeProizvodnje";
            reportDataSource4.Value = this.PracenjeProizvodnjeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Compromplus_app.rptStroj.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(45, 101);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1085, 587);
            this.reportViewer1.TabIndex = 1;
            // 
            // ArtiklTableAdapter
            // 
            this.ArtiklTableAdapter.ClearBeforeFill = true;
            // 
            // DjelatnikTableAdapter
            // 
            this.DjelatnikTableAdapter.ClearBeforeFill = true;
            // 
            // StrojTableAdapter
            // 
            this.StrojTableAdapter.ClearBeforeFill = true;
            // 
            // PracenjeProizvodnjeTableAdapter
            // 
            this.PracenjeProizvodnjeTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Odaberi ID stroja:";
            // 
            // formaPracenjeProizvodnjeStrojevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 700);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.cboIdPracenje2);
            this.Name = "formaPracenjeProizvodnjeStrojevi";
            this.Text = "formaPracenjeProizvodnjeStrojevi";
            this.Load += new System.EventHandler(this.formaPracenjeProizvodnjeStrojevi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArtiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T23_EnigmaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DjelatnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StrojBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PracenjeProizvodnjeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboIdPracenje2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ArtiklBindingSource;
        private T23_EnigmaDataSet2 T23_EnigmaDataSet2;
        private System.Windows.Forms.BindingSource DjelatnikBindingSource;
        private System.Windows.Forms.BindingSource StrojBindingSource;
        private System.Windows.Forms.BindingSource PracenjeProizvodnjeBindingSource;
        private T23_EnigmaDataSet2TableAdapters.ArtiklTableAdapter ArtiklTableAdapter;
        private T23_EnigmaDataSet2TableAdapters.DjelatnikTableAdapter DjelatnikTableAdapter;
        private T23_EnigmaDataSet2TableAdapters.StrojTableAdapter StrojTableAdapter;
        private T23_EnigmaDataSet2TableAdapters.PracenjeProizvodnjeTableAdapter PracenjeProizvodnjeTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}