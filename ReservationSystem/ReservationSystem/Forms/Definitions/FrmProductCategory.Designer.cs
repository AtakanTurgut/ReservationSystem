namespace ReservationSystem.Forms.Definitions
{
    partial class FrmProductCategory
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
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.durumuSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vazgeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grdStatus = new DevExpress.XtraGrid.GridControl();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditStatus = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.durumuSilToolStripMenuItem,
            this.vazgeçToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(143, 48);
            // 
            // durumuSilToolStripMenuItem
            // 
            this.durumuSilToolStripMenuItem.Name = "durumuSilToolStripMenuItem";
            this.durumuSilToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.durumuSilToolStripMenuItem.Text = "Kategoriyi Sil";
            this.durumuSilToolStripMenuItem.Click += new System.EventHandler(this.kategoriyiSilToolStripMenuItem_Click);
            // 
            // vazgeçToolStripMenuItem
            // 
            this.vazgeçToolStripMenuItem.Name = "vazgeçToolStripMenuItem";
            this.vazgeçToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.vazgeçToolStripMenuItem.Text = "Vazgeç";
            // 
            // grdStatus
            // 
            this.grdStatus.DataSource = this.bindingSource;
            this.grdStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdStatus.Location = new System.Drawing.Point(0, 0);
            this.grdStatus.MainView = this.gridView1;
            this.grdStatus.Name = "grdStatus";
            this.grdStatus.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditStatus});
            this.grdStatus.Size = new System.Drawing.Size(494, 421);
            this.grdStatus.TabIndex = 8;
            this.grdStatus.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn2});
            this.gridView1.GridControl = this.grdStatus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Kategori";
            this.gridColumn4.FieldName = "ProductCategory";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Durum";
            this.gridColumn2.ColumnEdit = this.repositoryItemLookUpEditStatus;
            this.gridColumn2.FieldName = "StatusId";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // repositoryItemLookUpEditStatus
            // 
            this.repositoryItemLookUpEditStatus.AutoHeight = false;
            this.repositoryItemLookUpEditStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditStatus.DisplayMember = "StatusName";
            this.repositoryItemLookUpEditStatus.Name = "repositoryItemLookUpEditStatus";
            this.repositoryItemLookUpEditStatus.NullText = "Durum Seçin";
            this.repositoryItemLookUpEditStatus.ValueMember = "StatusId";
            // 
            // FrmProductCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 421);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.grdStatus);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProductCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Kategori Tanımları";
            this.Load += new System.EventHandler(this.FrmProductCategory_Load);
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem durumuSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vazgeçToolStripMenuItem;
        private DevExpress.XtraGrid.GridControl grdStatus;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditStatus;
        private System.Windows.Forms.BindingSource bindingSource;
    }
}