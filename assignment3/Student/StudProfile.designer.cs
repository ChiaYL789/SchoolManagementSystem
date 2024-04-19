namespace ASSIGNMENT
{
    partial class frmProfile
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
            this.btnBackPro = new System.Windows.Forms.Button();
            this.gbProfile = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblStudID = new System.Windows.Forms.Label();
            this.lblsid = new System.Windows.Forms.Label();
            this.lblGenderPro = new System.Windows.Forms.Label();
            this.lblNamePro = new System.Windows.Forms.Label();
            this.txtNewaddress = new System.Windows.Forms.TextBox();
            this.lbladdr = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnExitProfile = new System.Windows.Forms.Button();
            this.txtPhonePro = new System.Windows.Forms.TextBox();
            this.txtEmailPro = new System.Windows.Forms.TextBox();
            this.lblCno = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNewpassPro = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUserPP = new System.Windows.Forms.Label();
            this.gbProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackPro
            // 
            this.btnBackPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackPro.Location = new System.Drawing.Point(12, 12);
            this.btnBackPro.Name = "btnBackPro";
            this.btnBackPro.Size = new System.Drawing.Size(92, 40);
            this.btnBackPro.TabIndex = 10;
            this.btnBackPro.Text = "Back";
            this.btnBackPro.UseVisualStyleBackColor = true;
            this.btnBackPro.Click += new System.EventHandler(this.btnBackPro_Click);
            // 
            // gbProfile
            // 
            this.gbProfile.Controls.Add(this.btnShow);
            this.gbProfile.Controls.Add(this.lblStudID);
            this.gbProfile.Controls.Add(this.lblsid);
            this.gbProfile.Controls.Add(this.lblGenderPro);
            this.gbProfile.Controls.Add(this.lblNamePro);
            this.gbProfile.Controls.Add(this.txtNewaddress);
            this.gbProfile.Controls.Add(this.lbladdr);
            this.gbProfile.Controls.Add(this.lblGender);
            this.gbProfile.Controls.Add(this.lblName);
            this.gbProfile.Controls.Add(this.btnExitProfile);
            this.gbProfile.Controls.Add(this.txtPhonePro);
            this.gbProfile.Controls.Add(this.txtEmailPro);
            this.gbProfile.Controls.Add(this.lblCno);
            this.gbProfile.Controls.Add(this.lblEmail);
            this.gbProfile.Controls.Add(this.txtNewpassPro);
            this.gbProfile.Controls.Add(this.btnUpdate);
            this.gbProfile.Controls.Add(this.lblPass);
            this.gbProfile.Location = new System.Drawing.Point(223, 85);
            this.gbProfile.Name = "gbProfile";
            this.gbProfile.Size = new System.Drawing.Size(928, 575);
            this.gbProfile.TabIndex = 1;
            this.gbProfile.TabStop = false;
            this.gbProfile.Text = "Edit Profile :";
            this.gbProfile.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(839, 140);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(70, 30);
            this.btnShow.TabIndex = 48;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblStudID
            // 
            this.lblStudID.AutoSize = true;
            this.lblStudID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStudID.Location = new System.Drawing.Point(635, 92);
            this.lblStudID.Name = "lblStudID";
            this.lblStudID.Size = new System.Drawing.Size(2, 22);
            this.lblStudID.TabIndex = 47;
            // 
            // lblsid
            // 
            this.lblsid.AutoSize = true;
            this.lblsid.Location = new System.Drawing.Point(486, 92);
            this.lblsid.Name = "lblsid";
            this.lblsid.Size = new System.Drawing.Size(91, 20);
            this.lblsid.TabIndex = 46;
            this.lblsid.Text = "StudentID :";
            // 
            // lblGenderPro
            // 
            this.lblGenderPro.AutoSize = true;
            this.lblGenderPro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGenderPro.Location = new System.Drawing.Point(218, 140);
            this.lblGenderPro.Name = "lblGenderPro";
            this.lblGenderPro.Size = new System.Drawing.Size(2, 22);
            this.lblGenderPro.TabIndex = 43;
            // 
            // lblNamePro
            // 
            this.lblNamePro.AutoSize = true;
            this.lblNamePro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNamePro.Location = new System.Drawing.Point(218, 90);
            this.lblNamePro.Name = "lblNamePro";
            this.lblNamePro.Size = new System.Drawing.Size(2, 22);
            this.lblNamePro.TabIndex = 42;
            this.lblNamePro.Click += new System.EventHandler(this.lblNamePro_Click);
            // 
            // txtNewaddress
            // 
            this.txtNewaddress.Location = new System.Drawing.Point(218, 288);
            this.txtNewaddress.Name = "txtNewaddress";
            this.txtNewaddress.Size = new System.Drawing.Size(246, 26);
            this.txtNewaddress.TabIndex = 3;
            // 
            // lbladdr
            // 
            this.lbladdr.AutoSize = true;
            this.lbladdr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdr.Location = new System.Drawing.Point(84, 288);
            this.lbladdr.Name = "lbladdr";
            this.lbladdr.Size = new System.Drawing.Size(76, 20);
            this.lbladdr.TabIndex = 39;
            this.lbladdr.Text = "Address :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(92, 140);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(71, 20);
            this.lblGender.TabIndex = 30;
            this.lblGender.Text = "Gender :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(104, 92);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 20);
            this.lblName.TabIndex = 29;
            this.lblName.Text = "Name :";
            // 
            // btnExitProfile
            // 
            this.btnExitProfile.Location = new System.Drawing.Point(221, 377);
            this.btnExitProfile.Name = "btnExitProfile";
            this.btnExitProfile.Size = new System.Drawing.Size(116, 52);
            this.btnExitProfile.TabIndex = 6;
            this.btnExitProfile.Text = "Clear";
            this.btnExitProfile.UseVisualStyleBackColor = true;
            this.btnExitProfile.Click += new System.EventHandler(this.btnExitProfile_Click_1);
            // 
            // txtPhonePro
            // 
            this.txtPhonePro.Location = new System.Drawing.Point(218, 239);
            this.txtPhonePro.Name = "txtPhonePro";
            this.txtPhonePro.Size = new System.Drawing.Size(246, 26);
            this.txtPhonePro.TabIndex = 2;
            // 
            // txtEmailPro
            // 
            this.txtEmailPro.Location = new System.Drawing.Point(218, 188);
            this.txtEmailPro.Name = "txtEmailPro";
            this.txtEmailPro.Size = new System.Drawing.Size(246, 26);
            this.txtEmailPro.TabIndex = 1;
            // 
            // lblCno
            // 
            this.lblCno.AutoSize = true;
            this.lblCno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCno.Location = new System.Drawing.Point(31, 242);
            this.lblCno.Name = "lblCno";
            this.lblCno.Size = new System.Drawing.Size(133, 20);
            this.lblCno.TabIndex = 25;
            this.lblCno.Text = "Contact Number :";
            this.lblCno.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(108, 190);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 20);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "Email :";
            // 
            // txtNewpassPro
            // 
            this.txtNewpassPro.Location = new System.Drawing.Point(635, 140);
            this.txtNewpassPro.Name = "txtNewpassPro";
            this.txtNewpassPro.PasswordChar = '*';
            this.txtNewpassPro.Size = new System.Drawing.Size(185, 26);
            this.txtNewpassPro.TabIndex = 4;
            this.txtNewpassPro.TextChanged += new System.EventHandler(this.txtNewpassPro_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(443, 377);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 52);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnEditP_Click_1);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(487, 140);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(86, 20);
            this.lblPass.TabIndex = 17;
            this.lblPass.Text = "Password :";
            // 
            // lblUserPP
            // 
            this.lblUserPP.AutoSize = true;
            this.lblUserPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserPP.Location = new System.Drawing.Point(494, 24);
            this.lblUserPP.Name = "lblUserPP";
            this.lblUserPP.Size = new System.Drawing.Size(195, 37);
            this.lblUserPP.TabIndex = 31;
            this.lblUserPP.Text = "User Profile";
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.gbProfile);
            this.Controls.Add(this.lblUserPP);
            this.Controls.Add(this.btnBackPro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmProfile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.frmProfile_Load);
            this.gbProfile.ResumeLayout(false);
            this.gbProfile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBackPro;
        private System.Windows.Forms.GroupBox gbProfile;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnExitProfile;
        private System.Windows.Forms.TextBox txtPhonePro;
        private System.Windows.Forms.TextBox txtEmailPro;
        private System.Windows.Forms.Label lblCno;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNewpassPro;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUserPP;
        private System.Windows.Forms.Label lbladdr;
        private System.Windows.Forms.TextBox txtNewaddress;
        private System.Windows.Forms.Label lblGenderPro;
        private System.Windows.Forms.Label lblNamePro;
        private System.Windows.Forms.Label lblStudID;
        private System.Windows.Forms.Label lblsid;
        private System.Windows.Forms.Button btnShow;
    }
}