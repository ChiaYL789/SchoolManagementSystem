namespace ASSIGNMENT
{
    partial class frmStudentHome
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
            this.btnLoutHP = new System.Windows.Forms.Button();
            this.btnProfileTT = new System.Windows.Forms.Button();
            this.btnEnrollTT = new System.Windows.Forms.Button();
            this.btnPayTT = new System.Windows.Forms.Button();
            this.btnTimeTT = new System.Windows.Forms.Button();
            this.lblStudname = new System.Windows.Forms.Label();
            this.gbHome = new System.Windows.Forms.GroupBox();
            this.lblWelc = new System.Windows.Forms.Label();
            this.lblHomeshow = new System.Windows.Forms.Label();
            this.gbHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoutHP
            // 
            this.btnLoutHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoutHP.Location = new System.Drawing.Point(12, 12);
            this.btnLoutHP.Name = "btnLoutHP";
            this.btnLoutHP.Size = new System.Drawing.Size(149, 46);
            this.btnLoutHP.TabIndex = 10;
            this.btnLoutHP.Text = "Log Out";
            this.btnLoutHP.UseVisualStyleBackColor = true;
            this.btnLoutHP.Click += new System.EventHandler(this.btnLoutHP_Click);
            // 
            // btnProfileTT
            // 
            this.btnProfileTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfileTT.Location = new System.Drawing.Point(118, 402);
            this.btnProfileTT.Name = "btnProfileTT";
            this.btnProfileTT.Size = new System.Drawing.Size(207, 84);
            this.btnProfileTT.TabIndex = 4;
            this.btnProfileTT.Text = "Update/Edit Profile";
            this.btnProfileTT.UseVisualStyleBackColor = true;
            this.btnProfileTT.Click += new System.EventHandler(this.btnProfileTT_Click);
            // 
            // btnEnrollTT
            // 
            this.btnEnrollTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnrollTT.Location = new System.Drawing.Point(118, 167);
            this.btnEnrollTT.Name = "btnEnrollTT";
            this.btnEnrollTT.Size = new System.Drawing.Size(207, 84);
            this.btnEnrollTT.TabIndex = 2;
            this.btnEnrollTT.Text = "Enrollment";
            this.btnEnrollTT.UseVisualStyleBackColor = true;
            this.btnEnrollTT.Click += new System.EventHandler(this.btnEnrollTT_Click);
            // 
            // btnPayTT
            // 
            this.btnPayTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayTT.Location = new System.Drawing.Point(118, 288);
            this.btnPayTT.Name = "btnPayTT";
            this.btnPayTT.Size = new System.Drawing.Size(207, 84);
            this.btnPayTT.TabIndex = 3;
            this.btnPayTT.Text = "Payment";
            this.btnPayTT.UseVisualStyleBackColor = true;
            this.btnPayTT.Click += new System.EventHandler(this.btnPayTT_Click);
            // 
            // btnTimeTT
            // 
            this.btnTimeTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeTT.Location = new System.Drawing.Point(118, 57);
            this.btnTimeTT.Name = "btnTimeTT";
            this.btnTimeTT.Size = new System.Drawing.Size(207, 84);
            this.btnTimeTT.TabIndex = 1;
            this.btnTimeTT.Text = "Timetable";
            this.btnTimeTT.UseVisualStyleBackColor = true;
            this.btnTimeTT.Click += new System.EventHandler(this.btnTimeTT_Click);
            // 
            // lblStudname
            // 
            this.lblStudname.AutoSize = true;
            this.lblStudname.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudname.Location = new System.Drawing.Point(293, 267);
            this.lblStudname.Name = "lblStudname";
            this.lblStudname.Size = new System.Drawing.Size(0, 31);
            this.lblStudname.TabIndex = 20;
            // 
            // gbHome
            // 
            this.gbHome.Controls.Add(this.btnProfileTT);
            this.gbHome.Controls.Add(this.btnEnrollTT);
            this.gbHome.Controls.Add(this.btnPayTT);
            this.gbHome.Controls.Add(this.btnTimeTT);
            this.gbHome.Location = new System.Drawing.Point(679, 54);
            this.gbHome.Name = "gbHome";
            this.gbHome.Size = new System.Drawing.Size(444, 557);
            this.gbHome.TabIndex = 1;
            this.gbHome.TabStop = false;
            // 
            // lblWelc
            // 
            this.lblWelc.AutoSize = true;
            this.lblWelc.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelc.Location = new System.Drawing.Point(227, 180);
            this.lblWelc.Name = "lblWelc";
            this.lblWelc.Size = new System.Drawing.Size(209, 44);
            this.lblWelc.TabIndex = 22;
            this.lblWelc.Text = "Welcome !";
            // 
            // lblHomeshow
            // 
            this.lblHomeshow.AutoSize = true;
            this.lblHomeshow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHomeshow.Location = new System.Drawing.Point(158, 574);
            this.lblHomeshow.Name = "lblHomeshow";
            this.lblHomeshow.Size = new System.Drawing.Size(2, 22);
            this.lblHomeshow.TabIndex = 23;
            // 
            // frmStudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.lblHomeshow);
            this.Controls.Add(this.lblWelc);
            this.Controls.Add(this.gbHome);
            this.Controls.Add(this.lblStudname);
            this.Controls.Add(this.btnLoutHP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmStudentHome";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.gbHome.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLoutHP;
        private System.Windows.Forms.Button btnProfileTT;
        private System.Windows.Forms.Button btnEnrollTT;
        private System.Windows.Forms.Button btnPayTT;
        private System.Windows.Forms.Button btnTimeTT;
        private System.Windows.Forms.Label lblStudname;
        private System.Windows.Forms.GroupBox gbHome;
        private System.Windows.Forms.Label lblWelc;
        private System.Windows.Forms.Label lblHomeshow;
    }
}