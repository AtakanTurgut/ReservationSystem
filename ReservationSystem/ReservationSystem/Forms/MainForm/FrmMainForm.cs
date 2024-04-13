using ReservationSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationSystem.Forms.MainForm
{
	public partial class FrmMainForm : Form
	{
		public FrmMainForm()
		{
			InitializeComponent();
		}

		HotelDbEntities db = new HotelDbEntities();

		private void FrmMainForm_Load(object sender, EventArgs e)
		{
			gridControlCustomer.DataSource = (from x in db.Reservations select new
            {
                x.ReservationNameSurname,
                x.People,
                x.Rooms.RoomNo,
                x.Statuses.StatusName
            }).ToList();

			gridControlProduct.DataSource = (from x in db.Products select new
            {
				x.ProductName,
				x.Total,
				x.Units.UnitName,
				x.Statuses.StatusName
			}).ToList();

			// Ürün-Stok Grafiği
			var products = db.Products.ToList();
			foreach (var product in products)
			{
				chartControlProduct.Series["Urun-Stok"]
					.Points.AddPoint(product.ProductName, double.Parse(product.Total.ToString()));		// x,y
			}

			// Oda Doluluk Grafiği
			var statuses = db.ChartRoomStatus();
			foreach (var status in statuses)
			{
				chartControlRoom.Series["Durumlar"]
					.Points.AddPoint(status.StatusName, double.Parse(status.Count.ToString()));		// x,y
			}

			gridControlReservation.DataSource = (from x in db.Reservations select new
            {
				x.ReservationNameSurname,
				x.People,
				x.Rooms.RoomNo,
				x.Statuses.StatusName
			}).Where(x => x.StatusName == "Bugün Gelecekler").ToList();
		}
	}
}
