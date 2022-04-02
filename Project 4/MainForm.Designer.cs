namespace Project_4
{
    partial class myAppTracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myAppTracker));
            this.label1 = new System.Windows.Forms.Label();
            this.mapPictureBox = new System.Windows.Forms.PictureBox();
            this.btnCasesX100K = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblAG = new System.Windows.Forms.Label();
            this.lblUS = new System.Windows.Forms.Label();
            this.lblStatistics = new System.Windows.Forms.Label();
            this.statesPictureBox2 = new System.Windows.Forms.PictureBox();
            this.statesPictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.outputMessage = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.btnVaccinations = new System.Windows.Forms.Button();
            this.btnCommunityTransmission = new System.Windows.Forms.Button();
            this.btnVaccinationsByAge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(850, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Alain\'s App";
            // 
            // mapPictureBox
            // 
            this.mapPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("mapPictureBox.Image")));
            this.mapPictureBox.Location = new System.Drawing.Point(308, 65);
            this.mapPictureBox.Name = "mapPictureBox";
            this.mapPictureBox.Size = new System.Drawing.Size(1158, 562);
            this.mapPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapPictureBox.TabIndex = 1;
            this.mapPictureBox.TabStop = false;
            // 
            // btnCasesX100K
            // 
            this.btnCasesX100K.Location = new System.Drawing.Point(1129, 664);
            this.btnCasesX100K.Name = "btnCasesX100K";
            this.btnCasesX100K.Size = new System.Drawing.Size(179, 33);
            this.btnCasesX100K.TabIndex = 2;
            this.btnCasesX100K.Text = "&Cases per 100K";
            this.btnCasesX100K.UseVisualStyleBackColor = true;
            this.btnCasesX100K.Click += new System.EventHandler(this.btnCasesX100K_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(1349, 732);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 33);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 787);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1466, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(700, 4, 500, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(186, 20);
            this.toolStripStatusLabel1.Text = "Developed by Alain Garcia";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblUS);
            this.panel1.Controls.Add(this.lblStatistics);
            this.panel1.Controls.Add(this.statesPictureBox2);
            this.panel1.Controls.Add(this.statesPictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 786);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblWelcome);
            this.panel3.Controls.Add(this.lblAG);
            this.panel3.Location = new System.Drawing.Point(46, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 68);
            this.panel3.TabIndex = 6;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(62, 11);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(99, 18);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome to";
            // 
            // lblAG
            // 
            this.lblAG.AutoSize = true;
            this.lblAG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAG.Location = new System.Drawing.Point(13, 34);
            this.lblAG.Name = "lblAG";
            this.lblAG.Size = new System.Drawing.Size(175, 18);
            this.lblAG.TabIndex = 5;
            this.lblAG.Text = "Alain Garcia\'s Tracker";
            // 
            // lblUS
            // 
            this.lblUS.AutoSize = true;
            this.lblUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUS.Location = new System.Drawing.Point(31, 126);
            this.lblUS.Name = "lblUS";
            this.lblUS.Size = new System.Drawing.Size(182, 16);
            this.lblUS.TabIndex = 4;
            this.lblUS.Text = "United States New Cases";
            // 
            // lblStatistics
            // 
            this.lblStatistics.AutoSize = true;
            this.lblStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatistics.Location = new System.Drawing.Point(117, 95);
            this.lblStatistics.Name = "lblStatistics";
            this.lblStatistics.Size = new System.Drawing.Size(70, 16);
            this.lblStatistics.TabIndex = 3;
            this.lblStatistics.Text = "Statistics";
            // 
            // statesPictureBox2
            // 
            this.statesPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("statesPictureBox2.Image")));
            this.statesPictureBox2.Location = new System.Drawing.Point(34, 439);
            this.statesPictureBox2.Name = "statesPictureBox2";
            this.statesPictureBox2.Size = new System.Drawing.Size(242, 325);
            this.statesPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.statesPictureBox2.TabIndex = 1;
            this.statesPictureBox2.TabStop = false;
            // 
            // statesPictureBox1
            // 
            this.statesPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("statesPictureBox1.Image")));
            this.statesPictureBox1.Location = new System.Drawing.Point(34, 159);
            this.statesPictureBox1.Name = "statesPictureBox1";
            this.statesPictureBox1.Size = new System.Drawing.Size(242, 284);
            this.statesPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.statesPictureBox1.TabIndex = 0;
            this.statesPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.outputMessage);
            this.panel2.Controls.Add(this.lblDashboard);
            this.panel2.Location = new System.Drawing.Point(315, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1151, 63);
            this.panel2.TabIndex = 0;
            // 
            // outputMessage
            // 
            this.outputMessage.BackColor = System.Drawing.Color.Gray;
            this.outputMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.outputMessage.Location = new System.Drawing.Point(686, 16);
            this.outputMessage.Name = "outputMessage";
            this.outputMessage.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.outputMessage.Size = new System.Drawing.Size(437, 28);
            this.outputMessage.TabIndex = 1;
            this.outputMessage.Text = "Message for the user";
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDashboard.Location = new System.Drawing.Point(18, 8);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(161, 36);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Dashboard";
            // 
            // btnVaccinations
            // 
            this.btnVaccinations.Location = new System.Drawing.Point(896, 664);
            this.btnVaccinations.Name = "btnVaccinations";
            this.btnVaccinations.Size = new System.Drawing.Size(179, 33);
            this.btnVaccinations.TabIndex = 1;
            this.btnVaccinations.Text = "&Vaccinations";
            this.btnVaccinations.UseVisualStyleBackColor = true;
            this.btnVaccinations.Click += new System.EventHandler(this.btnVaccinations_Click);
            // 
            // btnCommunityTransmission
            // 
            this.btnCommunityTransmission.Location = new System.Drawing.Point(651, 664);
            this.btnCommunityTransmission.Name = "btnCommunityTransmission";
            this.btnCommunityTransmission.Size = new System.Drawing.Size(179, 33);
            this.btnCommunityTransmission.TabIndex = 5;
            this.btnCommunityTransmission.Text = "Comunnity Transmission";
            this.btnCommunityTransmission.UseVisualStyleBackColor = true;
            this.btnCommunityTransmission.Click += new System.EventHandler(this.btnCommunityTransmission_Click);
            // 
            // btnVaccinationsByAge
            // 
            this.btnVaccinationsByAge.Location = new System.Drawing.Point(414, 664);
            this.btnVaccinationsByAge.Name = "btnVaccinationsByAge";
            this.btnVaccinationsByAge.Size = new System.Drawing.Size(179, 33);
            this.btnVaccinationsByAge.TabIndex = 6;
            this.btnVaccinationsByAge.Text = "Vaccinations By &Age";
            this.btnVaccinationsByAge.UseVisualStyleBackColor = true;
            this.btnVaccinationsByAge.Click += new System.EventHandler(this.btnVaccinationsByAge_Click);
            // 
            // myAppTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1466, 813);
            this.Controls.Add(this.btnVaccinationsByAge);
            this.Controls.Add(this.btnCommunityTransmission);
            this.Controls.Add(this.btnVaccinations);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCasesX100K);
            this.Controls.Add(this.mapPictureBox);
            this.Controls.Add(this.label1);
            this.Name = "myAppTracker";
            this.Text = "My App tracker";
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox mapPictureBox;
        private System.Windows.Forms.Button btnCasesX100K;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox statesPictureBox2;
        private System.Windows.Forms.PictureBox statesPictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label outputMessage;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Label lblUS;
        private System.Windows.Forms.Label lblStatistics;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAG;
        private System.Windows.Forms.Button btnVaccinations;
        private System.Windows.Forms.Button btnCommunityTransmission;
        private System.Windows.Forms.Button btnVaccinationsByAge;
    }
}