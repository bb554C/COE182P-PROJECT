namespace COE182P_Project
{
    partial class DisplayMapForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayMapForm));
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUnderInvestigation = new System.Windows.Forms.TextBox();
            this.textBoxActiveSerious = new System.Windows.Forms.TextBox();
            this.textBoxActiveMild = new System.Windows.Forms.TextBox();
            this.textBoxClosedRecovered = new System.Windows.Forms.TextBox();
            this.textBoxClosedDeceased = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTotalActive = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTotalClosed = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
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
            this.gMapControl.Location = new System.Drawing.Point(12, 12);
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
            this.gMapControl.Size = new System.Drawing.Size(776, 668);
            this.gMapControl.TabIndex = 0;
            this.gMapControl.Zoom = 14D;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 686);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "UNDER INVESTIGATION",
            "ACTIVE - SERIOUS",
            "ACTIVE - MILD",
            "CLOSED - RECOVERED",
            "CLOSED - DECEASED"});
            this.checkedListBox1.Location = new System.Drawing.Point(794, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(200, 106);
            this.checkedListBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(794, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Under Investigation (BLUE)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(794, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Active - Serious (RED)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(794, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Active - Mild (YELLOW)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(794, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Closed - Recovered (GREEN)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(794, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Closed - Deceased (BLACK)";
            // 
            // textBoxUnderInvestigation
            // 
            this.textBoxUnderInvestigation.Location = new System.Drawing.Point(794, 149);
            this.textBoxUnderInvestigation.Name = "textBoxUnderInvestigation";
            this.textBoxUnderInvestigation.ReadOnly = true;
            this.textBoxUnderInvestigation.Size = new System.Drawing.Size(200, 22);
            this.textBoxUnderInvestigation.TabIndex = 8;
            this.textBoxUnderInvestigation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxActiveSerious
            // 
            this.textBoxActiveSerious.Location = new System.Drawing.Point(794, 219);
            this.textBoxActiveSerious.Name = "textBoxActiveSerious";
            this.textBoxActiveSerious.ReadOnly = true;
            this.textBoxActiveSerious.Size = new System.Drawing.Size(200, 22);
            this.textBoxActiveSerious.TabIndex = 9;
            this.textBoxActiveSerious.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxActiveMild
            // 
            this.textBoxActiveMild.Location = new System.Drawing.Point(794, 289);
            this.textBoxActiveMild.Name = "textBoxActiveMild";
            this.textBoxActiveMild.ReadOnly = true;
            this.textBoxActiveMild.Size = new System.Drawing.Size(200, 22);
            this.textBoxActiveMild.TabIndex = 10;
            this.textBoxActiveMild.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxClosedRecovered
            // 
            this.textBoxClosedRecovered.Location = new System.Drawing.Point(794, 359);
            this.textBoxClosedRecovered.Name = "textBoxClosedRecovered";
            this.textBoxClosedRecovered.ReadOnly = true;
            this.textBoxClosedRecovered.Size = new System.Drawing.Size(200, 22);
            this.textBoxClosedRecovered.TabIndex = 11;
            this.textBoxClosedRecovered.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxClosedDeceased
            // 
            this.textBoxClosedDeceased.Location = new System.Drawing.Point(794, 429);
            this.textBoxClosedDeceased.Name = "textBoxClosedDeceased";
            this.textBoxClosedDeceased.ReadOnly = true;
            this.textBoxClosedDeceased.Size = new System.Drawing.Size(200, 22);
            this.textBoxClosedDeceased.TabIndex = 12;
            this.textBoxClosedDeceased.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(794, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total Active Cases";
            // 
            // textBoxTotalActive
            // 
            this.textBoxTotalActive.Location = new System.Drawing.Point(794, 494);
            this.textBoxTotalActive.Name = "textBoxTotalActive";
            this.textBoxTotalActive.ReadOnly = true;
            this.textBoxTotalActive.Size = new System.Drawing.Size(200, 22);
            this.textBoxTotalActive.TabIndex = 14;
            this.textBoxTotalActive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(794, 540);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Total Closed Cases";
            // 
            // textBoxTotalClosed
            // 
            this.textBoxTotalClosed.Location = new System.Drawing.Point(794, 565);
            this.textBoxTotalClosed.Name = "textBoxTotalClosed";
            this.textBoxTotalClosed.ReadOnly = true;
            this.textBoxTotalClosed.Size = new System.Drawing.Size(200, 22);
            this.textBoxTotalClosed.TabIndex = 16;
            this.textBoxTotalClosed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(794, 610);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total Cases";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(794, 630);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(200, 22);
            this.textBoxTotal.TabIndex = 18;
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRefresh.Location = new System.Drawing.Point(794, 669);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(200, 40);
            this.buttonRefresh.TabIndex = 19;
            this.buttonRefresh.Text = "RELOAD";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // DisplayMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxTotalClosed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxTotalActive);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxClosedDeceased);
            this.Controls.Add(this.textBoxClosedRecovered);
            this.Controls.Add(this.textBoxActiveMild);
            this.Controls.Add(this.textBoxActiveSerious);
            this.Controls.Add(this.textBoxUnderInvestigation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.gMapControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayMapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OUTBREAK MONITOR - Display Map";
            this.Load += new System.EventHandler(this.DisplayMap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUnderInvestigation;
        private System.Windows.Forms.TextBox textBoxActiveSerious;
        private System.Windows.Forms.TextBox textBoxActiveMild;
        private System.Windows.Forms.TextBox textBoxClosedRecovered;
        private System.Windows.Forms.TextBox textBoxClosedDeceased;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTotalActive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTotalClosed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Button buttonRefresh;
    }
}