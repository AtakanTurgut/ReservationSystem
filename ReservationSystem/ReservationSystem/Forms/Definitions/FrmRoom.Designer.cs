namespace ReservationSystem.Forms.Definitions
{
    partial class FrmRoom
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
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditStatus = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.durumuSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vazgeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditStatus)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
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
            this.grdStatus.TabIndex = 4;
            this.grdStatus.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn6,
            this.gridColumn5,
            this.gridColumn2});
            this.gridView1.GridControl = this.grdStatus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Oda Numarası";
            this.gridColumn1.FieldName = "RoomNo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Kat";
            this.gridColumn3.FieldName = "Floor";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Kapasite";
            this.gridColumn4.FieldName = "Capacity";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Durum";
            this.gridColumn2.ColumnEdit = this.repositoryItemLookUpEditStatus;
            this.gridColumn2.FieldName = "StatusId";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
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
            this.contextMenuStrip.Size = new System.Drawing.Size(121, 48);
            // 
            // durumuSilToolStripMenuItem
            // 
            this.durumuSilToolStripMenuItem.Name = "durumuSilToolStripMenuItem";
            this.durumuSilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.durumuSilToolStripMenuItem.Text = "Odayı Sil";
            this.durumuSilToolStripMenuItem.Click += new System.EventHandler(this.odayiSilToolStripMenuItem_Click);
            // 
            // vazgeçToolStripMenuItem
            // 
            this.vazgeçToolStripMenuItem.Name = "vazgeçToolStripMenuItem";
            this.vazgeçToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vazgeçToolStripMenuItem.Text = "Vazgeç";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Telefon";
            this.gridColumn6.FieldName = "Phone";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Açıklama";
            this.gridColumn5.FieldName = "Description";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // FrmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 421);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.grdStatus);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oda Tanımları";
            this.Load += new System.EventHandler(this.FrmRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditStatus)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdStatus;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem durumuSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vazgeçToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}