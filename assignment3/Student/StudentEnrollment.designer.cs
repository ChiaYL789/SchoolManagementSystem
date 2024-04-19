namespace ASSIGNMENT
{
    partial class frmEnroll
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
            this.btnBackEn = new System.Windows.Forms.Button();
            this.gbEnroll = new System.Windows.Forms.GroupBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.cbLvlEn = new System.Windows.Forms.ComboBox();
            this.cbModuleEn = new System.Windows.Forms.ComboBox();
            this.lblMlvl = new System.Windows.Forms.Label();
            this.lblModule = new System.Windows.Forms.Label();
            this.cbScheduleEn = new System.Windows.Forms.ComboBox();
            this.lblSch = new System.Windows.Forms.Label();
            this.btnDltReqEN = new System.Windows.Forms.Button();
            this.btnSubmitEn = new System.Windows.Forms.Button();
            this.lblEnroll = new System.Windows.Forms.Label();
            this.pnlEnroll = new System.Windows.Forms.Panel();
            this.gbEnroll.SuspendLayout();
            this.pnlEnroll.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackEn
            // 
            this.btnBackEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackEn.Location = new System.Drawing.Point(12, 12);
            this.btnBackEn.Name = "btnBackEn";
            this.btnBackEn.Size = new System.Drawing.Size(92, 40);
            this.btnBackEn.TabIndex = 1;
            this.btnBackEn.Text = "Back";
            this.btnBackEn.UseVisualStyleBackColor = true;
            this.btnBackEn.Click += new System.EventHandler(this.btnBackEn_Click);
            // 
            // gbEnroll
            // 
            this.gbEnroll.Controls.Add(this.btnCheck);
            this.gbEnroll.Controls.Add(this.cbLvlEn);
            this.gbEnroll.Controls.Add(this.cbModuleEn);
            this.gbEnroll.Controls.Add(this.lblMlvl);
            this.gbEnroll.Controls.Add(this.lblModule);
            this.gbEnroll.Location = new System.Drawing.Point(200, 65);
            this.gbEnroll.Name = "gbEnroll";
            this.gbEnroll.Size = new System.Drawing.Size(905, 194);
            this.gbEnroll.TabIndex = 31;
            this.gbEnroll.TabStop = false;
            this.gbEnroll.Text = "Enrollment : ";
            this.gbEnroll.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(718, 84);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(148, 54);
            this.btnCheck.TabIndex = 28;
            this.btnCheck.Text = "Check Availability";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbLvlEn
            // 
            this.cbLvlEn.FormattingEnabled = true;
            this.cbLvlEn.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advance"});
            this.cbLvlEn.Location = new System.Drawing.Point(257, 130);
            this.cbLvlEn.Name = "cbLvlEn";
            this.cbLvlEn.Size = new System.Drawing.Size(410, 28);
            this.cbLvlEn.TabIndex = 27;
            this.cbLvlEn.SelectedIndexChanged += new System.EventHandler(this.cbLvlEn_SelectedIndexChanged);
            // 
            // cbModuleEn
            // 
            this.cbModuleEn.FormattingEnabled = true;
            this.cbModuleEn.Location = new System.Drawing.Point(257, 57);
            this.cbModuleEn.Name = "cbModuleEn";
            this.cbModuleEn.Size = new System.Drawing.Size(410, 28);
            this.cbModuleEn.TabIndex = 26;
            this.cbModuleEn.SelectedIndexChanged += new System.EventHandler(this.cbModuleEn_SelectedIndexChanged);
            // 
            // lblMlvl
            // 
            this.lblMlvl.AutoSize = true;
            this.lblMlvl.Location = new System.Drawing.Point(156, 133);
            this.lblMlvl.Name = "lblMlvl";
            this.lblMlvl.Size = new System.Drawing.Size(58, 20);
            this.lblMlvl.TabIndex = 10;
            this.lblMlvl.Text = "Level : ";
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Location = new System.Drawing.Point(138, 57);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(73, 20);
            this.lblModule.TabIndex = 9;
            this.lblModule.Text = "Module : ";
            // 
            // cbScheduleEn
            // 
            this.cbScheduleEn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbScheduleEn.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbScheduleEn.FormattingEnabled = true;
            this.cbScheduleEn.Location = new System.Drawing.Point(243, 41);
            this.cbScheduleEn.Name = "cbScheduleEn";
            this.cbScheduleEn.Size = new System.Drawing.Size(422, 28);
            this.cbScheduleEn.TabIndex = 32;
            this.cbScheduleEn.SelectedIndexChanged += new System.EventHandler(this.cbScheduleEn_SelectedIndexChanged);
            // 
            // lblSch
            // 
            this.lblSch.AutoSize = true;
            this.lblSch.Location = new System.Drawing.Point(121, 41);
            this.lblSch.Name = "lblSch";
            this.lblSch.Size = new System.Drawing.Size(88, 20);
            this.lblSch.TabIndex = 31;
            this.lblSch.Text = "Schedule : ";
            this.lblSch.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnDltReqEN
            // 
            this.btnDltReqEN.Location = new System.Drawing.Point(507, 107);
            this.btnDltReqEN.Name = "btnDltReqEN";
            this.btnDltReqEN.Size = new System.Drawing.Size(114, 94);
            this.btnDltReqEN.TabIndex = 30;
            this.btnDltReqEN.Text = "Delete Pending Request";
            this.btnDltReqEN.UseVisualStyleBackColor = true;
            this.btnDltReqEN.Click += new System.EventHandler(this.btnDltReqEN_Click);
            // 
            // btnSubmitEn
            // 
            this.btnSubmitEn.Location = new System.Drawing.Point(270, 107);
            this.btnSubmitEn.Name = "btnSubmitEn";
            this.btnSubmitEn.Size = new System.Drawing.Size(119, 94);
            this.btnSubmitEn.TabIndex = 29;
            this.btnSubmitEn.Text = "Submit";
            this.btnSubmitEn.UseVisualStyleBackColor = true;
            this.btnSubmitEn.Click += new System.EventHandler(this.btnSubmitEn_Click);
            // 
            // lblEnroll
            // 
            this.lblEnroll.AutoSize = true;
            this.lblEnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnroll.Location = new System.Drawing.Point(465, 16);
            this.lblEnroll.Name = "lblEnroll";
            this.lblEnroll.Size = new System.Drawing.Size(310, 37);
            this.lblEnroll.TabIndex = 27;
            this.lblEnroll.Text = "Classes Enrollment";
            // 
            // pnlEnroll
            // 
            this.pnlEnroll.Controls.Add(this.lblSch);
            this.pnlEnroll.Controls.Add(this.btnDltReqEN);
            this.pnlEnroll.Controls.Add(this.btnSubmitEn);
            this.pnlEnroll.Controls.Add(this.cbScheduleEn);
            this.pnlEnroll.Location = new System.Drawing.Point(202, 288);
            this.pnlEnroll.Name = "pnlEnroll";
            this.pnlEnroll.Size = new System.Drawing.Size(920, 249);
            this.pnlEnroll.TabIndex = 33;
            // 
            // frmEnroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.pnlEnroll);
            this.Controls.Add(this.gbEnroll);
            this.Controls.Add(this.lblEnroll);
            this.Controls.Add(this.btnBackEn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEnroll";
            this.Text = "Enrollment";
            this.Load += new System.EventHandler(this.frmEnroll_Load);
            this.gbEnroll.ResumeLayout(false);
            this.gbEnroll.PerformLayout();
            this.pnlEnroll.ResumeLayout(false);
            this.pnlEnroll.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBackEn;
        private System.Windows.Forms.GroupBox gbEnroll;
        private System.Windows.Forms.ComboBox cbLvlEn;
        private System.Windows.Forms.ComboBox cbModuleEn;
        private System.Windows.Forms.Label lblMlvl;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.Button btnDltReqEN;
        private System.Windows.Forms.Button btnSubmitEn;
        private System.Windows.Forms.Label lblEnroll;
        private System.Windows.Forms.Label lblSch;
        private System.Windows.Forms.ComboBox cbScheduleEn;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Panel pnlEnroll;
    }
}