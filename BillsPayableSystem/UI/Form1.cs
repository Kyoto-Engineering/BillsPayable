using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using BillsPayableSystem.DbGateway;
//using BillsPayableSystem.UI;

namespace BillsPayableSystem
{
    public partial class Form1 : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        public int btype_id, nameOfBillId;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BillsType();
        }

        private void BillsType()
        {
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select BillTypeName from BillsPayableType";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cmbBillsType.Items.Add(rdr.GetValue(0).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbBillsType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBillsName.Text = "";
            cmbBillsName.Items.Clear();
            cmbBillsName.SelectedIndex = -1;

            txtDescriptions.Clear();

            txtAmount.Clear();

            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT BillTypeId from BillsPayableType WHERE BillTypeName= '" + cmbBillsType.Text + "'";
                
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    btype_id = rdr.GetInt32(0);
                }
                if ((rdr != null))
                {
                    rdr.Close();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select distinct RTRIM(BillName) from BillsPayableName where BillTypeId= " + btype_id + "";
               
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbBillsName.Items.Add(rdr[0]);            
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
        }

        private void cmbBillsName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "select BillId from BillsPayableName WHERE BillName= '" + cmbBillsName.Text + "'";

                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    nameOfBillId = rdr.GetInt32(0);
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
        }

        private void cmbTransactionName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (cmbFY.Text == "")
            {
                MessageBox.Show("Please Select Fiscal Year", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtPayableTo.Text == "")
            {
                MessageBox.Show("Please  enter Payable To", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbBillsType.Text == "")
            {
                MessageBox.Show("Please Select Type of Bill", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbBillsName.Text == "")
            {
                MessageBox.Show("Please Select Name of Bill", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtDescriptions.Text == "")
            {
                MessageBox.Show("Please  enter Description", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbTransactionName.Text == "")
            {
                MessageBox.Show("Please Select Transaction Type", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtAmount.Text == "")
            {
                MessageBox.Show("Please  enter Amount", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                String query = "insert into BTransaction(BillId, Descriptions, TransactionType, Amount, Date, DueDate, PayableTo, FiscalYear) values (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@d1", nameOfBillId);
                cmd.Parameters.AddWithValue("@d2", txtDescriptions.Text);
                cmd.Parameters.AddWithValue("@d3", cmbTransactionName.Text);
                cmd.Parameters.AddWithValue("@d4", Convert.ToDecimal(txtAmount.Text));
                cmd.Parameters.AddWithValue("@d5", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@d6", DueDate.Value);
                cmd.Parameters.AddWithValue("@d7", txtPayableTo.Text);
                cmd.Parameters.AddWithValue("@d8", cmbFY.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbFY.Items.Clear();
                txtPayableTo.Clear();
                cmbBillsType.Items.Clear();
                cmbBillsName.Items.Clear();
                txtDescriptions.Clear();
                cmbTransactionName.Items.Clear();
                txtAmount.Clear();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

    }
}
