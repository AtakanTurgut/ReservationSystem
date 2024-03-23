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

namespace ReservationSystem.Forms.Customer
{
    public partial class FrmCustomerList : Form
    {
        public FrmCustomerList()
        {
            InitializeComponent();
        }

        HotelDbEntities db = new HotelDbEntities();

        private void FrmCustomerList_Load(object sender, EventArgs e)
        {
            db.Customers.Load(); /**/

            //gridControl1.DataSource = (from x in db.Customers select new
            bindingSource.DataSource = (from x in db.Customers.Local select new
            {
                x.CustomerId,
                x.NameSurname,
                x.IdentityNumber,
                x.Mail,
                x.Phone,
                x.Rooms.RoomNo,
                x.Countries.CountryName,
                x.Cities.City,
                x.Address,
                x.Statuses.StatusName,
                x.Description
            }).ToList();

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmCustomerCard FrmCustomerCard = new FrmCustomerCard();
            FrmCustomerCard.id = int.Parse(gridView1.GetFocusedRowCellValue("CustomerId").ToString());
            FrmCustomerCard.Show();
        }

        private void musteriyiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource.RemoveCurrent();
            db.SaveChanges();
        }
    }
}
