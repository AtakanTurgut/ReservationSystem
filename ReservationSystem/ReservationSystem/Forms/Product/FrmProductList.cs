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
            gridControl1.DataSource = (from x in db.Products select new
            {
                x.ProductId,
                x.ProductCategories.ProductCategory,
                x.ProductName,
                x.Price,
                x.Units.UnitName
            }).ToList();
        }
    }
}
