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
    public partial class FrmProductMovement : Form
    {
        public FrmProductMovement()
        {
            InitializeComponent();
        }

        HotelDbEntities db = new HotelDbEntities();
        Repository<ProductMovements> repository = new Repository<ProductMovements>();
        public int id;

        private void FrmProductMovement_Load(object sender, EventArgs e)
        {
            txtProductId.Text = id.ToString();
            txtProductId.Enabled = false;

            if (id != 0)
            {
                var product = repository.Find(x => x.MovementId == id);
                lookUpEditProduct.EditValue = product.ProductId;
                txtAmount.Text = product.Amount.ToString();
                txtDescription.Text = product.Description;
                cmbMovementType.Text = product.MovementType;
                dateMovement.Text = product.Date.ToString();
            }

            lookUpEditProduct.Properties.DataSource = (from x in db.Products select new
            {
                x.ProductId,
                x.ProductName   
            }).ToList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ProductMovements movement = new ProductMovements();
            movement.ProductId = int.Parse(lookUpEditProduct.EditValue.ToString());
            movement.Date = DateTime.Parse(dateMovement.Text);
            movement.MovementType = cmbMovementType.Text;
            movement.Amount = decimal.Parse(txtAmount.Text);
            movement.Description = txtDescription.Text;
            
            repository.TAdd(movement);

            XtraMessageBox.Show("Ürün Hareketi sisteme kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var value = repository.Find(x => x.MovementId == id);
            value.ProductId = int.Parse(lookUpEditProduct.EditValue.ToString());
            value.Date = DateTime.Parse(dateMovement.Text);
            value.MovementType = cmbMovementType.Text;
            value.Amount = decimal.Parse(txtAmount.Text);
            value.Description = txtDescription.Text;

            repository.TUpdate(value);

            XtraMessageBox.Show("Ürün Hareketi başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
