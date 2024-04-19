namespace assignment3
{
    partial class frmAddCC
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
            this.grpAddCC = new System.Windows.Forms.GroupBox();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.lblclassID = new System.Windows.Forms.Label();
            this.cmbModuleLevel = new System.Windows.Forms.ComboBox();
            this.cmbModuleName = new System.Windows.Forms.ComboBox();
            this.cmbboxDay = new System.Windows.Forms.ComboBox();
            this.cmbboxTime = new System.Windows.Forms.ComboBox();
            this.txtCharge = new System.Windows.Forms.TextBox();
            this.lblModuleCharge = new System.Windows.Forms.Label();
            this.lblModuleLvl = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblModuleName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnAddClear = new System.Windows.Forms.Button();
            this.grpAddCC.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddCC
            // 
            this.grpAddCC.Controls.Add(this.txtClassID);
            this.grpAddCC.Controls.Add(this.lblclassID);
            this.grpAddCC.Controls.Add(this.cmbModuleLevel);
            this.grpAddCC.Controls.Add(this.cmbModuleName);
            this.grpAddCC.Controls.Add(this.cmbboxDay);
            this.grpAddCC.Controls.Add(this.cmbboxTime);
            this.grpAddCC.Controls.Add(this.txtCharge);
            this.grpAddCC.Controls.Add(this.lblModuleCharge);
            this.grpAddCC.Controls.Add(this.lblModuleLvl);
            this.grpAddCC.Controls.Add(this.lblTime);
            this.grpAddCC.Controls.Add(this.lblDay);
            this.grpAddCC.Controls.Add(this.lblModuleName);
            this.grpAddCC.Location = new System.Drawing.Point(92, 54);
            this.grpAddCC.Name = "grpAddCC";
            this.grpAddCC.Size = new System.Drawing.Size(707, 361);
            this.grpAddCC.TabIndex = 0;
            this.grpAddCC.TabStop = false;
            this.grpAddCC.Text = "New Coaching Class Details";
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(431, 129);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(171, 22);
            this.txtClassID.TabIndex = 23;
            this.txtClassID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblclassID
            // 
            this.lblclassID.AutoSize = true;
            this.lblclassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclassID.Location = new System.Drawing.Point(367, 129);
            this.lblclassID.Name = "lblclassID";
            this.lblclassID.Size = new System.Drawing.Size(58, 15);
            this.lblclassID.TabIndex = 22;
            this.lblclassID.Text = "Class ID :";
            this.lblclassID.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbModuleLevel
            // 
            this.cmbModuleLevel.FormattingEnabled = true;
            this.cmbModuleLevel.Location = new System.Drawing.Point(140, 126);
            this.cmbModuleLevel.Name = "cmbModuleLevel";
            this.cmbModuleLevel.Size = new System.Drawing.Size(168, 24);
            this.cmbModuleLevel.TabIndex = 21;
            // 
            // cmbModuleName
            // 
            this.cmbModuleName.FormattingEnabled = true;
            this.cmbModuleName.Items.AddRange(new object[] {
            "Python",
            "Java",
            "C-Programing",
            "IOOP"});
            this.cmbModuleName.Location = new System.Drawing.Point(140, 70);
            this.cmbModuleName.Name = "cmbModuleName";
            this.cmbModuleName.Size = new System.Drawing.Size(461, 24);
            this.cmbModuleName.TabIndex = 20;
            this.cmbModuleName.SelectedIndexChanged += new System.EventHandler(this.cmbModuleName_SelectedIndexChanged);
            // 
            // cmbboxDay
            // 
            this.cmbboxDay.FormattingEnabled = true;
            this.cmbboxDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.cmbboxDay.Location = new System.Drawing.Point(141, 238);
            this.cmbboxDay.Name = "cmbboxDay";
            this.cmbboxDay.Size = new System.Drawing.Size(167, 24);
            this.cmbboxDay.TabIndex = 19;
            // 
            // cmbboxTime
            // 
            this.cmbboxTime.FormattingEnabled = true;
            this.cmbboxTime.Items.AddRange(new object[] {
            "9:00AM to 11:30AM ",
            "1:00PM to 3:30PM",
            "4:30PM to 7:00PM",
            "7:30PM to 10:00PM "});
            this.cmbboxTime.Location = new System.Drawing.Point(431, 237);
            this.cmbboxTime.Name = "cmbboxTime";
            this.cmbboxTime.Size = new System.Drawing.Size(171, 24);
            this.cmbboxTime.TabIndex = 18;
            // 
            // txtCharge
            // 
            this.txtCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharge.Location = new System.Drawing.Point(171, 183);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Size = new System.Drawing.Size(105, 21);
            this.txtCharge.TabIndex = 17;
            // 
            // lblModuleCharge
            // 
            this.lblModuleCharge.AutoSize = true;
            this.lblModuleCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleCharge.Location = new System.Drawing.Point(39, 185);
            this.lblModuleCharge.Name = "lblModuleCharge";
            this.lblModuleCharge.Size = new System.Drawing.Size(126, 15);
            this.lblModuleCharge.TabIndex = 16;
            this.lblModuleCharge.Text = "Module Charge (RM):";
            // 
            // lblModuleLvl
            // 
            this.lblModuleLvl.AutoSize = true;
            this.lblModuleLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleLvl.Location = new System.Drawing.Point(39, 129);
            this.lblModuleLvl.Name = "lblModuleLvl";
            this.lblModuleLvl.Size = new System.Drawing.Size(84, 15);
            this.lblModuleLvl.TabIndex = 12;
            this.lblModuleLvl.Text = "Module Level:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(334, 240);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(91, 15);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Assigned Time:";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(40, 240);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(98, 15);
            this.lblDay.TabIndex = 8;
            this.lblDay.Text = "Assigned Day(s):";
            // 
            // lblModuleName
            // 
            this.lblModuleName.AutoSize = true;
            this.lblModuleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleName.Location = new System.Drawing.Point(40, 73);
            this.lblModuleName.Name = "lblModuleName";
            this.lblModuleName.Size = new System.Drawing.Size(89, 15);
            this.lblModuleName.TabIndex = 0;
            this.lblModuleName.Text = "Module Name:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 438);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(71, 37);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(728, 438);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(71, 37);
            this.btnAddNew.TabIndex = 8;
            this.btnAddNew.Text = "Add";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnAddClear
            // 
            this.btnAddClear.Location = new System.Drawing.Point(805, 438);
            this.btnAddClear.Name = "btnAddClear";
            this.btnAddClear.Size = new System.Drawing.Size(76, 37);
            this.btnAddClear.TabIndex = 12;
            this.btnAddClear.Text = "Clear All ";
            this.btnAddClear.UseVisualStyleBackColor = true;
            this.btnAddClear.Click += new System.EventHandler(this.btnAddClear_Click);
            // 
            // frmAddCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(893, 487);
            this.Controls.Add(this.btnAddClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.grpAddCC);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddCC";
            this.Text = "Add Coaching Class";
            this.Load += new System.EventHandler(this.frmAddCC_Load);
            this.grpAddCC.ResumeLayout(false);
            this.grpAddCC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddCC;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblModuleName;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnAddClear;
        private System.Windows.Forms.TextBox txtCharge;
        private System.Windows.Forms.Label lblModuleCharge;
        private System.Windows.Forms.Label lblModuleLvl;
        private System.Windows.Forms.ComboBox cmbboxTime;
        private System.Windows.Forms.ComboBox cmbboxDay;
        private System.Windows.Forms.ComboBox cmbModuleName;
        private System.Windows.Forms.ComboBox cmbModuleLevel;
        private System.Windows.Forms.Label lblclassID;
        private System.Windows.Forms.TextBox txtClassID;
    }
}