using ReservationSystem.Entities;
using ReservationSystem.Forms.Customer;
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
    public partial class FrmProductList : Form
    {
        public FrmProductList()
        {
            InitializeComponent();
        }

        HotelDbEntities db = new HotelDbEntities();

        private void FrmProductList_Load(object sender, EventArgs e)
        {
            db.Products.Load(); /**/

            //gridControl1.DataSource = (from x in db.Products select new
            bindingSource.DataSource = (from x in db.Products.Local select new
            {
                x.ProductId,
                x.ProductCategories.ProductCategory,
                x.ProductName,
                x.Price,
                x.Units.UnitName
            }).ToList();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmProductCard FrmProductCard = new FrmProductCard();
            FrmProductCard.id = int.Parse(gridView1.GetFocusedRowCellValue("ProductId").ToString());
            FrmProductCard.Show();
        }

        private void urunuSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource.RemoveCurrent();
            db.SaveChanges();
        }
    }
}
