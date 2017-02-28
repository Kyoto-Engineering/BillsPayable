using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BillsPayableSystem.DbGateway;


namespace BillsPayableSystem.UI
{
    public partial class UnpaidBillListUI : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        private ConnectionString cs = new ConnectionString();
        public UnpaidBillListUI()
        {
            InitializeComponent();
        }

        private void UnpaidBillListUI_Load(object sender, EventArgs e)
        {
            GetUnPaidBillList();
            
        }

        private void GetUnPaidBillList()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT BTransaction.BillTransactionId,BPayableTo.BPayableToName, BTransaction.Amount, BTransaction.DueDate,BillsPayableName.BillName FROM BillsPayableName INNER JOIN BTransaction ON BillsPayableName.BillId = BTransaction.BillId INNER JOIN BPayableTo ON BTransaction.BPayableToId = BPayableTo.BPayableToId WHERE BTransaction.BillTransactionId not in( SELECT Payment.BillTransactionId FROM Payment)", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                uppaidBillListDataGridView.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = uppaidBillListDataGridView.Rows.Add();
                    uppaidBillListDataGridView.Rows[n].Cells[0].Value = item[0].ToString();
                    uppaidBillListDataGridView.Rows[n].Cells[1].Value = item[1].ToString();
                    uppaidBillListDataGridView.Rows[n].Cells[2].Value = item[2].ToString();
                    uppaidBillListDataGridView.Rows[n].Cells[3].Value = item[3].ToString();
                    uppaidBillListDataGridView.Rows[n].Cells[4].Value = item[4].ToString();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void uppaidBillListDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmPayment paymentUI = new frmPayment();
            paymentUI.billIdTextBox.Text = uppaidBillListDataGridView.CurrentRow.Cells[0].Value.ToString();
            paymentUI.payableTextBox.Text = uppaidBillListDataGridView.CurrentRow.Cells[1].Value.ToString();
            paymentUI.amountTextBox.Text = uppaidBillListDataGridView.CurrentRow.Cells[2].Value.ToString();
            paymentUI.billEntryDateTextBox.Text = uppaidBillListDataGridView.CurrentRow.Cells[3].Value.ToString();
            paymentUI.billPurposeTextBox.Text = uppaidBillListDataGridView.CurrentRow.Cells[4].Value.ToString();

            this.Dispose();
            paymentUI.ShowDialog();

        }

        private void UnpaidBillListUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            MainUI1 mainUi1 = new MainUI1();
            mainUi1.Show();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
           
            //string searchString = searchTextBox.Text.Trim();           
            //    foreach (DataGridViewRow row in uppaidBillListDataGridView.Rows)
            //    {
            //        if (row.Cells["Column2"].Value.ToString().Contains(searchString))
            //        {
            //            uppaidBillListDataGridView.CurrentRow.Selected = false;
            //            uppaidBillListDataGridView.Rows[row.Index].Selected = true;
            //            int index = row.Index;
            //            uppaidBillListDataGridView.FirstDisplayedScrollingRowIndex = index;
            //            break;
            //        }              
            //}     
           // SqlDataAdapter sda = new SqlDataAdapter("SELECT *FROM BTransaction WHERE (Amount LIKE '%" + searchTextBox.Text + "%')", con);

            SqlDataAdapter sda = new SqlDataAdapter("SELECT BTransaction.BillTransactionId,BPayableTo.BPayableToName, BTransaction.Amount, BTransaction.DueDate,BillsPayableName.BillName FROM BillsPayableName INNER JOIN BTransaction ON BillsPayableName.BillId = BTransaction.BillId INNER JOIN BPayableTo ON BTransaction.BPayableToId = BPayableTo.BPayableToId WHERE (BPayableTo.BPayableToName LIKE '" + searchTextBox.Text + "%')", con);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            uppaidBillListDataGridView.Rows.Clear();
            foreach (DataRow item in dataTable.Rows)
            {
                int n = uppaidBillListDataGridView.Rows.Add();
                uppaidBillListDataGridView.Rows[n].Cells[0].Value = item[0].ToString();
                uppaidBillListDataGridView.Rows[n].Cells[1].Value = item[1].ToString();
                uppaidBillListDataGridView.Rows[n].Cells[2].Value = item[2].ToString();
                uppaidBillListDataGridView.Rows[n].Cells[3].Value = item[3].ToString();
                uppaidBillListDataGridView.Rows[n].Cells[4].Value = item[4].ToString();
            }




        }
    }
}

