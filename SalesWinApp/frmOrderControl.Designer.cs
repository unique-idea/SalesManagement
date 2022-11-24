namespace SalesWinApp
{
    partial class frmOrderControl
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
            this.lbFreight = new System.Windows.Forms.Label();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.lbShippedDate = new System.Windows.Forms.Label();
            this.lbRequiredDate = new System.Windows.Forms.Label();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.dtShippedDate = new System.Windows.Forms.DateTimePicker();
            this.dtRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.dtOrderDate = new System.Windows.Forms.DateTimePicker();
            this.btnCLose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbMemberID = new System.Windows.Forms.ComboBox();
            this.dataGridOrderInfo = new System.Windows.Forms.DataGridView();
            this.btnDeleteOrderInfo = new System.Windows.Forms.Button();
            this.btnCreateOrderInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtFreight = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFreight
            // 
            this.lbFreight.AutoSize = true;
            this.lbFreight.Location = new System.Drawing.Point(30, 110);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(44, 15);
            this.lbFreight.TabIndex = 22;
            this.lbFreight.Text = "Freight";
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(30, 66);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(63, 15);
            this.lbMemberID.TabIndex = 23;
            this.lbMemberID.Text = "MemberID";
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(30, 29);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(48, 15);
            this.lbOrderID.TabIndex = 24;
            this.lbOrderID.Text = "OrderID";
            // 
            // lbShippedDate
            // 
            this.lbShippedDate.AutoSize = true;
            this.lbShippedDate.Location = new System.Drawing.Point(30, 249);
            this.lbShippedDate.Name = "lbShippedDate";
            this.lbShippedDate.Size = new System.Drawing.Size(74, 15);
            this.lbShippedDate.TabIndex = 31;
            this.lbShippedDate.Text = "ShippedDate";
            // 
            // lbRequiredDate
            // 
            this.lbRequiredDate.AutoSize = true;
            this.lbRequiredDate.Location = new System.Drawing.Point(30, 202);
            this.lbRequiredDate.Name = "lbRequiredDate";
            this.lbRequiredDate.Size = new System.Drawing.Size(78, 15);
            this.lbRequiredDate.TabIndex = 32;
            this.lbRequiredDate.Text = "RequiredDate";
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(30, 157);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(61, 15);
            this.lbOrderDate.TabIndex = 33;
            this.lbOrderDate.Text = "OrderDate";
            // 
            // dtShippedDate
            // 
            this.dtShippedDate.Location = new System.Drawing.Point(149, 245);
            this.dtShippedDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtShippedDate.Name = "dtShippedDate";
            this.dtShippedDate.Size = new System.Drawing.Size(221, 23);
            this.dtShippedDate.TabIndex = 28;
            // 
            // dtRequiredDate
            // 
            this.dtRequiredDate.Location = new System.Drawing.Point(149, 198);
            this.dtRequiredDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtRequiredDate.Name = "dtRequiredDate";
            this.dtRequiredDate.Size = new System.Drawing.Size(221, 23);
            this.dtRequiredDate.TabIndex = 29;
            // 
            // dtOrderDate
            // 
            this.dtOrderDate.Location = new System.Drawing.Point(149, 153);
            this.dtOrderDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtOrderDate.Name = "dtOrderDate";
            this.dtOrderDate.Size = new System.Drawing.Size(221, 23);
            this.dtOrderDate.TabIndex = 30;
            // 
            // btnCLose
            // 
            this.btnCLose.Location = new System.Drawing.Point(295, 323);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(75, 23);
            this.btnCLose.TabIndex = 35;
            this.btnCLose.Text = "Close";
            this.btnCLose.UseVisualStyleBackColor = true;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(30, 323);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbMemberID
            // 
            this.cbMemberID.FormattingEnabled = true;
            this.cbMemberID.Location = new System.Drawing.Point(149, 62);
            this.cbMemberID.Name = "cbMemberID";
            this.cbMemberID.Size = new System.Drawing.Size(221, 23);
            this.cbMemberID.TabIndex = 36;
            // 
            // dataGridOrderInfo
            // 
            this.dataGridOrderInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrderInfo.Location = new System.Drawing.Point(406, 29);
            this.dataGridOrderInfo.Name = "dataGridOrderInfo";
            this.dataGridOrderInfo.RowTemplate.Height = 25;
            this.dataGridOrderInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridOrderInfo.Size = new System.Drawing.Size(629, 324);
            this.dataGridOrderInfo.TabIndex = 37;
            this.dataGridOrderInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOrderInfo_CellDoubleClick);
            // 
            // btnDeleteOrderInfo
            // 
            this.btnDeleteOrderInfo.Location = new System.Drawing.Point(782, 372);
            this.btnDeleteOrderInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteOrderInfo.Name = "btnDeleteOrderInfo";
            this.btnDeleteOrderInfo.Size = new System.Drawing.Size(122, 27);
            this.btnDeleteOrderInfo.TabIndex = 38;
            this.btnDeleteOrderInfo.Text = "Delete";
            this.btnDeleteOrderInfo.UseVisualStyleBackColor = true;
            this.btnDeleteOrderInfo.Click += new System.EventHandler(this.btnDeleteOrderInfo_Click);
            // 
            // btnCreateOrderInfo
            // 
            this.btnCreateOrderInfo.Location = new System.Drawing.Point(548, 372);
            this.btnCreateOrderInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateOrderInfo.Name = "btnCreateOrderInfo";
            this.btnCreateOrderInfo.Size = new System.Drawing.Size(122, 27);
            this.btnCreateOrderInfo.TabIndex = 39;
            this.btnCreateOrderInfo.Text = "Create";
            this.btnCreateOrderInfo.UseVisualStyleBackColor = true;
            this.btnCreateOrderInfo.Click += new System.EventHandler(this.btnCreateOrderInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(406, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "OrderDetails";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(149, 21);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(221, 23);
            this.txtOrderID.TabIndex = 41;
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(149, 106);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(221, 23);
            this.txtFreight.TabIndex = 42;
            // 
            // frmOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 426);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteOrderInfo);
            this.Controls.Add(this.btnCreateOrderInfo);
            this.Controls.Add(this.dataGridOrderInfo);
            this.Controls.Add(this.cbMemberID);
            this.Controls.Add(this.btnCLose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbShippedDate);
            this.Controls.Add(this.lbRequiredDate);
            this.Controls.Add(this.lbOrderDate);
            this.Controls.Add(this.dtShippedDate);
            this.Controls.Add(this.dtRequiredDate);
            this.Controls.Add(this.dtOrderDate);
            this.Controls.Add(this.lbFreight);
            this.Controls.Add(this.lbMemberID);
            this.Controls.Add(this.lbOrderID);
            this.Name = "frmOrderControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderControl";
            this.Load += new System.EventHandler(this.frmOrderControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbFreight;
        private Label lbMemberID;
        private Label lbOrderID;
        private Label lbShippedDate;
        private Label lbRequiredDate;
        private Label lbOrderDate;
        private DateTimePicker dtShippedDate;
        private DateTimePicker dtRequiredDate;
        private DateTimePicker dtOrderDate;
        private Button btnCLose;
        private Button btnSave;
        private ComboBox cbMemberID;
        private DataGridView dataGridOrderInfo;
        private Button btnDeleteOrderInfo;
        private Button btnCreateOrderInfo;
        private Label label1;
        private TextBox txtOrderID;
        private TextBox txtFreight;
    }
}