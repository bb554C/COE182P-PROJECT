using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.Hide();
            MenuForm MF = new MenuForm();
            MF.ShowDialog();
            this.Show();
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {

        }
    }
}
