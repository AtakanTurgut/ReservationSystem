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

namespace ReservationSystem.Forms.Product
{
    public partial class FrmProductCard : Form
    {
        public FrmProductCard()
        {
            InitializeComponent();
        }

        HotelDbEntities db = new HotelDbEntities();
        Repository<Products> repository = new Repository<Products>();
 
        private void FrmProductCard_Load(object sender, EventArgs e)
        {
            lookUpEditUnit.Properties.DataSource = (from x in db.Units select new
            {
                x.UnitId,
                x.UnitName   
            }).ToList();

            lookUpEditCategory.Properties.DataSource = (from x in db.ProductCategories select new
            {
                x.ProductCategoryId,
                x.ProductCategory   
            }).ToList();

            lookUpEditStatus.Properties.DataSource = (from x in db.Statuses select new
            {
                x.StatusId,
                x.StatusName   
            }).ToList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Products product = new Products();
            product.ProductName = txtProductName.Text;
            product.ProductCategoryId = int.Parse(lookUpEditCategory.EditValue.ToString());
            product.UnitId = int.Parse(lookUpEditUnit.EditValue.ToString());
            product.StatusId = int.Parse(lookUpEditStatus.EditValue.ToString());
            product.Price = decimal.Parse(txtProductPrice.Text);
            product.Total = int.Parse(txtProductTotal.Text);
            product.Kdv = byte.Parse(txtProductKdv.Text);

            repository.TAdd(product);
            XtraMessageBox.Show("Ürün başarılı bir şekilde sisteme kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
