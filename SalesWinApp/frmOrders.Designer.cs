namespace SalesWinApp
{
    partial class frmOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lbFreight = new System.Windows.Forms.Label();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.lbShippedDate = new System.Windows.Forms.Label();
            this.lbRequiredDate = new System.Windows.Forms.Label();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.dtShippedDate = new System.Windows.Forms.DateTimePicker();
            this.dtRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.dtOrderDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(31, 240);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowTemplate.Height = 25;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(744, 169);
            this.dgvOrder.TabIndex = 0;
            this.dgvOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellDoubleClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(31, 187);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(365, 187);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(701, 187);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(336, 142);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(133, 24);
            this.btnLoad.TabIndex = 22;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(109, 105);
            this.txtFreight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.ReadOnly = true;
            this.txtFreight.Size = new System.Drawing.Size(168, 23);
            this.txtFreight.TabIndex = 19;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(109, 62);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.ReadOnly = true;
            this.txtMemberID.Size = new System.Drawing.Size(168, 23);
            this.txtMemberID.TabIndex = 20;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(109, 21);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(168, 23);
            this.txtOrderID.TabIndex = 21;
            // 
            // lbFreight
            // 
            this.lbFreight.AutoSize = true;
            this.lbFreight.Location = new System.Drawing.Point(31, 108);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(44, 15);
            this.lbFreight.TabIndex = 13;
            this.lbFreight.Text = "Freight";
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(31, 64);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(63, 15);
            this.lbMemberID.TabIndex = 14;
            this.lbMemberID.Text = "MemberID";
            // 
            // lbShippedDate
            // 
            this.lbShippedDate.AutoSize = true;
            this.lbShippedDate.Location = new System.Drawing.Point(444, 108);
            this.lbShippedDate.Name = "lbShippedDate";
            this.lbShippedDate.Size = new System.Drawing.Size(74, 15);
            this.lbShippedDate.TabIndex = 15;
            this.lbShippedDate.Text = "ShippedDate";
            // 
            // lbRequiredDate
            // 
            this.lbRequiredDate.AutoSize = true;
            this.lbRequiredDate.Location = new System.Drawing.Point(444, 64);
            this.lbRequiredDate.Name = "lbRequiredDate";
            this.lbRequiredDate.Size = new System.Drawing.Size(78, 15);
            this.lbRequiredDate.TabIndex = 16;
            this.lbRequiredDate.Text = "RequiredDate";
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(444, 23);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(61, 15);
            this.lbOrderDate.TabIndex = 17;
            this.lbOrderDate.Text = "OrderDate";
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(31, 23);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(48, 15);
            this.lbOrderID.TabIndex = 18;
            this.lbOrderID.Text = "OrderID";
            // 
            // dtShippedDate
            // 
            this.dtShippedDate.Location = new System.Drawing.Point(554, 108);
            this.dtShippedDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtShippedDate.Name = "dtShippedDate";
            this.dtShippedDate.Size = new System.Drawing.Size(221, 23);
            this.dtShippedDate.TabIndex = 10;
            // 
            // dtRequiredDate
            // 
            this.dtRequiredDate.Location = new System.Drawing.Point(554, 65);
            this.dtRequiredDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtRequiredDate.Name = "dtRequiredDate";
            this.dtRequiredDate.Size = new System.Drawing.Size(221, 23);
            this.dtRequiredDate.TabIndex = 11;
            // 
            // dtOrderDate
            // 
            this.dtOrderDate.Location = new System.Drawing.Point(554, 23);
            this.dtOrderDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtOrderDate.Name = "dtOrderDate";
            this.dtOrderDate.Size = new System.Drawing.Size(221, 23);
            this.dtOrderDate.TabIndex = 12;
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 433);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lbFreight);
            this.Controls.Add(this.lbMemberID);
            this.Controls.Add(this.lbShippedDate);
            this.Controls.Add(this.lbRequiredDate);
            this.Controls.Add(this.lbOrderDate);
            this.Controls.Add(this.lbOrderID);
            this.Controls.Add(this.dtShippedDate);
            this.Controls.Add(this.dtRequiredDate);
            this.Controls.Add(this.dtOrderDate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvOrder);
            this.Name = "frmOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.frmOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvOrder;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnClose;
        private Button btnLoad;
        private TextBox txtFreight;
        private TextBox txtMemberID;
        private TextBox txtOrderID;
        private Label lbFreight;
        private Label lbMemberID;
        private Label lbShippedDate;
        private Label lbRequiredDate;
        private Label lbOrderDate;
        private Label lbOrderID;
        private DateTimePicker dtShippedDate;
        private DateTimePicker dtRequiredDate;
        private DateTimePicker dtOrderDate;
    }
}