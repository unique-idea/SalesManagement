using BusinessObject;
using DataAccess.Repository;
using Microsoft.Extensions.Configuration;
using System.Windows.Forms;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        public static IConfiguration Configuration;
        public IMemberRepository MemberRepository = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var build = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = build.Build();
            var adminDefaultSettings = Configuration.GetSection("AdminAccount").Get<MemberObject>();
            var adminEmail = adminDefaultSettings.Email;
            var adminPassword = adminDefaultSettings.Password;
            var adminCompanyname = adminDefaultSettings.CompanyName;
            var email = txtEmail.Text;
            var password = txtPassword.Text;

            if (String.IsNullOrEmpty(email))
            {
                MessageBox.Show("Your email is empty or wrong Information and try again!");

            }
            else if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Your password is empty or wrong Information and try again!");
            }
            else
            {
                try
                {
                    if (email.Equals(adminEmail) && password.Equals(adminPassword))
                    {
                        frmMain frmMain = new frmMain();
                        frmMain.adminName = adminCompanyname;
                        this.Hide();
                        frmMain.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MemberObject accountInfo = MemberRepository.Login(email, password);
                        if (accountInfo == null)
                        {
                            MessageBox.Show("Email or password is incorrect or wrong information and try again!");
                        }
                        else
                        {
                            frmMembersInfo frmMember = new frmMembersInfo()
                            {
                                Text = "Profile",
                                InsertOrUpdate = true,
                                UserProfile = accountInfo,
                                MemberRepository = MemberRepository
                            };
                            this.Hide();
                            frmMember.ShowDialog();
                            this.Show();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Something wrong");
                }
            }
        }
        public void ClearText()
        {
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}