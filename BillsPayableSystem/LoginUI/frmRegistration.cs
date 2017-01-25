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
            cmbUserType.Text = "";
            txtFullName.Text = "";
            designationTextBox.Text = "";
            departmentTextBox.Text = "";
            txtContact_no.Text = "";
            userButton.Enabled = true;
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

                string cb = "insert into Registration(UserName,Email,UserType,Password,Name,Designation,Department,ContactNo) VALUES ('" + txtUsername.Text + "','" + txtEmail.Text + "','" + cmbUserType.Text + "','" + txtPassword.Text + "','" + txtFullName.Text + "','" + designationTextBox.Text + "','" + departmentTextBox.Text + "','" + txtContact_no.Text + "')";

                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully Registered", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
                userButton.Enabled = false;

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

    }
}
