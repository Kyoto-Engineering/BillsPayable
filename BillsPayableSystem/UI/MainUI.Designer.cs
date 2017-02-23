namespace BillsPayableSystem.UI
{
    partial class MainUI1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI1));
            this.btnBillEntry = new System.Windows.Forms.Button();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPayment = new System.Windows.Forms.Button();
            this.showBillListButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBillEntry
            // 
            this.btnBillEntry.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBillEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBillEntry.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillEntry.Location = new System.Drawing.Point(15, 93);
            this.btnBillEntry.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBillEntry.Name = "btnBillEntry";
            this.btnBillEntry.Size = new System.Drawing.Size(147, 66);
            this.btnBillEntry.TabIndex = 0;
            this.btnBillEntry.Text = "Bill Entry";
            this.btnBillEntry.UseVisualStyleBackColor = false;
            this.btnBillEntry.Click += new System.EventHandler(this.btnBillEntry_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRegistration.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistration.Location = new System.Drawing.Point(15, 387);
            this.btnRegistration.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(147, 66);
            this.btnRegistration.TabIndex = 1;
            this.btnRegistration.Text = "Registration";
            this.btnRegistration.UseVisualStyleBackColor = false;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(403, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Payable Bills System";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox1.Controls.Add(this.showBillListButton);
            this.groupBox1.Controls.Add(this.btnPayment);
            this.groupBox1.Controls.Add(this.btnBillEntry);
            this.groupBox1.Controls.Add(this.btnRegistration);
            this.groupBox1.Location = new System.Drawing.Point(51, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(172, 527);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPayment.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(15, 289);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(147, 66);
            this.btnPayment.TabIndex = 2;
            this.btnPayment.Text = "Unpaid Bill List And Pay";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // showBillListButton
            // 
            this.showBillListButton.BackColor = System.Drawing.Color.ForestGreen;
            this.showBillListButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showBillListButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBillListButton.Location = new System.Drawing.Point(15, 191);
            this.showBillListButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.showBillListButton.Name = "showBillListButton";
            this.showBillListButton.Size = new System.Drawing.Size(147, 66);
            this.showBillListButton.TabIndex = 3;
            this.showBillListButton.Text = "Bill List";
            this.showBillListButton.UseVisualStyleBackColor = false;
            this.showBillListButton.Click += new System.EventHandler(this.showBillListButton_Click);
            // 
            // MainUI1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1114, 640);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainUI1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainUI1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBillEntry;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button showBillListButton;
    }
}