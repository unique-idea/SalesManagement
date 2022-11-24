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
    public partial class frmMembersControl : Form
    {
        public IMemberRepository MemberRepository { get; set; }
        public MemberObject UserProfile { get; set; }
        public bool InsertOrUpdate { get; set; }
        public frmMembersControl()
        {
            InitializeComponent();
        }

        private void frmAddMembers_Load(object sender, EventArgs e)
        {
            txtMemberID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtMemberID.Text = UserProfile.MemberId.ToString();
                txtEmail.Text = UserProfile.Email;
                txtPassword.Text = UserProfile.Password;
                txtCountry.Text = UserProfile.Country;
                txtCity.Text = UserProfile.City;
                txtCompanyName.Text = UserProfile.CompanyName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new MemberObject()
                {
                    MemberId = int.Parse(txtMemberID.Text.Trim()),
                    Email = txtEmail.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    Country = txtCountry.Text.Trim(),
                    City = txtCity.Text.Trim(),
                    CompanyName = txtCompanyName.Text.Trim(),
                };
                if (InsertOrUpdate == false)
                {
                    if (txtMemberID.Text.Trim().Length != 0 && txtEmail.Text.Trim().Length != 0 && txtPassword.Text.Trim().Length != 0)
                    {
                        MemberRepository.InsertMember(user);
                        MessageBox.Show("Add successfully");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("MemberID, Email and Password must not be empty");
                    }
                }
                else
                {
                    if (txtEmail.Text.Trim().Length != 0 && txtPassword.Text.Trim().Length != 0)
                    {
                        MemberRepository.UpdateMember(user);
                        MessageBox.Show("Update successfully");
                    }
                    else
                    {
                        MessageBox.Show("MemberID, Email and Password must not be empty");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add failed" : "Update falied");
                Close();
            }
        }

        private void btnCLose_Click(object sender, EventArgs e) => Close();

        private void txtMemberID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
