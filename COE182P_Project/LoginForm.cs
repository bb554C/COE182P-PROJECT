using COE182P_Project.Classes;
using StoreManagementSystem.Source_Code.Classes;
using System;
using System.Windows.Forms;

namespace COE182P_Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Automated Reporting System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                e.Cancel = true;
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUsername.Text != "")
            {
                labelUsername.Visible = false;
            }
            else
                labelUsername.Visible = true;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != "")
            {
                labelPassword.Visible = false;
            }
            else
                labelPassword.Visible = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            if (username == UserAccountClass.GetUserName(username)
                && Encryption.ComputeSha256Hash(textBoxPassword.Text) == UserAccountClass.GetUserPassword(username)
                && UserAccountClass.GetUserAccountStatus(username))
            {
                this.Hide();
                MenuForm MF = new MenuForm();
                MF.userType = Convert.ToInt32(UserAccountClass.GetUserTypeID(username));
                MF.ShowDialog();
                textBoxPassword.Text = "";
                textBoxUsername.Text = "";
                this.Show();
            }
            else if (!UserAccountClass.GetUserAccountStatus(username))
                MessageBox.Show("User is deactivated, have an admin reactivate the account", "Account deactivated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Username or password does not match", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}
