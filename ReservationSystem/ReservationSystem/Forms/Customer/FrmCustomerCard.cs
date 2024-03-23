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

namespace ReservationSystem.Forms.Customer
{
    public partial class FrmCustomerCard : Form
    {
        public FrmCustomerCard()
        {
            InitializeComponent();
        }

        HotelDbEntities db = new HotelDbEntities();

        private void FrmCustomerCard_Load(object sender, EventArgs e)
        {
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
    }
}
