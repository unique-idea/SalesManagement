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
    public partial class frmOrderControl : Form
    {
        public IOrderRepository OrderRepository { get; set; }
        public IOrderDetailRepository OrderDetailRepository { get; set; }

        BindingSource source;
        public OrderObject OrderInfo { get; set; }

        public List<string> ListMemberID { get; set; }

        public List<ProductObject> ListProduct { get; set; }

        public List<OrderDetailObject> ListOrderDetail { get; set; }
        public bool InsertOrUpdate { get; set; }
        public frmOrderControl()
        {
            InitializeComponent();
        }

        private void frmOrderControl_Load(object sender, EventArgs e)
        {
            source = new BindingSource();
            source.DataSource = ListOrderDetail;
            if (InsertOrUpdate)
            {
                txtOrderID.Text = OrderInfo.OrderId.ToString();
                cbMemberID.Text = OrderInfo.MemberId.ToString();               
                txtFreight.Text = OrderInfo.Freight.ToString();
                dtOrderDate.Value = OrderInfo.OrderDate;
                dtRequiredDate.Value = OrderInfo.RequiredDate;
                dtShippedDate.Value = OrderInfo.ShippedDate;
            }
            else
            {
                ListMemberID.ForEach(memberID => cbMemberID.Items.Add(memberID));
                cbMemberID.DropDownStyle = ComboBoxStyle.DropDownList;
                cbMemberID.SelectedIndex = 0;
            }
            dataGridOrderInfo.DataSource = null;
            dataGridOrderInfo.DataSource = source;

            if (ListOrderDetail.Count == 0)
            {
                btnDeleteOrderInfo.Enabled = false;
            }
            else
            {
                btnDeleteOrderInfo.Enabled = true;
            }
            dataGridOrderInfo.CellDoubleClick += dataGridOrderInfo_CellDoubleClick;
        }
        public void UpdateOrderDetails()
        {
            source = new BindingSource();
            source.DataSource = OrderDetailRepository.GetOrdersByOrderID(int.Parse(txtOrderID.Text)).ToList<OrderDetailObject>();

            dataGridOrderInfo.DataSource = null;
            dataGridOrderInfo.DataSource = source;
        }
        private void dataGridOrderInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmOrderDetail frmOrderDetail = new frmOrderDetail()
                {
                    Text = "Update OrderDetails",
                    OrderID = int.Parse(txtOrderID.Text),
                    InsertOrUpdate = true,
                    ProductID = int.Parse(dataGridOrderInfo.CurrentRow.Cells["ProductId"].Value.ToString()),
                    Quantity = int.Parse(dataGridOrderInfo.CurrentRow.Cells["Quantity"].Value.ToString()),
                    Discount = double.Parse(dataGridOrderInfo.CurrentRow.Cells["Discount"].Value.ToString()),
                    OrderDetailRepository = OrderDetailRepository,
                    ListProduct = ListProduct
                };
                if (frmOrderDetail.ShowDialog() == DialogResult.OK)
                {
                    UpdateOrderDetails();
                    source.Position = source.Count - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong");
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
                OrderObject order = new OrderObject()
                {
                    OrderId = int.Parse(txtOrderID.Text.Trim()),
                    MemberId = int.Parse(cbMemberID.SelectedItem != null ? cbMemberID.SelectedItem.ToString() : cbMemberID.Text),
                    OrderDate = dtOrderDate.Value,
                    RequiredDate = dtRequiredDate.Value,
                    ShippedDate = dtShippedDate.Value,
                    Freight = decimal.Parse(txtFreight.Text.Trim()),
                };
                if (InsertOrUpdate == false)
                {
                    if (txtOrderID.Text.Trim().Length != 0 && txtFreight.Text.Trim().Length != 0 && int.Parse(txtOrderID.Text) > 0 && int.Parse(txtFreight.Text) > 0)
                    {
                        OrderRepository.InsertOrder(order);
                        MessageBox.Show("Add new order successfully");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("One of field is empty , OrderID or Freight <0  please check input again");
                    }
                }
                else
                {
                    if (txtFreight.Text.Trim().Length != 0)
                    {
                        OrderRepository.UpdateOrder(order);
                        MessageBox.Show("Update product successfully");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("One of field is empty, please fill all the field");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Adding order failed" : "Updating order failed");
                Close();
            }
        }

        private void btnCreateOrderInfo_Click(object sender, EventArgs e)
        {
            try
            {
                frmOrderDetail frmOrderDetail = new frmOrderDetail()
                {
                    InsertOrUpdate = false,
                    OrderID = int.Parse(txtOrderID.Text),
                    ListProduct = ListProduct,
                    OrderDetailRepository = OrderDetailRepository,
                };
                if (frmOrderDetail.ShowDialog() == DialogResult.OK)
                {
                    UpdateOrderDetails();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order must be existed first then adding order detail");
            }
        }

        private void btnDeleteOrderInfo_Click(object sender, EventArgs e)
        {
            try
            {
                int ProductID = int.Parse(dataGridOrderInfo.CurrentRow.Cells["ProductId"].Value.ToString());
                OrderDetailRepository.DeleteOrderDetail(OrderInfo.OrderId, ProductID);
                MessageBox.Show("Delete order detail successfully");
                UpdateOrderDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Deleting orderDetail failed");
            }
        }
    }
}
