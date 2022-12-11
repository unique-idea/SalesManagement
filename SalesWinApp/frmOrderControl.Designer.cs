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
            this.lbFreight.Location = new System.Drawing.Point(34, 147);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(55, 20);
            this.lbFreight.TabIndex = 22;
            this.lbFreight.Text = "Freight";
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(34, 88);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(80, 20);
            this.lbMemberID.TabIndex = 23;
            this.lbMemberID.Text = "MemberID";
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(34, 39);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(62, 20);
            this.lbOrderID.TabIndex = 24;
            this.lbOrderID.Text = "OrderID";
            // 
            // lbShippedDate
            // 
            this.lbShippedDate.AutoSize = true;
            this.lbShippedDate.Location = new System.Drawing.Point(34, 332);
            this.lbShippedDate.Name = "lbShippedDate";
            this.lbShippedDate.Size = new System.Drawing.Size(96, 20);
            this.lbShippedDate.TabIndex = 31;
            this.lbShippedDate.Text = "ShippedDate";
            // 
            // lbRequiredDate
            // 
            this.lbRequiredDate.AutoSize = true;
            this.lbRequiredDate.Location = new System.Drawing.Point(34, 269);
            this.lbRequiredDate.Name = "lbRequiredDate";
            this.lbRequiredDate.Size = new System.Drawing.Size(101, 20);
            this.lbRequiredDate.TabIndex = 32;
            this.lbRequiredDate.Text = "RequiredDate";
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(34, 209);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(79, 20);
            this.lbOrderDate.TabIndex = 33;
            this.lbOrderDate.Text = "OrderDate";
            // 
            // dtShippedDate
            // 
            this.dtShippedDate.Location = new System.Drawing.Point(170, 327);
            this.dtShippedDate.Name = "dtShippedDate";
            this.dtShippedDate.Size = new System.Drawing.Size(252, 27);
            this.dtShippedDate.TabIndex = 28;
            // 
            // dtRequiredDate
            // 
            this.dtRequiredDate.Location = new System.Drawing.Point(170, 264);
            this.dtRequiredDate.Name = "dtRequiredDate";
            this.dtRequiredDate.Size = new System.Drawing.Size(252, 27);
            this.dtRequiredDate.TabIndex = 29;
            // 
            // dtOrderDate
            // 
            this.dtOrderDate.Location = new System.Drawing.Point(170, 204);
            this.dtOrderDate.Name = "dtOrderDate";
            this.dtOrderDate.Size = new System.Drawing.Size(252, 27);
            this.dtOrderDate.TabIndex = 30;
            // 
            // btnCLose
            // 
            this.btnCLose.Location = new System.Drawing.Point(337, 431);
            this.btnCLose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(86, 31);
            this.btnCLose.TabIndex = 35;
            this.btnCLose.Text = "Close";
            this.btnCLose.UseVisualStyleBackColor = true;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(34, 431);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbMemberID
            // 
            this.cbMemberID.FormattingEnabled = true;
            this.cbMemberID.Location = new System.Drawing.Point(170, 83);
            this.cbMemberID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMemberID.Name = "cbMemberID";
            this.cbMemberID.Size = new System.Drawing.Size(252, 28);
            this.cbMemberID.TabIndex = 36;
            // 
            // dataGridOrderInfo
            // 
            this.dataGridOrderInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrderInfo.Location = new System.Drawing.Point(464, 39);
            this.dataGridOrderInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridOrderInfo.Name = "dataGridOrderInfo";
            this.dataGridOrderInfo.RowHeadersWidth = 51;
            this.dataGridOrderInfo.RowTemplate.Height = 25;
            this.dataGridOrderInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridOrderInfo.Size = new System.Drawing.Size(719, 432);
            this.dataGridOrderInfo.TabIndex = 37;
            this.dataGridOrderInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOrderInfo_CellContentClick);
            this.dataGridOrderInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOrderInfo_CellDoubleClick);
            // 
            // btnDeleteOrderInfo
            // 
            this.btnDeleteOrderInfo.Location = new System.Drawing.Point(894, 496);
            this.btnDeleteOrderInfo.Name = "btnDeleteOrderInfo";
            this.btnDeleteOrderInfo.Size = new System.Drawing.Size(139, 36);
            this.btnDeleteOrderInfo.TabIndex = 38;
            this.btnDeleteOrderInfo.Text = "Delete";
            this.btnDeleteOrderInfo.UseVisualStyleBackColor = true;
            this.btnDeleteOrderInfo.Click += new System.EventHandler(this.btnDeleteOrderInfo_Click);
            // 
            // btnCreateOrderInfo
            // 
            this.btnCreateOrderInfo.Location = new System.Drawing.Point(626, 496);
            this.btnCreateOrderInfo.Name = "btnCreateOrderInfo";
            this.btnCreateOrderInfo.Size = new System.Drawing.Size(139, 36);
            this.btnCreateOrderInfo.TabIndex = 39;
            this.btnCreateOrderInfo.Text = "Create";
            this.btnCreateOrderInfo.UseVisualStyleBackColor = true;
            this.btnCreateOrderInfo.Click += new System.EventHandler(this.btnCreateOrderInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(464, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 28);
            this.label1.TabIndex = 40;
            this.label1.Text = "OrderDetails";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(170, 28);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(252, 27);
            this.txtOrderID.TabIndex = 41;
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(170, 141);
            this.txtFreight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(252, 27);
            this.txtFreight.TabIndex = 42;
            // 
            // frmOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 568);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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