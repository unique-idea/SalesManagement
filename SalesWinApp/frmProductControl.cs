using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmProductControl : Form
    {
        public IProductRepository ProductRepository { get; set; }

        public bool InsertOrUpdate { get; set; }

        public ProductObject ProductInfo { get; set; }
        public frmProductControl()
        {
            InitializeComponent();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            txtProductID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate)
            {
                txtProductID.Text = ProductInfo.ProductId.ToString();
                txtProductName.Text = ProductInfo.ProductName;
                txtCateID.Text = ProductInfo.CategoryId.ToString();
                txtWeight.Text = ProductInfo.Weight;
                txtUnitPrice.Text = ProductInfo.UnitPrice.ToString();
                txtUnitsInStock.Text = ProductInfo.UnitsInStock.ToString();
            }
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new ProductObject()
                {
                    ProductId = int.Parse(txtProductID.Text.Trim()),
                    ProductName = txtProductName.Text.Trim(),
                    CategoryId = int.Parse(txtCateID.Text.Trim()),
                    Weight = txtWeight.Text.Trim(),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text.Trim()),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text.Trim())
                };
                if (InsertOrUpdate == false)
                {
                    if (txtProductID.Text.Trim().Length != 0 && txtProductName.Text.Trim().Length != 0 && txtCateID.Text.Trim().Length != 0 && txtUnitPrice.Text.Trim().Length != 0 && txtUnitsInStock.Text.Trim().Length != 0)
                    {
                        ProductRepository.InsertProduct(product);
                        MessageBox.Show("Add new product successfully");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("One of field is empty, please fill all the field");
                    }
                }
                else
                {
                    if (txtProductName.Text.Trim().Length != 0 && txtCateID.Text.Trim().Length != 0 && txtUnitPrice.Text.Trim().Length != 0 && txtUnitsInStock.Text.Trim().Length != 0)
                    {
                        ProductRepository.UpdateProduct(product);
                        MessageBox.Show("Update product successfully");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("One of field is empty, please fill all the field");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Adding product failed" : "Updating product failed");
                Close();
            }
        }
    }
}
