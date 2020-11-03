using System;
using System.Windows.Forms;

namespace COE182P_Project
{
    public partial class MenuForm : Form
    {
        public int userType = 0;
        public MenuForm()
        {
            InitializeComponent();
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {
            switch (userType)
            {
                case 1:
                    buttonAddPatient.Enabled = true;
                    break;
                case 2:
                    buttonAddPatient.Enabled = true;
                    buttonDisplayMap.Enabled = true;
                    break;
                case 3:
                    buttonAddPatient.Enabled = true;
                    buttonDisplayMap.Enabled = true;
                    buttonPatientList.Enabled = true;
                    break;
                case 4:
                    buttonAddPatient.Enabled = true;
                    buttonDisplayMap.Enabled = true;
                    buttonPatientList.Enabled = true;
                    buttonCreateAccount.Enabled = true;
                    buttonUpdateAccount.Enabled = true;
                    break;
            }
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            buttonLogOut_Click(sender, e);
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPatientForm AP = new AddPatientForm();
            AP.ShowDialog();
            this.Show();
        }

        private void buttonDisplayMap_Click(object sender, EventArgs e)
        {
            this.Hide();
            DisplayMapForm DM = new DisplayMapForm();
            DM.ShowDialog();
            this.Show();
        }

        private void buttonPatientList_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientListForm PLF = new PatientListForm();
            PLF.ShowDialog();
            this.Show();
        }
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            AddUserForm AUF = new AddUserForm();
            this.Hide();
            AUF.ShowDialog();
            this.Show();
        }

        private void buttonUpdateAccount_Click(object sender, EventArgs e)
        {
            AddUserForm AUF = new AddUserForm();
            this.Hide();
            AUF.State = 1;
            AUF.ShowDialog();
            this.Show();
        }


    }
}
