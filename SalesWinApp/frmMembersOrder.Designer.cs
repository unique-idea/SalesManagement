namespace SalesWinApp
{
    partial class frmMembersOrder
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
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridOrderDetail = new System.Windows.Forms.DataGridView();
            this.dataGridOrder = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(250, 411);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(308, 28);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridOrderDetail
            // 
            this.dataGridOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrderDetail.Location = new System.Drawing.Point(12, 260);
            this.dataGridOrderDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridOrderDetail.Name = "dataGridOrderDetail";
            this.dataGridOrderDetail.ReadOnly = true;
            this.dataGridOrderDetail.RowHeadersWidth = 51;
            this.dataGridOrderDetail.RowTemplate.Height = 29;
            this.dataGridOrderDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridOrderDetail.Size = new System.Drawing.Size(776, 137);
            this.dataGridOrderDetail.TabIndex = 4;
            // 
            // dataGridOrder
            // 
            this.dataGridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrder.Location = new System.Drawing.Point(12, 33);
            this.dataGridOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridOrder.Name = "dataGridOrder";
            this.dataGridOrder.ReadOnly = true;
            this.dataGridOrder.RowHeadersWidth = 51;
            this.dataGridOrder.RowTemplate.Height = 29;
            this.dataGridOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridOrder.Size = new System.Drawing.Size(776, 195);
            this.dataGridOrder.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "OrderList";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "OrderDetailList";
            // 
            // frmMembersOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridOrderDetail);
            this.Controls.Add(this.dataGridOrder);
            this.Name = "frmMembersOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MembersOrder";
            this.Load += new System.EventHandler(this.frmMembersOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClose;
        private DataGridView dataGridOrderDetail;
        private DataGridView dataGridOrder;
        private Label label1;
        private Label label2;
    }
}