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
            this.txtpictureBox = new System.Windows.Forms.PictureBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.lblBillImage = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBillSiNo = new System.Windows.Forms.Label();
            this.txtBillSerialNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPaymentDate.Location = new System.Drawing.Point(227, 95);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(282, 29);
            this.dtpPaymentDate.TabIndex = 0;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDate.Location = new System.Drawing.Point(76, 99);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(135, 22);
            this.lblPaymentDate.TabIndex = 1;
            this.lblPaymentDate.Text = "Payment Date :";
            // 
            // txtpictureBox
            // 
            this.txtpictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtpictureBox.BackgroundImage")));
            this.txtpictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtpictureBox.Location = new System.Drawing.Point(227, 184);
            this.txtpictureBox.Name = "txtpictureBox";
            this.txtpictureBox.Size = new System.Drawing.Size(420, 301);
            this.txtpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtpictureBox.TabIndex = 2;
            this.txtpictureBox.TabStop = false;
            this.txtpictureBox.Click += new System.EventHandler(this.txtpictureBox_Click);
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.Color.Cyan;
            this.browseButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.browseButton.Location = new System.Drawing.Point(227, 492);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(219, 31);
            this.browseButton.TabIndex = 3;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // lblBillImage
            // 
            this.lblBillImage.AutoSize = true;
            this.lblBillImage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillImage.Location = new System.Drawing.Point(107, 187);
            this.lblBillImage.Name = "lblBillImage";
            this.lblBillImage.Size = new System.Drawing.Size(104, 22);
            this.lblBillImage.TabIndex = 4;
            this.lblBillImage.Text = "Bill Image :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(532, 536);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 65);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(858, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 42);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(795, 8);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(58, 41);
            this.btnMin.TabIndex = 7;
            this.btnMin.Text = "Min";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(412, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Payment";
            // 
            // lblBillSiNo
            // 
            this.lblBillSiNo.AutoSize = true;
            this.lblBillSiNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillSiNo.Location = new System.Drawing.Point(81, 143);
            this.lblBillSiNo.Name = "lblBillSiNo";
            this.lblBillSiNo.Size = new System.Drawing.Size(130, 22);
            this.lblBillSiNo.TabIndex = 9;
            this.lblBillSiNo.Text = "Bill Serial No :";
            // 
            // txtBillSerialNo
            // 
            this.txtBillSerialNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillSerialNo.Location = new System.Drawing.Point(227, 141);
            this.txtBillSerialNo.Name = "txtBillSerialNo";
            this.txtBillSerialNo.Size = new System.Drawing.Size(282, 29);
            this.txtBillSerialNo.TabIndex = 10;
            this.txtBillSerialNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBillSerialNo_KeyPress);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(922, 646);
            this.ControlBox = false;
            this.Controls.Add(this.txtBillSerialNo);
            this.Controls.Add(this.lblBillSiNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblBillImage);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.txtpictureBox);
            this.Controls.Add(this.lblPaymentDate);
            this.Controls.Add(this.dtpPaymentDate);
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentUI";
            this.Load += new System.EventHandler(this.PaymentUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label lblBillImage;
        public System.Windows.Forms.PictureBox txtpictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBillSiNo;
        private System.Windows.Forms.TextBox txtBillSerialNo;
    }
}