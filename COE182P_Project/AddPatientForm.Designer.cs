namespace COE182P_Project
{
    partial class AddPatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatientForm));
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.buttonAddPatient = new System.Windows.Forms.Button();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.textBoxContactNumber1 = new System.Windows.Forms.TextBox();
            this.textBoxContactNumber2 = new System.Windows.Forms.TextBox();
            this.textBoxContactNumber3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPatientStatus = new System.Windows.Forms.ComboBox();
            this.labelPatientStatus = new System.Windows.Forms.Label();
            this.textBoxMedicalNotes = new System.Windows.Forms.TextBox();
            this.labelMedicalNotes = new System.Windows.Forms.Label();
            this.textBoxLatitude = new System.Windows.Forms.TextBox();
            this.labelLatitude = new System.Windows.Forms.Label();
            this.textBoxLongitude = new System.Windows.Forms.TextBox();
            this.labelLongitude = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gMapControl
            // 
            this.gMapControl.Bearing = 0F;
            this.gMapControl.CanDragMap = true;
            this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl.GrayScaleMode = false;
            this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl.LevelsKeepInMemory = 5;
            this.gMapControl.Location = new System.Drawing.Point(268, 12);
            this.gMapControl.MarkersEnabled = true;
            this.gMapControl.MaxZoom = 24;
            this.gMapControl.MinZoom = 2;
            this.gMapControl.MouseWheelZoomEnabled = true;
            this.gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl.Name = "gMapControl";
            this.gMapControl.NegativeMode = false;
            this.gMapControl.PolygonsEnabled = true;
            this.gMapControl.RetryLoadTile = 0;
            this.gMapControl.RoutesEnabled = true;
            this.gMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl.ShowTileGridLines = false;
            this.gMapControl.Size = new System.Drawing.Size(480, 480);
            this.gMapControl.TabIndex = 0;
            this.gMapControl.Zoom = 2D;
            this.gMapControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GmapControl_Click);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(12, 12);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(250, 27);
            this.textBoxFirstName.TabIndex = 1;
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxFirstName_TextChanged);
            // 
            // buttonAddPatient
            // 
            this.buttonAddPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonAddPatient.Enabled = false;
            this.buttonAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPatient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddPatient.Location = new System.Drawing.Point(12, 499);
            this.buttonAddPatient.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddPatient.Name = "buttonAddPatient";
            this.buttonAddPatient.Size = new System.Drawing.Size(736, 49);
            this.buttonAddPatient.TabIndex = 2;
            this.buttonAddPatient.Text = "Add Patient";
            this.buttonAddPatient.UseVisualStyleBackColor = false;
            this.buttonAddPatient.Click += new System.EventHandler(this.buttonAddPatient_Click);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.BackColor = System.Drawing.Color.White;
            this.labelFirstName.Enabled = false;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.ForeColor = System.Drawing.Color.Black;
            this.labelFirstName.Location = new System.Drawing.Point(20, 17);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(90, 17);
            this.labelFirstName.TabIndex = 3;
            this.labelFirstName.Text = "FIRST NAME";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(12, 45);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(250, 27);
            this.textBoxLastName.TabIndex = 2;
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.BackColor = System.Drawing.Color.White;
            this.labelLastName.Enabled = false;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.ForeColor = System.Drawing.Color.Black;
            this.labelLastName.Location = new System.Drawing.Point(20, 50);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(86, 17);
            this.labelLastName.TabIndex = 5;
            this.labelLastName.Text = "LAST NAME";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.comboBoxGender.Location = new System.Drawing.Point(12, 78);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(250, 28);
            this.comboBoxGender.TabIndex = 3;
            this.comboBoxGender.SelectedValueChanged += new System.EventHandler(this.comboBoxGender_SelectedValueChanged);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.BackColor = System.Drawing.Color.White;
            this.labelGender.Enabled = false;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.ForeColor = System.Drawing.Color.Black;
            this.labelGender.Location = new System.Drawing.Point(20, 83);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(67, 17);
            this.labelGender.TabIndex = 7;
            this.labelGender.Text = "GENDER";
            // 
            // textBoxContactNumber1
            // 
            this.textBoxContactNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContactNumber1.Location = new System.Drawing.Point(12, 112);
            this.textBoxContactNumber1.Name = "textBoxContactNumber1";
            this.textBoxContactNumber1.Size = new System.Drawing.Size(70, 27);
            this.textBoxContactNumber1.TabIndex = 4;
            this.textBoxContactNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxContactNumber1.TextChanged += new System.EventHandler(this.textBoxContactNumber1_TextChanged);
            this.textBoxContactNumber1.Enter += new System.EventHandler(this.textBoxContactNumber1_TextChanged);
            this.textBoxContactNumber1.Leave += new System.EventHandler(this.textBoxContactNumber1_TextChanged);
            // 
            // textBoxContactNumber2
            // 
            this.textBoxContactNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContactNumber2.Location = new System.Drawing.Point(107, 112);
            this.textBoxContactNumber2.Name = "textBoxContactNumber2";
            this.textBoxContactNumber2.Size = new System.Drawing.Size(60, 27);
            this.textBoxContactNumber2.TabIndex = 5;
            this.textBoxContactNumber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxContactNumber2.TextChanged += new System.EventHandler(this.textBoxContactNumber2_TextChanged);
            this.textBoxContactNumber2.Enter += new System.EventHandler(this.textBoxContactNumber2_TextChanged);
            this.textBoxContactNumber2.Leave += new System.EventHandler(this.textBoxContactNumber2_TextChanged);
            // 
            // textBoxContactNumber3
            // 
            this.textBoxContactNumber3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContactNumber3.Location = new System.Drawing.Point(192, 112);
            this.textBoxContactNumber3.Name = "textBoxContactNumber3";
            this.textBoxContactNumber3.Size = new System.Drawing.Size(70, 27);
            this.textBoxContactNumber3.TabIndex = 6;
            this.textBoxContactNumber3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxContactNumber3.TextChanged += new System.EventHandler(this.textBoxContactNumber3_TextChanged);
            this.textBoxContactNumber3.Enter += new System.EventHandler(this.textBoxContactNumber3_TextChanged);
            this.textBoxContactNumber3.Leave += new System.EventHandler(this.textBoxContactNumber3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(86, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(171, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(78, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "PHONE NUMBER";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(12, 164);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(250, 22);
            this.dateTimePicker.TabIndex = 7;
            this.dateTimePicker.Value = new System.DateTime(2020, 11, 2, 18, 39, 12, 0);
            // 
            // comboBoxPatientStatus
            // 
            this.comboBoxPatientStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPatientStatus.FormattingEnabled = true;
            this.comboBoxPatientStatus.Items.AddRange(new object[] {
            "UNDER INVESTIGATION",
            "ACTIVE - SERIOUS",
            "ACTIVE - MILD",
            "CLOSED - RECOVERED",
            "CLOSED - DECEASED"});
            this.comboBoxPatientStatus.Location = new System.Drawing.Point(12, 192);
            this.comboBoxPatientStatus.Name = "comboBoxPatientStatus";
            this.comboBoxPatientStatus.Size = new System.Drawing.Size(250, 28);
            this.comboBoxPatientStatus.TabIndex = 8;
            this.comboBoxPatientStatus.SelectedValueChanged += new System.EventHandler(this.comboBoxPatientStatus_SelectedIndexChanged);
            // 
            // labelPatientStatus
            // 
            this.labelPatientStatus.AutoSize = true;
            this.labelPatientStatus.BackColor = System.Drawing.Color.White;
            this.labelPatientStatus.Enabled = false;
            this.labelPatientStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientStatus.ForeColor = System.Drawing.Color.Black;
            this.labelPatientStatus.Location = new System.Drawing.Point(20, 198);
            this.labelPatientStatus.Name = "labelPatientStatus";
            this.labelPatientStatus.Size = new System.Drawing.Size(125, 17);
            this.labelPatientStatus.TabIndex = 17;
            this.labelPatientStatus.Text = "PATIENT STATUS";
            // 
            // textBoxMedicalNotes
            // 
            this.textBoxMedicalNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMedicalNotes.Location = new System.Drawing.Point(12, 226);
            this.textBoxMedicalNotes.Multiline = true;
            this.textBoxMedicalNotes.Name = "textBoxMedicalNotes";
            this.textBoxMedicalNotes.Size = new System.Drawing.Size(250, 200);
            this.textBoxMedicalNotes.TabIndex = 9;
            this.textBoxMedicalNotes.TextChanged += new System.EventHandler(this.textBoxMedicalNotes_TextChanged);
            // 
            // labelMedicalNotes
            // 
            this.labelMedicalNotes.AutoSize = true;
            this.labelMedicalNotes.BackColor = System.Drawing.Color.White;
            this.labelMedicalNotes.Enabled = false;
            this.labelMedicalNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedicalNotes.ForeColor = System.Drawing.Color.Black;
            this.labelMedicalNotes.Location = new System.Drawing.Point(20, 232);
            this.labelMedicalNotes.Name = "labelMedicalNotes";
            this.labelMedicalNotes.Size = new System.Drawing.Size(119, 17);
            this.labelMedicalNotes.TabIndex = 18;
            this.labelMedicalNotes.Text = "MEDICAL NOTES";
            // 
            // textBoxLatitude
            // 
            this.textBoxLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLatitude.Location = new System.Drawing.Point(12, 432);
            this.textBoxLatitude.Name = "textBoxLatitude";
            this.textBoxLatitude.ReadOnly = true;
            this.textBoxLatitude.Size = new System.Drawing.Size(250, 27);
            this.textBoxLatitude.TabIndex = 9;
            // 
            // labelLatitude
            // 
            this.labelLatitude.AutoSize = true;
            this.labelLatitude.BackColor = System.Drawing.Color.White;
            this.labelLatitude.Enabled = false;
            this.labelLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLatitude.ForeColor = System.Drawing.Color.Black;
            this.labelLatitude.Location = new System.Drawing.Point(222, 437);
            this.labelLatitude.Name = "labelLatitude";
            this.labelLatitude.Size = new System.Drawing.Size(34, 17);
            this.labelLatitude.TabIndex = 19;
            this.labelLatitude.Text = "LAT";
            // 
            // textBoxLongitude
            // 
            this.textBoxLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLongitude.Location = new System.Drawing.Point(12, 465);
            this.textBoxLongitude.Name = "textBoxLongitude";
            this.textBoxLongitude.ReadOnly = true;
            this.textBoxLongitude.Size = new System.Drawing.Size(250, 27);
            this.textBoxLongitude.TabIndex = 10;
            // 
            // labelLongitude
            // 
            this.labelLongitude.AutoSize = true;
            this.labelLongitude.BackColor = System.Drawing.Color.White;
            this.labelLongitude.Enabled = false;
            this.labelLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLongitude.ForeColor = System.Drawing.Color.Black;
            this.labelLongitude.Location = new System.Drawing.Point(208, 470);
            this.labelLongitude.Name = "labelLongitude";
            this.labelLongitude.Size = new System.Drawing.Size(48, 17);
            this.labelLongitude.TabIndex = 20;
            this.labelLongitude.Text = "LONG";
            // 
            // AddPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 553);
            this.Controls.Add(this.labelLongitude);
            this.Controls.Add(this.textBoxLongitude);
            this.Controls.Add(this.labelLatitude);
            this.Controls.Add(this.textBoxLatitude);
            this.Controls.Add(this.labelMedicalNotes);
            this.Controls.Add(this.textBoxMedicalNotes);
            this.Controls.Add(this.labelPatientStatus);
            this.Controls.Add(this.comboBoxPatientStatus);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxContactNumber3);
            this.Controls.Add(this.textBoxContactNumber2);
            this.Controls.Add(this.textBoxContactNumber1);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.buttonAddPatient);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.gMapControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OUTBREAK MONITOR - Add Patient";
            this.Load += new System.EventHandler(this.AddPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Button buttonAddPatient;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.TextBox textBoxContactNumber1;
        private System.Windows.Forms.TextBox textBoxContactNumber2;
        private System.Windows.Forms.TextBox textBoxContactNumber3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboBoxPatientStatus;
        private System.Windows.Forms.Label labelPatientStatus;
        private System.Windows.Forms.TextBox textBoxMedicalNotes;
        private System.Windows.Forms.Label labelMedicalNotes;
        private System.Windows.Forms.TextBox textBoxLatitude;
        private System.Windows.Forms.Label labelLatitude;
        private System.Windows.Forms.TextBox textBoxLongitude;
        private System.Windows.Forms.Label labelLongitude;
    }
}