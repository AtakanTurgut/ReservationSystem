namespace ReservationSystem.Forms.MainForm
{
	partial class FrmMainForm
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
			DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
			DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
			this.gridControlCustomer = new DevExpress.XtraGrid.GridControl();
			this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.musteriyiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vazgeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupControlCustomer = new DevExpress.XtraEditors.GroupControl();
			this.groupControlProduct = new DevExpress.XtraEditors.GroupControl();
			this.gridControlProduct = new DevExpress.XtraGrid.GridControl();
			this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
			this.chartControlProduct = new DevExpress.XtraCharts.ChartControl();
			this.groupControlReservation = new DevExpress.XtraEditors.GroupControl();
			this.gridControlReservation = new DevExpress.XtraGrid.GridControl();
			this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.groupControlRoom = new DevExpress.XtraEditors.GroupControl();
			this.chartControlRoom = new DevExpress.XtraCharts.ChartControl();
			((System.ComponentModel.ISupportInitialize)(this.gridControlCustomer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.contextMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupControlCustomer)).BeginInit();
			this.groupControlCustomer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupControlProduct)).BeginInit();
			this.groupControlProduct.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControlProduct)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
			this.groupControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartControlProduct)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControlReservation)).BeginInit();
			this.groupControlReservation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControlReservation)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControlRoom)).BeginInit();
			this.groupControlRoom.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartControlRoom)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControlCustomer
			// 
			this.gridControlCustomer.DataSource = this.bindingSource;
			this.gridControlCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControlCustomer.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.gridControlCustomer.Location = new System.Drawing.Point(2, 28);
			this.gridControlCustomer.MainView = this.gridView1;
			this.gridControlCustomer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.gridControlCustomer.Name = "gridControlCustomer";
			this.gridControlCustomer.Size = new System.Drawing.Size(443, 135);
			this.gridControlCustomer.TabIndex = 2;
			this.gridControlCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.DetailHeight = 682;
			this.gridView1.GridControl = this.gridControlCustomer;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsEditForm.PopupEditFormWidth = 1562;
			this.gridView1.OptionsView.ShowGroupPanel = false;
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musteriyiSilToolStripMenuItem,
            this.vazgeçToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(159, 52);
			// 
			// musteriyiSilToolStripMenuItem
			// 
			this.musteriyiSilToolStripMenuItem.Name = "musteriyiSilToolStripMenuItem";
			this.musteriyiSilToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
			this.musteriyiSilToolStripMenuItem.Text = "Müşteriyi Sil";
			// 
			// vazgeçToolStripMenuItem
			// 
			this.vazgeçToolStripMenuItem.Name = "vazgeçToolStripMenuItem";
			this.vazgeçToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
			this.vazgeçToolStripMenuItem.Text = "Vazgeç";
			// 
			// groupControlCustomer
			// 
			this.groupControlCustomer.Controls.Add(this.gridControlCustomer);
			this.groupControlCustomer.Location = new System.Drawing.Point(14, 16);
			this.groupControlCustomer.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.groupControlCustomer.Name = "groupControlCustomer";
			this.groupControlCustomer.Size = new System.Drawing.Size(447, 165);
			this.groupControlCustomer.TabIndex = 3;
			this.groupControlCustomer.Text = "Müşteri Listesi";
			// 
			// groupControlProduct
			// 
			this.groupControlProduct.Controls.Add(this.gridControlProduct);
			this.groupControlProduct.Location = new System.Drawing.Point(471, 16);
			this.groupControlProduct.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.groupControlProduct.Name = "groupControlProduct";
			this.groupControlProduct.Size = new System.Drawing.Size(420, 346);
			this.groupControlProduct.TabIndex = 4;
			this.groupControlProduct.Text = "Ürün-Stok Listesi";
			// 
			// gridControlProduct
			// 
			this.gridControlProduct.DataSource = this.bindingSource;
			this.gridControlProduct.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControlProduct.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.gridControlProduct.Location = new System.Drawing.Point(2, 28);
			this.gridControlProduct.MainView = this.gridView2;
			this.gridControlProduct.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.gridControlProduct.Name = "gridControlProduct";
			this.gridControlProduct.Size = new System.Drawing.Size(416, 316);
			this.gridControlProduct.TabIndex = 2;
			this.gridControlProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
			// 
			// gridView2
			// 
			this.gridView2.DetailHeight = 852;
			this.gridView2.GridControl = this.gridControlProduct;
			this.gridView2.Name = "gridView2";
			this.gridView2.OptionsEditForm.PopupEditFormWidth = 1952;
			this.gridView2.OptionsView.ShowGroupPanel = false;
			// 
			// groupControl3
			// 
			this.groupControl3.Controls.Add(this.chartControlProduct);
			this.groupControl3.Location = new System.Drawing.Point(901, 16);
			this.groupControl3.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.groupControl3.Name = "groupControl3";
			this.groupControl3.Size = new System.Drawing.Size(461, 166);
			this.groupControl3.TabIndex = 5;
			this.groupControl3.Text = "Ürün-Stok Grafiği";
			// 
			// chartControlProduct
			// 
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
			this.chartControlProduct.Diagram = xyDiagram1;
			this.chartControlProduct.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chartControlProduct.Legend.LegendID = -1;
			this.chartControlProduct.Location = new System.Drawing.Point(2, 28);
			this.chartControlProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.chartControlProduct.Name = "chartControlProduct";
			series1.Name = "Urun-Stok";
			series1.SeriesID = 0;
			this.chartControlProduct.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
			this.chartControlProduct.Size = new System.Drawing.Size(457, 136);
			this.chartControlProduct.TabIndex = 0;
			// 
			// groupControlReservation
			// 
			this.groupControlReservation.Controls.Add(this.gridControlReservation);
			this.groupControlReservation.Location = new System.Drawing.Point(15, 192);
			this.groupControlReservation.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.groupControlReservation.Name = "groupControlReservation";
			this.groupControlReservation.Size = new System.Drawing.Size(446, 170);
			this.groupControlReservation.TabIndex = 4;
			this.groupControlReservation.Text = "Bugün Gelecek Müşteriler";
			// 
			// gridControlReservation
			// 
			this.gridControlReservation.DataSource = this.bindingSource;
			this.gridControlReservation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControlReservation.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.gridControlReservation.Location = new System.Drawing.Point(2, 28);
			this.gridControlReservation.MainView = this.gridView4;
			this.gridControlReservation.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.gridControlReservation.Name = "gridControlReservation";
			this.gridControlReservation.Size = new System.Drawing.Size(442, 140);
			this.gridControlReservation.TabIndex = 2;
			this.gridControlReservation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
			// 
			// gridView4
			// 
			this.gridView4.DetailHeight = 852;
			this.gridView4.GridControl = this.gridControlReservation;
			this.gridView4.Name = "gridView4";
			this.gridView4.OptionsEditForm.PopupEditFormWidth = 1952;
			this.gridView4.OptionsView.ShowGroupPanel = false;
			// 
			// groupControlRoom
			// 
			this.groupControlRoom.Controls.Add(this.chartControlRoom);
			this.groupControlRoom.Location = new System.Drawing.Point(901, 192);
			this.groupControlRoom.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
			this.groupControlRoom.Name = "groupControlRoom";
			this.groupControlRoom.Size = new System.Drawing.Size(461, 170);
			this.groupControlRoom.TabIndex = 6;
			this.groupControlRoom.Text = "Oda Doluluk Grafiği";
			// 
			// chartControlRoom
			// 
			this.chartControlRoom.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chartControlRoom.Legend.LegendID = -1;
			this.chartControlRoom.Location = new System.Drawing.Point(2, 28);
			this.chartControlRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.chartControlRoom.Name = "chartControlRoom";
			series2.LegendTextPattern = "{A}";
			series2.Name = "Durumlar";
			series2.SeriesID = 1;
			series2.View = pieSeriesView1;
			this.chartControlRoom.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
			this.chartControlRoom.Size = new System.Drawing.Size(457, 140);
			this.chartControlRoom.TabIndex = 0;
			// 
			// FrmMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1379, 370);
			this.Controls.Add(this.groupControlRoom);
			this.Controls.Add(this.groupControlReservation);
			this.Controls.Add(this.groupControl3);
			this.Controls.Add(this.groupControlProduct);
			this.Controls.Add(this.groupControlCustomer);
			this.Name = "FrmMainForm";
			this.Text = "Ana Form";
			this.Load += new System.EventHandler(this.FrmMainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControlCustomer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.contextMenuStrip.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupControlCustomer)).EndInit();
			this.groupControlCustomer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupControlProduct)).EndInit();
			this.groupControlProduct.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControlProduct)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
			this.groupControl3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartControlProduct)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControlReservation)).EndInit();
			this.groupControlReservation.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControlReservation)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControlRoom)).EndInit();
			this.groupControlRoom.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartControlRoom)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControlCustomer;
		private System.Windows.Forms.BindingSource bindingSource;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem musteriyiSilToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem vazgeçToolStripMenuItem;
		private DevExpress.XtraEditors.GroupControl groupControlCustomer;
		private DevExpress.XtraEditors.GroupControl groupControlProduct;
		private DevExpress.XtraGrid.GridControl gridControlProduct;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
		private DevExpress.XtraEditors.GroupControl groupControl3;
		private DevExpress.XtraEditors.GroupControl groupControlReservation;
		private DevExpress.XtraGrid.GridControl gridControlReservation;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
		private DevExpress.XtraEditors.GroupControl groupControlRoom;
		private DevExpress.XtraCharts.ChartControl chartControlProduct;
		private DevExpress.XtraCharts.ChartControl chartControlRoom;
	}
}