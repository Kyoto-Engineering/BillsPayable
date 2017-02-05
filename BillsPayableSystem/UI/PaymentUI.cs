using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BillsPayableSystem.DbGateway;
using BillsPayableSystem.LoginUI;

namespace BillsPayableSystem.UI
{
    public partial class frmPayment : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        public int billTransactionId;
        public string userName;

        public frmPayment()
        {
            InitializeComponent();
        }

        private void BillSerialNoLoad()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();

                //string query = "Select SiNo from BTransaction except Select SiNo from BTransaction where StatusForSN='Paid'";
                string query = "Select SiNo from BTransaction LEFT JOIN Payment ON BTransaction.BillTransactionId = Payment.BillTransactionId EXCEPT Select SiNo from BTransaction RIGHT JOIN Payment ON BTransaction.BillTransactionId = Payment.BillTransactionId";

                cmd = new SqlCommand(query, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cmbBillSN.Items.Add(rdr[0]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PaymentUI_Load(object sender, EventArgs e)
        {
            userName = frmLogin.userName;
            BillSerialNoLoad();
        }

       
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbBillSN.Text))
            {
                MessageBox.Show("Please Select Bill Serial Number", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                int fyr = FiscallYear();
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string query = "insert into Payment(PaymentDate, EntryDateTime, InputBy, BillTransactionId,Fiscalyr) values(@d1,@d2,@d3,@d4,@d5)" + "SELECT CONVERT(int, SCOPE_IDENTITY())";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@d1", dtpPaymentDate.Value);
                cmd.Parameters.AddWithValue("@d2", DateTime.UtcNow.ToLocalTime());
                cmd.Parameters.AddWithValue("@d3", userName);
                cmd.Parameters.AddWithValue("@d4", billTransactionId);
                cmd.Parameters.AddWithValue("@d5", fyr);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Paid successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainUI1 frm3 = new MainUI1();
            frm3.Show();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtBillSerialNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);


        }

        private void cmbBillSN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "select BillTransactionId,SiNo from BTransaction WHERE SiNo= '" + cmbBillSN.Text + "'";

                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    billTransactionId = rdr.GetInt32(0);
                }
                if ((rdr != null))
                {
                    rdr.Close();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!string.IsNullOrWhiteSpace(cmbBillSN.Text))
            {
                try
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    cmd = con.CreateCommand();
                    string query = "SELECT dbo.BPayableTo.BPayableToName, dbo.BTransaction.BIssueDate, dbo.BTransaction.Amount, dbo.BillsPayableName.BillName FROM dbo.BPayableTo INNER JOIN dbo.BTransaction ON dbo.BPayableTo.BPayableToId = dbo.BTransaction.BPayableToId INNER JOIN dbo.BillsPayableName ON dbo.BTransaction.BillId = dbo.BillsPayableName.BillId where SiNo= '" + cmbBillSN.Text + "'";                  
                    cmd = new SqlCommand(query, con);                   
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        payableTextBox.Text = rdr["BPayableToName"].ToString();
                        billEntryDateTextBox.Text = rdr["BIssueDate"].ToString();
                        amountTextBox.Text = rdr["Amount"].ToString();
                        billPurposeTextBox.Text = rdr["BillName"].ToString();
                    }
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
             
               catch(Exception ex)
               {
                  MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
            }           
        }
        private void ClearData()
        {
            cmbBillSN.SelectedIndex = -1;
            amountTextBox.Clear();
            billPurposeTextBox.Clear();
            billEntryDateTextBox.Clear();
            payableTextBox.Clear();
        }
        int FiscallYear()
        {
            int yr;
            DateTime x = dtpPaymentDate.Value;
            if (x.Month >= 7 && x.Month <= 12)
            {
                yr = Convert.ToInt32(x.ToString("yy"));
            }
            else
            {
                yr = Convert.ToInt32(x.ToString("yy")) - 1;
            }
            return yr;
        }

        private void frmPayment_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            MainUI1 frm3 = new MainUI1();
            frm3.Show();
        }

    }
}
