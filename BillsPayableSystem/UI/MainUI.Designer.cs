﻿namespace BillsPayableSystem.UI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBillEntry
            // 
            this.btnBillEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBillEntry.Location = new System.Drawing.Point(28, 38);
            this.btnBillEntry.Name = "btnBillEntry";
            this.btnBillEntry.Size = new System.Drawing.Size(85, 79);
            this.btnBillEntry.TabIndex = 0;
            this.btnBillEntry.Text = "Bill Entry";
            this.btnBillEntry.UseVisualStyleBackColor = false;
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRegistration.Location = new System.Drawing.Point(28, 153);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(85, 78);
            this.btnRegistration.TabIndex = 1;
            this.btnRegistration.Text = "Registration";
            this.btnRegistration.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bills Payable System";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBillEntry);
            this.groupBox1.Controls.Add(this.btnRegistration);
            this.groupBox1.Location = new System.Drawing.Point(47, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 295);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // MainUI1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(932, 473);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "MainUI1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainUI";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBillEntry;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}