namespace asmt5._0
{
    partial class LecturerStudentList
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.selectModule_listbox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.studentlist_dgv = new System.Windows.Forms.DataGridView();
            this.studentlisttitle = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentlist_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.selectModule_listbox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(46, 54);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(281, 139);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Module: ";
            // 
            // selectModule_listbox
            // 
            this.selectModule_listbox.FormattingEnabled = true;
            this.selectModule_listbox.Items.AddRange(new object[] {
            "Python",
            "IOOP",
            "C-Programming",
            "JAVA"});
            this.selectModule_listbox.Location = new System.Drawing.Point(165, 30);
            this.selectModule_listbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectModule_listbox.Name = "selectModule_listbox";
            this.selectModule_listbox.Size = new System.Drawing.Size(103, 82);
            this.selectModule_listbox.TabIndex = 1;
            this.selectModule_listbox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select module to view list:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.studentlist_dgv);
            this.groupBox2.Location = new System.Drawing.Point(46, 211);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(668, 184);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student List ";
            // 
            // studentlist_dgv
            // 
            this.studentlist_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentlist_dgv.Location = new System.Drawing.Point(10, 20);
            this.studentlist_dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.studentlist_dgv.Name = "studentlist_dgv";
            this.studentlist_dgv.RowHeadersWidth = 51;
            this.studentlist_dgv.RowTemplate.Height = 24;
            this.studentlist_dgv.Size = new System.Drawing.Size(640, 151);
            this.studentlist_dgv.TabIndex = 0;
            // 
            // studentlisttitle
            // 
            this.studentlisttitle.AutoSize = true;
            this.studentlisttitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentlisttitle.Location = new System.Drawing.Point(289, 16);
            this.studentlisttitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentlisttitle.Name = "studentlisttitle";
            this.studentlisttitle.Size = new System.Drawing.Size(118, 24);
            this.studentlisttitle.TabIndex = 44;
            this.studentlisttitle.Text = "Student List";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(11, 11);
            this.back_btn.Margin = new System.Windows.Forms.Padding(2);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(62, 29);
            this.back_btn.TabIndex = 52;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // LecturerStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(759, 422);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.studentlisttitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LecturerStudentList";
            this.Text = "LecturerStudentList";
            this.Load += new System.EventHandler(this.LecturerStudentList_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentlist_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox selectModule_listbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView studentlist_dgv;
        private System.Windows.Forms.Label studentlisttitle;
        private System.Windows.Forms.Button back_btn;
    }
}