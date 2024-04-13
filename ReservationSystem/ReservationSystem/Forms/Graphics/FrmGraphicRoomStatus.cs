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

namespace ReservationSystem.Forms.Graphics
{
	public partial class FrmGraphicRoomStatus : Form
	{
		public FrmGraphicRoomStatus()
		{
			InitializeComponent();
		}

		HotelDbEntities db = new HotelDbEntities();

		private void FrmGraphicRoomStatus_Load(object sender, EventArgs e)
		{
			gridControl1.DataSource = db.ChartRoomStatus();

			// Oda Doluluk Grafiği
			var statuses = db.ChartRoomStatus();
			foreach (var status in statuses)
			{
				chartControlRoom.Series["Durumlar"]
					.Points.AddPoint(status.StatusName, double.Parse(status.Count.ToString()));     // x,y
			}
		}
	}
}
