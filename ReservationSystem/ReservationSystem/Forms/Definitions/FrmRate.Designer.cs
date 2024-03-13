namespace ReservationSystem.Forms.Definitions
{
    partial class FrmRate
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
            this.grdStatus = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditStatus = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.durumuSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vazgeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
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
            this.grdStatus.TabIndex = 3;
            this.grdStatus.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn2});
            this.gridView1.GridControl = this.grdStatus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Kur";
            this.gridColumn1.FieldName = "RateName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Değer";
            this.gridColumn3.FieldName = "ExchangeRate";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tarih";
            this.gridColumn4.FieldName = "Date";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Sembol";
            this.gridColumn5.FieldName = "Symbol";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Durum";
            this.gridColumn2.ColumnEdit = this.repositoryItemLookUpEditStatus;
            this.gridColumn2.FieldName = "StatusId";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
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
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.durumuSilToolStripMenuItem,
            this.vazgeçToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(115, 48);
            // 
            // durumuSilToolStripMenuItem
            // 
            this.durumuSilToolStripMenuItem.Name = "durumuSilToolStripMenuItem";
            this.durumuSilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.durumuSilToolStripMenuItem.Text = "Kuru Sil";
            this.durumuSilToolStripMenuItem.Click += new System.EventHandler(this.kuruSilToolStripMenuItem_Click);
            // 
            // vazgeçToolStripMenuItem
            // 
            this.vazgeçToolStripMenuItem.Name = "vazgeçToolStripMenuItem";
            this.vazgeçToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vazgeçToolStripMenuItem.Text = "Vazgeç";
            // 
            // FrmRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 421);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.grdStatus);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kur Tanımları";
            this.Load += new System.EventHandler(this.FrmRate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdStatus;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditStatus;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem durumuSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vazgeçToolStripMenuItem;
    }
}