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
            this.btnBillEntry = new System.Windows.Forms.Button();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBillEntry
            // 
            this.btnBillEntry.Location = new System.Drawing.Point(44, 117);
            this.btnBillEntry.Name = "btnBillEntry";
            this.btnBillEntry.Size = new System.Drawing.Size(85, 79);
            this.btnBillEntry.TabIndex = 0;
            this.btnBillEntry.Text = "Bill Entry";
            this.btnBillEntry.UseVisualStyleBackColor = true;
            // 
            // btnRegistration
            // 
            this.btnRegistration.Location = new System.Drawing.Point(44, 245);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(85, 78);
            this.btnRegistration.TabIndex = 1;
            this.btnRegistration.Text = "Registration";
            this.btnRegistration.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bills Payable System";
            // 
            // MainUI1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.btnBillEntry);
            this.Name = "MainUI1";
            this.Text = "MainUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBillEntry;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Label label1;
    }
}