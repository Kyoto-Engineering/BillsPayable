﻿namespace BillsPayableSystem.UI
{
    partial class frmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
<<<<<<< HEAD
=======
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
>>>>>>> origin/master
            this.label1 = new System.Windows.Forms.Label();
            this.lblBillSiNo = new System.Windows.Forms.Label();
            this.cmbBillSN = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dtpPaymentDate
            // 
<<<<<<< HEAD
            this.dtpPaymentDate.CustomFormat = "dd/MM/yyy";
            this.dtpPaymentDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPaymentDate.Location = new System.Drawing.Point(185, 93);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(101, 29);
=======
            this.dtpPaymentDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPaymentDate.Location = new System.Drawing.Point(185, 93);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(282, 29);
>>>>>>> origin/master
            this.dtpPaymentDate.TabIndex = 0;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDate.Location = new System.Drawing.Point(38, 97);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(135, 22);
            this.lblPaymentDate.TabIndex = 1;
            this.lblPaymentDate.Text = "Payment Date :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(253, 235);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 65);
            this.btnSave.TabIndex = 5;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
<<<<<<< HEAD
=======
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(611, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 42);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(549, 4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(58, 41);
            this.btnMin.TabIndex = 7;
            this.btnMin.Text = "Min";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
>>>>>>> origin/master
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(269, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Payment";
            // 
            // lblBillSiNo
            // 
            this.lblBillSiNo.AutoSize = true;
            this.lblBillSiNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillSiNo.Location = new System.Drawing.Point(43, 167);
            this.lblBillSiNo.Name = "lblBillSiNo";
            this.lblBillSiNo.Size = new System.Drawing.Size(130, 22);
            this.lblBillSiNo.TabIndex = 9;
            this.lblBillSiNo.Text = "Bill Serial No :";
            // 
            // cmbBillSN
            // 
            this.cmbBillSN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBillSN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBillSN.FormattingEnabled = true;
            this.cmbBillSN.Location = new System.Drawing.Point(185, 164);
            this.cmbBillSN.Name = "cmbBillSN";
            this.cmbBillSN.Size = new System.Drawing.Size(282, 30);
            this.cmbBillSN.TabIndex = 10;
            this.cmbBillSN.SelectedIndexChanged += new System.EventHandler(this.cmbBillSN_SelectedIndexChanged);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(675, 367);
<<<<<<< HEAD
            this.Controls.Add(this.cmbBillSN);
            this.Controls.Add(this.lblBillSiNo);
            this.Controls.Add(this.label1);
=======
            this.ControlBox = false;
            this.Controls.Add(this.cmbBillSN);
            this.Controls.Add(this.lblBillSiNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
>>>>>>> origin/master
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblPaymentDate);
            this.Controls.Add(this.dtpPaymentDate);
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentUI";
<<<<<<< HEAD
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPayment_FormClosed);
=======
>>>>>>> origin/master
            this.Load += new System.EventHandler(this.PaymentUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSave;
<<<<<<< HEAD
=======
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMin;
>>>>>>> origin/master
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBillSiNo;
        private System.Windows.Forms.ComboBox cmbBillSN;
    }
}