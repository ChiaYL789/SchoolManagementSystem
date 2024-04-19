namespace asmt5._0
{
    partial class LecturerEnrollment
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
            this.RequestTitle = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.schedule_cb = new System.Windows.Forms.ComboBox();
            this.level_cb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.student_cb = new System.Windows.Forms.ComboBox();
            this.enroll_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.module_cb = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RequestTitle
            // 
            this.RequestTitle.AutoSize = true;
            this.RequestTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestTitle.Location = new System.Drawing.Point(249, 21);
            this.RequestTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RequestTitle.Name = "RequestTitle";
            this.RequestTitle.Size = new System.Drawing.Size(111, 24);
            this.RequestTitle.TabIndex = 48;
            this.RequestTitle.Text = "Enrollment";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(17, 12);
            this.back_btn.Margin = new System.Windows.Forms.Padding(2);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(62, 29);
            this.back_btn.TabIndex = 52;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.schedule_cb);
            this.groupBox1.Controls.Add(this.level_cb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.student_cb);
            this.groupBox1.Controls.Add(this.enroll_btn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.module_cb);
            this.groupBox1.Location = new System.Drawing.Point(106, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 325);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Assigned Module to Student";
            // 
            // schedule_cb
            // 
            this.schedule_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.schedule_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedule_cb.FormattingEnabled = true;
            this.schedule_cb.Location = new System.Drawing.Point(140, 163);
            this.schedule_cb.Name = "schedule_cb";
            this.schedule_cb.Size = new System.Drawing.Size(286, 24);
            this.schedule_cb.TabIndex = 21;
            // 
            // level_cb
            // 
            this.level_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.level_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level_cb.FormattingEnabled = true;
            this.level_cb.Location = new System.Drawing.Point(140, 128);
            this.level_cb.Name = "level_cb";
            this.level_cb.Size = new System.Drawing.Size(286, 24);
            this.level_cb.TabIndex = 20;
            this.level_cb.SelectedIndexChanged += new System.EventHandler(this.level_cb_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Schedule :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Level :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student ID :";
            // 
            // student_cb
            // 
            this.student_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_cb.FormattingEnabled = true;
            this.student_cb.Location = new System.Drawing.Point(140, 43);
            this.student_cb.Name = "student_cb";
            this.student_cb.Size = new System.Drawing.Size(286, 24);
            this.student_cb.TabIndex = 2;
            this.student_cb.SelectedIndexChanged += new System.EventHandler(this.student_cb_SelectedIndexChanged);
            // 
            // enroll_btn
            // 
            this.enroll_btn.Location = new System.Drawing.Point(158, 203);
            this.enroll_btn.Name = "enroll_btn";
            this.enroll_btn.Size = new System.Drawing.Size(76, 32);
            this.enroll_btn.TabIndex = 10;
            this.enroll_btn.Text = "Enroll";
            this.enroll_btn.UseVisualStyleBackColor = true;
            this.enroll_btn.Click += new System.EventHandler(this.enroll_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Class ID :";
            // 
            // module_cb
            // 
            this.module_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.module_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.module_cb.FormattingEnabled = true;
            this.module_cb.Location = new System.Drawing.Point(140, 88);
            this.module_cb.Name = "module_cb";
            this.module_cb.Size = new System.Drawing.Size(286, 24);
            this.module_cb.TabIndex = 10;
            this.module_cb.SelectedIndexChanged += new System.EventHandler(this.module_cb_SelectedIndexChanged);
            // 
            // LecturerEnrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(613, 408);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RequestTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LecturerEnrollment";
            this.Text = "LecturerRequest";
            this.Load += new System.EventHandler(this.LecturerRequest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label RequestTitle;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox schedule_cb;
        private System.Windows.Forms.ComboBox level_cb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox student_cb;
        private System.Windows.Forms.Button enroll_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox module_cb;
    }
}