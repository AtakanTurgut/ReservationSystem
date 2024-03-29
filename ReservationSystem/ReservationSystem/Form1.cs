﻿using System;
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
    }
}
