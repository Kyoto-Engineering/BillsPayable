namespace BillsPayableSystem.UI
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblBillSiNo = new System.Windows.Forms.Label();
            this.cmbBillSN = new System.Windows.Forms.ComboBox();
            this.payableTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.billEntryDateTextBox = new System.Windows.Forms.TextBox();
            this.billPurposeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.CustomFormat = "dd/MM/yyy";
            this.dtpPaymentDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPaymentDate.Location = new System.Drawing.Point(185, 93);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(101, 29);
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
            this.btnSave.Location = new System.Drawing.Point(562, 341);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 65);
            this.btnSave.TabIndex = 5;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
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
            // payableTextBox
            // 
            this.payableTextBox.Location = new System.Drawing.Point(275, 216);
            this.payableTextBox.Name = "payableTextBox";
            this.payableTextBox.ReadOnly = true;
            this.payableTextBox.Size = new System.Drawing.Size(192, 20);
            this.payableTextBox.TabIndex = 11;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(275, 266);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.ReadOnly = true;
            this.amountTextBox.Size = new System.Drawing.Size(192, 20);
            this.amountTextBox.TabIndex = 12;
            // 
            // billEntryDateTextBox
            // 
            this.billEntryDateTextBox.Location = new System.Drawing.Point(275, 312);
            this.billEntryDateTextBox.Name = "billEntryDateTextBox";
            this.billEntryDateTextBox.ReadOnly = true;
            this.billEntryDateTextBox.Size = new System.Drawing.Size(192, 20);
            this.billEntryDateTextBox.TabIndex = 13;
            // 
            // billPurposeTextBox
            // 
            this.billPurposeTextBox.Location = new System.Drawing.Point(275, 355);
            this.billPurposeTextBox.Name = "billPurposeTextBox";
            this.billPurposeTextBox.ReadOnly = true;
            this.billPurposeTextBox.Size = new System.Drawing.Size(192, 20);
            this.billPurposeTextBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Payable To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Bill Entry Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Bill Purpose:";
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(940, 418);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.billPurposeTextBox);
            this.Controls.Add(this.billEntryDateTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.payableTextBox);
            this.Controls.Add(this.cmbBillSN);
            this.Controls.Add(this.lblBillSiNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblPaymentDate);
            this.Controls.Add(this.dtpPaymentDate);
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPayment_FormClosed);
            this.Load += new System.EventHandler(this.PaymentUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSave;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBillSiNo;
        private System.Windows.Forms.ComboBox cmbBillSN;
        private System.Windows.Forms.TextBox payableTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox billEntryDateTextBox;
        private System.Windows.Forms.TextBox billPurposeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}