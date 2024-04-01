using DevExpress.XtraEditors;
using ReservationSystem.Entities;
using ReservationSystem.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationSystem.Forms.Reservation
{
    public partial class FrmReservationCard : Form
    {
        public FrmReservationCard()
        {
            InitializeComponent();
        }

        HotelDbEntities db = new HotelDbEntities();
        Repository<Reservations> repository = new Repository<Reservations>();
        public int id;

        private void FrmReservationCard_Load(object sender, EventArgs e)
        {
            lookUpCustomer.Properties.DataSource = (from x in db.Customers select new
            {
                x.CustomerId,
                x.NameSurname
            }).ToList();

            lookUpEditRoom.Properties.DataSource = (from x in db.Rooms select new
            {
                x.RoomId,
                x.RoomNo,
                x.Statuses.StatusName
            }).Where(y => y.StatusName == "Aktif").ToList();

            lookUpEditStatus.Properties.DataSource = (from x in db.Statuses select new
            {
                x.StatusId,
                x.StatusName
            }).ToList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Reservations reservation = new Reservations();
            reservation.CustomerId = int.Parse(lookUpCustomer.EditValue.ToString());
            reservation.EntryDate = DateTime.Parse(dateEditStatingDate.Text);
            reservation.LeavingDate = DateTime.Parse(dateEditQuittingDate.Text);
            reservation.People = numericUpPeopleCount.Value.ToString();
            reservation.RoomId = int.Parse(lookUpEditRoom.EditValue.ToString());
            reservation.ReservationNameSurname = txtReservationNameSurname.Text;
            reservation.Phone = txtPhone.Text;
            reservation.Description = txtDescription.Text;
            reservation.StatusId = int.Parse(lookUpEditStatus.EditValue.ToString());

            repository.TAdd(reservation);

            XtraMessageBox.Show("Rezervasyon başarılı bir şekilde sisteme kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
