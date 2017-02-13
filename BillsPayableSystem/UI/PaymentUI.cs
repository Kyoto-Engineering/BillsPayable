﻿using System;
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
        private ConnectionString cs = new ConnectionString();
        public int billTransactionId;
        public string userName;
        public int departID,currentId;
        public string inpb;
        public string inpb1;
        public string bankName;
        public frmPayment()
        {
            InitializeComponent();
        }

        private void ClearData()
        {
            cmbBillSN.Items.Clear();
            cmbBillSN.SelectedIndex = -1;
            amountTextBox.Clear();
            billPurposeTextBox.Clear();
            billEntryDateTextBox.Clear();
            payableTextBox.Clear();
           //dtpPaymentDate.Value = DateTimePicker.MinDateTime;
            //dtpPaymentDate.Text = DateTime.Now.ToString();
            dtpPaymentDate.ResetText();
        }

        private void BillSerialNoLoad()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();

                //string query = "Select SiNo from BTransaction except Select SiNo from BTransaction where StatusForSN='Paid'";
                //string query ="Select BillTransactionId from BTransaction LEFT JOIN Payment ON BTransaction.BillTransactionId = Payment.BillTransactionId EXCEPT Select SiNo from BTransaction RIGHT JOIN Payment ON BTransaction.BillTransactionId = Payment.BillTransactionId";
                string query ="SELECT BillTransactionId FROM BTransaction EXCEPT SELECT Payment.BillTransactionId FROM Payment";

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

        //R
        private void PaymentUI_Load(object sender, EventArgs e)
        {
            
            approvalGroupBox.Enabled = false;
            settlementGroupBox.Enabled = false;
            userName = frmLogin.userName;
            BillSerialNoLoad();
            AuthLoad();
           // BankNameLoad();
         // AccountNoLoad();

        }
        private void AccountNoLoad()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ctt = "select AccountNo from t_bank where BankName='"+bankNameComboBox.Text+"'";
                cmd = new SqlCommand(ctt);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    accontNumComboBox.Items.Add(rdr.GetValue(0).ToString());
                }
                accontNumComboBox.Items.Add("Not In The List");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AuthLoad()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ctt = "select DepartName from t_department";
                cmd = new SqlCommand(ctt);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    approvalAuthComboBox.Items.Add(rdr.GetValue(0).ToString());
                }
                approvalAuthComboBox.Items.Add("Not In The List");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void BankNameLoad()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ctt = "select BankName from t_bank";
                cmd = new SqlCommand(ctt);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    bankNameComboBox.Items.Add(rdr.GetValue(0).ToString());
                }
                bankNameComboBox.Items.Add("Not In The List");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //R
        public void InsertApprovalAndSettelement()
        {
            if (!string.IsNullOrWhiteSpace(cmbBillSN.Text))
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string query1 =
                    "insert into t_approval(ApprovedAuth, ApprovedBy, ApprovedDate,ApprovedAmount) values(@d1,@d2,@d3,@d4)" +
                    "SELECT CONVERT(int, SCOPE_IDENTITY())";

                cmd = new SqlCommand(query1, con);
                cmd.Parameters.AddWithValue("@d1", approvalAuthComboBox.Text);
                cmd.Parameters.AddWithValue("@d2", approvedByComboBox.Text);
                cmd.Parameters.AddWithValue("@d3", approvalDateTimePicker.Text);
                cmd.Parameters.AddWithValue("@d4", Convert.ToDecimal(approvalAmountTextBox.Text));
                currentId = (int) cmd.ExecuteScalar();
                con.Close();
            }
            if (paymentMethodComboBox.Text == "Cheque")
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string query ="insert into t_settlement(SettlementDate, PayMethod, BankName,AccNumber,ChqNumber,SettlementAmount) values(@d1,@d2,@d3,@d4,@d5,@d6)" +"SELECT CONVERT(int, SCOPE_IDENTITY())";

                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@d1", settlementDateTimePicker.Text);
                    cmd.Parameters.AddWithValue("@d2", paymentMethodComboBox.Text);
                    cmd.Parameters.AddWithValue("@d3", bankNameComboBox.Text);
                    cmd.Parameters.AddWithValue("@d4", accontNumComboBox.Text);
                    cmd.Parameters.AddWithValue("@d5", chaqueNumTextBox.Text);
                    cmd.Parameters.AddWithValue("@d6", Convert.ToDecimal(settlementAmountTxtBox.Text));
                    currentId = (int) cmd.ExecuteScalar();
                    con.Close();
                   
                    
                
            }
            else
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string query ="insert into t_settlement(SettlementDate, PayMethod,SettlementAmount) values(@d1,@d2,@d3)" +"SELECT CONVERT(int, SCOPE_IDENTITY())";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@d1", settlementDateTimePicker.Text);
                cmd.Parameters.AddWithValue("@d2", paymentMethodComboBox.Text);
                cmd.Parameters.AddWithValue("@d3", Convert.ToDecimal(settlementAmountTxtBox.Text));
                currentId = (int) cmd.ExecuteScalar();
                con.Close();
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //ToolTip btnSave1 = new ToolTip();
            //btnSave1.IsBalloon = true;
            //btnSave1.ShowAlways = true;
            //btnSave1.SetToolTip(btnSave, "hi");
           

            if (string.IsNullOrWhiteSpace(cmbBillSN.Text))
            {
                MessageBox.Show("Please Select Bill ID", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbBillSN.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(approvalAmountTextBox.Text))
            {
                MessageBox.Show("Please Enter appoval amount", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                approvalAmountTextBox.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(settlementAmountTxtBox.Text))
            {
                MessageBox.Show("Please Enter settlement amount", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                settlementAmountTxtBox.Focus();
                return;
            }
            
            if (string.IsNullOrWhiteSpace(paymentMethodComboBox.Text))
            {
                MessageBox.Show("Please Select payment method", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                settlementAmountTxtBox.Focus();
                return;
            }
            if (paymentMethodComboBox.Text=="cheque")
            {
                if (string.IsNullOrWhiteSpace(bankNameComboBox.Text))
                {
                    MessageBox.Show("Please Select bank name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    settlementAmountTxtBox.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(accontNumComboBox.Text))
                {
                    MessageBox.Show("Please Select account number", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    settlementAmountTxtBox.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(chaqueNumTextBox.Text))
                {
                    MessageBox.Show("Please give chaque number", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    settlementAmountTxtBox.Focus();
                    return;
                }
            }
            

            InsertApprovalAndSettelement();

            DialogResult dialogResult = MessageBox.Show("Are you Sure want To Pay Now", "Confirm",
                MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    int fyr = FiscallYear();
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string query =
                        "insert into Payment(PaymentDate, EntryDateTime, InputBy, BillTransactionId,Fiscalyr) values(@d1,@d2,@d3,@d4,@d5)" +
                        "SELECT CONVERT(int, SCOPE_IDENTITY())";

                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@d1", dtpPaymentDate.Value);
                    cmd.Parameters.AddWithValue("@d2", DateTime.UtcNow.ToLocalTime());
                    cmd.Parameters.AddWithValue("@d3", userName);
                    cmd.Parameters.AddWithValue("@d4", Convert.ToInt32(cmbBillSN.Text));
                    cmd.Parameters.AddWithValue("@d5", fyr);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Paid successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                    ApprovedClear();
                    BillSerialNoLoad();
                    cmbBillSN.ResetText();
                    paymentInfoGroupBox.Enabled = true;
                    lblBillSiNo.Focus();
                    SettlementClear();
                    this.paymentMethodComboBox_SelectedIndexChanged(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                    string query = "SELECT dbo.BPayableTo.BPayableToName, dbo.BTransaction.BIssueDate, dbo.BTransaction.Amount, dbo.BillsPayableName.BillName FROM dbo.BPayableTo INNER JOIN dbo.BTransaction ON dbo.BPayableTo.BPayableToId = dbo.BTransaction.BPayableToId INNER JOIN dbo.BillsPayableName ON dbo.BTransaction.BillId = dbo.BillsPayableName.BillId where BillTransactionId= '" + cmbBillSN.Text + "'";
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

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int FiscallYear()
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

      

        private void dtpPaymentDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpPaymentDate.Value >DateTime.Now)
            {
                //MessageBox.Show("You should select correct date or previous date from today");
                MessageBox.Show("You should select correct date or previous date from today", "Warrning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpPaymentDate.ResetText();
            }

        }


        //R
        private void approvalAuthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            approvedByComboBox.Items.Clear();
            GetAllEmpByDepartID();


            if (approvalAuthComboBox.Text == "Not In The List")
            {
                inpb = Microsoft.VisualBasic.Interaction.InputBox("Please Input department Here", "Input Here", "", -1,
                    -1);
                if (string.IsNullOrWhiteSpace(inpb))
                {
                    approvalAuthComboBox.SelectedIndex = -1;
                }
                else
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string ct3 = "select DepartName from t_department where DepartName='" + inpb + "'";
                    cmd = new SqlCommand(ct3, con);
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read() && !rdr.IsDBNull(0))
                    {
                        MessageBox.Show("This department Name Already Exists,Please Select From List", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                        approvalAuthComboBox.SelectedIndex = -1;
                    }
                    else
                    {
                        try
                        {
                            con = new SqlConnection(cs.DBConn);
                            con.Open();
                            string query4 = "insert into t_department (DepartName) values (@d1)" +
                                            "SELECT CONVERT(int, SCOPE_IDENTITY())";
                            cmd = new SqlCommand(query4, con);
                            cmd.Parameters.AddWithValue("@d1", inpb);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            approvalAuthComboBox.Items.Clear();
                            AuthLoad();
                            approvalAuthComboBox.SelectedText = inpb;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        public void GetAllEmpByDepartID()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "select DepartID from t_department WHERE DepartName= '" + approvalAuthComboBox.Text +"'";

                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    departID = rdr.GetInt32(0);
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


            if (!string.IsNullOrWhiteSpace(approvalAuthComboBox.Text))
            {

                approvedByComboBox.Items.Clear();
                approvedByComboBox.ResetText();
                approvedByComboBox.SelectedIndex = -1;
                try
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    cmd = con.CreateCommand();
                    string query = "SELECT EmpName from t_employee where DepartID= '" + departID + "'";

                    cmd = new SqlCommand(query, con);
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        approvedByComboBox.Items.Add(rdr.GetValue(0).ToString());
                    }
                    approvedByComboBox.Items.Add("Not In The List");
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
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void approvedByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (approvedByComboBox.Text == "Not In The List")
            {
                inpb = Microsoft.VisualBasic.Interaction.InputBox("Please Input name Here", "Input Here", "", -1, -1);
                if (string.IsNullOrWhiteSpace(inpb))
                {
                    approvalAuthComboBox.SelectedIndex = -1;
                }
                else
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string ct3 = "select EmpName,DepartID from t_employee where EmpName='" + inpb + "' AND DepartID='"+departID+"' ";
                    //string ct3 = "SELECT dbo.t_employee.DepartID, dbo.t_employee.EmpName, dbo.t_department.DepartName FROM dbo.t_department INNER JOIN dbo.t_employee ON dbo.t_department.DepartID = dbo.t_employee.DepartID where EmpName='" + inpb + "'";
                    
                    cmd = new SqlCommand(ct3, con);
                    rdr = cmd.ExecuteReader();


                    //if (rdr.Read())
                    //{
                    //    departID = rdr.GetInt32(0);
                    //}



                    
                        if (rdr.Read() && !rdr.IsDBNull(0))
                        {
                            MessageBox.Show("This employee Name Already Exists,Please Select From List", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            con.Close();
                            approvedByComboBox.SelectedIndex = -1;
                        }
                    

                    else
                    {
                        try
                        {
                            con = new SqlConnection(cs.DBConn);
                            con.Open();
                            string query4 = "insert into t_employee (EmpName,departID) values (@d1,@d2)" +
                                            "SELECT CONVERT(int, SCOPE_IDENTITY())";
                            cmd = new SqlCommand(query4, con);
                            cmd.Parameters.AddWithValue("@d1", inpb);
                            cmd.Parameters.AddWithValue("@d2", departID);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            approvedByComboBox.Items.Clear();
                            GetAllEmpByDepartID();
                            approvedByComboBox.SelectedText = inpb;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }


        private void paymentMethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bankNameComboBox.Items.Clear();
            bankNameComboBox.SelectedIndex = -1;
            bankNameComboBox.ResetText();
            BankNameLoad();
            //cmbBillPurpose.Text = "";
            //cmbBillPurpose.Items.Clear();
            //cmbBillPurpose.SelectedIndex = -1;
            //txtBillNarrative.Clear();

            if (paymentMethodComboBox.Text == "Cheque")
            {
                bankNameLabel.Visible = true;
                bankNameComboBox.Visible = true;
                accNumberLabel.Visible = true;
                accontNumComboBox.Visible = true;
                chqNumberLabel.Visible = true;
                chaqueNumTextBox.Visible = true;

            }
            else
            {
                bankNameLabel.Visible = false;
                bankNameComboBox.Visible = false;
                accNumberLabel.Visible = false;
                accontNumComboBox.Visible = false;
                chqNumberLabel.Visible = false;
                chaqueNumTextBox.Visible = false;
            }
            // BillPurposeLoad();
        }

        private void bankNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            accontNumComboBox.Items.Clear();
            accontNumComboBox.SelectedIndex = -1;
            accontNumComboBox.ResetText();
            AccountNoLoad();
            if (bankNameComboBox.Text == "Not In The List")
            {

                inpb = Microsoft.VisualBasic.Interaction.InputBox("Please Input Bank name Here", "Input Here", "", -1,
                    -1);

                if (!string.IsNullOrEmpty(inpb))
                {
                    inpb1 = Microsoft.VisualBasic.Interaction.InputBox("Please Input Account no Here", "Input Here", "",
                        -1, -1);



                    if (string.IsNullOrWhiteSpace(inpb))
                    {
                        bankNameComboBox.SelectedIndex = -1;
                    }

                    if (!string.IsNullOrEmpty(inpb1))
                    {

                        con = new SqlConnection(cs.DBConn);
                        con.Open();
                        string ct3 = "select BankName from t_bank where BankName='" + inpb + "'";

                        cmd = new SqlCommand(ct3, con);
                        rdr = cmd.ExecuteReader();
                        if (rdr.Read() && !rdr.IsDBNull(0))
                        {
                            MessageBox.Show("This Bank Name Already Exists,Please Select From List", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            con.Close();
                            bankNameComboBox.SelectedIndex = -1;
                        }
                        else
                        {
                            try
                            {
                                con = new SqlConnection(cs.DBConn);
                                con.Open();
                                string query4 = "insert into t_bank (BankName,AccountNo) values (@d1,@d2)" +
                                                "SELECT CONVERT(int, SCOPE_IDENTITY())";
                                cmd = new SqlCommand(query4, con);
                                cmd.Parameters.AddWithValue("@d1", inpb);
                                cmd.Parameters.AddWithValue("@d2", inpb1);
                                cmd.ExecuteNonQuery();
                                con.Close();
                                bankNameComboBox.Items.Clear();
                                BankNameLoad();
                                bankNameComboBox.SelectedText = inpb;
                                accontNumComboBox.Items.Clear();
                                AccountNoLoad();
                                accontNumComboBox.SelectedText = inpb1;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please enter bank account number");
                    }

                }
                else
                {
                    MessageBox.Show("Please enter bank name");
                    
                    bankNameComboBox.SelectedIndex = -1;
                    bankNameComboBox.ResetText();
                }
            }
        }

        //&& !string.IsNullOrEmpty(bankNameComboBox.Text) && !(bankNameComboBox.Text == "Not In The List")
        private void accontNumComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (accontNumComboBox.Text == "Not In The List" && !string.IsNullOrEmpty(bankNameComboBox.Text) && !(bankNameComboBox.Text == "Not In The List"))
            {
                inpb = Microsoft.VisualBasic.Interaction.InputBox("Please Input Account number Here", "Input Here", "", -1, -1);
                if (string.IsNullOrWhiteSpace(inpb))
                {
                    accontNumComboBox.SelectedIndex = -1;
                }
                else
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string ct3 = "select AccountNo from t_bank where AccountNo='" + inpb + "'";
                   
                    cmd = new SqlCommand(ct3, con);
                    rdr = cmd.ExecuteReader();
                    
                    if (rdr.Read() && !rdr.IsDBNull(0))
                    {
                        MessageBox.Show("This  Account number Already Exists,Please Select From List", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                        accontNumComboBox.SelectedIndex = -1;
                    }
                    else
                    {
                        try
                        {
                            con = new SqlConnection(cs.DBConn);
                            con.Open();
                           // cmd.CommandText = "select BankName from t_bank WHERE BankName= '" + bankNameComboBox.Text + "'";
                          //  rdr = cmd.ExecuteReader();
                           
                            
                              //  bankName = rdr.ToString();
                            
                            string query4 = "insert into t_bank (BankName,AccountNo) values ('"+bankNameComboBox.Text +"',@d2)" + "SELECT CONVERT(int, SCOPE_IDENTITY())";
                            
                            cmd = new SqlCommand(query4, con);
                            
                                                     
                           // cmd.Parameters.AddWithValue("@d1", bankName);
                            cmd.Parameters.AddWithValue("@d2", inpb);
                            
                            cmd.ExecuteNonQuery();
                            con.Close();
                            accontNumComboBox.Items.Clear();
                            accontNumComboBox.SelectedIndex = -1;
                            accontNumComboBox.ResetText();
                            AccountNoLoad();
                            accontNumComboBox.SelectedText = inpb;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            //else
            //{
            //    MessageBox.Show("Select Bank Name and Account Number in correct format");
            //    accontNumComboBox.Items.Clear();
            //    accontNumComboBox.SelectedIndex = -1;
            //    accontNumComboBox.ResetText();
            //}
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbBillSN.Text))
            {
                paymentInfoGroupBox.Enabled = false;
                approvalGroupBox.Enabled = true;
                ApprovedClear();
                AuthLoad(); 
            }
            else
            {
                MessageBox.Show("Please Select Bill Serial Number", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbBillSN.Focus();
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(approvalAuthComboBox.Text))
            {
                MessageBox.Show("Please Select Approval Authority ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                approvalAuthComboBox.Focus();
                return;
               
            }

            if (string.IsNullOrWhiteSpace(approvedByComboBox.Text))
            {
                MessageBox.Show("Please Select Approval Person name ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                approvedByComboBox.Focus();
                return;

            }
            if (string.IsNullOrWhiteSpace(approvalAmountTextBox.Text))
            {
                MessageBox.Show("Please Select Approval Amount ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                approvedByComboBox.Focus();
                return;
            }

          
                approvalGroupBox.Enabled = false;
                settlementGroupBox.Enabled = true;

            MessageBox.Show("Approved Successfully...");

        }
        

        private void refreshButton_Click(object sender, EventArgs e)
        {
            //paymentInfoGroupBox.Enabled = true;  
            //ClearData();
            //BillSerialNoLoad(); 
                                     
            //settlementGroupBox.Enabled = false;
            //approvalGroupBox.Enabled = true;
            //ApprovedClear();
            //approvalGroupBox.Enabled = false;
            
            //approvalGroupBox.Enabled = false;
            //settlementGroupBox.Enabled = false;
            //userName = frmLogin.userName;
            //BillSerialNoLoad();
            //AuthLoad();
            this.PaymentUI_Load(null, null);
            paymentInfoGroupBox.Enabled = true;
            ClearData();
            BillSerialNoLoad();
            ApprovedClear();
            SettlementClear();
            this.paymentMethodComboBox_SelectedIndexChanged(null, null);
        }

      
       public void ApprovedClear()
       {
          
            approvalAuthComboBox.Items.Clear();
            approvalAuthComboBox.SelectedIndex=-1;
            approvalAuthComboBox.ResetText();
            approvedByComboBox.Items.Clear();
            approvedByComboBox.SelectedIndex=-1;
            approvedByComboBox.ResetText();
            approvalAmountTextBox.Clear();
           approvalDateTimePicker.ResetText();

        }

        public void SettlementClear()
        {
            settlementAmountTxtBox.Clear();
           // paymentMethodComboBox.Items.Clear();
            paymentMethodComboBox.SelectedIndex = -1;
            paymentMethodComboBox.ResetText();
            bankNameComboBox.Items.Clear();
            bankNameComboBox.SelectedIndex = -1;
            bankNameComboBox.ResetText();
            accontNumComboBox.Items.Clear();
            accontNumComboBox.SelectedIndex = -1;
            accontNumComboBox.ResetText();
            chaqueNumTextBox.Clear();
            settlementDateTimePicker.ResetText();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            ClearData();
            BillSerialNoLoad();
        }

        private void approvalDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (approvalDateTimePicker.Value > DateTime.Now)
            {
                //MessageBox.Show("You should select correct date or previous date from today");
                MessageBox.Show("You should select correct date or previous date from today", "Warrning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                approvalDateTimePicker.ResetText();
            }
        }

        private void settlementDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (settlementDateTimePicker.Value > DateTime.Now)
            {
                //MessageBox.Show("You should select correct date or previous date from today");
                MessageBox.Show("You should select correct date or previous date from today", "Warrning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                settlementDateTimePicker.ResetText();
            }
        }

        private void settlementAmountTxtBox_TextChanged(object sender, EventArgs e)
        {
            decimal val1=0;
            decimal val2=0;
            decimal.TryParse(approvalAmountTextBox.Text, out val1);
            decimal.TryParse(settlementAmountTxtBox.Text, out val2);
            if (val1<val2)
            {

                MessageBox.Show("You should enter less or equal amount of appoval amount ", "Warrning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                settlementAmountTxtBox.Clear();
                settlementAmountTxtBox.Focus();
               
                
            } 
            
           
        }

        private void approvalAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            decimal val1 = 0;
            decimal val2 = 0;
            decimal.TryParse(amountTextBox.Text, out val1);
            decimal.TryParse(approvalAmountTextBox.Text, out val2);
            if (val1 < val2)
            {

                MessageBox.Show("You should enter less or equal amount of total amount ", "Warrning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                approvalAmountTextBox.Clear();
                approvalAmountTextBox.Focus();


            }
        }

        private void approvalAmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(approvalAmountTextBox.Text + ch, out x))
            {
                e.Handled = true;
            }
        }

        private void settlementAmountTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(settlementAmountTxtBox.Text + ch, out x))
            {
                e.Handled = true;
            }
        }

        private void amountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(amountTextBox.Text + ch, out x))
            {
                e.Handled = true;
            }
        }

      
      
        
       

    }
}
