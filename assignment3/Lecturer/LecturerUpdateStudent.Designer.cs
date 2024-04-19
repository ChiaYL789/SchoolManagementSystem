namespace asmt5._0
{
    partial class LecturerUpdateStudent
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
            this.studentlisttitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.student_listbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.studentlist_dgv = new System.Windows.Forms.DataGridView();
            this.back_btn = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.newschedule_cb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newmodule_cb = new System.Windows.Forms.ComboBox();
            this.module_cb = new System.Windows.Forms.ComboBox();
            this.newmodule_lb = new System.Windows.Forms.Label();
            this.newlevel_lb = new System.Windows.Forms.Label();
            this.moduleEdit_lb = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.newlevel_cb = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentlist_dgv)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentlisttitle
            // 
            this.studentlisttitle.AutoSize = true;
            this.studentlisttitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentlisttitle.Location = new System.Drawing.Point(221, 23);
            this.studentlisttitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentlisttitle.Name = "studentlisttitle";
            this.studentlisttitle.Size = new System.Drawing.Size(153, 24);
            this.studentlisttitle.TabIndex = 42;
            this.studentlisttitle.Text = "Update Student";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delete_btn);
            this.groupBox1.Controls.Add(this.student_listbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 61);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(349, 237);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student: ";
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(191, 204);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(2);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(92, 21);
            this.delete_btn.TabIndex = 49;
            this.delete_btn.Text = "Delete Student";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // student_listbox
            // 
            this.student_listbox.FormattingEnabled = true;
            this.student_listbox.Location = new System.Drawing.Point(165, 30);
            this.student_listbox.Margin = new System.Windows.Forms.Padding(2);
            this.student_listbox.Name = "student_listbox";
            this.student_listbox.Size = new System.Drawing.Size(132, 160);
            this.student_listbox.TabIndex = 1;
            this.student_listbox.SelectedIndexChanged += new System.EventHandler(this.student_listbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a student to edit:";
            // 
            // studentlist_dgv
            // 
            this.studentlist_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentlist_dgv.Location = new System.Drawing.Point(16, 314);
            this.studentlist_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.studentlist_dgv.Name = "studentlist_dgv";
            this.studentlist_dgv.RowHeadersWidth = 51;
            this.studentlist_dgv.RowTemplate.Height = 24;
            this.studentlist_dgv.Size = new System.Drawing.Size(629, 153);
            this.studentlist_dgv.TabIndex = 2;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(9, 11);
            this.back_btn.Margin = new System.Windows.Forms.Padding(2);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(62, 29);
            this.back_btn.TabIndex = 53;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.newschedule_cb);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.newmodule_cb);
            this.groupBox7.Controls.Add(this.module_cb);
            this.groupBox7.Controls.Add(this.newmodule_lb);
            this.groupBox7.Controls.Add(this.newlevel_lb);
            this.groupBox7.Controls.Add(this.moduleEdit_lb);
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Controls.Add(this.save_btn);
            this.groupBox7.Controls.Add(this.newlevel_cb);
            this.groupBox7.Location = new System.Drawing.Point(373, 61);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(272, 237);
            this.groupBox7.TabIndex = 54;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Select module to update:";
            // 
            // newschedule_cb
            // 
            this.newschedule_cb.FormattingEnabled = true;
            this.newschedule_cb.Location = new System.Drawing.Point(107, 154);
            this.newschedule_cb.Margin = new System.Windows.Forms.Padding(2);
            this.newschedule_cb.Name = "newschedule_cb";
            this.newschedule_cb.Size = new System.Drawing.Size(138, 21);
            this.newschedule_cb.TabIndex = 48;
            this.newschedule_cb.SelectedIndexChanged += new System.EventHandler(this.newschedule_cb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Schedule:";
            // 
            // newmodule_cb
            // 
            this.newmodule_cb.FormattingEnabled = true;
            this.newmodule_cb.Items.AddRange(new object[] {
            "Python",
            "IOOP",
            "C-Programming",
            "JAVA"});
            this.newmodule_cb.Location = new System.Drawing.Point(107, 87);
            this.newmodule_cb.Margin = new System.Windows.Forms.Padding(2);
            this.newmodule_cb.Name = "newmodule_cb";
            this.newmodule_cb.Size = new System.Drawing.Size(138, 21);
            this.newmodule_cb.TabIndex = 46;
            this.newmodule_cb.SelectedIndexChanged += new System.EventHandler(this.newmodule_cb_SelectedIndexChanged);
            // 
            // module_cb
            // 
            this.module_cb.FormattingEnabled = true;
            this.module_cb.Location = new System.Drawing.Point(107, 27);
            this.module_cb.Margin = new System.Windows.Forms.Padding(2);
            this.module_cb.Name = "module_cb";
            this.module_cb.Size = new System.Drawing.Size(138, 21);
            this.module_cb.TabIndex = 45;
            this.module_cb.SelectedIndexChanged += new System.EventHandler(this.module_cb_SelectedIndexChanged);
            // 
            // newmodule_lb
            // 
            this.newmodule_lb.AutoSize = true;
            this.newmodule_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newmodule_lb.Location = new System.Drawing.Point(19, 90);
            this.newmodule_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newmodule_lb.Name = "newmodule_lb";
            this.newmodule_lb.Size = new System.Drawing.Size(89, 17);
            this.newmodule_lb.TabIndex = 46;
            this.newmodule_lb.Text = "New Module:";
            // 
            // newlevel_lb
            // 
            this.newlevel_lb.AutoSize = true;
            this.newlevel_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newlevel_lb.Location = new System.Drawing.Point(58, 124);
            this.newlevel_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newlevel_lb.Name = "newlevel_lb";
            this.newlevel_lb.Size = new System.Drawing.Size(46, 17);
            this.newlevel_lb.TabIndex = 33;
            this.newlevel_lb.Text = "Level:";
            // 
            // moduleEdit_lb
            // 
            this.moduleEdit_lb.AutoSize = true;
            this.moduleEdit_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduleEdit_lb.Location = new System.Drawing.Point(47, 30);
            this.moduleEdit_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moduleEdit_lb.Name = "moduleEdit_lb";
            this.moduleEdit_lb.Size = new System.Drawing.Size(58, 17);
            this.moduleEdit_lb.TabIndex = 35;
            this.moduleEdit_lb.Text = "Module:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 204);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 21);
            this.button1.TabIndex = 39;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(20, 204);
            this.save_btn.Margin = new System.Windows.Forms.Padding(2);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(121, 21);
            this.save_btn.TabIndex = 18;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // newlevel_cb
            // 
            this.newlevel_cb.FormattingEnabled = true;
            this.newlevel_cb.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advance"});
            this.newlevel_cb.Location = new System.Drawing.Point(107, 124);
            this.newlevel_cb.Margin = new System.Windows.Forms.Padding(2);
            this.newlevel_cb.Name = "newlevel_cb";
            this.newlevel_cb.Size = new System.Drawing.Size(138, 21);
            this.newlevel_cb.TabIndex = 46;
            this.newlevel_cb.SelectedIndexChanged += new System.EventHandler(this.newlevel_cb_SelectedIndexChanged);
            // 
            // LecturerUpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(689, 492);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.studentlist_dgv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.studentlisttitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LecturerUpdateStudent";
            this.Text = "LecturerUpdateStudent";
            this.Load += new System.EventHandler(this.LecturerUpdateStudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentlist_dgv)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentlisttitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox student_listbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView studentlist_dgv;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox newschedule_cb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox newmodule_cb;
        private System.Windows.Forms.ComboBox module_cb;
        private System.Windows.Forms.Label newmodule_lb;
        private System.Windows.Forms.Label newlevel_lb;
        private System.Windows.Forms.Label moduleEdit_lb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.ComboBox newlevel_cb;
    }
}