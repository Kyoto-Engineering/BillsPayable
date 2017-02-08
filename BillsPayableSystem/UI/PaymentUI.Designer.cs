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
            this.components = new System.ComponentModel.Container();
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.bankNameLabel = new System.Windows.Forms.Label();
            this.approvalAuthComboBox = new System.Windows.Forms.ComboBox();
            this.paymentMethodComboBox = new System.Windows.Forms.ComboBox();
            this.approvalAmountTextBox = new System.Windows.Forms.TextBox();
            this.approvalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.settlementDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.accNumberLabel = new System.Windows.Forms.Label();
            this.chqNumberLabel = new System.Windows.Forms.Label();
            this.chaqueNumTextBox = new System.Windows.Forms.TextBox();
            this.bankNameComboBox = new System.Windows.Forms.ComboBox();
            this.approvedByComboBox = new System.Windows.Forms.ComboBox();
            this.billsPayableDBDataSet = new BillsPayableSystem.BillsPayableDBDataSet();
            this.tdepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_departmentTableAdapter = new BillsPayableSystem.BillsPayableDBDataSetTableAdapters.t_departmentTableAdapter();
            this.accontNumComboBox = new System.Windows.Forms.ComboBox();
            this.settlementAmountTxtBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.billsPayableDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdepartmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.CustomFormat = "dd/MM/yyy";
            this.dtpPaymentDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPaymentDate.Location = new System.Drawing.Point(166, 88);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(126, 29);
            this.dtpPaymentDate.TabIndex = 0;
            this.dtpPaymentDate.ValueChanged += new System.EventHandler(this.dtpPaymentDate_ValueChanged);
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDate.Location = new System.Drawing.Point(19, 92);
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
            this.btnSave.Location = new System.Drawing.Point(326, 389);
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
            this.label1.Location = new System.Drawing.Point(168, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Payment";
            // 
            // lblBillSiNo
            // 
            this.lblBillSiNo.AutoSize = true;
            this.lblBillSiNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillSiNo.Location = new System.Drawing.Point(24, 138);
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
            this.cmbBillSN.Location = new System.Drawing.Point(166, 135);
            this.cmbBillSN.Name = "cmbBillSN";
            this.cmbBillSN.Size = new System.Drawing.Size(282, 30);
            this.cmbBillSN.TabIndex = 10;
            this.cmbBillSN.SelectedIndexChanged += new System.EventHandler(this.cmbBillSN_SelectedIndexChanged);
            // 
            // payableTextBox
            // 
            this.payableTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payableTextBox.Location = new System.Drawing.Point(166, 183);
            this.payableTextBox.Name = "payableTextBox";
            this.payableTextBox.ReadOnly = true;
            this.payableTextBox.Size = new System.Drawing.Size(282, 29);
            this.payableTextBox.TabIndex = 11;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTextBox.Location = new System.Drawing.Point(166, 233);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.ReadOnly = true;
            this.amountTextBox.Size = new System.Drawing.Size(282, 29);
            this.amountTextBox.TabIndex = 12;
            this.amountTextBox.TextChanged += new System.EventHandler(this.amountTextBox_TextChanged);
            // 
            // billEntryDateTextBox
            // 
            this.billEntryDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billEntryDateTextBox.Location = new System.Drawing.Point(166, 280);
            this.billEntryDateTextBox.Name = "billEntryDateTextBox";
            this.billEntryDateTextBox.ReadOnly = true;
            this.billEntryDateTextBox.Size = new System.Drawing.Size(282, 29);
            this.billEntryDateTextBox.TabIndex = 13;
            // 
            // billPurposeTextBox
            // 
            this.billPurposeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billPurposeTextBox.Location = new System.Drawing.Point(166, 329);
            this.billPurposeTextBox.Name = "billPurposeTextBox";
            this.billPurposeTextBox.ReadOnly = true;
            this.billPurposeTextBox.Size = new System.Drawing.Size(282, 29);
            this.billPurposeTextBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Payable To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Bill Entry Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Bill Purpose:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(469, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Appoval Authority :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(505, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Approved by :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(492, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Approval Date :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(476, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Approval amount :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(778, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 19);
            this.label11.TabIndex = 24;
            this.label11.Text = "Settlement Date :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(776, 245);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 19);
            this.label13.TabIndex = 26;
            this.label13.Text = "Payment method :";
            // 
            // bankNameLabel
            // 
            this.bankNameLabel.AutoSize = true;
            this.bankNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankNameLabel.Location = new System.Drawing.Point(807, 286);
            this.bankNameLabel.Name = "bankNameLabel";
            this.bankNameLabel.Size = new System.Drawing.Size(98, 19);
            this.bankNameLabel.TabIndex = 27;
            this.bankNameLabel.Text = "Bank Name :";
            this.bankNameLabel.Visible = false;
            // 
            // approvalAuthComboBox
            // 
            this.approvalAuthComboBox.FormattingEnabled = true;
            this.approvalAuthComboBox.Location = new System.Drawing.Point(617, 142);
            this.approvalAuthComboBox.Name = "approvalAuthComboBox";
            this.approvalAuthComboBox.Size = new System.Drawing.Size(121, 21);
            this.approvalAuthComboBox.TabIndex = 28;
            this.approvalAuthComboBox.SelectedIndexChanged += new System.EventHandler(this.approvalAuthComboBox_SelectedIndexChanged);
            // 
            // paymentMethodComboBox
            // 
            this.paymentMethodComboBox.FormattingEnabled = true;
            this.paymentMethodComboBox.Items.AddRange(new object[] {
            "Cash",
            "cheque"});
            this.paymentMethodComboBox.Location = new System.Drawing.Point(908, 245);
            this.paymentMethodComboBox.Name = "paymentMethodComboBox";
            this.paymentMethodComboBox.Size = new System.Drawing.Size(110, 21);
            this.paymentMethodComboBox.TabIndex = 29;
            this.paymentMethodComboBox.SelectedIndexChanged += new System.EventHandler(this.paymentMethodComboBox_SelectedIndexChanged);
            // 
            // approvalAmountTextBox
            // 
            this.approvalAmountTextBox.Location = new System.Drawing.Point(617, 288);
            this.approvalAmountTextBox.Name = "approvalAmountTextBox";
            this.approvalAmountTextBox.Size = new System.Drawing.Size(121, 20);
            this.approvalAmountTextBox.TabIndex = 31;
            // 
            // approvalDateTimePicker
            // 
            this.approvalDateTimePicker.Location = new System.Drawing.Point(617, 242);
            this.approvalDateTimePicker.Name = "approvalDateTimePicker";
            this.approvalDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.approvalDateTimePicker.TabIndex = 32;
            // 
            // settlementDateTimePicker
            // 
            this.settlementDateTimePicker.Location = new System.Drawing.Point(908, 145);
            this.settlementDateTimePicker.Name = "settlementDateTimePicker";
            this.settlementDateTimePicker.Size = new System.Drawing.Size(110, 20);
            this.settlementDateTimePicker.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(610, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 32);
            this.label10.TabIndex = 35;
            this.label10.Text = "Approval";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(870, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 32);
            this.label15.TabIndex = 36;
            this.label15.Text = "Settlement";
            // 
            // accNumberLabel
            // 
            this.accNumberLabel.AutoSize = true;
            this.accNumberLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accNumberLabel.Location = new System.Drawing.Point(775, 327);
            this.accNumberLabel.Name = "accNumberLabel";
            this.accNumberLabel.Size = new System.Drawing.Size(130, 19);
            this.accNumberLabel.TabIndex = 37;
            this.accNumberLabel.Text = "Account Number :";
            this.accNumberLabel.Visible = false;
            // 
            // chqNumberLabel
            // 
            this.chqNumberLabel.AutoSize = true;
            this.chqNumberLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chqNumberLabel.Location = new System.Drawing.Point(778, 368);
            this.chqNumberLabel.Name = "chqNumberLabel";
            this.chqNumberLabel.Size = new System.Drawing.Size(127, 19);
            this.chqNumberLabel.TabIndex = 38;
            this.chqNumberLabel.Text = "Chaque Number :";
            this.chqNumberLabel.Visible = false;
            // 
            // chaqueNumTextBox
            // 
            this.chaqueNumTextBox.Location = new System.Drawing.Point(908, 367);
            this.chaqueNumTextBox.Name = "chaqueNumTextBox";
            this.chaqueNumTextBox.Size = new System.Drawing.Size(110, 20);
            this.chaqueNumTextBox.TabIndex = 41;
            this.chaqueNumTextBox.Visible = false;
            // 
            // bankNameComboBox
            // 
            this.bankNameComboBox.FormattingEnabled = true;
            this.bankNameComboBox.Location = new System.Drawing.Point(908, 284);
            this.bankNameComboBox.Name = "bankNameComboBox";
            this.bankNameComboBox.Size = new System.Drawing.Size(110, 21);
            this.bankNameComboBox.TabIndex = 42;
            this.bankNameComboBox.Visible = false;
            this.bankNameComboBox.SelectedIndexChanged += new System.EventHandler(this.bankNameComboBox_SelectedIndexChanged);
            // 
            // approvedByComboBox
            // 
            this.approvedByComboBox.FormattingEnabled = true;
            this.approvedByComboBox.Location = new System.Drawing.Point(617, 191);
            this.approvedByComboBox.Name = "approvedByComboBox";
            this.approvedByComboBox.Size = new System.Drawing.Size(121, 21);
            this.approvedByComboBox.TabIndex = 43;
            this.approvedByComboBox.SelectedIndexChanged += new System.EventHandler(this.approvedByComboBox_SelectedIndexChanged);
            // 
            // billsPayableDBDataSet
            // 
            this.billsPayableDBDataSet.DataSetName = "BillsPayableDBDataSet";
            this.billsPayableDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tdepartmentBindingSource
            // 
            this.tdepartmentBindingSource.DataMember = "t_department";
            this.tdepartmentBindingSource.DataSource = this.billsPayableDBDataSet;
            // 
            // t_departmentTableAdapter
            // 
            this.t_departmentTableAdapter.ClearBeforeFill = true;
            // 
            // accontNumComboBox
            // 
            this.accontNumComboBox.FormattingEnabled = true;
            this.accontNumComboBox.Location = new System.Drawing.Point(908, 325);
            this.accontNumComboBox.Name = "accontNumComboBox";
            this.accontNumComboBox.Size = new System.Drawing.Size(110, 21);
            this.accontNumComboBox.TabIndex = 44;
            this.accontNumComboBox.Visible = false;
            this.accontNumComboBox.SelectedIndexChanged += new System.EventHandler(this.accontNumComboBox_SelectedIndexChanged);
            // 
            // settlementAmountTxtBox
            // 
            this.settlementAmountTxtBox.Location = new System.Drawing.Point(908, 194);
            this.settlementAmountTxtBox.Name = "settlementAmountTxtBox";
            this.settlementAmountTxtBox.Size = new System.Drawing.Size(110, 20);
            this.settlementAmountTxtBox.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(760, 194);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 19);
            this.label12.TabIndex = 46;
            this.label12.Text = "Settlement Amount :";
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1059, 556);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.settlementAmountTxtBox);
            this.Controls.Add(this.accontNumComboBox);
            this.Controls.Add(this.approvedByComboBox);
            this.Controls.Add(this.bankNameComboBox);
            this.Controls.Add(this.chaqueNumTextBox);
            this.Controls.Add(this.chqNumberLabel);
            this.Controls.Add(this.accNumberLabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.settlementDateTimePicker);
            this.Controls.Add(this.approvalDateTimePicker);
            this.Controls.Add(this.approvalAmountTextBox);
            this.Controls.Add(this.paymentMethodComboBox);
            this.Controls.Add(this.approvalAuthComboBox);
            this.Controls.Add(this.bankNameLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
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
            ((System.ComponentModel.ISupportInitialize)(this.billsPayableDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdepartmentBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label bankNameLabel;
        private System.Windows.Forms.ComboBox approvalAuthComboBox;
        private System.Windows.Forms.ComboBox paymentMethodComboBox;
        private System.Windows.Forms.TextBox approvalAmountTextBox;
        private System.Windows.Forms.DateTimePicker approvalDateTimePicker;
        private System.Windows.Forms.DateTimePicker settlementDateTimePicker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label accNumberLabel;
        private System.Windows.Forms.Label chqNumberLabel;
        private System.Windows.Forms.TextBox chaqueNumTextBox;
        private System.Windows.Forms.ComboBox bankNameComboBox;
        private System.Windows.Forms.ComboBox approvedByComboBox;
        private BillsPayableDBDataSet billsPayableDBDataSet;
        private System.Windows.Forms.BindingSource tdepartmentBindingSource;
        private BillsPayableDBDataSetTableAdapters.t_departmentTableAdapter t_departmentTableAdapter;
        private System.Windows.Forms.ComboBox accontNumComboBox;
        private System.Windows.Forms.TextBox settlementAmountTxtBox;
        private System.Windows.Forms.Label label12;
    }
}