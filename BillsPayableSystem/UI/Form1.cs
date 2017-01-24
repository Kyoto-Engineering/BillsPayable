﻿using System;
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
    public partial class frmBillEntry : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        public int btype_id, nameOfBillId, bPayableToId, user_id, nameOfBPayableId;
        

        public frmBillEntry()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BillsType();
            PayableTo();
        }
        private void ClearData()
        {
            //cmbPayableTo.Text = "";
            cmbPayableTo.Items.Clear();
            cmbPayableTo.SelectedIndex = -1;
            txtPayableTo.Visible = false;
            txtPayableTo.Clear();
            txtAmount.Clear();
            cmbPaymentMethod.SelectedIndex = -1;
            cmbBillType.SelectedIndex = -1;
            cmbBillPurpose.Text = "";
            cmbBillPurpose.Items.Clear();
            cmbBillPurpose.SelectedIndex = -1;
            txtBillNarrative.Clear();
            txtNote.Clear();
        }

        private void connection()
        {
            con = new SqlConnection(cs.DBConn);
            con.Open();
        }

        private void reader()
        {
            cmd.Connection = con;
            rdr = cmd.ExecuteReader();
        }

        private void BillsType()
        {
            try
            {
                connection();
                string ct = "select BillTypeName from BillsPayableType";
                cmd = new SqlCommand(ct);
                reader();
                while (rdr.Read())
                {
                    cmbBillType.Items.Add(rdr.GetValue(0).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PayableTo()
        {
            try
            {
                connection();
                string ctt = "select BPayableToName from BPayableTo";
                cmd = new SqlCommand(ctt);
                reader();
                while (rdr.Read())
                {
                    cmbPayableTo.Items.Add(rdr.GetValue(0).ToString());
                }
                cmbPayableTo.Items.Add("Not In The List");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbPayableTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPayableTo.Text == "Not In The List")
            {
                txtPayableTo.Visible = true;
                txtPayableTo.Focus();
            }
            else
            {
                txtPayableTo.Clear();
                txtPayableTo.Visible = false;

                try
                {
                    connection();
                    cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT BPayableToId from BPayableTo WHERE BPayableToName= '" + cmbPayableTo.Text + "'";
                    
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        bPayableToId = rdr.GetInt32(0);
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
        }


        private void cmbBillsType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBillPurpose.Text = "";
            cmbBillPurpose.Items.Clear();
            cmbBillPurpose.SelectedIndex = -1;

            txtBillNarrative.Clear();

            try
            {
                connection();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT BillTypeId from BillsPayableType WHERE BillTypeName= '" + cmbBillType.Text + "'";

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

                connection();
                string ct = "select distinct RTRIM(BillName) from BillsPayableName where BillTypeId= " + btype_id + "";

                cmd = new SqlCommand(ct);
                reader();

                while (rdr.Read())
                {
                    cmbBillPurpose.Items.Add(rdr[0]);
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

        private void cmbBillPurpose_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                connection();
                cmd = con.CreateCommand();
                cmd.CommandText = "select BillId from BillsPayableName WHERE BillName= '" + cmbBillPurpose.Text + "'";

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

        private void BtnSave_Click(object sender, EventArgs e)
        {
              String x="";
              if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Please  enter Amount", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrWhiteSpace(cmbPaymentMethod.Text))
            {
                MessageBox.Show("Please Select Payment Method", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrWhiteSpace(cmbBillType.Text))
            {
                MessageBox.Show("Please Select Type of Bill", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrWhiteSpace(cmbBillPurpose.Text))
            {
                MessageBox.Show("Please Select Bill Purpose", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrWhiteSpace(txtBillNarrative.Text))
            {
                MessageBox.Show("Please  enter Bill Narrative", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrWhiteSpace(cmbPayableTo.Text))
            {
                MessageBox.Show("Please  enter PayableTo Name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else if (cmbPayableTo.Text == "Not In The List")
            {
                try
                {
                    connection();
                    string ct2 = "select BPayableToName from BPayableTo where BPayableToName='" + txtPayableTo.Text +
                                 "'";

                    cmd = new SqlCommand(ct2);
                    reader();
                    while (rdr.Read())
                    {
                        x = rdr.GetValue(0).ToString();
                    }
                    if (x.Length > 0)
                    {
                        MessageBox.Show("This PayableTo Name Already Exists,Please Select From List", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();

                    }

                    else
                        try
                        {

                            connection();
                            String query1 = "insert into BPayableTo (BPayableToName, BillId) values (@d1,@d2)" +
                                            "SELECT CONVERT(int,SCOPE_IDENTITY())";
                            cmd = new SqlCommand(query1);
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("@d1", txtPayableTo.Text);
                            cmd.Parameters.AddWithValue("@d2", nameOfBillId);
                            nameOfBPayableId = (int) cmd.ExecuteScalar();
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                nameOfBPayableId = bPayableToId;
            }
             try
                {   
                    connection();
                    String query ="insert into BTransaction(BillId, Narrative, PaymentMethod, Amount, BIssueDate, BReceivedDate, DueDate, BPayableToId, Note) values (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9)";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@d1", nameOfBillId);
                    cmd.Parameters.AddWithValue("@d2", txtBillNarrative.Text);
                    cmd.Parameters.AddWithValue("@d3", cmbPaymentMethod.Text);
                    cmd.Parameters.AddWithValue("@d4", Convert.ToDecimal(txtAmount.Text));
                    cmd.Parameters.AddWithValue("@d5", dtpBillDate.Value);
                    cmd.Parameters.AddWithValue("@d6", dtpBillReceivedDate.Value);
                    cmd.Parameters.AddWithValue("@d7", dtpDueDate.Value);
                    cmd.Parameters.AddWithValue("@d8", nameOfBPayableId);
                    cmd.Parameters.AddWithValue("@d9", txtNote.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saved successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close();
                    ClearData();
                    PayableTo();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

      
    
