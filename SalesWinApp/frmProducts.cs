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
    public partial class frmProducts : Form
    {
        public IProductRepository ProductRepository = new ProductRepository();
        BindingSource source;

        public frmProducts()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProductControl addProduct = new frmProductControl()
            {
                InsertOrUpdate = false,
                Text = "Create Product",
                ProductRepository = ProductRepository,
            };
            if (addProduct.ShowDialog() == DialogResult.OK)
            {
                addProduct.Hide();
                loadProducts();
                source.Position = source.Count - 1;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadProducts();
        }
        public void loadProducts()
        {
            try
            {
                var products = ProductRepository.GetProducts();

                source = new BindingSource();
                source.DataSource = products;

                txtProductID.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtCategory.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtUnitsInStock.DataBindings.Clear();

                txtProductID.DataBindings.Add("Text", source, "ProductID");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtCategory.DataBindings.Add("Text", source, "CategoryID");
                txtWeight.DataBindings.Add("Text", source, "Weight");
                txtPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock");

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = source;

                if (products.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loading products failed");
            }
        }

        private void ClearText()
        {
            txtProductID.Text = "";
            txtProductName.Text = "";
            txtCategory.Text = "";
            txtWeight.Text = "";
            txtPrice.Text = "";
            txtUnitsInStock.Text = "";
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {

            btnDelete.Enabled = false;
           dataGridView1.CellDoubleClick += DvgProductList_CellDoubleClick;
        }

        private void DvgProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProductControl addProduct = new frmProductControl()
            {
                Text = "Update Product",
                InsertOrUpdate = true,
                ProductInfo = GetProductObject(),
                ProductRepository = ProductRepository,
            };
            if (addProduct.ShowDialog() == DialogResult.OK)
            {
                addProduct.Hide();
                loadProducts();
                source.Position = source.Count - 1;
            }
        }

        private ProductObject GetProductObject()
        {
            ProductObject product = null;
            try
            {
                product = new ProductObject
                {
                    ProductId = int.Parse(txtProductID.Text),
                    ProductName = txtProductName.Text,
                    CategoryId = int.Parse(txtProductID.Text),
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtPrice.Text),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Getting product failed");
            }
            return product;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var product = GetProductObject();
                DialogResult isDeleted = MessageBox.Show("Do you really want to delete?", "Deleting", MessageBoxButtons.YesNo);
                if (isDeleted == DialogResult.Yes)
                {
                    ProductRepository.DeleteProduct(product.ProductId);
                    MessageBox.Show("Delete product successfully");
                    loadProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Deleting product failed");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {   
            var searchProductIdText = txtSearchKey.Text;
            var serchKey = cboTypeSearch.Text;

            if (searchProductIdText.Trim().Length == 0)
            {
                MessageBox.Show("You can not search with empty value");
            }
            else
            {
                if (serchKey.Equals("ID"))
                {
                    var product = ProductRepository.GetProductByID(int.Parse(searchProductIdText));
                    if (product == null)
                    {
                        MessageBox.Show("This product does not exists");
                    }
                    else
                    {
                        source = new BindingSource();
                        source.DataSource = product;

                        txtProductID.DataBindings.Clear();
                        txtProductName.DataBindings.Clear();
                        txtCategory.DataBindings.Clear();
                        txtWeight.DataBindings.Clear();
                        txtPrice.DataBindings.Clear();
                        txtUnitsInStock.DataBindings.Clear();

                        txtProductID.DataBindings.Add("Text", source, "ProductID");
                        txtProductName.DataBindings.Add("Text", source, "ProductName");
                        txtCategory.DataBindings.Add("Text", source, "CategoryID");
                        txtWeight.DataBindings.Add("Text", source, "Weight");
                        txtPrice.DataBindings.Add("Text", source, "UnitPrice");
                        txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock");

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = source;
                        txtSearchKey.Text = "";
                    }
                }
                else if (serchKey.Equals("Name"))
                {

                    List<ProductObject> products = new List<ProductObject>();
                    products = ProductRepository.GetProducts().ToList<ProductObject>();

                    if (products == null || products.Count == 0)
                    {
                        MessageBox.Show("There is no product to search");
                    }
                    else
                    {
                        List<ProductObject> productsContainName = new List<ProductObject>();
                        products.ForEach(product =>
                        {
                            if (product.ProductName.ToLower().Contains(txtSearchKey.Text.Trim().ToLower()))
                            {
                                productsContainName.Add(product);
                            }
                        });
                        source = new BindingSource();
                        source.DataSource = productsContainName;

                        txtProductID.DataBindings.Clear();
                        txtProductName.DataBindings.Clear();
                        txtCategory.DataBindings.Clear();
                        txtWeight.DataBindings.Clear();
                        txtPrice.DataBindings.Clear();
                        txtUnitsInStock.DataBindings.Clear();

                        txtProductID.DataBindings.Add("Text", source, "ProductID");
                        txtProductName.DataBindings.Add("Text", source, "ProductName");
                        txtCategory.DataBindings.Add("Text", source, "CategoryID");
                        txtWeight.DataBindings.Add("Text", source, "Weight");
                        txtPrice.DataBindings.Add("Text", source, "UnitPrice");
                        txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock");

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = source;
                        txtSearchKey.Text = "";
                    }
                }            
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmProductControl addProduct = new frmProductControl()
            {
                Text = "Update Product",
                InsertOrUpdate = true,
                ProductInfo = GetProductObject(),
                ProductRepository = ProductRepository,
            };
            if (addProduct.ShowDialog() == DialogResult.OK)
            {
                loadProducts();
                source.Position = source.Count - 1;
            }
        }
    }
}
