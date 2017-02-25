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
    public partial class AllPayableBillListUI : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        private ConnectionString cs = new ConnectionString();
        public AllPayableBillListUI()
        {
            InitializeComponent();
        }

        private void AllPayableBillListUI_Load(object sender, EventArgs e)
        {
            GetAllBill();
        }

        private void GetAllBill()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT BTransaction.BillTransactionId,BPayableTo.BPayableToName, BTransaction.Amount, BTransaction.DueDate,BillsPayableName.BillName FROM BillsPayableName INNER JOIN BTransaction ON BillsPayableName.BillId = BTransaction.BillId INNER JOIN BPayableTo ON BTransaction.BPayableToId = BPayableTo.BPayableToId", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                allPayableBillDataGridView.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = allPayableBillDataGridView.Rows.Add();
                    allPayableBillDataGridView.Rows[n].Cells[0].Value = item[0].ToString();
                    allPayableBillDataGridView.Rows[n].Cells[1].Value = item[1].ToString();
                    allPayableBillDataGridView.Rows[n].Cells[2].Value = item[2].ToString();
                    allPayableBillDataGridView.Rows[n].Cells[3].Value = item[3].ToString();
                    allPayableBillDataGridView.Rows[n].Cells[4].Value = item[4].ToString();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AllPayableBillListUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            MainUI1 mainUi1 =new MainUI1();
            mainUi1.Show();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT BTransaction.BillTransactionId,BPayableTo.BPayableToName, BTransaction.Amount, BTransaction.DueDate,BillsPayableName.BillName FROM BillsPayableName INNER JOIN BTransaction ON BillsPayableName.BillId = BTransaction.BillId INNER JOIN BPayableTo ON BTransaction.BPayableToId = BPayableTo.BPayableToId WHERE (BPayableTo.BPayableToName LIKE '%" + searchTextBox.Text + "%')", con);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            allPayableBillDataGridView.Rows.Clear();
            foreach (DataRow item in dataTable.Rows)
            {
                int n = allPayableBillDataGridView.Rows.Add();
                allPayableBillDataGridView.Rows[n].Cells[0].Value = item[0].ToString();
                allPayableBillDataGridView.Rows[n].Cells[1].Value = item[1].ToString();
                allPayableBillDataGridView.Rows[n].Cells[2].Value = item[2].ToString();
                allPayableBillDataGridView.Rows[n].Cells[3].Value = item[3].ToString();
                allPayableBillDataGridView.Rows[n].Cells[4].Value = item[4].ToString();
            }

        }


    }
}
