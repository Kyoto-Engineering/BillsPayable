namespace BillsPayableSystem
{
    partial class frmBillEntry
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
            this.lblBillType = new System.Windows.Forms.Label();
            this.lblBillsName = new System.Windows.Forms.Label();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.cmbBillType = new System.Windows.Forms.ComboBox();
            this.cmbBillPurpose = new System.Windows.Forms.ComboBox();
            this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
            this.BtnSave = new System.Windows.Forms.Button();
            this.lblPayableTo = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.txtBillNarrative = new System.Windows.Forms.RichTextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblBillReceivedDate = new System.Windows.Forms.Label();
            this.dtpBillReceivedDate = new System.Windows.Forms.DateTimePicker();
            this.txtPayableTo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.cmbPayableTo = new System.Windows.Forms.ComboBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblBillType
            // 
            this.lblBillType.AutoSize = true;
            this.lblBillType.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillType.ForeColor = System.Drawing.Color.Yellow;
            this.lblBillType.Location = new System.Drawing.Point(699, 85);
            this.lblBillType.Name = "lblBillType";
            this.lblBillType.Size = new System.Drawing.Size(93, 22);
            this.lblBillType.TabIndex = 0;
            this.lblBillType.Text = "Bill Type :";
            // 
            // lblBillsName
            // 
            this.lblBillsName.AutoSize = true;
            this.lblBillsName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillsName.ForeColor = System.Drawing.Color.Yellow;
            this.lblBillsName.Location = new System.Drawing.Point(687, 170);
            this.lblBillsName.Name = "lblBillsName";
            this.lblBillsName.Size = new System.Drawing.Size(120, 22);
            this.lblBillsName.TabIndex = 1;
            this.lblBillsName.Text = "Bill Purpose :";
            // 
            // lblBillDate
            // 
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillDate.ForeColor = System.Drawing.Color.Yellow;
            this.lblBillDate.Location = new System.Drawing.Point(24, 80);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Size = new System.Drawing.Size(242, 22);
            this.lblBillDate.TabIndex = 2;
            this.lblBillDate.Text = "Bill Date/Date Of Bill Issue :";
            // 
            // cmbBillType
            // 
            this.cmbBillType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBillType.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBillType.FormattingEnabled = true;
            this.cmbBillType.Location = new System.Drawing.Point(813, 85);
            this.cmbBillType.Name = "cmbBillType";
            this.cmbBillType.Size = new System.Drawing.Size(363, 30);
            this.cmbBillType.TabIndex = 6;
            this.cmbBillType.SelectedIndexChanged += new System.EventHandler(this.cmbBillsType_SelectedIndexChanged);
            // 
            // cmbBillPurpose
            // 
            this.cmbBillPurpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBillPurpose.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBillPurpose.FormattingEnabled = true;
            this.cmbBillPurpose.Location = new System.Drawing.Point(813, 170);
            this.cmbBillPurpose.Name = "cmbBillPurpose";
            this.cmbBillPurpose.Size = new System.Drawing.Size(363, 30);
            this.cmbBillPurpose.TabIndex = 7;
            this.cmbBillPurpose.SelectedIndexChanged += new System.EventHandler(this.cmbBillPurpose_SelectedIndexChanged_1);
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBillDate.Location = new System.Drawing.Point(272, 85);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(267, 29);
            this.dtpBillDate.TabIndex = 8;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.DarkGreen;
            this.BtnSave.Location = new System.Drawing.Point(618, 477);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(112, 60);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblPayableTo
            // 
            this.lblPayableTo.AutoSize = true;
            this.lblPayableTo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayableTo.ForeColor = System.Drawing.Color.Yellow;
            this.lblPayableTo.Location = new System.Drawing.Point(155, 260);
            this.lblPayableTo.Name = "lblPayableTo";
            this.lblPayableTo.Size = new System.Drawing.Size(111, 22);
            this.lblPayableTo.TabIndex = 15;
            this.lblPayableTo.Text = "Payable To :";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(272, 364);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(267, 29);
            this.txtAmount.TabIndex = 25;
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Cheque",
            "Cash"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(272, 402);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(267, 30);
            this.cmbPaymentMethod.TabIndex = 24;
            // 
            // txtBillNarrative
            // 
            this.txtBillNarrative.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillNarrative.Location = new System.Drawing.Point(813, 248);
            this.txtBillNarrative.Name = "txtBillNarrative";
            this.txtBillNarrative.Size = new System.Drawing.Size(363, 119);
            this.txtBillNarrative.TabIndex = 23;
            this.txtBillNarrative.Text = "";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.Yellow;
            this.lblAmount.Location = new System.Drawing.Point(182, 364);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(84, 22);
            this.lblAmount.TabIndex = 22;
            this.lblAmount.Text = "Amount :";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.ForeColor = System.Drawing.Color.Yellow;
            this.lblPaymentMethod.Location = new System.Drawing.Point(107, 402);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(159, 22);
            this.lblPaymentMethod.TabIndex = 21;
            this.lblPaymentMethod.Text = "Payment Method :";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Yellow;
            this.lblDescription.Location = new System.Drawing.Point(675, 220);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(132, 22);
            this.lblDescription.TabIndex = 20;
            this.lblDescription.Text = "Bill Narrative :";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueDate.Location = new System.Drawing.Point(272, 211);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(267, 29);
            this.dtpDueDate.TabIndex = 29;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.ForeColor = System.Drawing.Color.Yellow;
            this.lblDueDate.Location = new System.Drawing.Point(169, 211);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(97, 22);
            this.lblDueDate.TabIndex = 28;
            this.lblDueDate.Text = "Due Date :";
            // 
            // lblBillReceivedDate
            // 
            this.lblBillReceivedDate.AutoSize = true;
            this.lblBillReceivedDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillReceivedDate.ForeColor = System.Drawing.Color.Yellow;
            this.lblBillReceivedDate.Location = new System.Drawing.Point(95, 141);
            this.lblBillReceivedDate.Name = "lblBillReceivedDate";
            this.lblBillReceivedDate.Size = new System.Drawing.Size(171, 22);
            this.lblBillReceivedDate.TabIndex = 30;
            this.lblBillReceivedDate.Text = "Bill Received Date :";
            // 
            // dtpBillReceivedDate
            // 
            this.dtpBillReceivedDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBillReceivedDate.Location = new System.Drawing.Point(272, 142);
            this.dtpBillReceivedDate.Name = "dtpBillReceivedDate";
            this.dtpBillReceivedDate.Size = new System.Drawing.Size(267, 29);
            this.dtpBillReceivedDate.TabIndex = 31;
            // 
            // txtPayableTo
            // 
            this.txtPayableTo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayableTo.Location = new System.Drawing.Point(272, 296);
            this.txtPayableTo.Name = "txtPayableTo";
            this.txtPayableTo.Size = new System.Drawing.Size(267, 52);
            this.txtPayableTo.TabIndex = 34;
            this.txtPayableTo.Text = "";
            this.txtPayableTo.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(509, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 35;
            this.label1.Text = "Bill Entry";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblNote.Location = new System.Drawing.Point(748, 373);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(59, 22);
            this.lblNote.TabIndex = 36;
            this.lblNote.Text = "Note :";
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(813, 373);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(363, 63);
            this.txtNote.TabIndex = 37;
            this.txtNote.Text = "";
            // 
            // cmbPayableTo
            // 
            this.cmbPayableTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPayableTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPayableTo.DropDownWidth = 233;
            this.cmbPayableTo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPayableTo.FormattingEnabled = true;
            this.cmbPayableTo.ItemHeight = 22;
            this.cmbPayableTo.Location = new System.Drawing.Point(272, 260);
            this.cmbPayableTo.Name = "cmbPayableTo";
            this.cmbPayableTo.Size = new System.Drawing.Size(267, 30);
            this.cmbPayableTo.TabIndex = 38;
            this.cmbPayableTo.SelectedIndexChanged += new System.EventHandler(this.cmbPayableTo_SelectedIndexChanged);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(736, 135);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(53, 19);
            this.lblFrom.TabIndex = 39;
            this.lblFrom.Text = "From :";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(994, 135);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(35, 19);
            this.lblTo.TabIndex = 40;
            this.lblTo.Text = "To :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(813, 131);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(163, 26);
            this.dateTimePicker1.TabIndex = 41;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(1034, 131);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(142, 26);
            this.dateTimePicker2.TabIndex = 42;
            // 
            // frmBillEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1283, 694);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.cmbPayableTo);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPayableTo);
            this.Controls.Add(this.dtpBillReceivedDate);
            this.Controls.Add(this.lblBillReceivedDate);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.cmbPaymentMethod);
            this.Controls.Add(this.txtBillNarrative);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPayableTo);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.dtpBillDate);
            this.Controls.Add(this.cmbBillPurpose);
            this.Controls.Add(this.cmbBillType);
            this.Controls.Add(this.lblBillDate);
            this.Controls.Add(this.lblBillsName);
            this.Controls.Add(this.lblBillType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBillEntry";
            this.Text = "Bill Entry";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBillType;
        private System.Windows.Forms.Label lblBillsName;
        private System.Windows.Forms.Label lblBillDate;
        private System.Windows.Forms.ComboBox cmbBillType;
        private System.Windows.Forms.ComboBox cmbBillPurpose;
        private System.Windows.Forms.DateTimePicker dtpBillDate;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label lblPayableTo;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.RichTextBox txtBillNarrative;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblBillReceivedDate;
        private System.Windows.Forms.DateTimePicker dtpBillReceivedDate;
        private System.Windows.Forms.RichTextBox txtPayableTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.RichTextBox txtNote;
        private System.Windows.Forms.ComboBox cmbPayableTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}

