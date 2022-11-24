namespace SalesWinApp
{
    partial class frmMain
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
            this.lbWelcome = new System.Windows.Forms.Label();
            this.btnMembersManagement = new System.Windows.Forms.Button();
            this.btnProductManagement = new System.Windows.Forms.Button();
            this.btnOrderManagement = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbWelcome.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbWelcome.Location = new System.Drawing.Point(224, 40);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(353, 54);
            this.lbWelcome.TabIndex = 0;
            this.lbWelcome.Text = "Welcome to Fstore";
            // 
            // btnMembersManagement
            // 
            this.btnMembersManagement.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMembersManagement.Location = new System.Drawing.Point(50, 234);
            this.btnMembersManagement.Name = "btnMembersManagement";
            this.btnMembersManagement.Size = new System.Drawing.Size(171, 23);
            this.btnMembersManagement.TabIndex = 1;
            this.btnMembersManagement.Text = "Menber Management";
            this.btnMembersManagement.UseVisualStyleBackColor = false;
            this.btnMembersManagement.Click += new System.EventHandler(this.btnMembersManagement_Click);
            // 
            // btnProductManagement
            // 
            this.btnProductManagement.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnProductManagement.Location = new System.Drawing.Point(316, 234);
            this.btnProductManagement.Name = "btnProductManagement";
            this.btnProductManagement.Size = new System.Drawing.Size(171, 23);
            this.btnProductManagement.TabIndex = 2;
            this.btnProductManagement.Text = "Product Management";
            this.btnProductManagement.UseVisualStyleBackColor = false;
            this.btnProductManagement.Click += new System.EventHandler(this.btnProductManagement_Click);
            // 
            // btnOrderManagement
            // 
            this.btnOrderManagement.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnOrderManagement.Location = new System.Drawing.Point(579, 234);
            this.btnOrderManagement.Name = "btnOrderManagement";
            this.btnOrderManagement.Size = new System.Drawing.Size(171, 23);
            this.btnOrderManagement.TabIndex = 3;
            this.btnOrderManagement.Text = "Order Management";
            this.btnOrderManagement.UseVisualStyleBackColor = false;
            this.btnOrderManagement.Click += new System.EventHandler(this.btnOrderManagement_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLogOut.Location = new System.Drawing.Point(361, 304);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(72, 24);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(237, 119);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(47, 37);
            this.lbName.TabIndex = 5;
            this.lbName.Text = ".....";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 364);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnOrderManagement);
            this.Controls.Add(this.btnProductManagement);
            this.Controls.Add(this.btnMembersManagement);
            this.Controls.Add(this.lbWelcome);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbWelcome;
        private Button btnMembersManagement;
        private Button btnProductManagement;
        private Button btnOrderManagement;
        private Button btnLogOut;
        private Label lbName;
    }
}