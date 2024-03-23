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

namespace ReservationSystem.Forms.Employee
{
    public partial class FrmEmployeeList : Form
    {
        public FrmEmployeeList()
        {
            InitializeComponent();
        }

        HotelDbEntities db = new HotelDbEntities();

        private void FrmEmployeeList_Load(object sender, EventArgs e)
        {
            db.Employees.Load(); /**/

            //gridControl1.DataSource = (from x in db.Employees select new
            bindingSource.DataSource = (from x in db.Employees.Local select new
            {
                x.EmployeeId,
                x.NameSurname,
                x.IdentityNumber,
                x.Mail,
                x.Phone,
                x.Departments.DepartmentName,
                x.Missions.MissionName,
                x.Statuses.StatusName
            }).ToList();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmEmployeeCard FrmEmployeeCard = new FrmEmployeeCard();
            FrmEmployeeCard.id = int.Parse(gridView1.GetFocusedRowCellValue("EmployeeId").ToString());
            FrmEmployeeCard.Show();
        }

        private void personeliSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource.RemoveCurrent();
            db.SaveChanges();
        }

        private void personeliSilToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            bindingSource.RemoveCurrent();
            db.SaveChanges();
        }
    }
}
