using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BillsPayableSystem.DbGateway;

namespace BillsPayableSystem.LoginUI
{
    public partial class frmRegistration : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        //private SqlDataAdapter sda;
        ConnectionString cs = new ConnectionString();
        public frmRegistration()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            //cmbUserType.Text = "";
            cmbUserType.SelectedIndex = -1;
            txtFullName.Text = "";
            designationTextBox.Text = "";
            departmentTextBox.Text = "";
            txtContact_no.Text = "";
            userButton.Enabled = true;

            txtUsername.Focus();
        }

        private void showLoginfrm()
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {

        }

        private void userButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter Email Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbUserType.Text))
            {
                MessageBox.Show("Please Select User type", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbUserType.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("You Must Type Your Full Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFullName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(designationTextBox.Text))
            {
                MessageBox.Show("Please Enter Your Designation", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                designationTextBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(departmentTextBox.Text))
            {
                MessageBox.Show("Please Enter Your Department", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                departmentTextBox.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtContact_no.Text))
            {
                MessageBox.Show("Please Enter Your Contact Number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContact_no.Focus();
                return;
            }

            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select UserName from Registration where UserName=@d";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@d", System.Data.SqlDbType.NChar, 30, "UserName"));
                cmd.Parameters["@d"].Value = txtUsername.Text;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Username Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = "";
                    txtUsername.Focus();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct1 = "select Email from registration where Email='" + txtEmail.Text + "'";

                cmd = new SqlCommand(ct1);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Email Address Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Text = "";
                    txtEmail.Focus();

                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cb = "insert into Registration(UserName,Email,UserType,Password,Name,Designation,Department,ContactNo) VALUES ('" + txtUsername.Text + "','" + txtEmail.Text + "','" + cmbUserType.Text + "','" + txtPassword.Text + "','" + txtFullName.Text + "','" + designationTextBox.Text + "','" + departmentTextBox.Text + "','" + txtContact_no.Text + "')";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully Registered", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
                userButton.Enabled = false;
                //showLoginfrm();
            }
            catch (FormatException formatException)
            {
                MessageBox.Show("Please Enter Input in Correct Format", formatException.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void txtContact_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Contact_No = txtContact_no.Text;
            //if (char.IsNumber(e.KeyChar) || e.KeyChar=='+')
            if (char.IsNumber(e.KeyChar))
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string emailId = txtEmail.Text.Trim();
            Regex mRegxExpression;

            mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

            if (!mRegxExpression.IsMatch(emailId))
            {
                MessageBox.Show("E-mail address format is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Show();
        }
    }
}
