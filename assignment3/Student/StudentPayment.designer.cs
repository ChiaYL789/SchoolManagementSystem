namespace ASSIGNMENT
{
    partial class frmPay
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
            this.btnBackP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPay = new System.Windows.Forms.GroupBox();
            this.lblPaymentstatus = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnConfirmPay = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnInvoiceP = new System.Windows.Forms.Button();
            this.pnlApay = new System.Windows.Forms.Panel();
            this.pnlViewinv = new System.Windows.Forms.Panel();
            this.btnBackInvoiceToAP = new System.Windows.Forms.Button();
            this.grbInv = new System.Windows.Forms.GroupBox();
            this.lblTotalinInvoice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvInvoicePay = new System.Windows.Forms.DataGridView();
            this.gbPay.SuspendLayout();
            this.pnlApay.SuspendLayout();
            this.pnlViewinv.SuspendLayout();
            this.grbInv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoicePay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackP
            // 
            this.btnBackP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackP.Location = new System.Drawing.Point(12, 12);
            this.btnBackP.Name = "btnBackP";
            this.btnBackP.Size = new System.Drawing.Size(92, 40);
            this.btnBackP.TabIndex = 14;
            this.btnBackP.Text = "Back";
            this.btnBackP.UseVisualStyleBackColor = true;
            this.btnBackP.Click += new System.EventHandler(this.btnBackP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 37);
            this.label1.TabIndex = 33;
            this.label1.Text = "Payment";
            // 
            // gbPay
            // 
            this.gbPay.Controls.Add(this.lblPaymentstatus);
            this.gbPay.Controls.Add(this.lblStatus);
            this.gbPay.Controls.Add(this.btnConfirmPay);
            this.gbPay.Controls.Add(this.lblTotalAmount);
            this.gbPay.Controls.Add(this.lblTotal);
            this.gbPay.Controls.Add(this.btnInvoiceP);
            this.gbPay.Location = new System.Drawing.Point(64, 35);
            this.gbPay.Name = "gbPay";
            this.gbPay.Size = new System.Drawing.Size(578, 342);
            this.gbPay.TabIndex = 32;
            this.gbPay.TabStop = false;
            this.gbPay.Text = "Amount Payable : ";
            this.gbPay.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblPaymentstatus
            // 
            this.lblPaymentstatus.AutoSize = true;
            this.lblPaymentstatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPaymentstatus.Location = new System.Drawing.Point(282, 149);
            this.lblPaymentstatus.Name = "lblPaymentstatus";
            this.lblPaymentstatus.Size = new System.Drawing.Size(2, 22);
            this.lblPaymentstatus.TabIndex = 35;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(78, 149);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(130, 20);
            this.lblStatus.TabIndex = 33;
            this.lblStatus.Text = "Payment Status :";
            // 
            // btnConfirmPay
            // 
            this.btnConfirmPay.Location = new System.Drawing.Point(342, 243);
            this.btnConfirmPay.Name = "btnConfirmPay";
            this.btnConfirmPay.Size = new System.Drawing.Size(162, 77);
            this.btnConfirmPay.TabIndex = 6;
            this.btnConfirmPay.Text = "Confirm Payment";
            this.btnConfirmPay.UseVisualStyleBackColor = true;
            this.btnConfirmPay.Click += new System.EventHandler(this.btnConfirmPay_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalAmount.Location = new System.Drawing.Point(279, 83);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(2, 22);
            this.lblTotalAmount.TabIndex = 31;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(96, 80);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(112, 20);
            this.lblTotal.TabIndex = 30;
            this.lblTotal.Text = "Total Amount :";
            // 
            // btnInvoiceP
            // 
            this.btnInvoiceP.Location = new System.Drawing.Point(74, 246);
            this.btnInvoiceP.Name = "btnInvoiceP";
            this.btnInvoiceP.Size = new System.Drawing.Size(189, 71);
            this.btnInvoiceP.TabIndex = 22;
            this.btnInvoiceP.Text = "View Invoice";
            this.btnInvoiceP.UseVisualStyleBackColor = true;
            this.btnInvoiceP.Click += new System.EventHandler(this.btnInvoiceP_Click);
            // 
            // pnlApay
            // 
            this.pnlApay.Controls.Add(this.gbPay);
            this.pnlApay.Location = new System.Drawing.Point(81, 93);
            this.pnlApay.Name = "pnlApay";
            this.pnlApay.Size = new System.Drawing.Size(677, 435);
            this.pnlApay.TabIndex = 34;
            // 
            // pnlViewinv
            // 
            this.pnlViewinv.Controls.Add(this.btnBackInvoiceToAP);
            this.pnlViewinv.Controls.Add(this.grbInv);
            this.pnlViewinv.Location = new System.Drawing.Point(44, 12);
            this.pnlViewinv.Name = "pnlViewinv";
            this.pnlViewinv.Size = new System.Drawing.Size(726, 583);
            this.pnlViewinv.TabIndex = 33;
            // 
            // btnBackInvoiceToAP
            // 
            this.btnBackInvoiceToAP.Location = new System.Drawing.Point(262, 474);
            this.btnBackInvoiceToAP.Name = "btnBackInvoiceToAP";
            this.btnBackInvoiceToAP.Size = new System.Drawing.Size(162, 77);
            this.btnBackInvoiceToAP.TabIndex = 2;
            this.btnBackInvoiceToAP.Text = "Back";
            this.btnBackInvoiceToAP.UseVisualStyleBackColor = true;
            this.btnBackInvoiceToAP.Click += new System.EventHandler(this.btnBackInvoiceToAP_Click);
            // 
            // grbInv
            // 
            this.grbInv.Controls.Add(this.lblTotalinInvoice);
            this.grbInv.Controls.Add(this.label2);
            this.grbInv.Controls.Add(this.dgvInvoicePay);
            this.grbInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInv.Location = new System.Drawing.Point(29, 41);
            this.grbInv.Name = "grbInv";
            this.grbInv.Size = new System.Drawing.Size(666, 427);
            this.grbInv.TabIndex = 1;
            this.grbInv.TabStop = false;
            this.grbInv.Text = "INVOICE";
            // 
            // lblTotalinInvoice
            // 
            this.lblTotalinInvoice.AutoSize = true;
            this.lblTotalinInvoice.Location = new System.Drawing.Point(337, 375);
            this.lblTotalinInvoice.Name = "lblTotalinInvoice";
            this.lblTotalinInvoice.Size = new System.Drawing.Size(0, 26);
            this.lblTotalinInvoice.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Amount :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvInvoicePay
            // 
            this.dgvInvoicePay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoicePay.Location = new System.Drawing.Point(23, 42);
            this.dgvInvoicePay.Name = "dgvInvoicePay";
            this.dgvInvoicePay.RowHeadersWidth = 51;
            this.dgvInvoicePay.RowTemplate.Height = 24;
            this.dgvInvoicePay.Size = new System.Drawing.Size(616, 312);
            this.dgvInvoicePay.TabIndex = 0;
            this.dgvInvoicePay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(831, 719);
            this.Controls.Add(this.pnlViewinv);
            this.Controls.Add(this.pnlApay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBackP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPay";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.frmPay_Load);
            this.gbPay.ResumeLayout(false);
            this.gbPay.PerformLayout();
            this.pnlApay.ResumeLayout(false);
            this.pnlViewinv.ResumeLayout(false);
            this.grbInv.ResumeLayout(false);
            this.grbInv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoicePay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBackP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPay;
        private System.Windows.Forms.Button btnInvoiceP;
        private System.Windows.Forms.Panel pnlApay;
        private System.Windows.Forms.Panel pnlViewinv;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox grbInv;
        private System.Windows.Forms.DataGridView dgvInvoicePay;
        private System.Windows.Forms.Button btnBackInvoiceToAP;
        private System.Windows.Forms.Button btnConfirmPay;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPaymentstatus;
        private System.Windows.Forms.Label lblTotalinInvoice;
        private System.Windows.Forms.Label label2;
    }
}