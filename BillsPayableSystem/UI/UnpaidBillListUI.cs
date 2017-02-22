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
            //try
            //{
            //    con = new SqlConnection(cs.DBConn);
            //    con.Open();

            //    //string query = "Select SiNo from BTransaction except Select SiNo from BTransaction where StatusForSN='Paid'";
            //    //string query ="Select BillTransactionId from BTransaction LEFT JOIN Payment ON BTransaction.BillTransactionId = Payment.BillTransactionId EXCEPT Select SiNo from BTransaction RIGHT JOIN Payment ON BTransaction.BillTransactionId = Payment.BillTransactionId";
            //    string query = "SELECT BillTransactionId FROM BTransaction EXCEPT SELECT Payment.BillTransactionId FROM Payment";

            //    cmd = new SqlCommand(query, con);
            //    rdr = cmd.ExecuteReader();
            //    while (rdr.Read())
            //    {
            //        cmbBillSN.Items.Add(rdr[0]);
            //    }
            //    con.Close();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
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
            //(uppaidBillListDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("Column2 LIKE '{0}%'", searchTextBox.Text);

            //DataTable dt=new DataTable();

            //string searchValue = string.Format("Column2 LIKE '{0}%'", searchTextBox.Text);

            //uppaidBillListDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //try
            //{
            //    foreach (DataGridViewRow row in uppaidBillListDataGridView.Rows)
            //    {
            //        if (row.Cells[1].Value.ToString().Equals(searchValue))
            //        {
            //            row.Selected = true;
            //            break;
            //        }
            //    }
            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show(exc.Message);
            //}


            string searchString = searchTextBox.Text.Trim();
            if (searchString == string.Empty)
            {
                MessageBox.Show("Enter Valid Consumer Number..!");
            }
            else
            {
                foreach (DataGridViewRow row in uppaidBillListDataGridView.Rows)
                {
                    if (row.Cells["Column2"].Value.ToString().Contains(searchString))
                    {
                        uppaidBillListDataGridView.CurrentRow.Selected = false;
                        uppaidBillListDataGridView.Rows[row.Index].Selected = true;
                        int index = row.Index;
                        uppaidBillListDataGridView.FirstDisplayedScrollingRowIndex = index;
                        break;
                    }
                }
            }


           
        }

    }



}

