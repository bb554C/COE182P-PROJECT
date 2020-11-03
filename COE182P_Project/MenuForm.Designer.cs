namespace COE182P_Project
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonAddPatient = new System.Windows.Forms.Button();
            this.buttonDisplayMap = new System.Windows.Forms.Button();
            this.buttonPatientList = new System.Windows.Forms.Button();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.buttonUpdateAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonLogOut.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.ForeColor = System.Drawing.Color.Red;
            this.buttonLogOut.Location = new System.Drawing.Point(16, 295);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(347, 49);
            this.buttonLogOut.TabIndex = 3;
            this.buttonLogOut.Text = "LOG OUT";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonAddPatient
            // 
            this.buttonAddPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonAddPatient.Enabled = false;
            this.buttonAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPatient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddPatient.Location = new System.Drawing.Point(16, 15);
            this.buttonAddPatient.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddPatient.Name = "buttonAddPatient";
            this.buttonAddPatient.Size = new System.Drawing.Size(347, 49);
            this.buttonAddPatient.TabIndex = 0;
            this.buttonAddPatient.Text = "Add Patient";
            this.buttonAddPatient.UseVisualStyleBackColor = false;
            this.buttonAddPatient.Click += new System.EventHandler(this.buttonAddPatient_Click);
            // 
            // buttonDisplayMap
            // 
            this.buttonDisplayMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDisplayMap.Enabled = false;
            this.buttonDisplayMap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDisplayMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplayMap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDisplayMap.Location = new System.Drawing.Point(16, 84);
            this.buttonDisplayMap.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDisplayMap.Name = "buttonDisplayMap";
            this.buttonDisplayMap.Size = new System.Drawing.Size(347, 49);
            this.buttonDisplayMap.TabIndex = 1;
            this.buttonDisplayMap.Text = "Display Map";
            this.buttonDisplayMap.UseVisualStyleBackColor = false;
            this.buttonDisplayMap.Click += new System.EventHandler(this.buttonDisplayMap_Click);
            // 
            // buttonPatientList
            // 
            this.buttonPatientList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonPatientList.Enabled = false;
            this.buttonPatientList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPatientList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPatientList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonPatientList.Location = new System.Drawing.Point(16, 153);
            this.buttonPatientList.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPatientList.Name = "buttonPatientList";
            this.buttonPatientList.Size = new System.Drawing.Size(347, 49);
            this.buttonPatientList.TabIndex = 2;
            this.buttonPatientList.Text = "Patient List";
            this.buttonPatientList.UseVisualStyleBackColor = false;
            this.buttonPatientList.Click += new System.EventHandler(this.buttonPatientList_Click);
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonCreateAccount.Enabled = false;
            this.buttonCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateAccount.Location = new System.Drawing.Point(88, 210);
            this.buttonCreateAccount.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(200, 37);
            this.buttonCreateAccount.TabIndex = 4;
            this.buttonCreateAccount.Text = "Create Account";
            this.buttonCreateAccount.UseVisualStyleBackColor = false;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // buttonUpdateAccount
            // 
            this.buttonUpdateAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonUpdateAccount.Enabled = false;
            this.buttonUpdateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateAccount.Location = new System.Drawing.Point(88, 254);
            this.buttonUpdateAccount.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdateAccount.Name = "buttonUpdateAccount";
            this.buttonUpdateAccount.Size = new System.Drawing.Size(200, 37);
            this.buttonUpdateAccount.TabIndex = 5;
            this.buttonUpdateAccount.Text = "Update Account";
            this.buttonUpdateAccount.UseVisualStyleBackColor = false;
            this.buttonUpdateAccount.Click += new System.EventHandler(this.buttonUpdateAccount_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(379, 353);
            this.Controls.Add(this.buttonUpdateAccount);
            this.Controls.Add(this.buttonCreateAccount);
            this.Controls.Add(this.buttonPatientList);
            this.Controls.Add(this.buttonDisplayMap);
            this.Controls.Add(this.buttonAddPatient);
            this.Controls.Add(this.buttonLogOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OUTBREAK MONITOR - Main Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonAddPatient;
        private System.Windows.Forms.Button buttonDisplayMap;
        private System.Windows.Forms.Button buttonPatientList;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.Button buttonUpdateAccount;
    }
}