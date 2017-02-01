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
<<<<<<< HEAD
                string query = "Select BillTransactionId from BTransaction Except Select BillTransactionId from Payment order by  BTransaction.BillTransactionId desc";
=======
                string query = "Select SiNo from BTransaction where StatusForSN!='Paid'  order by  BillTransactionId desc";
>>>>>>> origin/master
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

        private void SaveStatus()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string qry = "Update BTransaction set  StatusForSN='Paid'  where BillTransactionId='"+billTransactionId+"' ";
                cmd = new SqlCommand(qry, con);
                cmd.ExecuteReader();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
<<<<<<< HEAD
                int fyr = FiscallYear();
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string query = "insert into Payment(PaymentDate, EntryDateTime, InputBy, BillTransactionId,Fiscalyr) values(@d1,@d2,@d3,@d4,@d5)";
=======
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string query ="insert into Payment(PaymentDate, EntryDateTime, InputBy, BillTransactionId) values(@d1,@d2,@d3,@d4)";
>>>>>>> origin/master
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@d1", dtpPaymentDate.Value);
                cmd.Parameters.AddWithValue("@d2", DateTime.UtcNow.ToLocalTime());
                cmd.Parameters.AddWithValue("@d3", userName);
                cmd.Parameters.AddWithValue("@d4", billTransactionId);
<<<<<<< HEAD
                cmd.Parameters.AddWithValue("@d5",fyr );
=======
>>>>>>> origin/master

                cmd.ExecuteNonQuery();
                con.Close();               
                MessageBox.Show("Saved successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
<<<<<<< HEAD
                //SaveStatus();               
=======
                SaveStatus();               
>>>>>>> origin/master
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
<<<<<<< HEAD
                cmd.CommandText = "select BillTransactionId from BTransaction WHERE BillTransactionId= '" + cmbBillSN.Text + "'";
=======
                cmd.CommandText = "select BillTransactionId from BTransaction WHERE SiNo= '" + cmbBillSN.Text + "'";
>>>>>>> origin/master
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
<<<<<<< HEAD
        }

        int FiscallYear()
        {
            int yr;
            DateTime x=dtpPaymentDate.Value;
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
=======
        }       
>>>>>>> origin/master
    }
}
