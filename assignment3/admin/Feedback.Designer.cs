namespace assignment3
{
    partial class frmFeedback
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
            this.cbTrainerID = new System.Windows.Forms.ComboBox();
            this.lblTrainerID = new System.Windows.Forms.Label();
            this.grpFeedback = new System.Windows.Forms.GroupBox();
            this.lblTrainerName = new System.Windows.Forms.Label();
            this.dgvFeedback = new System.Windows.Forms.DataGridView();
            this.btnback = new System.Windows.Forms.Button();
            this.grpFeedback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTrainerID
            // 
            this.cbTrainerID.FormattingEnabled = true;
            this.cbTrainerID.Location = new System.Drawing.Point(290, 59);
            this.cbTrainerID.Name = "cbTrainerID";
            this.cbTrainerID.Size = new System.Drawing.Size(124, 21);
            this.cbTrainerID.TabIndex = 2;
            this.cbTrainerID.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblTrainerID
            // 
            this.lblTrainerID.AutoSize = true;
            this.lblTrainerID.Location = new System.Drawing.Point(207, 62);
            this.lblTrainerID.Name = "lblTrainerID";
            this.lblTrainerID.Size = new System.Drawing.Size(67, 13);
            this.lblTrainerID.TabIndex = 4;
            this.lblTrainerID.Text = "Trainer\'s ID :";
            this.lblTrainerID.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpFeedback
            // 
            this.grpFeedback.Controls.Add(this.lblTrainerName);
            this.grpFeedback.Controls.Add(this.dgvFeedback);
            this.grpFeedback.Controls.Add(this.cbTrainerID);
            this.grpFeedback.Controls.Add(this.lblTrainerID);
            this.grpFeedback.Location = new System.Drawing.Point(85, 73);
            this.grpFeedback.Name = "grpFeedback";
            this.grpFeedback.Size = new System.Drawing.Size(654, 365);
            this.grpFeedback.TabIndex = 7;
            this.grpFeedback.TabStop = false;
            this.grpFeedback.Text = "groupBox1";
            this.grpFeedback.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblTrainerName
            // 
            this.lblTrainerName.AutoSize = true;
            this.lblTrainerName.Location = new System.Drawing.Point(287, 99);
            this.lblTrainerName.Name = "lblTrainerName";
            this.lblTrainerName.Size = new System.Drawing.Size(44, 13);
            this.lblTrainerName.TabIndex = 8;
            this.lblTrainerName.Text = "(NAME)";
            // 
            // dgvFeedback
            // 
            this.dgvFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedback.Location = new System.Drawing.Point(54, 127);
            this.dgvFeedback.Name = "dgvFeedback";
            this.dgvFeedback.Size = new System.Drawing.Size(539, 179);
            this.dgvFeedback.TabIndex = 7;
            this.dgvFeedback.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(12, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(106, 34);
            this.btnback.TabIndex = 15;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpFeedback);
            this.Controls.Add(this.btnback);
            this.Name = "frmFeedback";
            this.Text = "Feedback";
            this.Load += new System.EventHandler(this.frmFeedback_Load);
            this.grpFeedback.ResumeLayout(false);
            this.grpFeedback.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbTrainerID;
        private System.Windows.Forms.Label lblTrainerID;
        private System.Windows.Forms.GroupBox grpFeedback;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DataGridView dgvFeedback;
        private System.Windows.Forms.Label lblTrainerName;
    }
}