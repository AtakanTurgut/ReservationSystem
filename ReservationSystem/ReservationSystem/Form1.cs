using ReservationSystem.Forms.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStatusDefinitions_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Definitions.FrmStatus FrmStatus = new Forms.Definitions.FrmStatus();
            FrmStatus.Show();
        }

        private void btnUnitDefinitions_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Definitions.FrmUnit FrmUnit = new Forms.Definitions.FrmUnit();
            FrmUnit.Show();
        }

        private void btnDepartmentDefinitions_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Definitions.FrmDepartment FrmDepartment = new Forms.Definitions.FrmDepartment();
            FrmDepartment.Show();
        }

        private void btnMissionDefinitions_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Definitions.FrmMission FrmMission = new Forms.Definitions.FrmMission();
            FrmMission.Show();
        }

        private void btnCaseDefinitions_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Definitions.FrmCase FrmCase = new Forms.Definitions.FrmCase();
            FrmCase.Show();
        }

        private void btnRateDefinitions_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Definitions.FrmRate FrmRate = new Forms.Definitions.FrmRate();
            FrmRate.Show();
        }

        private void btnRoomDefinitions_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Definitions.FrmRoom FrmRoom = new Forms.Definitions.FrmRoom();
            FrmRoom.Show();
        }

        private void btnPhoneDefinitions_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Definitions.FrmPhone FrmPhone = new Forms.Definitions.FrmPhone();
            FrmPhone.Show();
        }

        private void btnCountryDefinitions_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Definitions.FrmCountry FrmCountry = new Forms.Definitions.FrmCountry();
            FrmCountry.Show();
        }

        private void btnProductCategoryDefinitions_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Definitions.FrmProductCategory FrmProductCategory = new Forms.Definitions.FrmProductCategory();
            FrmProductCategory.Show();
        }

        private void btnNewEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Employee.FrmEmployeeCard FrmEmployeeCard = new Forms.Employee.FrmEmployeeCard();
            FrmEmployeeCard.Show();
        }

        private void btnEmployeeList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Employee.FrmEmployeeList FrmEmployeeList = new Forms.Employee.FrmEmployeeList();
            FrmEmployeeList.MdiParent = this;
            FrmEmployeeList.Show();
        }

        private void btnNewCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Customer.FrmCustomerCard FrmCustomerCard = new Forms.Customer.FrmCustomerCard();
            FrmCustomerCard.Show();
        }

        private void btnCustomerList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Customer.FrmCustomerList FrmCustomerList = new Forms.Customer.FrmCustomerList();
            FrmCustomerList.MdiParent = this;
            FrmCustomerList.Show();
        }

        private void btnProductList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Product.FrmProductList FrmProductList = new Forms.Product.FrmProductList();
            FrmProductList.MdiParent = this;
            FrmProductList.Show();
        }

        private void btnNewProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Product.FrmProductCard FrmProductCard = new Forms.Product.FrmProductCard();
            FrmProductCard.Show();
        }

        private void btnProductInput_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Product.FrmProductInputMovements FrmProductInputMovements = new Forms.Product.FrmProductInputMovements();
            FrmProductInputMovements.MdiParent = this;
            FrmProductInputMovements.Show();
        }

        private void btnProductOutput_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Product.FrmProductOutputMovements FrmProductOutputMovements = new Forms.Product.FrmProductOutputMovements();
            FrmProductOutputMovements.MdiParent = this;
            FrmProductOutputMovements.Show();
        }

        private void btnProductMovement_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Product.FrmProductMovement FrmProductMovement = new Forms.Product.FrmProductMovement();
            FrmProductMovement.Show();
        }

        private void btnNewReservation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Reservation.FrmReservationCard FrmReservationCard = new Forms.Reservation.FrmReservationCard();
            FrmReservationCard.Show();
        }

        private void btnReservationList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Reservation.FrmReservationList FrmReservationList = new Forms.Reservation.FrmReservationList();
            FrmReservationList.MdiParent = this;
            FrmReservationList.Show();
        }

        private void btnActiveReservationList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Reservation.FrmActiveReservationList FrmActiveReservationList = new Forms.Reservation.FrmActiveReservationList();
            FrmActiveReservationList.MdiParent = this;
            FrmActiveReservationList.Show();
        }

        private void btnPassiveReservationList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Reservation.FrmPassiveReservationList FrmPassiveReservationList = new Forms.Reservation.FrmPassiveReservationList();
            FrmPassiveReservationList.MdiParent = this;
            FrmPassiveReservationList.Show();
        }

        private void btnPassedReservationList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Reservation.FrmPassedReservationList FrmPassedReservationList = new Forms.Reservation.FrmPassedReservationList();
            FrmPassedReservationList.MdiParent = this;
            FrmPassedReservationList.Show();
        }

        private void btnFutureReservationList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Reservation.FrmFutureReservationList FrmFutureReservationList = new Forms.Reservation.FrmFutureReservationList();
            FrmFutureReservationList.MdiParent = this;
            FrmFutureReservationList.Show();
        }

        private void btnRate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Tools.FrmRate FrmRate = new Forms.Tools.FrmRate();
            FrmRate.MdiParent = this;
            FrmRate.Show();
        }

        private void btnYouTube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Tools.FrmYouTube FrmYouTube = new Forms.Tools.FrmYouTube();
            FrmYouTube.MdiParent = this;
            FrmYouTube.Show();
        }

        private void btnGoogle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Tools.FrmGoogle FrmGoogle = new Forms.Tools.FrmGoogle();
            FrmGoogle.MdiParent = this;
            FrmGoogle.Show();
        }

        private void btnCalculator_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void btnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }
    }
}
