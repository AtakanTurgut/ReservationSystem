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

namespace ReservationSystem.Forms.Employee
{
    public partial class FrmEmployeeCard : Form
    {
        public FrmEmployeeCard()
        {
            InitializeComponent();
        }

        HotelDbEntities db = new HotelDbEntities();
        Repository<Employees> repository = new Repository<Employees>();
        public int id;

        private void FrmEmployeeCard_Load(object sender, EventArgs e)
        {
            this.Text = id.ToString();

            if (id != 0)
            {
                var employee = repository.Find(x => x.EmployeeId == id);
                txtNameSurname.Text = employee.NameSurname;
                txtIdentityNumber.Text = employee.IdentityNumber;
                txtAddress.Text = employee.Address;
                txtMail.Text = employee.Mail;
                txtPhone.Text = employee.Phone;
                dateEditStatingDate.Text = employee.StartingDate.ToString();
                dateEditQuittingDate.Text = employee.QuittingDate.ToString();
                txtDescription.Text = employee.Description;
                pictureEditProfile1.Image = Image.FromFile(employee.ProfileFront);
                pictureEditProfile2.Image = Image.FromFile(employee.ProfileBack);
                /*
            employee.DepartmentId = int.Parse(lookUpEditDepartment.EditValue.ToString());
            employee.MissionId = int.Parse(lookUpEditMission.EditValue.ToString());
            employee.StatusId = int.Parse(lookUpEditStatus.EditValue.ToString());*/
            }

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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Employees employee = new Employees();
            employee.NameSurname = txtNameSurname.Text;
            employee.IdentityNumber = txtIdentityNumber.Text;
            employee.Address = txtAddress.Text;
            employee.Mail = txtMail.Text;
            employee.Phone = txtPhone.Text;
            employee.StartingDate = DateTime.Parse(dateEditStatingDate.Text);
            employee.Description = txtDescription.Text;
            employee.ProfileFront = pictureEditProfile1.GetLoadedImageLocation();
            employee.ProfileBack = pictureEditProfile2.GetLoadedImageLocation();
            employee.DepartmentId = int.Parse(lookUpEditDepartment.EditValue.ToString());
            employee.MissionId = int.Parse(lookUpEditMission.EditValue.ToString());
            employee.StatusId = int.Parse(lookUpEditStatus.EditValue.ToString());

            repository.TAdd(employee);

            XtraMessageBox.Show("Personel başarılı bir şekilde sisteme kaydedildi.");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var value = repository.Find(x => x.EmployeeId == id);
            value.NameSurname = txtNameSurname.Text;
            value.IdentityNumber = txtIdentityNumber.Text;
            value.Address = txtAddress.Text;
            value.Mail = txtMail.Text;
            value.Phone = txtPhone.Text;
            value.StartingDate = DateTime.Parse(dateEditStatingDate.Text);
            value.Description = txtDescription.Text;
            value.ProfileFront = pictureEditProfile1.GetLoadedImageLocation();
            value.ProfileBack = pictureEditProfile2.GetLoadedImageLocation();
            /*
value.DepartmentId = int.Parse(lookUpEditDepartment.EditValue.ToString());
value.MissionId = int.Parse(lookUpEditMission.EditValue.ToString());
value.StatusId = int.Parse(lookUpEditStatus.EditValue.ToString());
*/
            repository.TUpdate(value);

            XtraMessageBox.Show("Personel kartı bilgileri başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
