namespace ReservationSystem.Forms.Graphics
{
	partial class FrmGraphicProductStock
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
			DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
			DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
			this.gridControlProduct = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.chartControlProduct = new DevExpress.XtraCharts.ChartControl();
			((System.ComponentModel.ISupportInitialize)(this.gridControlProduct)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartControlProduct)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControlProduct
			// 
			this.gridControlProduct.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.gridControlProduct.Location = new System.Drawing.Point(14, 14);
			this.gridControlProduct.MainView = this.gridView1;
			this.gridControlProduct.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.gridControlProduct.Name = "gridControlProduct";
			this.gridControlProduct.Size = new System.Drawing.Size(455, 342);
			this.gridControlProduct.TabIndex = 0;
			this.gridControlProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.DetailHeight = 437;
			this.gridView1.GridControl = this.gridControlProduct;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsEditForm.PopupEditFormWidth = 1000;
			// 
			// chartControlProduct
			// 
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
			this.chartControlProduct.Diagram = xyDiagram1;
			this.chartControlProduct.Legend.LegendID = -1;
			this.chartControlProduct.Location = new System.Drawing.Point(477, 14);
			this.chartControlProduct.Name = "chartControlProduct";
			series1.Name = "Urun-Stok";
			series1.SeriesID = 1;
			this.chartControlProduct.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
			this.chartControlProduct.Size = new System.Drawing.Size(890, 342);
			this.chartControlProduct.TabIndex = 1;
			// 
			// FrmGraphicProductStock
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1379, 370);
			this.Controls.Add(this.chartControlProduct);
			this.Controls.Add(this.gridControlProduct);
			this.Name = "FrmGraphicProductStock";
			this.Text = "Ürün-Stok Grafiği";
			this.Load += new System.EventHandler(this.FrmGraphicProductStock_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControlProduct)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartControlProduct)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControlProduct;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraCharts.ChartControl chartControlProduct;
	}
}