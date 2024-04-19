namespace assignment3.admin
{
    partial class frmViewTrainerList
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
            this.grpDelete = new System.Windows.Forms.GroupBox();
            this.cbTrainerID = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTrainerID = new System.Windows.Forms.Label();
            this.sgvTrainerList = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sgvTrainerList)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDelete
            // 
            this.grpDelete.Controls.Add(this.cbTrainerID);
            this.grpDelete.Controls.Add(this.btnDelete);
            this.grpDelete.Controls.Add(this.btnReset);
            this.grpDelete.Controls.Add(this.lblTrainerID);
            this.grpDelete.Controls.Add(this.sgvTrainerList);
            this.grpDelete.Location = new System.Drawing.Point(21, 61);
            this.grpDelete.Name = "grpDelete";
            this.grpDelete.Size = new System.Drawing.Size(756, 363);
            this.grpDelete.TabIndex = 31;
            this.grpDelete.TabStop = false;
            this.grpDelete.Text = "Delete Trainer";
            // 
            // cbTrainerID
            // 
            this.cbTrainerID.FormattingEnabled = true;
            this.cbTrainerID.Location = new System.Drawing.Point(248, 289);
            this.cbTrainerID.Name = "cbTrainerID";
            this.cbTrainerID.Size = new System.Drawing.Size(121, 21);
            this.cbTrainerID.TabIndex = 5;
            this.cbTrainerID.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(453, 291);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(453, 320);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblTrainerID
            // 
            this.lblTrainerID.AutoSize = true;
            this.lblTrainerID.Location = new System.Drawing.Point(182, 293);
            this.lblTrainerID.Name = "lblTrainerID";
            this.lblTrainerID.Size = new System.Drawing.Size(60, 13);
            this.lblTrainerID.TabIndex = 1;
            this.lblTrainerID.Text = "Trainer ID :";
            // 
            // sgvTrainerList
            // 
            this.sgvTrainerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sgvTrainerList.Location = new System.Drawing.Point(19, 37);
            this.sgvTrainerList.Name = "sgvTrainerList";
            this.sgvTrainerList.Size = new System.Drawing.Size(719, 218);
            this.sgvTrainerList.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(106, 34);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmViewTrainerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpDelete);
            this.Name = "frmViewTrainerList";
            this.Text = "ViewTrainerList";
            this.Load += new System.EventHandler(this.ViewTrainerList_Load);
            this.grpDelete.ResumeLayout(false);
            this.grpDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sgvTrainerList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpDelete;
        private System.Windows.Forms.ComboBox cbTrainerID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTrainerID;
        private System.Windows.Forms.DataGridView sgvTrainerList;
        private System.Windows.Forms.Button btnBack;
    }
}