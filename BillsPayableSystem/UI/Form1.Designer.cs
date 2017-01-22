namespace BillsPayableSystem
{
    partial class Form1
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
            this.lblBillsType = new System.Windows.Forms.Label();
            this.lblBillsName = new System.Windows.Forms.Label();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.cmbBillsType = new System.Windows.Forms.ComboBox();
            this.cmbBillsName = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BtnSave = new System.Windows.Forms.Button();
            this.lblFinancialYear = new System.Windows.Forms.Label();
            this.cmbFY = new System.Windows.Forms.ComboBox();
            this.lblPayableTo = new System.Windows.Forms.Label();
            this.txtPayableTo = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbTransactionName = new System.Windows.Forms.ComboBox();
            this.txtDescriptions = new System.Windows.Forms.RichTextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTransactionName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.DueDate = new System.Windows.Forms.DateTimePicker();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBillsType
            // 
            this.lblBillsType.AutoSize = true;
            this.lblBillsType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillsType.Location = new System.Drawing.Point(37, 151);
            this.lblBillsType.Name = "lblBillsType";
            this.lblBillsType.Size = new System.Drawing.Size(81, 19);
            this.lblBillsType.TabIndex = 0;
            this.lblBillsType.Text = "Bills Type:";
            // 
            // lblBillsName
            // 
            this.lblBillsName.AutoSize = true;
            this.lblBillsName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillsName.Location = new System.Drawing.Point(32, 198);
            this.lblBillsName.Name = "lblBillsName";
            this.lblBillsName.Size = new System.Drawing.Size(88, 19);
            this.lblBillsName.TabIndex = 1;
            this.lblBillsName.Text = "Bills Name:";
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDate.Location = new System.Drawing.Point(69, 69);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(47, 19);
            this.lblPaymentDate.TabIndex = 2;
            this.lblPaymentDate.Text = "Date:";
            // 
            // cmbBillsType
            // 
            this.cmbBillsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBillsType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBillsType.FormattingEnabled = true;
            this.cmbBillsType.Location = new System.Drawing.Point(136, 151);
            this.cmbBillsType.Name = "cmbBillsType";
            this.cmbBillsType.Size = new System.Drawing.Size(200, 27);
            this.cmbBillsType.TabIndex = 6;
            this.cmbBillsType.SelectedIndexChanged += new System.EventHandler(this.cmbBillsType_SelectedIndexChanged);
            // 
            // cmbBillsName
            // 
            this.cmbBillsName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBillsName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBillsName.FormattingEnabled = true;
            this.cmbBillsName.Location = new System.Drawing.Point(136, 198);
            this.cmbBillsName.Name = "cmbBillsName";
            this.cmbBillsName.Size = new System.Drawing.Size(200, 27);
            this.cmbBillsName.TabIndex = 7;
            this.cmbBillsName.SelectedIndexChanged += new System.EventHandler(this.cmbBillsName_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(622, 283);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(88, 46);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblFinancialYear
            // 
            this.lblFinancialYear.AutoSize = true;
            this.lblFinancialYear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinancialYear.Location = new System.Drawing.Point(30, 31);
            this.lblFinancialYear.Name = "lblFinancialYear";
            this.lblFinancialYear.Size = new System.Drawing.Size(86, 19);
            this.lblFinancialYear.TabIndex = 13;
            this.lblFinancialYear.Text = "Fiscal Year:";
            // 
            // cmbFY
            // 
            this.cmbFY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFY.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFY.FormattingEnabled = true;
            this.cmbFY.Items.AddRange(new object[] {
            "2015-16",
            "2016-17",
            "2017-18",
            "2018-19",
            "2019-20",
            "2020-21",
            "2021-22",
            "2022-23",
            "2023-24",
            "2024-25"});
            this.cmbFY.Location = new System.Drawing.Point(136, 31);
            this.cmbFY.Name = "cmbFY";
            this.cmbFY.Size = new System.Drawing.Size(200, 27);
            this.cmbFY.TabIndex = 14;
            // 
            // lblPayableTo
            // 
            this.lblPayableTo.AutoSize = true;
            this.lblPayableTo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayableTo.Location = new System.Drawing.Point(29, 109);
            this.lblPayableTo.Name = "lblPayableTo";
            this.lblPayableTo.Size = new System.Drawing.Size(88, 19);
            this.lblPayableTo.TabIndex = 15;
            this.lblPayableTo.Text = "Payable To:";
            // 
            // txtPayableTo
            // 
            this.txtPayableTo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayableTo.Location = new System.Drawing.Point(136, 111);
            this.txtPayableTo.Name = "txtPayableTo";
            this.txtPayableTo.Size = new System.Drawing.Size(200, 26);
            this.txtPayableTo.TabIndex = 16;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(525, 235);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 26);
            this.txtAmount.TabIndex = 25;
            // 
            // cmbTransactionName
            // 
            this.cmbTransactionName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransactionName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTransactionName.FormattingEnabled = true;
            this.cmbTransactionName.Items.AddRange(new object[] {
            "Cheque",
            "Cash"});
            this.cmbTransactionName.Location = new System.Drawing.Point(525, 190);
            this.cmbTransactionName.Name = "cmbTransactionName";
            this.cmbTransactionName.Size = new System.Drawing.Size(200, 27);
            this.cmbTransactionName.TabIndex = 24;
            // 
            // txtDescriptions
            // 
            this.txtDescriptions.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptions.Location = new System.Drawing.Point(525, 33);
            this.txtDescriptions.Name = "txtDescriptions";
            this.txtDescriptions.Size = new System.Drawing.Size(200, 88);
            this.txtDescriptions.TabIndex = 23;
            this.txtDescriptions.Text = "";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(448, 235);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(66, 19);
            this.lblAmount.TabIndex = 22;
            this.lblAmount.Text = "Amount:";
            // 
            // lblTransactionName
            // 
            this.lblTransactionName.AutoSize = true;
            this.lblTransactionName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionName.Location = new System.Drawing.Point(385, 190);
            this.lblTransactionName.Name = "lblTransactionName";
            this.lblTransactionName.Size = new System.Drawing.Size(129, 19);
            this.lblTransactionName.TabIndex = 21;
            this.lblTransactionName.Text = "Transaction Type:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(416, 31);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(98, 19);
            this.lblDescription.TabIndex = 20;
            this.lblDescription.Text = "Descriptions:";
            // 
            // DueDate
            // 
            this.DueDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDate.Location = new System.Drawing.Point(525, 139);
            this.DueDate.Name = "DueDate";
            this.DueDate.Size = new System.Drawing.Size(200, 26);
            this.DueDate.TabIndex = 29;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(435, 139);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(79, 19);
            this.lblDueDate.TabIndex = 28;
            this.lblDueDate.Text = "Due Date:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(777, 361);
            this.Controls.Add(this.DueDate);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.cmbTransactionName);
            this.Controls.Add(this.txtDescriptions);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblTransactionName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtPayableTo);
            this.Controls.Add(this.lblPayableTo);
            this.Controls.Add(this.cmbFY);
            this.Controls.Add(this.lblFinancialYear);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbBillsName);
            this.Controls.Add(this.cmbBillsType);
            this.Controls.Add(this.lblPaymentDate);
            this.Controls.Add(this.lblBillsName);
            this.Controls.Add(this.lblBillsType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBillsType;
        private System.Windows.Forms.Label lblBillsName;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.ComboBox cmbBillsType;
        private System.Windows.Forms.ComboBox cmbBillsName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label lblFinancialYear;
        private System.Windows.Forms.ComboBox cmbFY;
        private System.Windows.Forms.Label lblPayableTo;
        private System.Windows.Forms.TextBox txtPayableTo;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cmbTransactionName;
        private System.Windows.Forms.RichTextBox txtDescriptions;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTransactionName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DateTimePicker DueDate;
        private System.Windows.Forms.Label lblDueDate;
    }
}

