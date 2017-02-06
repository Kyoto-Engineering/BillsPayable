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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillEntry));
            this.BtnSave = new System.Windows.Forms.Button();
            this.txtBillNarrative = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.lblBillType = new System.Windows.Forms.Label();
            this.lblBillsName = new System.Windows.Forms.Label();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.cmbBillType = new System.Windows.Forms.ComboBox();
            this.cmbBillPurpose = new System.Windows.Forms.ComboBox();
            this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
            this.lblPayableTo = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblBillReceivedDate = new System.Windows.Forms.Label();
            this.dtpBillReceivedDate = new System.Windows.Forms.DateTimePicker();
            this.cmbPayableTo = new System.Windows.Forms.ComboBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblSiNo = new System.Windows.Forms.Label();
            this.txtBillSiNo = new System.Windows.Forms.TextBox();
            this.lblBillImage = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.txtpictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.txtpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.DarkGreen;
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.Location = new System.Drawing.Point(555, 502);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(112, 60);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtBillNarrative
            // 
            this.txtBillNarrative.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillNarrative.Location = new System.Drawing.Point(813, 298);
            this.txtBillNarrative.Name = "txtBillNarrative";
            this.txtBillNarrative.Size = new System.Drawing.Size(363, 112);
            this.txtBillNarrative.TabIndex = 12;
            this.txtBillNarrative.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Blue;
            this.lblDescription.Location = new System.Drawing.Point(675, 301);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(132, 22);
            this.lblDescription.TabIndex = 20;
            this.lblDescription.Text = "Bill Narrative :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(524, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 35;
            this.label1.Text = "Bill Entry";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.Blue;
            this.lblNote.Location = new System.Drawing.Point(748, 420);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(59, 22);
            this.lblNote.TabIndex = 36;
            this.lblNote.Text = "Note :";
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNote.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(813, 416);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(363, 63);
            this.txtNote.TabIndex = 13;
            this.txtNote.Text = "";
            // 
            // lblBillType
            // 
            this.lblBillType.AutoSize = true;
            this.lblBillType.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillType.ForeColor = System.Drawing.Color.Blue;
            this.lblBillType.Location = new System.Drawing.Point(173, 384);
            this.lblBillType.Name = "lblBillType";
            this.lblBillType.Size = new System.Drawing.Size(93, 22);
            this.lblBillType.TabIndex = 0;
            this.lblBillType.Text = "Bill Type :";
            // 
            // lblBillsName
            // 
            this.lblBillsName.AutoSize = true;
            this.lblBillsName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillsName.ForeColor = System.Drawing.Color.Blue;
            this.lblBillsName.Location = new System.Drawing.Point(146, 461);
            this.lblBillsName.Name = "lblBillsName";
            this.lblBillsName.Size = new System.Drawing.Size(120, 22);
            this.lblBillsName.TabIndex = 1;
            this.lblBillsName.Text = "Bill Purpose :";
            // 
            // lblBillDate
            // 
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillDate.ForeColor = System.Drawing.Color.Blue;
            this.lblBillDate.Location = new System.Drawing.Point(24, 76);
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
            this.cmbBillType.Location = new System.Drawing.Point(272, 383);
            this.cmbBillType.Name = "cmbBillType";
            this.cmbBillType.Size = new System.Drawing.Size(267, 30);
            this.cmbBillType.TabIndex = 7;
            this.cmbBillType.SelectedIndexChanged += new System.EventHandler(this.cmbBillsType_SelectedIndexChanged);
            // 
            // cmbBillPurpose
            // 
            this.cmbBillPurpose.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBillPurpose.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBillPurpose.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBillPurpose.FormattingEnabled = true;
            this.cmbBillPurpose.Location = new System.Drawing.Point(272, 458);
            this.cmbBillPurpose.Name = "cmbBillPurpose";
            this.cmbBillPurpose.Size = new System.Drawing.Size(267, 30);
            this.cmbBillPurpose.TabIndex = 10;
            this.cmbBillPurpose.SelectedIndexChanged += new System.EventHandler(this.cmbBillPurpose_SelectedIndexChanged_1);
            this.cmbBillPurpose.Leave += new System.EventHandler(this.cmbBillPurpose_Leave);
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dtpBillDate.CustomFormat = " dd/MM/yyyy";
            this.dtpBillDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBillDate.Location = new System.Drawing.Point(272, 76);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(142, 29);
            this.dtpBillDate.TabIndex = 0;
            // 
            // lblPayableTo
            // 
            this.lblPayableTo.AutoSize = true;
            this.lblPayableTo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayableTo.ForeColor = System.Drawing.Color.Blue;
            this.lblPayableTo.Location = new System.Drawing.Point(155, 257);
            this.lblPayableTo.Name = "lblPayableTo";
            this.lblPayableTo.Size = new System.Drawing.Size(111, 22);
            this.lblPayableTo.TabIndex = 15;
            this.lblPayableTo.Text = "Payable To :";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.ForeColor = System.Drawing.Color.Blue;
            this.lblPaymentMethod.Location = new System.Drawing.Point(25, 345);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(241, 22);
            this.lblPaymentMethod.TabIndex = 21;
            this.lblPaymentMethod.Text = "Proposed Payment Method :";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.Blue;
            this.lblAmount.Location = new System.Drawing.Point(182, 302);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(84, 22);
            this.lblAmount.TabIndex = 22;
            this.lblAmount.Text = "Amount :";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Cheque",
            "Cash"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(272, 342);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(267, 30);
            this.cmbPaymentMethod.TabIndex = 6;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(272, 301);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(267, 29);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.ForeColor = System.Drawing.Color.Blue;
            this.lblDueDate.Location = new System.Drawing.Point(169, 170);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(97, 22);
            this.lblDueDate.TabIndex = 28;
            this.lblDueDate.Text = "Due Date :";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDueDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDueDate.Location = new System.Drawing.Point(272, 169);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(144, 29);
            this.dtpDueDate.TabIndex = 2;
            // 
            // lblBillReceivedDate
            // 
            this.lblBillReceivedDate.AutoSize = true;
            this.lblBillReceivedDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillReceivedDate.ForeColor = System.Drawing.Color.Blue;
            this.lblBillReceivedDate.Location = new System.Drawing.Point(95, 123);
            this.lblBillReceivedDate.Name = "lblBillReceivedDate";
            this.lblBillReceivedDate.Size = new System.Drawing.Size(171, 22);
            this.lblBillReceivedDate.TabIndex = 30;
            this.lblBillReceivedDate.Text = "Bill Received Date :";
            // 
            // dtpBillReceivedDate
            // 
            this.dtpBillReceivedDate.CustomFormat = "dd/MM/yyyy";
            this.dtpBillReceivedDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBillReceivedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBillReceivedDate.Location = new System.Drawing.Point(272, 122);
            this.dtpBillReceivedDate.Name = "dtpBillReceivedDate";
            this.dtpBillReceivedDate.Size = new System.Drawing.Size(144, 29);
            this.dtpBillReceivedDate.TabIndex = 1;
            // 
            // cmbPayableTo
            // 
            this.cmbPayableTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPayableTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPayableTo.DropDownWidth = 233;
            this.cmbPayableTo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPayableTo.FormattingEnabled = true;
            this.cmbPayableTo.ItemHeight = 22;
            this.cmbPayableTo.Location = new System.Drawing.Point(272, 255);
            this.cmbPayableTo.Name = "cmbPayableTo";
            this.cmbPayableTo.Size = new System.Drawing.Size(267, 30);
            this.cmbPayableTo.TabIndex = 4;
            this.cmbPayableTo.SelectedIndexChanged += new System.EventHandler(this.cmbPayableTo_SelectedIndexChanged);
            this.cmbPayableTo.Leave += new System.EventHandler(this.cmbPayableTo_Leave);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.Blue;
            this.lblFrom.Location = new System.Drawing.Point(140, 424);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(65, 22);
            this.lblFrom.TabIndex = 39;
            this.lblFrom.Text = "From :";
            this.lblFrom.Visible = false;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.Color.Blue;
            this.lblTo.Location = new System.Drawing.Point(358, 424);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(41, 22);
            this.lblTo.TabIndex = 40;
            this.lblTo.Text = "To :";
            this.lblTo.Visible = false;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = " dd/MM/yyyy";
            this.dtpFrom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(209, 422);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(134, 29);
            this.dtpFrom.TabIndex = 8;
            this.dtpFrom.Visible = false;
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = " dd/MM/yyyy";
            this.dtpTo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(405, 422);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(134, 29);
            this.dtpTo.TabIndex = 9;
            this.dtpTo.Visible = false;
            // 
            // lblSiNo
            // 
            this.lblSiNo.AutoSize = true;
            this.lblSiNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiNo.ForeColor = System.Drawing.Color.Blue;
            this.lblSiNo.Location = new System.Drawing.Point(136, 213);
            this.lblSiNo.Name = "lblSiNo";
            this.lblSiNo.Size = new System.Drawing.Size(130, 22);
            this.lblSiNo.TabIndex = 43;
            this.lblSiNo.Text = "Bill Serial No :";
            // 
            // txtBillSiNo
            // 
            this.txtBillSiNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillSiNo.Location = new System.Drawing.Point(272, 211);
            this.txtBillSiNo.Name = "txtBillSiNo";
            this.txtBillSiNo.Size = new System.Drawing.Size(267, 29);
            this.txtBillSiNo.TabIndex = 3;
            // 
            // lblBillImage
            // 
            this.lblBillImage.AutoSize = true;
            this.lblBillImage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillImage.ForeColor = System.Drawing.Color.Blue;
            this.lblBillImage.Location = new System.Drawing.Point(701, 68);
            this.lblBillImage.Name = "lblBillImage";
            this.lblBillImage.Size = new System.Drawing.Size(104, 22);
            this.lblBillImage.TabIndex = 49;
            this.lblBillImage.Text = "Bill Image :";
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.Color.Cyan;
            this.browseButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.ForeColor = System.Drawing.Color.Black;
            this.browseButton.Location = new System.Drawing.Point(813, 260);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(144, 33);
            this.browseButton.TabIndex = 11;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // txtpictureBox
            // 
            this.txtpictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtpictureBox.BackgroundImage")));
            this.txtpictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtpictureBox.Location = new System.Drawing.Point(813, 68);
            this.txtpictureBox.Name = "txtpictureBox";
            this.txtpictureBox.Size = new System.Drawing.Size(363, 189);
            this.txtpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtpictureBox.TabIndex = 47;
            this.txtpictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmBillEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1238, 655);
            this.Controls.Add(this.lblBillImage);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.txtpictureBox);
            this.Controls.Add(this.txtBillSiNo);
            this.Controls.Add(this.lblSiNo);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.cmbPayableTo);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.label1);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill Entry";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBillEntry_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.RichTextBox txtBillNarrative;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.RichTextBox txtNote;

        private System.Windows.Forms.Label lblBillType;
        private System.Windows.Forms.Label lblBillsName;
        private System.Windows.Forms.Label lblBillDate;
        private System.Windows.Forms.ComboBox cmbBillType;
        private System.Windows.Forms.ComboBox cmbBillPurpose;
        private System.Windows.Forms.DateTimePicker dtpBillDate;
        private System.Windows.Forms.Label lblPayableTo;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label lblBillReceivedDate;
        private System.Windows.Forms.DateTimePicker dtpBillReceivedDate;
        private System.Windows.Forms.ComboBox cmbPayableTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblSiNo;
        private System.Windows.Forms.TextBox txtBillSiNo;
        private System.Windows.Forms.Label lblBillImage;
        private System.Windows.Forms.Button browseButton;
        public System.Windows.Forms.PictureBox txtpictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

