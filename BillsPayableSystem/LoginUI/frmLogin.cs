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
using BillsPayableSystem.UI;

namespace BillsPayableSystem.LoginUI
{
    public partial class frmLogin : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        //private SqlDataAdapter sda;
        private SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        public int uId;
        public static string userType;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please enter user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs.DBConn);

                SqlCommand myCommand = default(SqlCommand);

                myCommand = new SqlCommand("SELECT UserName,Password FROM Registration WHERE UserName = @username AND Password = @UserPassword", myConnection);
                SqlParameter uName = new SqlParameter("@username", SqlDbType.VarChar);
                SqlParameter uPassword = new SqlParameter("@UserPassword", SqlDbType.VarChar);
                uName.Value = txtUsername.Text;
                uPassword.Value = txtPassword.Text;
                myCommand.Parameters.Add(uName);
                myCommand.Parameters.Add(uPassword);

                myCommand.Connection.Open();

                //SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
                rdr = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                if (rdr.Read() == true)
                {
                    int i;
                    progressBar2.Visible = true;
                    progressBar2.Maximum = 3;
                    progressBar2.Minimum = 0;
                    progressBar2.Value = 2;
                    progressBar2.Step = 1;

                    for (i = 0; i <= 3; i++)
                    {
                        progressBar2.PerformStep();
                    }
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string ct = "select UserType,UserId from Registration where Username='" + txtUsername.Text + "'and Password='" + txtPassword.Text + "'";
                    cmd = new SqlCommand(ct);
                    cmd.Connection = con;
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        userType = (rdr.GetString(0));
                        uId = (rdr.GetInt32(1));

                    }
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }

                    if (userType.Trim() == "Admin")
                    {
                        this.Hide();
                        MainUI1 frm = new MainUI1();
                        frm.Show();

                        //frm.lblUser.Text = txtUsername.Text;
                        txtPassword.Clear();
                        txtUsername.Clear();
                    }
                    //if (txtUserType.Text.Trim() == "User")
                    //{

                    //    MasterPagesForUser frm = new MasterPagesForUser();
                    //    this.Visible = false;
                    //    frm.ShowDialog();
                    //    this.Visible = true;

                    //}

                }


                else
                {
                    MessageBox.Show("Login is Failed...Try again !", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();

                }
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
