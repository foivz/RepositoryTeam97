namespace aplikacija
{
    partial class formaDokumentiPregled
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formaDokumentiPregled));
            this.dokumentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dokumentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dokumentDataGridView = new System.Windows.Forms.DataGridView();
            this.stavke_dokumentaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t28EnigmaDataSet = new aplikacija.T28EnigmaDataSet();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavke_dokumentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dokumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dokumentTableAdapter = new aplikacija.T28EnigmaDataSetTableAdapters.DokumentTableAdapter();
            this.tableAdapterManager = new aplikacija.T28EnigmaDataSetTableAdapters.TableAdapterManager();
            this.artikliTableAdapter = new aplikacija.T28EnigmaDataSetTableAdapters.ArtikliTableAdapter();
            this.stavke_dokumentaTableAdapter = new aplikacija.T28EnigmaDataSetTableAdapters.stavke_dokumentaTableAdapter();
            this.tipDokumentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipDokumentaTableAdapter = new aplikacija.T28EnigmaDataSetTableAdapters.TipDokumentaTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentBindingNavigator)).BeginInit();
            this.dokumentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_dokumentaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t28EnigmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_dokumentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipDokumentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dokumentBindingNavigator
            // 
            this.dokumentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dokumentBindingNavigator.BindingSource = this.dokumentBindingSource;
            this.dokumentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dokumentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dokumentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.dokumentBindingNavigatorSaveItem});
            this.dokumentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dokumentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dokumentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dokumentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dokumentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dokumentBindingNavigator.Name = "dokumentBindingNavigator";
            this.dokumentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dokumentBindingNavigator.Size = new System.Drawing.Size(910, 25);
            this.dokumentBindingNavigator.TabIndex = 0;
            this.dokumentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dokumentBindingNavigatorSaveItem
            // 
            this.dokumentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dokumentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dokumentBindingNavigatorSaveItem.Image")));
            this.dokumentBindingNavigatorSaveItem.Name = "dokumentBindingNavigatorSaveItem";
            this.dokumentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dokumentBindingNavigatorSaveItem.Text = "Save Data";
            this.dokumentBindingNavigatorSaveItem.Click += new System.EventHandler(this.dokumentBindingNavigatorSaveItem_Click);
            // 
            // dokumentDataGridView
            // 
            this.dokumentDataGridView.AutoGenerateColumns = false;
            this.dokumentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dokumentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dokumentDataGridView.DataSource = this.dokumentBindingSource;
            this.dokumentDataGridView.Location = new System.Drawing.Point(26, 28);
            this.dokumentDataGridView.Name = "dokumentDataGridView";
            this.dokumentDataGridView.Size = new System.Drawing.Size(761, 220);
            this.dokumentDataGridView.TabIndex = 1;
            this.dokumentDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dokumentDataGridView_CellBeginEdit);
            this.dokumentDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dokumentDataGridView_CellEndEdit);
            this.dokumentDataGridView.SelectionChanged += new System.EventHandler(this.dokumentDataGridView_SelectionChanged);
            // 
            // stavke_dokumentaDataGridView
            // 
            this.stavke_dokumentaDataGridView.AutoGenerateColumns = false;
            this.stavke_dokumentaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stavke_dokumentaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.stavke_dokumentaDataGridView.DataSource = this.stavke_dokumentaBindingSource;
            this.stavke_dokumentaDataGridView.Location = new System.Drawing.Point(26, 269);
            this.stavke_dokumentaDataGridView.Name = "stavke_dokumentaDataGridView";
            this.stavke_dokumentaDataGridView.Size = new System.Drawing.Size(761, 216);
            this.stavke_dokumentaDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "artikliId";
            this.dataGridViewTextBoxColumn6.DataSource = this.artikliBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "naziv";
            this.dataGridViewTextBoxColumn6.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewTextBoxColumn6.HeaderText = "artikliId";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "IdArtikli";
            // 
            // artikliBindingSource
            // 
            this.artikliBindingSource.DataMember = "Artikli";
            this.artikliBindingSource.DataSource = this.t28EnigmaDataSet;
            // 
            // t28EnigmaDataSet
            // 
            this.t28EnigmaDataSet.DataSetName = "T28EnigmaDataSet";
            this.t28EnigmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "dokumentId";
            this.dataGridViewTextBoxColumn7.HeaderText = "dokumentId";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "kolicina";
            this.dataGridViewTextBoxColumn8.HeaderText = "kolicina";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // stavke_dokumentaBindingSource
            // 
            this.stavke_dokumentaBindingSource.DataMember = "stavke_dokumenta";
            this.stavke_dokumentaBindingSource.DataSource = this.t28EnigmaDataSet;
            // 
            // dokumentBindingSource
            // 
            this.dokumentBindingSource.DataMember = "Dokument";
            this.dokumentBindingSource.DataSource = this.t28EnigmaDataSet;
            // 
            // dokumentTableAdapter
            // 
            this.dokumentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArtikliTableAdapter = this.artikliTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DjelatnikTableAdapter = null;
            this.tableAdapterManager.DokumentTableAdapter = this.dokumentTableAdapter;
            this.tableAdapterManager.EvidencijaKontroleTableAdapter = null;
            this.tableAdapterManager.KorisnikTableAdapter = null;
            this.tableAdapterManager.PoslovniPartnerTableAdapter = null;
            this.tableAdapterManager.RepromaterijalTableAdapter = null;
            this.tableAdapterManager.stavke_dokumentaTableAdapter = this.stavke_dokumentaTableAdapter;
            this.tableAdapterManager.stavke_repromaterijalaTableAdapter = null;
            this.tableAdapterManager.StrojTableAdapter = null;
            this.tableAdapterManager.TipDokumentaTableAdapter = null;
            this.tableAdapterManager.TipKorisnikaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = aplikacija.T28EnigmaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // artikliTableAdapter
            // 
            this.artikliTableAdapter.ClearBeforeFill = true;
            // 
            // stavke_dokumentaTableAdapter
            // 
            this.stavke_dokumentaTableAdapter.ClearBeforeFill = true;
            // 
            // tipDokumentaBindingSource
            // 
            this.tipDokumentaBindingSource.DataMember = "TipDokumenta";
            this.tipDokumentaBindingSource.DataSource = this.t28EnigmaDataSet;
            // 
            // tipDokumentaTableAdapter
            // 
            this.tipDokumentaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdDokument";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdDokument";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "datum";
            this.dataGridViewTextBoxColumn3.HeaderText = "datum";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "opis";
            this.dataGridViewTextBoxColumn4.HeaderText = "opis";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tipDokumenta";
            this.dataGridViewTextBoxColumn5.DataSource = this.tipDokumentaBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "naziv";
            this.dataGridViewTextBoxColumn5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewTextBoxColumn5.HeaderText = "tipDokumenta";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "IdTipDokumenta";
            // 
            // formaDokumentiPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 506);
            this.Controls.Add(this.stavke_dokumentaDataGridView);
            this.Controls.Add(this.dokumentDataGridView);
            this.Controls.Add(this.dokumentBindingNavigator);
            this.Name = "formaDokumentiPregled";
            this.Text = "formaDokumentiPregled";
            this.Load += new System.EventHandler(this.formaDokumentiPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dokumentBindingNavigator)).EndInit();
            this.dokumentBindingNavigator.ResumeLayout(false);
            this.dokumentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_dokumentaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t28EnigmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_dokumentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipDokumentaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private T28EnigmaDataSet t28EnigmaDataSet;
        private System.Windows.Forms.BindingSource dokumentBindingSource;
        private T28EnigmaDataSetTableAdapters.DokumentTableAdapter dokumentTableAdapter;
        private T28EnigmaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dokumentBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton dokumentBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dokumentDataGridView;
        private T28EnigmaDataSetTableAdapters.stavke_dokumentaTableAdapter stavke_dokumentaTableAdapter;
        private System.Windows.Forms.BindingSource stavke_dokumentaBindingSource;
        private System.Windows.Forms.DataGridView stavke_dokumentaDataGridView;
        private T28EnigmaDataSetTableAdapters.ArtikliTableAdapter artikliTableAdapter;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource tipDokumentaBindingSource;
        private T28EnigmaDataSetTableAdapters.TipDokumentaTableAdapter tipDokumentaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
    }
}