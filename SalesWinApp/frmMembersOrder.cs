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
    public partial class frmMembersOrder : Form
    {
        public IOrderRepository OrderRepository = new OrderRepository();
        public IOrderDetailRepository OrderDetailRepository = new OrderDetailRepository();
        BindingSource sourceorder;
        BindingSource sourceorderdetail;
        public int MemberID { get; set; }
        public frmMembersOrder()
        {
            InitializeComponent();
        }

        private void frmMembersOrder_Load(object sender, EventArgs e)
        {
            try
            {
                List<OrderObject> orders = new List<OrderObject>();
                List<OrderDetailObject> orderDetails = new List<OrderDetailObject>();
                orders = OrderRepository.GetOrdersWithUserId(MemberID).ToList<OrderObject>();
                sourceorder = new BindingSource();
                sourceorder.DataSource = orders;
                dataGridOrder.DataSource = null;
                dataGridOrder.DataSource = sourceorder;
                orders.ForEach(order =>
                {
                    var listOrderDetailByOrderID = OrderDetailRepository.GetOrdersByOrderID(order.OrderId);
                    orderDetails.AddRange(listOrderDetailByOrderID);
                });
                sourceorderdetail = new BindingSource();
                sourceorderdetail.DataSource = orderDetails;
                dataGridOrderDetail.DataSource = null;
                dataGridOrderDetail.DataSource = orderDetails;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something wrong");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
