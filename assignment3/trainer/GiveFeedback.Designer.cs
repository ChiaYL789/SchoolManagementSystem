namespace assignment3
{
    partial class frmGiveFeedback
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
            this.btnBack = new System.Windows.Forms.Button();
            this.grpFeedback = new System.Windows.Forms.GroupBox();
            this.cmbFeedback = new System.Windows.Forms.ComboBox();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.lblSubj = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnFeedbackClear = new System.Windows.Forms.Button();
            this.grpFeedback.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 352);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(71, 37);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpFeedback
            // 
            this.grpFeedback.Controls.Add(this.cmbFeedback);
            this.grpFeedback.Controls.Add(this.txtFeedback);
            this.grpFeedback.Controls.Add(this.lblFeedback);
            this.grpFeedback.Controls.Add(this.lblSubj);
            this.grpFeedback.Location = new System.Drawing.Point(72, 84);
            this.grpFeedback.Name = "grpFeedback";
            this.grpFeedback.Size = new System.Drawing.Size(542, 214);
            this.grpFeedback.TabIndex = 9;
            this.grpFeedback.TabStop = false;
            this.grpFeedback.Text = "Give Feedback to Admin";
            // 
            // cmbFeedback
            // 
            this.cmbFeedback.FormattingEnabled = true;
            this.cmbFeedback.Items.AddRange(new object[] {
            "Suggestion/Guidance",
            "Complaint/Constructive",
            "Encouragement/Appreciation"});
            this.cmbFeedback.Location = new System.Drawing.Point(181, 69);
            this.cmbFeedback.Name = "cmbFeedback";
            this.cmbFeedback.Size = new System.Drawing.Size(313, 24);
            this.cmbFeedback.TabIndex = 7;
            // 
            // txtFeedback
            // 
            this.txtFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeedback.Location = new System.Drawing.Point(182, 119);
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(312, 21);
            this.txtFeedback.TabIndex = 6;
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.Location = new System.Drawing.Point(79, 122);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(95, 15);
            this.lblFeedback.TabIndex = 5;
            this.lblFeedback.Text = "Your Feedback: ";
            // 
            // lblSubj
            // 
            this.lblSubj.AutoSize = true;
            this.lblSubj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubj.Location = new System.Drawing.Point(50, 73);
            this.lblSubj.Name = "lblSubj";
            this.lblSubj.Size = new System.Drawing.Size(124, 15);
            this.lblSubj.TabIndex = 3;
            this.lblSubj.Text = "Subject of Feedback: ";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(518, 352);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(71, 37);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnFeedbackClear
            // 
            this.btnFeedbackClear.Location = new System.Drawing.Point(595, 352);
            this.btnFeedbackClear.Name = "btnFeedbackClear";
            this.btnFeedbackClear.Size = new System.Drawing.Size(71, 37);
            this.btnFeedbackClear.TabIndex = 11;
            this.btnFeedbackClear.Text = "Clear all";
            this.btnFeedbackClear.UseVisualStyleBackColor = true;
            this.btnFeedbackClear.Click += new System.EventHandler(this.btnFeedbackClear_Click);
            // 
            // frmGiveFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(678, 401);
            this.Controls.Add(this.btnFeedbackClear);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.grpFeedback);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGiveFeedback";
            this.Text = "GiveFeedback";
            this.Load += new System.EventHandler(this.frmGiveFeedback_Load);
            this.grpFeedback.ResumeLayout(false);
            this.grpFeedback.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpFeedback;
        private System.Windows.Forms.Label lblSubj;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnFeedbackClear;
        private System.Windows.Forms.ComboBox cmbFeedback;
    }
}