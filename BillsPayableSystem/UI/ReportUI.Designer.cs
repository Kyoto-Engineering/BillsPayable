namespace BillsPayableSystem.UI
{
    partial class ReportUI
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
            this.unpaidBillListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // unpaidBillListButton
            // 
            this.unpaidBillListButton.BackColor = System.Drawing.Color.LightCyan;
            this.unpaidBillListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unpaidBillListButton.Location = new System.Drawing.Point(111, 60);
            this.unpaidBillListButton.Name = "unpaidBillListButton";
            this.unpaidBillListButton.Size = new System.Drawing.Size(186, 63);
            this.unpaidBillListButton.TabIndex = 0;
            this.unpaidBillListButton.Text = "Unpaid Bill List";
            this.unpaidBillListButton.UseVisualStyleBackColor = false;
            this.unpaidBillListButton.Click += new System.EventHandler(this.unpaidBillListButton_Click);
            // 
            // ReportUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(791, 396);
            this.Controls.Add(this.unpaidBillListButton);
            this.Name = "ReportUI";
            this.Text = "ReportUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button unpaidBillListButton;
    }
}