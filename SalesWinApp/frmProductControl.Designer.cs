namespace SalesWinApp
{
    partial class frmProductControl
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
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtCateID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnCLose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbUnitslnStock = new System.Windows.Forms.Label();
            this.lbCategoryID = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.txtUnitsInStock = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(165, 255);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(283, 27);
            this.txtUnitPrice.TabIndex = 25;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(165, 203);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(283, 27);
            this.txtWeight.TabIndex = 24;
            // 
            // txtCateID
            // 
            this.txtCateID.Location = new System.Drawing.Point(165, 157);
            this.txtCateID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCateID.Name = "txtCateID";
            this.txtCateID.Size = new System.Drawing.Size(283, 27);
            this.txtCateID.TabIndex = 23;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(165, 107);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(283, 27);
            this.txtProductName.TabIndex = 22;
            // 
            // btnCLose
            // 
            this.btnCLose.Location = new System.Drawing.Point(362, 447);
            this.btnCLose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(86, 31);
            this.btnCLose.TabIndex = 21;
            this.btnCLose.Text = "Close";
            this.btnCLose.UseVisualStyleBackColor = true;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(45, 447);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(47, 210);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(56, 20);
            this.lbWeight.TabIndex = 18;
            this.lbWeight.Text = "Weight";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(45, 258);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(68, 20);
            this.lbUnitPrice.TabIndex = 17;
            this.lbUnitPrice.Text = "UnitPrice";
            // 
            // lbUnitslnStock
            // 
            this.lbUnitslnStock.AutoSize = true;
            this.lbUnitslnStock.Location = new System.Drawing.Point(45, 313);
            this.lbUnitslnStock.Name = "lbUnitslnStock";
            this.lbUnitslnStock.Size = new System.Drawing.Size(90, 20);
            this.lbUnitslnStock.TabIndex = 16;
            this.lbUnitslnStock.Text = "UnitslnStock";
            // 
            // lbCategoryID
            // 
            this.lbCategoryID.AutoSize = true;
            this.lbCategoryID.Location = new System.Drawing.Point(47, 160);
            this.lbCategoryID.Name = "lbCategoryID";
            this.lbCategoryID.Size = new System.Drawing.Size(84, 20);
            this.lbCategoryID.TabIndex = 15;
            this.lbCategoryID.Text = "CategoryID";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(45, 110);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(104, 20);
            this.lbProductName.TabIndex = 14;
            this.lbProductName.Text = "Product Name";
            // 
            // txtUnitsInStock
            // 
            this.txtUnitsInStock.Location = new System.Drawing.Point(165, 306);
            this.txtUnitsInStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUnitsInStock.Name = "txtUnitsInStock";
            this.txtUnitsInStock.Size = new System.Drawing.Size(283, 27);
            this.txtUnitsInStock.TabIndex = 26;
            this.txtUnitsInStock.UseSystemPasswordChar = true;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(165, 60);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(283, 27);
            this.txtProductID.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Product ID";
            // 
            // frmProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 539);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.txtUnitsInStock);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtCateID);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.btnCLose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.lbUnitslnStock);
            this.Controls.Add(this.lbCategoryID);
            this.Controls.Add(this.lbProductName);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProductControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Control";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtUnitPrice;
        private TextBox txtWeight;
        private TextBox txtCateID;
        private TextBox txtProductName;
        private Button btnCLose;
        private Button btnSave;
        private Label lbWeight;
        private Label lbUnitPrice;
        private Label lbUnitslnStock;
        private Label lbCategoryID;
        private Label lbProductName;
        private TextBox txtUnitsInStock;
        private TextBox txtProductID;
        private Label label1;
    }
}