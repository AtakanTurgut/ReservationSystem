﻿using ReservationSystem.Entities;
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

namespace ReservationSystem.Forms.Product
{
    public partial class FrmProductOutputMovements : Form
    {
        public FrmProductOutputMovements()
        {
            InitializeComponent();
        }

        HotelDbEntities db = new HotelDbEntities();

        private void FrmProductOutputMovements_Load(object sender, EventArgs e)
        {
            db.ProductMovements.Load(); /**/

            //gridControl1.DataSource = (from x in db.ProductMovements select new
            bindingSource.DataSource = (from x in db.ProductMovements.Local select new
            {
                x.MovementId,
                x.Products.ProductName,
                x.Amount,
                x.Date,
                x.MovementType
            }).Where(y => y.MovementType == "Çıkış").ToList();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmProductMovement FrmProductMovement = new FrmProductMovement();
            FrmProductMovement.id = int.Parse(gridView1.GetFocusedRowCellValue("MovementId").ToString());
            FrmProductMovement.Show();
        }

        private void urunCıkısıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource.RemoveCurrent();
            db.SaveChanges();
        }
    }
}
