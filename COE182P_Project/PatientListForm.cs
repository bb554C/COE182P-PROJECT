using COE182P_Project.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace COE182P_Project
{
    public partial class PatientListForm : Form
    {
        public PatientListForm()
        {
            InitializeComponent();
        }

        private void PatientListForm_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            dataGridView.Rows.Clear();
            SqlConnection SQLconn = SQLConnection.SQLConnect();
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter("dbo.GetPatientInfo", SQLconn))
            {
                var command = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView.DataSource = ds.Tables[0];
            }
            SQLConnection.CloseSQLConnect(SQLconn);
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView.Rows[selectedrowindex];
                textBoxPatientID.Text = Convert.ToString(selectedRow.Cells["Patient ID"].Value);
                switch (Convert.ToString(selectedRow.Cells["Patient Status"].Value))
                {
                    case "Under Investigation":
                        comboBoxPatientStatus.SelectedIndex = 0;
                        break;
                    case "Active (Serious)":
                        comboBoxPatientStatus.SelectedIndex = 1;
                        break;
                    case "Active (Mild)":
                        comboBoxPatientStatus.SelectedIndex = 2;
                        break;
                    case "Closed (Recovered)":
                        comboBoxPatientStatus.SelectedIndex = 3;
                        break;
                    case "Closed (Deceased)":
                        comboBoxPatientStatus.SelectedIndex = 4;
                        break;
                }
                textBoxMedicalNotes.Text = Convert.ToString(selectedRow.Cells["Medical Notes"].Value);
            }
        }

        private void tetBoxMedicalNotes_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMedicalNotes.Text != "")
            {
                labelMedicalNotes.Visible = false;
            }
            else
                labelMedicalNotes.Visible = true;
        }

        private void buttonDeletePatient_Click(object sender, EventArgs e)
        {
            PatientClass.DeletePatient(Convert.ToInt32(textBoxPatientID.Text));
            PatientListForm_Load(sender, e);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            PatientClass.UpdatePatient(Convert.ToInt32(textBoxPatientID.Text), comboBoxPatientStatus.SelectedIndex + 1, textBoxMedicalNotes.Text);
            PatientListForm_Load(sender, e);
        }
    }
}
