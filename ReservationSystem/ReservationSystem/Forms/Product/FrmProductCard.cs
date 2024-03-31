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
        public int id;

        private void FrmProductCard_Load(object sender, EventArgs e)
        {
            this.Text = id.ToString();

            if (id != 0)
            { 
                var product = repository.Find(x => x.ProductId == id);
                txtProductName.Text = product.ProductName;
                lookUpEditCategory.EditValue = product.ProductCategoryId;
                lookUpEditUnit.EditValue = product.UnitId;
                lookUpEditStatus.EditValue = product.StatusId;
                txtProductPrice.Text = product.Price.ToString();
                txtProductTotal.Text = product.Total.ToString();
                txtProductKdv.Text = product.Kdv.ToString();
            }

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
            product.Total = decimal.Parse(txtProductTotal.Text);
            product.Kdv = byte.Parse(txtProductKdv.Text);

            repository.TAdd(product);

            XtraMessageBox.Show("Ürün başarılı bir şekilde sisteme kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var value = repository.Find(x => x.ProductId == id);
            value.ProductName = txtProductName.Text;
            value.ProductCategoryId = int.Parse(lookUpEditCategory.EditValue.ToString());
            value.UnitId = int.Parse(lookUpEditUnit.EditValue.ToString());
            value.StatusId = int.Parse(lookUpEditStatus.EditValue.ToString());
            value.Price = decimal.Parse(txtProductPrice.Text);
            value.Total = decimal.Parse(txtProductTotal.Text);
            value.Kdv = byte.Parse(txtProductKdv.Text);

            repository.TUpdate(value);

            XtraMessageBox.Show("Ürün kartı bilgileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
