namespace ASSIGNMENT
{
    partial class frmTT
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
            this.btnBackTT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTableTT = new System.Windows.Forms.GroupBox();
            this.dgvTimetable = new System.Windows.Forms.DataGridView();
            this.grpTableTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackTT
            // 
            this.btnBackTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackTT.Location = new System.Drawing.Point(12, 16);
            this.btnBackTT.Name = "btnBackTT";
            this.btnBackTT.Size = new System.Drawing.Size(92, 40);
            this.btnBackTT.TabIndex = 9;
            this.btnBackTT.Text = "Back";
            this.btnBackTT.UseVisualStyleBackColor = true;
            this.btnBackTT.Click += new System.EventHandler(this.btnBackTT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(529, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 46);
            this.label1.TabIndex = 19;
            this.label1.Text = "Timetable";
            // 
            // grpTableTT
            // 
            this.grpTableTT.Controls.Add(this.dgvTimetable);
            this.grpTableTT.Location = new System.Drawing.Point(255, 89);
            this.grpTableTT.Name = "grpTableTT";
            this.grpTableTT.Size = new System.Drawing.Size(825, 546);
            this.grpTableTT.TabIndex = 18;
            this.grpTableTT.TabStop = false;
            this.grpTableTT.Text = "Week 1";
            // 
            // dgvTimetable
            // 
            this.dgvTimetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimetable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTimetable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimetable.Location = new System.Drawing.Point(39, 50);
            this.dgvTimetable.Name = "dgvTimetable";
            this.dgvTimetable.RowHeadersWidth = 51;
            this.dgvTimetable.RowTemplate.Height = 24;
            this.dgvTimetable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvTimetable.Size = new System.Drawing.Size(754, 469);
            this.dgvTimetable.TabIndex = 15;
            this.dgvTimetable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpTableTT);
            this.Controls.Add(this.btnBackTT);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTT";
            this.Text = "Timetable";
            this.Load += new System.EventHandler(this.frmTT_Load);
            this.grpTableTT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBackTT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTableTT;
        private System.Windows.Forms.DataGridView dgvTimetable;
    }
}