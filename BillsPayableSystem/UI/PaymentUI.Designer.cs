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
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            this.approvalGroupBox = new System.Windows.Forms.GroupBox();
            this.approveButton = new System.Windows.Forms.Button();
            this.paymentInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.agreeButton = new System.Windows.Forms.Button();
            this.settlementGroupBox = new System.Windows.Forms.GroupBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.billsPayableDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdepartmentBindingSource)).BeginInit();
            this.approvalGroupBox.SuspendLayout();
            this.paymentInfoGroupBox.SuspendLayout();
            this.settlementGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.CustomFormat = "dd/MM/yyy";
            this.dtpPaymentDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPaymentDate.Location = new System.Drawing.Point(166, 39);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(126, 29);
            this.dtpPaymentDate.TabIndex = 0;
            this.dtpPaymentDate.ValueChanged += new System.EventHandler(this.dtpPaymentDate_ValueChanged);
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDate.Location = new System.Drawing.Point(19, 43);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(135, 22);
            this.lblPaymentDate.TabIndex = 1;
            this.lblPaymentDate.Text = "Payment Date :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(572, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Payment UI";
            // 
            // lblBillSiNo
            // 
            this.lblBillSiNo.AutoSize = true;
            this.lblBillSiNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillSiNo.Location = new System.Drawing.Point(79, 89);
            this.lblBillSiNo.Name = "lblBillSiNo";
            this.lblBillSiNo.Size = new System.Drawing.Size(74, 22);
            this.lblBillSiNo.TabIndex = 9;
            this.lblBillSiNo.Text = "Bill ID :";
            // 
            // cmbBillSN
            // 
            this.cmbBillSN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBillSN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBillSN.FormattingEnabled = true;
            this.cmbBillSN.Location = new System.Drawing.Point(166, 86);
            this.cmbBillSN.Name = "cmbBillSN";
            this.cmbBillSN.Size = new System.Drawing.Size(282, 30);
            this.cmbBillSN.TabIndex = 1;
            this.cmbBillSN.SelectedIndexChanged += new System.EventHandler(this.cmbBillSN_SelectedIndexChanged);
            // 
            // payableTextBox
            // 
            this.payableTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payableTextBox.Location = new System.Drawing.Point(166, 134);
            this.payableTextBox.Name = "payableTextBox";
            this.payableTextBox.ReadOnly = true;
            this.payableTextBox.Size = new System.Drawing.Size(282, 29);
            this.payableTextBox.TabIndex = 2;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTextBox.Location = new System.Drawing.Point(166, 184);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.ReadOnly = true;
            this.amountTextBox.Size = new System.Drawing.Size(282, 29);
            this.amountTextBox.TabIndex = 3;
            this.amountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountTextBox_KeyPress);
            // 
            // billEntryDateTextBox
            // 
            this.billEntryDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billEntryDateTextBox.Location = new System.Drawing.Point(166, 231);
            this.billEntryDateTextBox.Name = "billEntryDateTextBox";
            this.billEntryDateTextBox.ReadOnly = true;
            this.billEntryDateTextBox.Size = new System.Drawing.Size(282, 29);
            this.billEntryDateTextBox.TabIndex = 4;
            // 
            // billPurposeTextBox
            // 
            this.billPurposeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billPurposeTextBox.Location = new System.Drawing.Point(166, 280);
            this.billPurposeTextBox.Name = "billPurposeTextBox";
            this.billPurposeTextBox.ReadOnly = true;
            this.billPurposeTextBox.Size = new System.Drawing.Size(282, 29);
            this.billPurposeTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Payable To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Total Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Bill Entry Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Bill Purpose:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Appoval Authority :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Approved By :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(54, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Approval Date :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Approval Amount :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(54, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 19);
            this.label11.TabIndex = 24;
            this.label11.Text = "Settlement Date :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(52, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 19);
            this.label13.TabIndex = 26;
            this.label13.Text = "Payment Method :";
            // 
            // bankNameLabel
            // 
            this.bankNameLabel.AutoSize = true;
            this.bankNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankNameLabel.Location = new System.Drawing.Point(83, 188);
            this.bankNameLabel.Name = "bankNameLabel";
            this.bankNameLabel.Size = new System.Drawing.Size(98, 19);
            this.bankNameLabel.TabIndex = 27;
            this.bankNameLabel.Text = "Bank Name :";
            this.bankNameLabel.Visible = false;
            // 
            // approvalAuthComboBox
            // 
            this.approvalAuthComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.approvalAuthComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.approvalAuthComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvalAuthComboBox.FormattingEnabled = true;
            this.approvalAuthComboBox.Location = new System.Drawing.Point(179, 48);
            this.approvalAuthComboBox.Name = "approvalAuthComboBox";
            this.approvalAuthComboBox.Size = new System.Drawing.Size(133, 27);
            this.approvalAuthComboBox.TabIndex = 0;
            this.approvalAuthComboBox.SelectedIndexChanged += new System.EventHandler(this.approvalAuthComboBox_SelectedIndexChanged);
            // 
            // paymentMethodComboBox
            // 
            this.paymentMethodComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.paymentMethodComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.paymentMethodComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentMethodComboBox.FormattingEnabled = true;
            this.paymentMethodComboBox.Items.AddRange(new object[] {
            "Cash",
            "Cheque"});
            this.paymentMethodComboBox.Location = new System.Drawing.Point(184, 147);
            this.paymentMethodComboBox.Name = "paymentMethodComboBox";
            this.paymentMethodComboBox.Size = new System.Drawing.Size(110, 27);
            this.paymentMethodComboBox.TabIndex = 2;
            this.paymentMethodComboBox.SelectedIndexChanged += new System.EventHandler(this.paymentMethodComboBox_SelectedIndexChanged);
            // 
            // approvalAmountTextBox
            // 
            this.approvalAmountTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvalAmountTextBox.Location = new System.Drawing.Point(179, 194);
            this.approvalAmountTextBox.Name = "approvalAmountTextBox";
            this.approvalAmountTextBox.Size = new System.Drawing.Size(133, 26);
            this.approvalAmountTextBox.TabIndex = 3;
            this.approvalAmountTextBox.TextChanged += new System.EventHandler(this.approvalAmountTextBox_TextChanged);
            this.approvalAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.approvalAmountTextBox_KeyPress);
            // 
            // approvalDateTimePicker
            // 
            this.approvalDateTimePicker.CustomFormat = "dd/MM/yyy";
            this.approvalDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvalDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.approvalDateTimePicker.Location = new System.Drawing.Point(179, 148);
            this.approvalDateTimePicker.Name = "approvalDateTimePicker";
            this.approvalDateTimePicker.Size = new System.Drawing.Size(133, 29);
            this.approvalDateTimePicker.TabIndex = 2;
            this.approvalDateTimePicker.Value = new System.DateTime(2017, 2, 9, 13, 6, 54, 0);
            this.approvalDateTimePicker.ValueChanged += new System.EventHandler(this.approvalDateTimePicker_ValueChanged);
            // 
            // settlementDateTimePicker
            // 
            this.settlementDateTimePicker.CustomFormat = "dd/MM/yyy";
            this.settlementDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settlementDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.settlementDateTimePicker.Location = new System.Drawing.Point(184, 47);
            this.settlementDateTimePicker.Name = "settlementDateTimePicker";
            this.settlementDateTimePicker.Size = new System.Drawing.Size(110, 26);
            this.settlementDateTimePicker.TabIndex = 0;
            this.settlementDateTimePicker.Value = new System.DateTime(2017, 2, 11, 12, 59, 9, 0);
            this.settlementDateTimePicker.ValueChanged += new System.EventHandler(this.settlementDateTimePicker_ValueChanged);
            // 
            // accNumberLabel
            // 
            this.accNumberLabel.AutoSize = true;
            this.accNumberLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accNumberLabel.Location = new System.Drawing.Point(51, 229);
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
            this.chqNumberLabel.Location = new System.Drawing.Point(54, 270);
            this.chqNumberLabel.Name = "chqNumberLabel";
            this.chqNumberLabel.Size = new System.Drawing.Size(127, 19);
            this.chqNumberLabel.TabIndex = 38;
            this.chqNumberLabel.Text = "Chaque Number :";
            this.chqNumberLabel.Visible = false;
            // 
            // chaqueNumTextBox
            // 
            this.chaqueNumTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chaqueNumTextBox.Location = new System.Drawing.Point(184, 269);
            this.chaqueNumTextBox.Name = "chaqueNumTextBox";
            this.chaqueNumTextBox.Size = new System.Drawing.Size(110, 26);
            this.chaqueNumTextBox.TabIndex = 5;
            this.chaqueNumTextBox.Visible = false;
            // 
            // bankNameComboBox
            // 
            this.bankNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.bankNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.bankNameComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankNameComboBox.FormattingEnabled = true;
            this.bankNameComboBox.Location = new System.Drawing.Point(184, 186);
            this.bankNameComboBox.Name = "bankNameComboBox";
            this.bankNameComboBox.Size = new System.Drawing.Size(110, 27);
            this.bankNameComboBox.TabIndex = 3;
            this.bankNameComboBox.Visible = false;
            this.bankNameComboBox.SelectedIndexChanged += new System.EventHandler(this.bankNameComboBox_SelectedIndexChanged);
            // 
            // approvedByComboBox
            // 
            this.approvedByComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.approvedByComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.approvedByComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvedByComboBox.FormattingEnabled = true;
            this.approvedByComboBox.Location = new System.Drawing.Point(179, 97);
            this.approvedByComboBox.Name = "approvedByComboBox";
            this.approvedByComboBox.Size = new System.Drawing.Size(133, 27);
            this.approvedByComboBox.TabIndex = 1;
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
            this.accontNumComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.accontNumComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.accontNumComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accontNumComboBox.FormattingEnabled = true;
            this.accontNumComboBox.Location = new System.Drawing.Point(184, 227);
            this.accontNumComboBox.Name = "accontNumComboBox";
            this.accontNumComboBox.Size = new System.Drawing.Size(110, 27);
            this.accontNumComboBox.TabIndex = 4;
            this.accontNumComboBox.Visible = false;
            this.accontNumComboBox.SelectedIndexChanged += new System.EventHandler(this.accontNumComboBox_SelectedIndexChanged);
            // 
            // settlementAmountTxtBox
            // 
            this.settlementAmountTxtBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settlementAmountTxtBox.Location = new System.Drawing.Point(184, 96);
            this.settlementAmountTxtBox.Name = "settlementAmountTxtBox";
            this.settlementAmountTxtBox.Size = new System.Drawing.Size(110, 26);
            this.settlementAmountTxtBox.TabIndex = 1;
            this.settlementAmountTxtBox.TextChanged += new System.EventHandler(this.settlementAmountTxtBox_TextChanged);
            this.settlementAmountTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.settlementAmountTxtBox_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(36, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 19);
            this.label12.TabIndex = 46;
            this.label12.Text = "Settlement Amount :";
            // 
            // approvalGroupBox
            // 
            this.approvalGroupBox.Controls.Add(this.approveButton);
            this.approvalGroupBox.Controls.Add(this.approvedByComboBox);
            this.approvalGroupBox.Controls.Add(this.approvalDateTimePicker);
            this.approvalGroupBox.Controls.Add(this.approvalAmountTextBox);
            this.approvalGroupBox.Controls.Add(this.approvalAuthComboBox);
            this.approvalGroupBox.Controls.Add(this.label9);
            this.approvalGroupBox.Controls.Add(this.label8);
            this.approvalGroupBox.Controls.Add(this.label7);
            this.approvalGroupBox.Controls.Add(this.label6);
            this.approvalGroupBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvalGroupBox.Location = new System.Drawing.Point(493, 86);
            this.approvalGroupBox.Name = "approvalGroupBox";
            this.approvalGroupBox.Size = new System.Drawing.Size(318, 318);
            this.approvalGroupBox.TabIndex = 3;
            this.approvalGroupBox.TabStop = false;
            this.approvalGroupBox.Text = "Approval ";
            // 
            // approveButton
            // 
            this.approveButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approveButton.Location = new System.Drawing.Point(222, 235);
            this.approveButton.Name = "approveButton";
            this.approveButton.Size = new System.Drawing.Size(90, 32);
            this.approveButton.TabIndex = 4;
            this.approveButton.Text = "Approve";
            this.approveButton.UseVisualStyleBackColor = true;
            this.approveButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // paymentInfoGroupBox
            // 
            this.paymentInfoGroupBox.Controls.Add(this.cancelButton);
            this.paymentInfoGroupBox.Controls.Add(this.agreeButton);
            this.paymentInfoGroupBox.Controls.Add(this.lblPaymentDate);
            this.paymentInfoGroupBox.Controls.Add(this.dtpPaymentDate);
            this.paymentInfoGroupBox.Controls.Add(this.label5);
            this.paymentInfoGroupBox.Controls.Add(this.lblBillSiNo);
            this.paymentInfoGroupBox.Controls.Add(this.label4);
            this.paymentInfoGroupBox.Controls.Add(this.cmbBillSN);
            this.paymentInfoGroupBox.Controls.Add(this.label3);
            this.paymentInfoGroupBox.Controls.Add(this.payableTextBox);
            this.paymentInfoGroupBox.Controls.Add(this.label2);
            this.paymentInfoGroupBox.Controls.Add(this.amountTextBox);
            this.paymentInfoGroupBox.Controls.Add(this.billPurposeTextBox);
            this.paymentInfoGroupBox.Controls.Add(this.billEntryDateTextBox);
            this.paymentInfoGroupBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentInfoGroupBox.Location = new System.Drawing.Point(12, 37);
            this.paymentInfoGroupBox.Name = "paymentInfoGroupBox";
            this.paymentInfoGroupBox.Size = new System.Drawing.Size(464, 367);
            this.paymentInfoGroupBox.TabIndex = 2;
            this.paymentInfoGroupBox.TabStop = false;
            this.paymentInfoGroupBox.Text = "Payment Information";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(292, 326);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 29);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // agreeButton
            // 
            this.agreeButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agreeButton.Location = new System.Drawing.Point(373, 326);
            this.agreeButton.Name = "agreeButton";
            this.agreeButton.Size = new System.Drawing.Size(75, 28);
            this.agreeButton.TabIndex = 7;
            this.agreeButton.Text = "Agree";
            this.agreeButton.UseVisualStyleBackColor = true;
            this.agreeButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // settlementGroupBox
            // 
            this.settlementGroupBox.Controls.Add(this.chqNumberLabel);
            this.settlementGroupBox.Controls.Add(this.accNumberLabel);
            this.settlementGroupBox.Controls.Add(this.label12);
            this.settlementGroupBox.Controls.Add(this.chaqueNumTextBox);
            this.settlementGroupBox.Controls.Add(this.settlementDateTimePicker);
            this.settlementGroupBox.Controls.Add(this.bankNameComboBox);
            this.settlementGroupBox.Controls.Add(this.label11);
            this.settlementGroupBox.Controls.Add(this.paymentMethodComboBox);
            this.settlementGroupBox.Controls.Add(this.bankNameLabel);
            this.settlementGroupBox.Controls.Add(this.settlementAmountTxtBox);
            this.settlementGroupBox.Controls.Add(this.accontNumComboBox);
            this.settlementGroupBox.Controls.Add(this.label13);
            this.settlementGroupBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settlementGroupBox.Location = new System.Drawing.Point(828, 86);
            this.settlementGroupBox.Name = "settlementGroupBox";
            this.settlementGroupBox.Size = new System.Drawing.Size(309, 318);
            this.settlementGroupBox.TabIndex = 4;
            this.settlementGroupBox.TabStop = false;
            this.settlementGroupBox.Text = "Settlement";
            // 
            // refreshButton
            // 
            this.refreshButton.BackgroundImage = global::BillsPayableSystem.Properties.Resources.Capture;
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(899, 423);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(114, 43);
            this.refreshButton.TabIndex = 0;
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::BillsPayableSystem.Properties.Resources.pay_button_blue_hi;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1015, 423);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 43);
            this.btnSave.TabIndex = 1;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1249, 556);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.settlementGroupBox);
            this.Controls.Add(this.paymentInfoGroupBox);
            this.Controls.Add(this.approvalGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPayment_FormClosed);
            this.Load += new System.EventHandler(this.PaymentUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billsPayableDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdepartmentBindingSource)).EndInit();
            this.approvalGroupBox.ResumeLayout(false);
            this.approvalGroupBox.PerformLayout();
            this.paymentInfoGroupBox.ResumeLayout(false);
            this.paymentInfoGroupBox.PerformLayout();
            this.settlementGroupBox.ResumeLayout(false);
            this.settlementGroupBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox approvalGroupBox;
        private System.Windows.Forms.GroupBox paymentInfoGroupBox;
        private System.Windows.Forms.Button agreeButton;
        private System.Windows.Forms.GroupBox settlementGroupBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button approveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}