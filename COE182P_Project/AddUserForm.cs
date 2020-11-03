using COE182P_Project.Classes;
using StoreManagementSystem.Source_Code.Classes;
using System;
using System.Windows.Forms;

namespace COE182P_Project
{
    public partial class AddUserForm : Form
    {
        public int State = 0;
        public AddUserForm()
        {
            InitializeComponent();
        }
        private void AddUserForm_Load(object sender, EventArgs e)
        {
            comboBoxAccountStatus.SelectedIndex = 1;
            buttonAccount.Enabled = false;
            if (State == 1)
            {
                updateMode();
            }
        }
        private void updateMode()
        {
            textBoxFirstName.ReadOnly = true;
            textBoxLastName.ReadOnly = true;
            textBoxContactNumber1.ReadOnly = true;
            textBoxContactNumber2.ReadOnly = true;
            textBoxContactNumber3.ReadOnly = true;
            textBoxPassword.ReadOnly = true;
            comboBoxGender.Enabled = false;
            comboBoxUserType.Enabled = false;
            comboBoxAccountStatus.Enabled = false;
            textBoxAddress.ReadOnly = true;
            buttonAccount.Text = "UPDATE ACCOUNT";
        }
        private void enableButton()
        {
            if (textBoxUsername.Text != ""
                && textBoxFirstName.Text != ""
                && textBoxLastName.Text != ""
                && textBoxContactNumber1.Text != ""
                && textBoxContactNumber2.Text != ""
                && textBoxContactNumber3.Text != ""
                && textBoxPassword.Text != ""
                && comboBoxGender.Text != ""
                && comboBoxUserType.Text != ""
                && textBoxAddress.Text != ""
                && comboBoxAccountStatus.Text != ""
                )
            {
                buttonAccount.Enabled = true;
            }
        }
        private void textBoxContactNumber1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxContactNumber1.Text != "")
            {
                try
                {
                    int x = Convert.ToInt32(textBoxContactNumber1.Text);
                    enableButton();
                }
                catch (Exception ex)
                {
                    textBoxContactNumber1.Text = "";
                    MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (textBoxContactNumber1.Text.Length == 4
                && textBoxContactNumber2.Text == ""
                && textBoxContactNumber3.Text == "")
            {
                textBoxContactNumber2.Focus();
                enableButton();
            }
        }

        private void textBoxContactNumber2_TextChanged(object sender, EventArgs e)
        {
            if (textBoxContactNumber2.Text != "")
            {
                try
                {
                    int x = Convert.ToInt32(textBoxContactNumber2.Text);
                    enableButton();
                }
                catch (Exception ex)
                {
                    textBoxContactNumber2.Text = "";
                    MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (textBoxContactNumber2.Text.Length == 3
                && textBoxContactNumber3.Text == "")
            {
                textBoxContactNumber3.Focus();
                enableButton();
            }
        }

        private void textBoxContactNumber3_TextChanged(object sender, EventArgs e)
        {
            if (textBoxContactNumber3.Text != "")
            {
                try
                {
                    int x = Convert.ToInt32(textBoxContactNumber3.Text);
                    enableButton();
                }
                catch (Exception ex)
                {
                    textBoxContactNumber3.Text = "";
                    MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (textBoxContactNumber3.Text.Length == 4)
            {
                enableButton();
            }
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLastName.Text != "")
            {
                labelLastName.Visible = false;
                enableButton();
            }
            else
                labelLastName.Visible = true;
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text != "")
            {
                labelFirstName.Visible = false;
                enableButton();
            }
            else
                labelFirstName.Visible = true;
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            switch (State)
            {
                case 0:
                    if (textBoxUsername.Text != "")
                    {
                        labelUsername.Visible = false;
                        if (textBoxUsername.Text == UserAccountClass.GetUserName(textBoxUsername.Text))
                        {
                            MessageBox.Show("Username already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxUsername.Text = "";
                        }
                        enableButton();
                    }
                    else
                        labelUsername.Visible = true;
                    break;
                case 1:
                    if (textBoxUsername.Text != "")
                    {
                        labelUsername.Visible = false;
                        enableButton();
                    }
                    else
                        labelUsername.Visible = true;
                    if (textBoxUsername.Text == UserAccountClass.GetUserName(textBoxUsername.Text))
                    {
                        textBoxFirstName.ReadOnly = false;
                        textBoxLastName.ReadOnly = false;
                        textBoxContactNumber1.ReadOnly = false;
                        textBoxContactNumber2.ReadOnly = false;
                        textBoxContactNumber3.ReadOnly = false;
                        textBoxPassword.ReadOnly = false;
                        comboBoxGender.Enabled = true;
                        comboBoxUserType.Enabled = true;
                        comboBoxAccountStatus.Enabled = true;
                        textBoxAddress.ReadOnly = false;
                        User U = new User();
                        U = UserAccountClass.GetUserInfo(textBoxUsername.Text);
                        textBoxUsername.Text = U.Username;
                        textBoxFirstName.Text = U.FirstName;
                        textBoxLastName.Text = U.LastName;
                        string[] tempStr = U.ContactNumber.Split('-');
                        textBoxContactNumber1.Text = tempStr[0];
                        textBoxContactNumber2.Text = tempStr[1];
                        textBoxContactNumber3.Text = tempStr[2];
                        comboBoxGender.SelectedIndex = U.GenderID - 1;
                        comboBoxUserType.SelectedIndex = U.UserTypeID - 1;
                        comboBoxAccountStatus.SelectedIndex = Convert.ToInt32(U.AccountStatus);
                        textBoxAddress.Text = U.Address;
                    }
                    break;
            }

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != "")
            {
                labelPassword.Visible = false;
                enableButton();
            }
            else
                labelPassword.Visible = true;
        }

        private void comboBoxGender_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxGender.Text != "")
            {
                labelGender.Visible = false;
                enableButton();
            }
            else
                labelGender.Visible = true;
        }

        private void comboBoxUserType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxUserType.Text != "")
            {
                labelUserType.Visible = false;
                enableButton();
            }
            else
                labelUserType.Visible = true;
        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAddress.Text != "")
            {
                labelAddress.Visible = false;
                enableButton();
            }
            else
                labelAddress.Visible = true;
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            switch (State)
            {
                case 0:
                    UserAccountClass.AddNewUser(Convert.ToInt32(comboBoxGender.SelectedIndex) + 1,
                        Convert.ToInt32(comboBoxUserType.SelectedIndex) + 1,
                        textBoxUsername.Text,
                        textBoxFirstName.Text,
                        textBoxLastName.Text,
                        textBoxContactNumber1.Text + "-" + textBoxContactNumber2.Text + "-" + textBoxContactNumber3.Text,
                        Encryption.ComputeSha256Hash(textBoxPassword.Text),
                        textBoxAddress.Text,
                        Convert.ToBoolean(comboBoxAccountStatus.SelectedIndex));
                    MessageBox.Show("Account Creation Successful", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    break;
                case 1:
                    UserAccountClass.UpdateUser(Convert.ToInt32(comboBoxGender.SelectedIndex) + 1,
                        Convert.ToInt32(comboBoxUserType.SelectedIndex) + 1,
                        textBoxUsername.Text,
                        textBoxFirstName.Text,
                        textBoxLastName.Text,
                        textBoxContactNumber1.Text + "-" + textBoxContactNumber2.Text + "-" + textBoxContactNumber3.Text,
                        Encryption.ComputeSha256Hash(textBoxPassword.Text),
                        textBoxAddress.Text,
                        Convert.ToBoolean(comboBoxAccountStatus.SelectedIndex));
                    MessageBox.Show("Account Update Successful", "Update Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    break;
            }
        }
    }
}
