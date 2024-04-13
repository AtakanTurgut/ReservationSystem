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

            lookUpCustomer2.Properties.DataSource = (from x in db.Customers select new
            {
                x.CustomerId,
                x.NameSurname
            }).ToList();

            lookUpCustomer3.Properties.DataSource = (from x in db.Customers select new
            {
                x.CustomerId,
                x.NameSurname
            }).ToList();

            lookUpCustomer4.Properties.DataSource = (from x in db.Customers select new
            {
                x.CustomerId,
                x.NameSurname
            }).ToList();

			this.Text = id.ToString();

			if (id != 0)
            {
                var reservation = repository.Find(x => x.ReservationId == id);
                lookUpCustomer.EditValue = reservation.CustomerId;
                dateEditStatingDate.Text = reservation.EntryDate.ToString();
                dateEditQuittingDate.Text = reservation.LeavingDate.ToString();
                numericUpPeopleCount.Value = decimal.Parse(reservation.People.ToString());
                txtReservationNameSurname.Text = reservation.ReservationNameSurname;
				txtPhone.Text = reservation.Phone;
				lookUpEditRoom.EditValue = reservation.RoomId;
				lookUpCustomer2.EditValue = reservation.Person2;
                lookUpCustomer3.EditValue = reservation.Person3;
                lookUpCustomer4.EditValue = reservation.Person4;
                txtDescription.Text = reservation.Description;
				lookUpEditStatus.EditValue = reservation.StatusId;
			}

		}

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
			Reservations reservation = new Reservations();

			if (numericUpPeopleCount.Value == 1)
            {
				reservation.CustomerId = int.Parse(lookUpCustomer.EditValue.ToString());
			}

			if (numericUpPeopleCount.Value == 2)
            {
				reservation.CustomerId = int.Parse(lookUpCustomer.EditValue.ToString());
				reservation.Person2 = int.Parse(lookUpCustomer2.EditValue.ToString());
			}

			if (numericUpPeopleCount.Value == 3)
			{
				reservation.CustomerId = int.Parse(lookUpCustomer.EditValue.ToString());
				reservation.Person2 = int.Parse(lookUpCustomer2.EditValue.ToString());
				reservation.Person3 = int.Parse(lookUpCustomer3.EditValue.ToString());
			}

			if (numericUpPeopleCount.Value == 4)
			{
				reservation.CustomerId = int.Parse(lookUpCustomer.EditValue.ToString());
				reservation.Person2 = int.Parse(lookUpCustomer2.EditValue.ToString());
				reservation.Person3 = int.Parse(lookUpCustomer3.EditValue.ToString());
				reservation.Person4 = int.Parse(lookUpCustomer4.EditValue.ToString());
			}

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

		private void lookUpCustomer_EditValueChanged(object sender, EventArgs e)
		{
            int selected;
            selected = int.Parse(lookUpCustomer.EditValue.ToString());

            var phone = db.Customers.Where(x => x.CustomerId == selected).Select(y => y.Phone).FirstOrDefault();
            txtPhone.Text = phone.ToString();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			var value = repository.Find(x => x.ReservationId == id);
			value.CustomerId = int.Parse(lookUpCustomer.EditValue.ToString());
			value.EntryDate = DateTime.Parse(dateEditStatingDate.Text);
			value.LeavingDate = DateTime.Parse(dateEditQuittingDate.Text);
			value.People = numericUpPeopleCount.Value.ToString();
			value.RoomId = int.Parse(lookUpEditRoom.EditValue.ToString());
			value.ReservationNameSurname = txtReservationNameSurname.Text;
			value.Phone = txtPhone.Text;
			value.Description = txtDescription.Text;
			value.StatusId = int.Parse(lookUpEditStatus.EditValue.ToString());

			if (numericUpPeopleCount.Value == 1)
			{
				value.CustomerId = int.Parse(lookUpCustomer.EditValue.ToString());
			}

			if (numericUpPeopleCount.Value == 2)
			{
				value.CustomerId = int.Parse(lookUpCustomer.EditValue.ToString());
				value.Person2 = int.Parse(lookUpCustomer2.EditValue.ToString());
			}

			if (numericUpPeopleCount.Value == 3)
			{
				value.CustomerId = int.Parse(lookUpCustomer.EditValue.ToString());
				value.Person2 = int.Parse(lookUpCustomer2.EditValue.ToString());
				value.Person3 = int.Parse(lookUpCustomer3.EditValue.ToString());
			}

			if (numericUpPeopleCount.Value == 4)
			{
				value.CustomerId = int.Parse(lookUpCustomer.EditValue.ToString());
				value.Person2 = int.Parse(lookUpCustomer2.EditValue.ToString());
				value.Person3 = int.Parse(lookUpCustomer3.EditValue.ToString());
				value.Person4 = int.Parse(lookUpCustomer4.EditValue.ToString());
			}

			repository.TUpdate(value);

			XtraMessageBox.Show("Rezervasyon bilgileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
	}
}
