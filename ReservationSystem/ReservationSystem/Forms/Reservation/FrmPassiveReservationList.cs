using ReservationSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationSystem.Forms.Reservation
{
    public partial class FrmPassiveReservationList : Form
    {
        public FrmPassiveReservationList()
        {
            InitializeComponent();
        }

        HotelDbEntities db = new HotelDbEntities();

        private void FrmPassiveReservationList_Load(object sender, EventArgs e)
        {
            db.Reservations.Load(); /**/

            //gridControl1.DataSource = (from x in db.Reservations select new
            bindingSource.DataSource = (from x in db.Reservations.Local select new
            {
                x.ReservationId,
                x.Customers.NameSurname,
                x.Rooms.RoomNo,
                x.People,
                x.EntryDate,
                x.LeavingDate,
                x.Phone,
                x.Statuses.StatusName,
            }).Where(y => y.StatusName == "Rezervasyon İptal").ToList();
        }

        private void rezervasyonSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource.RemoveCurrent();
            db.SaveChanges();
        }
    }
}
