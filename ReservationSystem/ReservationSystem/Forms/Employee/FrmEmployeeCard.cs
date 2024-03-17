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

namespace ReservationSystem.Forms.Employee
{
    public partial class FrmEmployeeCard : Form
    {
        public FrmEmployeeCard()
        {
            InitializeComponent();
        }

        HotelDbEntities db = new HotelDbEntities();

        private void FrmEmployeeCard_Load(object sender, EventArgs e)
        {
            lookUpEditDepartment.Properties.DataSource = (from x in db.Departments select new
            {
                x.DepartmentId,
                x.DepartmentName
            }).ToList();

            lookUpEditMission.Properties.DataSource = (from x in db.Missions select new
            {
                x.MissionId,
                x.MissionName
            }).ToList();

            lookUpEditStatus.Properties.DataSource = (from x in db.Statuses select new
            {
                x.StatusId,
                x.StatusName   
            }).ToList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            txtDescription.Text = pictureEditProfile1.GetLoadedImageLocation();
        }
    }
}
