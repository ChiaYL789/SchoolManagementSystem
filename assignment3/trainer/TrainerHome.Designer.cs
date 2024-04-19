namespace assignment3
{
    partial class frmTrainerHome
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTPNum = new System.Windows.Forms.Label();
            this.grpNavBar = new System.Windows.Forms.GroupBox();
            this.btnUserProfile = new System.Windows.Forms.Button();
            this.btnStdList = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.grpNavBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(146, 180);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(202, 31);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome Back!";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(3, 438);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(130, 20);
            this.lblPosition.TabIndex = 2;
            this.lblPosition.Text = "Current Position: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Trainer /";
            // 
            // lblTPNum
            // 
            this.lblTPNum.AutoSize = true;
            this.lblTPNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTPNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPNum.Location = new System.Drawing.Point(191, 436);
            this.lblTPNum.Name = "lblTPNum";
            this.lblTPNum.Size = new System.Drawing.Size(2, 22);
            this.lblTPNum.TabIndex = 4;
            this.lblTPNum.Click += new System.EventHandler(this.lblTPNum_Click);
            // 
            // grpNavBar
            // 
            this.grpNavBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpNavBar.Controls.Add(this.btnUserProfile);
            this.grpNavBar.Controls.Add(this.btnStdList);
            this.grpNavBar.Controls.Add(this.btnFeedback);
            this.grpNavBar.Controls.Add(this.btnEdit);
            this.grpNavBar.Controls.Add(this.btnAdd);
            this.grpNavBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpNavBar.Location = new System.Drawing.Point(450, 62);
            this.grpNavBar.Name = "grpNavBar";
            this.grpNavBar.Size = new System.Drawing.Size(193, 342);
            this.grpNavBar.TabIndex = 5;
            this.grpNavBar.TabStop = false;
            this.grpNavBar.Text = "Navigation Bar";
            // 
            // btnUserProfile
            // 
            this.btnUserProfile.Location = new System.Drawing.Point(20, 273);
            this.btnUserProfile.Name = "btnUserProfile";
            this.btnUserProfile.Size = new System.Drawing.Size(152, 49);
            this.btnUserProfile.TabIndex = 4;
            this.btnUserProfile.Text = "User Profile";
            this.btnUserProfile.UseVisualStyleBackColor = true;
            this.btnUserProfile.Click += new System.EventHandler(this.btnUserProfile_Click);
            // 
            // btnStdList
            // 
            this.btnStdList.Location = new System.Drawing.Point(20, 215);
            this.btnStdList.Name = "btnStdList";
            this.btnStdList.Size = new System.Drawing.Size(152, 49);
            this.btnStdList.TabIndex = 3;
            this.btnStdList.Text = "View Student List";
            this.btnStdList.UseVisualStyleBackColor = true;
            this.btnStdList.Click += new System.EventHandler(this.btnStdList_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Location = new System.Drawing.Point(20, 156);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(152, 49);
            this.btnFeedback.TabIndex = 2;
            this.btnFeedback.Text = "Admin Feedback";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(20, 96);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(152, 49);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Modules List";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 36);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 51);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add New Module";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(22, 20);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(71, 37);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(209, 228);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 16);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "(NAME)";
            // 
            // frmTrainerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(729, 467);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.grpNavBar);
            this.Controls.Add(this.lblTPNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblWelcome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTrainerHome";
            this.Text = "Trainer Homepage ";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.grpNavBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTPNum;
        private System.Windows.Forms.GroupBox grpNavBar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnUserProfile;
        private System.Windows.Forms.Button btnStdList;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblName;
    }
}

