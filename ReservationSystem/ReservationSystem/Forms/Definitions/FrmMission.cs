using DevExpress.XtraEditors;
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

namespace ReservationSystem.Forms.Definitions
{
    public partial class FrmMission : Form
    {
        public FrmMission()
        {
            InitializeComponent();
        }

        HotelDbEntities db = new HotelDbEntities();

        private void FrmMission_Load(object sender, EventArgs e)
        {
            db.Missions.Load();
            bindingSource.DataSource = db.Missions.Local;

            repositoryItemLookUpEditDepartment.DataSource = (from x in db.Departments select new
            {
                x.DepartmentId,
                x.DepartmentName
            }).ToList();

            repositoryItemLookUpEditStatus.DataSource = (from x in db.Statuses select new
            {
                x.StatusId,
                x.StatusName
            }).ToList();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Bilgilerde bir hata var. Kontrol ederek tekrar deneyiniz!");
            }
        }

        private void goreviSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource.RemoveCurrent();
            db.SaveChanges();
        }

    }
}
