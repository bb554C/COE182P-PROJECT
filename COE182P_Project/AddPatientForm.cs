using COE182P_Project.Classes;
using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Windows.Forms;

namespace COE182P_Project
{
    public partial class AddPatientForm : Form
    {
        public AddPatientForm()
        {
            InitializeComponent();
        }

        private void AddPatient_Load(object sender, EventArgs e)
        {
            dateTimePicker.MaxDate = DateTime.Today;
            dateTimePicker.MinDate = DateTime.Today.AddYears(-100);
            gMapControl.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            gMapControl.Zoom = 15;
            gMapControl.Position = new PointLatLng(14.59039470768, 120.975780487061);

        }
        private void enableButton()
        {
            bool existingID = true;
            if (existingID
                && textBoxFirstName.Text != ""
                && textBoxLastName.Text != ""
                && comboBoxGender.Text != ""
                && textBoxContactNumber1.Text != ""
                && textBoxContactNumber2.Text != ""
                && textBoxContactNumber3.Text != ""
                && comboBoxPatientStatus.Text != ""
                && textBoxLatitude.Text != ""
                && textBoxLongitude.Text != "")
            {
                buttonAddPatient.Enabled = true;
            }
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

        private void comboBoxPatientStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPatientStatus.Text != "")
            {
                labelPatientStatus.Visible = false;
                enableButton();
            }
            else
                labelPatientStatus.Visible = true;
        }

        private void textBoxMedicalNotes_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMedicalNotes.Text != "")
            {
                labelMedicalNotes.Visible = false;
                enableButton();
            }
            else
                labelMedicalNotes.Visible = true;
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            PatientClass.AddNewPatient
                (comboBoxGender.SelectedIndex + 1,
                comboBoxPatientStatus.SelectedIndex + 1,
                textBoxFirstName.Text,
                textBoxLastName.Text,
                textBoxContactNumber1.Text + "-" + textBoxContactNumber2.Text + "-" + textBoxContactNumber3.Text,
                dateTimePicker.Value,
                textBoxLongitude.Text,
                textBoxLatitude.Text,
                textBoxMedicalNotes.Text);
            MessageBox.Show("Add Patient Successful", "Add Patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void GmapControl_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                double lat = gMapControl.FromLocalToLatLng(e.X, e.Y).Lat;
                double lng = gMapControl.FromLocalToLatLng(e.X, e.Y).Lng;
                textBoxLatitude.Text = lat.ToString();
                textBoxLongitude.Text = lng.ToString();
                enableButton();
            }
        }
    }
}
