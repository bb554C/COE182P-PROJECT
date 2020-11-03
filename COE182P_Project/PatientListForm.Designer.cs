namespace COE182P_Project
{
    partial class PatientListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientListForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxPatientID = new System.Windows.Forms.TextBox();
            this.labelPatientID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPatientStatus = new System.Windows.Forms.ComboBox();
            this.textBoxMedicalNotes = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelMedicalNotes = new System.Windows.Forms.Label();
            this.buttonDeletePatient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(982, 600);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // textBoxPatientID
            // 
            this.textBoxPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPatientID.Location = new System.Drawing.Point(12, 618);
            this.textBoxPatientID.Name = "textBoxPatientID";
            this.textBoxPatientID.ReadOnly = true;
            this.textBoxPatientID.Size = new System.Drawing.Size(175, 27);
            this.textBoxPatientID.TabIndex = 2;
            this.textBoxPatientID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPatientID
            // 
            this.labelPatientID.AutoSize = true;
            this.labelPatientID.BackColor = System.Drawing.SystemColors.Control;
            this.labelPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientID.ForeColor = System.Drawing.Color.Black;
            this.labelPatientID.Location = new System.Drawing.Point(42, 648);
            this.labelPatientID.Name = "labelPatientID";
            this.labelPatientID.Size = new System.Drawing.Size(100, 20);
            this.labelPatientID.TabIndex = 4;
            this.labelPatientID.Text = "PATIENT ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(239, 648);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "PATIENT STATUS";
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
            this.comboBoxPatientStatus.Location = new System.Drawing.Point(193, 618);
            this.comboBoxPatientStatus.Name = "comboBoxPatientStatus";
            this.comboBoxPatientStatus.Size = new System.Drawing.Size(250, 28);
            this.comboBoxPatientStatus.TabIndex = 9;
            // 
            // textBoxMedicalNotes
            // 
            this.textBoxMedicalNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMedicalNotes.Location = new System.Drawing.Point(449, 618);
            this.textBoxMedicalNotes.Multiline = true;
            this.textBoxMedicalNotes.Name = "textBoxMedicalNotes";
            this.textBoxMedicalNotes.Size = new System.Drawing.Size(331, 91);
            this.textBoxMedicalNotes.TabIndex = 10;
            this.textBoxMedicalNotes.TextChanged += new System.EventHandler(this.tetBoxMedicalNotes_TextChanged);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonUpdate.Location = new System.Drawing.Point(787, 618);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(207, 90);
            this.buttonUpdate.TabIndex = 20;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelMedicalNotes
            // 
            this.labelMedicalNotes.AutoSize = true;
            this.labelMedicalNotes.BackColor = System.Drawing.Color.White;
            this.labelMedicalNotes.Enabled = false;
            this.labelMedicalNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedicalNotes.ForeColor = System.Drawing.Color.Black;
            this.labelMedicalNotes.Location = new System.Drawing.Point(459, 624);
            this.labelMedicalNotes.Name = "labelMedicalNotes";
            this.labelMedicalNotes.Size = new System.Drawing.Size(119, 17);
            this.labelMedicalNotes.TabIndex = 21;
            this.labelMedicalNotes.Text = "MEDICAL NOTES";
            // 
            // buttonDeletePatient
            // 
            this.buttonDeletePatient.BackColor = System.Drawing.Color.Red;
            this.buttonDeletePatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeletePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletePatient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDeletePatient.Location = new System.Drawing.Point(12, 679);
            this.buttonDeletePatient.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeletePatient.Name = "buttonDeletePatient";
            this.buttonDeletePatient.Size = new System.Drawing.Size(175, 30);
            this.buttonDeletePatient.TabIndex = 22;
            this.buttonDeletePatient.Text = "DELETE PATIENT";
            this.buttonDeletePatient.UseVisualStyleBackColor = false;
            this.buttonDeletePatient.Click += new System.EventHandler(this.buttonDeletePatient_Click);
            // 
            // PatientListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.buttonDeletePatient);
            this.Controls.Add(this.labelMedicalNotes);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxMedicalNotes);
            this.Controls.Add(this.comboBoxPatientStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPatientID);
            this.Controls.Add(this.textBoxPatientID);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PatientListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OUTBREAK MONITOR - Patient List";
            this.Load += new System.EventHandler(this.PatientListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBoxPatientID;
        private System.Windows.Forms.Label labelPatientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPatientStatus;
        private System.Windows.Forms.TextBox textBoxMedicalNotes;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelMedicalNotes;
        private System.Windows.Forms.Button buttonDeletePatient;
    }
}