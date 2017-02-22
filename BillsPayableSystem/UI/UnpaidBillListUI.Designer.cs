namespace BillsPayableSystem.UI
{
    partial class UnpaidBillListUI
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
            this.uppaidBillListDataGridView = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uppaidBillListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uppaidBillListDataGridView
            // 
            this.uppaidBillListDataGridView.AllowUserToAddRows = false;
            this.uppaidBillListDataGridView.AllowUserToDeleteRows = false;
            this.uppaidBillListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uppaidBillListDataGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            this.uppaidBillListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uppaidBillListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uppaidBillListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.uppaidBillListDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uppaidBillListDataGridView.Location = new System.Drawing.Point(53, 111);
            this.uppaidBillListDataGridView.MultiSelect = false;
            this.uppaidBillListDataGridView.Name = "uppaidBillListDataGridView";
            this.uppaidBillListDataGridView.ReadOnly = true;
            this.uppaidBillListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uppaidBillListDataGridView.Size = new System.Drawing.Size(863, 361);
            this.uppaidBillListDataGridView.TabIndex = 0;
            this.uppaidBillListDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.uppaidBillListDataGridView_CellMouseClick);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(342, 38);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(272, 26);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Bill Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "PayableTo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Amount";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Due Date";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Bill Purpose";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // UnpaidBillListUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(956, 496);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.uppaidBillListDataGridView);
            this.Name = "UnpaidBillListUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UnpaidBillListUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UnpaidBillListUI_FormClosed);
            this.Load += new System.EventHandler(this.UnpaidBillListUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uppaidBillListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView uppaidBillListDataGridView;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}