namespace asmt5._0
{
    partial class frmLecturerHome
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
            this.role_lb = new System.Windows.Forms.Label();
            this.welcome_lb = new System.Windows.Forms.Label();
            this.currentposition_lb = new System.Windows.Forms.Label();
            this.name_lb = new System.Windows.Forms.Label();
            this.home_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.register_btn = new System.Windows.Forms.Button();
            this.request_btn = new System.Windows.Forms.Button();
            this.list_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.profile_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // role_lb
            // 
            this.role_lb.AutoSize = true;
            this.role_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role_lb.Location = new System.Drawing.Point(211, 281);
            this.role_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.role_lb.Name = "role_lb";
            this.role_lb.Size = new System.Drawing.Size(24, 13);
            this.role_lb.TabIndex = 49;
            this.role_lb.Text = "(ID)";
            this.role_lb.Click += new System.EventHandler(this.role_lb_Click);
            // 
            // welcome_lb
            // 
            this.welcome_lb.AutoSize = true;
            this.welcome_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_lb.Location = new System.Drawing.Point(103, 97);
            this.welcome_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcome_lb.Name = "welcome_lb";
            this.welcome_lb.Size = new System.Drawing.Size(122, 24);
            this.welcome_lb.TabIndex = 46;
            this.welcome_lb.Text = "Welcome !!!";
            // 
            // currentposition_lb
            // 
            this.currentposition_lb.AutoSize = true;
            this.currentposition_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentposition_lb.Location = new System.Drawing.Point(70, 281);
            this.currentposition_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentposition_lb.Name = "currentposition_lb";
            this.currentposition_lb.Size = new System.Drawing.Size(87, 13);
            this.currentposition_lb.TabIndex = 48;
            this.currentposition_lb.Text = "Current Position: ";
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lb.Location = new System.Drawing.Point(127, 130);
            this.name_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name_lb.Name = "name_lb";
            this.name_lb.Size = new System.Drawing.Size(65, 20);
            this.name_lb.TabIndex = 47;
            this.name_lb.Text = "(NAME)";
            this.name_lb.Click += new System.EventHandler(this.name_lb_Click);
            // 
            // home_btn
            // 
            this.home_btn.Location = new System.Drawing.Point(9, 10);
            this.home_btn.Margin = new System.Windows.Forms.Padding(2);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(63, 30);
            this.home_btn.TabIndex = 45;
            this.home_btn.Text = "Log Out";
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.register_btn);
            this.groupBox1.Controls.Add(this.request_btn);
            this.groupBox1.Controls.Add(this.list_btn);
            this.groupBox1.Controls.Add(this.delete_btn);
            this.groupBox1.Controls.Add(this.profile_btn);
            this.groupBox1.Location = new System.Drawing.Point(358, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(150, 309);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navigation Bar";
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(25, 23);
            this.register_btn.Margin = new System.Windows.Forms.Padding(2);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(104, 48);
            this.register_btn.TabIndex = 34;
            this.register_btn.Text = "Registration";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // request_btn
            // 
            this.request_btn.Location = new System.Drawing.Point(25, 77);
            this.request_btn.Margin = new System.Windows.Forms.Padding(2);
            this.request_btn.Name = "request_btn";
            this.request_btn.Size = new System.Drawing.Size(104, 48);
            this.request_btn.TabIndex = 29;
            this.request_btn.Text = "Enrollment";
            this.request_btn.UseVisualStyleBackColor = true;
            this.request_btn.Click += new System.EventHandler(this.request_btn_Click);
            // 
            // list_btn
            // 
            this.list_btn.Location = new System.Drawing.Point(25, 130);
            this.list_btn.Margin = new System.Windows.Forms.Padding(2);
            this.list_btn.Name = "list_btn";
            this.list_btn.Size = new System.Drawing.Size(104, 48);
            this.list_btn.TabIndex = 30;
            this.list_btn.Text = "Student List\r\n";
            this.list_btn.UseVisualStyleBackColor = true;
            this.list_btn.Click += new System.EventHandler(this.list_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(25, 183);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(2);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(104, 48);
            this.delete_btn.TabIndex = 32;
            this.delete_btn.Text = "Update Student";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // profile_btn
            // 
            this.profile_btn.Location = new System.Drawing.Point(25, 236);
            this.profile_btn.Margin = new System.Windows.Forms.Padding(2);
            this.profile_btn.Name = "profile_btn";
            this.profile_btn.Size = new System.Drawing.Size(104, 48);
            this.profile_btn.TabIndex = 33;
            this.profile_btn.Text = "User Profile";
            this.profile_btn.UseVisualStyleBackColor = true;
            this.profile_btn.Click += new System.EventHandler(this.profile_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 281);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Lecturer/";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmLecturerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(600, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.role_lb);
            this.Controls.Add(this.welcome_lb);
            this.Controls.Add(this.currentposition_lb);
            this.Controls.Add(this.name_lb);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLecturerHome";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LecturerHome_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label role_lb;
        private System.Windows.Forms.Label welcome_lb;
        private System.Windows.Forms.Label currentposition_lb;
        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button request_btn;
        private System.Windows.Forms.Button list_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button profile_btn;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Label label1;
    }
}

