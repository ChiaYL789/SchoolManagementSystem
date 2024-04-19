namespace assignment3
{
    partial class frmAdminHome
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
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblDNum = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnTList = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.tnEditProfile = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(22, 428);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(87, 13);
            this.lblPosition.TabIndex = 0;
            this.lblPosition.Text = "Current Position :";
            // 
            // lblDNum
            // 
            this.lblDNum.AutoSize = true;
            this.lblDNum.Location = new System.Drawing.Point(116, 428);
            this.lblDNum.Name = "lblDNum";
            this.lblDNum.Size = new System.Drawing.Size(42, 13);
            this.lblDNum.TabIndex = 1;
            this.lblDNum.Text = "(ROLE)";
            this.lblDNum.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(93, 169);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(157, 24);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome Back !!!";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(128, 217);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 24);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "(NAME)";
            this.lblName.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(13, 13);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(154, 39);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(462, 30);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(262, 70);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register New Trainer";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(462, 182);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(262, 70);
            this.btnAssign.TabIndex = 7;
            this.btnAssign.Text = "Manage Module Assigned";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnTList
            // 
            this.btnTList.Location = new System.Drawing.Point(462, 106);
            this.btnTList.Name = "btnTList";
            this.btnTList.Size = new System.Drawing.Size(262, 70);
            this.btnTList.TabIndex = 8;
            this.btnTList.Text = "View Trainer List";
            this.btnTList.UseVisualStyleBackColor = true;
            this.btnTList.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Location = new System.Drawing.Point(462, 334);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(262, 70);
            this.btnFeedback.TabIndex = 9;
            this.btnFeedback.Text = "View Feedback";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // tnEditProfile
            // 
            this.tnEditProfile.Location = new System.Drawing.Point(110, 276);
            this.tnEditProfile.Name = "tnEditProfile";
            this.tnEditProfile.Size = new System.Drawing.Size(118, 40);
            this.tnEditProfile.TabIndex = 10;
            this.tnEditProfile.Text = "Edit Profile";
            this.tnEditProfile.UseVisualStyleBackColor = true;
            this.tnEditProfile.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(462, 258);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(262, 70);
            this.btnReport.TabIndex = 11;
            this.btnReport.Text = "View Monthly Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmAdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.tnEditProfile);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.btnTList);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblDNum);
            this.Controls.Add(this.lblPosition);
            this.Name = "frmAdminHome";
            this.Text = "adminHomepage";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblDNum;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnTList;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button tnEditProfile;
        private System.Windows.Forms.Button btnReport;
    }
}