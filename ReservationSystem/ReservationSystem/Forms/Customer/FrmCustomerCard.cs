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

namespace ReservationSystem.Forms.Customer
{
    public partial class FrmCustomerCard : Form
    {
        public FrmCustomerCard()
        {
            InitializeComponent();
        }

        HotelDbEntities db = new HotelDbEntities();
        Repository<Customers> repository = new Repository<Customers>();
        public int id;
        public string defaultFilePath = "C:\\Users\\Excalibur\\Desktop\\ReservationSystem\\pictures\\default_profile.png";

        private void FrmCustomerCard_Load(object sender, EventArgs e)
        {
            this.Text = id.ToString();  

            if (id != 0)
            {
                var customer = repository.Find(x => x.CustomerId == id);
                txtNameSurname.Text = customer.NameSurname;
                txtIdentityNumber.Text = customer.IdentityNumber;
                txtAddress.Text = customer.Address;
                txtMail.Text = customer.Mail;
                txtPhone.Text = customer.Phone;
                txtDescription.Text = customer.Description;
                pictureEditProfile1.Image = Image.FromFile(customer.Photograph1);
                pictureEditProfile2.Image = Image.FromFile(customer.Photograph2);
                lookUpEditRoom.EditValue = customer.RoomId;
                lookUpEditCountry.EditValue = customer.CountryId;
                lookUpEditCity.EditValue = customer.CityId;
                lookUpEditTown.EditValue = customer.TownId;
                lookUpEditStatus.EditValue = customer.StatusId;

                lblFilePathFront.Text = customer.Photograph1;
                lblFilePathBack.Text = customer.Photograph2;
            }

            // Country List
            lookUpEditCountry.Properties.DataSource = (from x in db.Countries select new
            {
                x.CountryId,
                x.CountryName
            }).ToList();

            // Room List
            lookUpEditRoom.Properties.DataSource = (from x in db.Rooms select new
            {
                x.RoomId,
                x.RoomNo
            }).ToList();

            // City List
            lookUpEditCity.Properties.DataSource = (from x in db.Cities select new
            {
                CityId = x.id,
                CityName = x.City
            }).ToList();

            lookUpEditStatus.Properties.DataSource = (from x in db.Statuses select new
            {
                x.StatusId,
                x.StatusName   
            }).ToList();
        }

        private void lookUpEditCity_EditValueChanged(object sender, EventArgs e)
        {
            int selectedCity;
            selectedCity = int.Parse(lookUpEditCity.EditValue.ToString());

            lookUpEditTown.Properties.DataSource = (from x in db.Towns select new
            {
                TownId = x.id,
                TownName = x.Town,
                CityName = x.City
            }).Where(y => y.CityName == selectedCity).ToList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();
            customer.NameSurname = txtNameSurname.Text;
            customer.IdentityNumber = txtIdentityNumber.Text;
            customer.Address = txtAddress.Text;
            customer.Mail = txtMail.Text;
            customer.Phone = txtPhone.Text;
            customer.Description = txtDescription.Text;
            customer.Photograph1 = pictureEditProfile1.GetLoadedImageLocation();
            customer.Photograph2 = pictureEditProfile2.GetLoadedImageLocation();
            customer.RoomId = int.Parse(lookUpEditRoom.EditValue.ToString());
            customer.CountryId = int.Parse(lookUpEditCountry.EditValue.ToString());
            customer.CityId = int.Parse(lookUpEditCity.EditValue.ToString());
            customer.TownId = int.Parse(lookUpEditTown.EditValue.ToString());
            customer.StatusId = int.Parse(lookUpEditStatus.EditValue.ToString());

            if (string.IsNullOrEmpty(customer.Photograph1))
            {
                customer.Photograph1 = defaultFilePath;
            }

            if (string.IsNullOrEmpty(customer.Photograph2))
            {
                customer.Photograph2 = defaultFilePath;
            }

            repository.TAdd(customer);

            XtraMessageBox.Show("Müşteri başarılı bir şekilde sisteme kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var value = repository.Find(x => x.CustomerId == id);

            if (pictureEditProfile1.EditValue == null)
            {
                lblFilePathFront.Text = value.Photograph1;
            }

            if (pictureEditProfile2.EditValue == null)
            {
                lblFilePathBack.Text = value.Photograph2;
            }

            value.NameSurname = txtNameSurname.Text;
            value.IdentityNumber = txtIdentityNumber.Text;
            value.Address = txtAddress.Text;
            value.Mail = txtMail.Text;
            value.Phone = txtPhone.Text;
            value.Description = txtDescription.Text;
            value.Photograph1 = lblFilePathFront.Text;
            value.Photograph2 = lblFilePathBack.Text;
            value.RoomId = int.Parse(lookUpEditRoom.EditValue.ToString());
            value.CountryId = int.Parse(lookUpEditCountry.EditValue.ToString());
            value.CityId = int.Parse(lookUpEditCity.EditValue.ToString());
            value.TownId = int.Parse(lookUpEditTown.EditValue.ToString());
            value.StatusId = int.Parse(lookUpEditStatus.EditValue.ToString());

            repository.TUpdate(value);

            XtraMessageBox.Show("Müşteri kartı bilgileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void pictureEditProfile1_EditValueChanged(object sender, EventArgs e)
        {
            lblFilePathFront.Text = pictureEditProfile1.GetLoadedImageLocation().ToString();
        }

        private void pictureEditProfile2_EditValueChanged(object sender, EventArgs e)
        {
            lblFilePathBack.Text = pictureEditProfile2.GetLoadedImageLocation().ToString();
        }

    }
}
