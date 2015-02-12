namespace Compromplus_app
{
    partial class formaUtrosakIzvjestaj
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
            this.UtrosakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t23_EnigmaDataSet1 = new Compromplus_app.T23_EnigmaDataSet1();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RepromaterijalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cboUtrosak = new System.Windows.Forms.ComboBox();
            this.t23_EnigmaDataSet = new Compromplus_app.T23_EnigmaDataSet();
            this.t23EnigmaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artiklTableAdapter = new Compromplus_app.T23_EnigmaDataSet1TableAdapters.ArtiklTableAdapter();
            this.UtrosakTableAdapter = new Compromplus_app.T23_EnigmaDataSet1TableAdapters.UtrosakTableAdapter();
            this.RepromaterijalTableAdapter = new Compromplus_app.T23_EnigmaDataSet1TableAdapters.RepromaterijalTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UtrosakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_EnigmaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepromaterijalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_EnigmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23EnigmaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UtrosakBindingSource
            // 
            this.UtrosakBindingSource.DataMember = "Utrosak";
            this.UtrosakBindingSource.DataSource = this.t23_EnigmaDataSet1;
            // 
            // t23_EnigmaDataSet1
            // 
            this.t23_EnigmaDataSet1.DataSetName = "T23_EnigmaDataSet1";
            this.t23_EnigmaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataMember = "Artikl";
            this.artiklBindingSource.DataSource = this.t23_EnigmaDataSet1;
            // 
            // RepromaterijalBindingSource
            // 
            this.RepromaterijalBindingSource.DataMember = "Repromaterijal";
            this.RepromaterijalBindingSource.DataSource = this.t23_EnigmaDataSet1;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Utrosak";
            reportDataSource1.Value = this.UtrosakBindingSource;
            reportDataSource2.Name = "Artikl";
            reportDataSource2.Value = this.artiklBindingSource;
            reportDataSource3.Name = "Repromaterijal";
            reportDataSource3.Value = this.RepromaterijalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Compromplus_app.rptUtrosak.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(29, 93);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(855, 440);
            this.reportViewer1.TabIndex = 0;
            // 
            // cboUtrosak
            // 
            this.cboUtrosak.DataSource = this.artiklBindingSource;
            this.cboUtrosak.DisplayMember = "IdArtikl";
            this.cboUtrosak.FormattingEnabled = true;
            this.cboUtrosak.Location = new System.Drawing.Point(164, 50);
            this.cboUtrosak.Name = "cboUtrosak";
            this.cboUtrosak.Size = new System.Drawing.Size(121, 21);
            this.cboUtrosak.TabIndex = 1;
            this.cboUtrosak.ValueMember = "IdArtikl";
            this.cboUtrosak.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // t23_EnigmaDataSet
            // 
            this.t23_EnigmaDataSet.DataSetName = "T23_EnigmaDataSet";
            this.t23_EnigmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t23EnigmaDataSetBindingSource
            // 
            this.t23EnigmaDataSetBindingSource.DataSource = this.t23_EnigmaDataSet;
            this.t23EnigmaDataSetBindingSource.Position = 0;
            // 
            // artiklTableAdapter
            // 
            this.artiklTableAdapter.ClearBeforeFill = true;
            // 
            // UtrosakTableAdapter
            // 
            this.UtrosakTableAdapter.ClearBeforeFill = true;
            // 
            // RepromaterijalTableAdapter
            // 
            this.RepromaterijalTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Odaberi ID artikla";
            // 
            // formaUtrosakIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 545);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboUtrosak);
            this.Controls.Add(this.reportViewer1);
            this.Name = "formaUtrosakIzvjestaj";
            this.Text = "formaUtrosakIzvjestaj";
            this.Load += new System.EventHandler(this.formaUtrosakIzvjestaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UtrosakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_EnigmaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepromaterijalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23_EnigmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23EnigmaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cboUtrosak;
        private System.Windows.Forms.BindingSource t23EnigmaDataSetBindingSource;
        private T23_EnigmaDataSet t23_EnigmaDataSet;
        private T23_EnigmaDataSet1 t23_EnigmaDataSet1;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private T23_EnigmaDataSet1TableAdapters.ArtiklTableAdapter artiklTableAdapter;
        private System.Windows.Forms.BindingSource UtrosakBindingSource;
        private System.Windows.Forms.BindingSource RepromaterijalBindingSource;
        private T23_EnigmaDataSet1TableAdapters.UtrosakTableAdapter UtrosakTableAdapter;
        private T23_EnigmaDataSet1TableAdapters.RepromaterijalTableAdapter RepromaterijalTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}