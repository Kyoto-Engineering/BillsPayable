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
using System.IO;
using System.Runtime.InteropServices;
using BillsPayableSystem.DbGateway;
using BillsPayableSystem.LoginUI;
using BillsPayableSystem.UI;


namespace BillsPayableSystem
{
    public partial class frmBillEntry : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        public int btype_id, nameOfBillId, bPayableToId;
        public string user_id;
        private delegate void ChangeFocusDelegate(Control ctl);
        

        public frmBillEntry()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            user_id = frmLogin.uId.ToString();
            BillsType();
            PayableTo();
                       //For Spell check
//System.Windows.Forms.Integration.ElementHost elementHost1 = new System.Windows.Forms.Integration.ElementHost();
//System.Windows.Controls.TextBox textBoxz = new System.Windows.Controls.TextBox();
//textBoxz.SpellCheck.IsEnabled = true;
//elementHost1.Child = textBoxz;
        }

        private void changeFocus(Control ctl)
        {
            ctl.Focus();
        }
        private void ClearData()
        {        
            //cmbPayableTo.Text = "";
            cmbPayableTo.Items.Clear();
            cmbPayableTo.SelectedIndex = -1;
            txtBillSiNo.Clear();
            txtAmount.Clear();
            cmbPaymentMethod.SelectedIndex = -1;
            cmbBillType.SelectedIndex = -1;
            cmbBillPurpose.Text = "";
            cmbBillPurpose.Items.Clear();
            cmbBillPurpose.SelectedIndex = -1;
            txtpictureBox.Image = null;
            txtBillNarrative.Clear();
            txtNote.Clear();
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
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ctt = "select BPayableToName from BPayableTo";
                cmd = new SqlCommand(ctt);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();
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
                string input = Microsoft.VisualBasic.Interaction.InputBox("Please Input Payable To Here", "Input Here", "", -1, -1);
                if (string.IsNullOrWhiteSpace(input))
                {
                    cmbPayableTo.SelectedIndex = -1;
                }
                else
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string ct2 = "select BPayableToName from BPayableTo where BPayableToName='" + input + "'";
                    cmd = new SqlCommand(ct2, con);
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read() && !rdr.IsDBNull(0))
                    {
                        MessageBox.Show("This PayableTo Name Already Exists,Please Select From List", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                        cmbPayableTo.SelectedIndex = -1;
                    }
                    else
                    {
                        try
                        {
                            con = new SqlConnection(cs.DBConn);
                            con.Open();
                            string query1 = "insert into BPayableTo (BPayableToName) values (@d1)" ;
                            cmd = new SqlCommand(query1, con);
                            cmd.Parameters.AddWithValue("@d1", input);
                            cmd.ExecuteNonQuery();
                            
                            con.Close();
                            cmbPayableTo.Items.Clear();
                            PayableTo();
                            cmbPayableTo.SelectedText = input;
                            txtAmount.Focus();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                
            }
            else
            {
              try
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
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

            if (cmbBillType.Text == "Recurrent")
            {
                lblFrom.Visible = true;
                dtpFrom.Visible = true;
                lblTo.Visible = true;
                dtpTo.Visible = true;
            }
            else
            {
                lblFrom.Visible = false;
                dtpFrom.Visible = false;
                lblTo.Visible = false;
                dtpTo.Visible = false;
            }

                try
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
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

                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string ct = "select distinct RTRIM(BillName) from BillsPayableName where BillTypeId= " + btype_id + "";

                    cmd = new SqlCommand(ct);
                    cmd.Connection = con;
                    rdr = cmd.ExecuteReader();

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
                con = new SqlConnection(cs.DBConn);
                con.Open();
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

        private void SaveBillTransaction2()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                String query = "insert into BTransaction(BillId, Narrative, PaymentMethod, Amount, BIssueDate, BReceivedDate, DueDate, BPayableToId, Note, SiNo, UserId,StatusForSN,BillImage) values (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13)" + "SELECT CONVERT(int, SCOPE_IDENTITY())";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@d1", nameOfBillId);
                cmd.Parameters.AddWithValue("@d2", txtBillNarrative.Text);
                cmd.Parameters.AddWithValue("@d3", cmbPaymentMethod.Text);
                cmd.Parameters.AddWithValue("@d4", Convert.ToDecimal(txtAmount.Text));
                cmd.Parameters.AddWithValue("@d5", dtpBillDate.Value);
                cmd.Parameters.AddWithValue("@d6", dtpBillReceivedDate.Value);
                cmd.Parameters.AddWithValue("@d7", dtpDueDate.Value);
                cmd.Parameters.AddWithValue("@d8", bPayableToId);
                cmd.Parameters.AddWithValue("@d9", txtNote.Text);
                cmd.Parameters.AddWithValue("@d10", txtBillSiNo.Text);
                cmd.Parameters.AddWithValue("@d11", user_id);
                cmd.Parameters.AddWithValue("@d12", "New");

                if (txtpictureBox.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    Bitmap bmpImage = new Bitmap(txtpictureBox.Image);
                    bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] data = ms.GetBuffer();
                    SqlParameter p = new SqlParameter("@d13", SqlDbType.Image);
                    p.Value = data;
                    cmd.Parameters.Add(p);
                }
                else
                {
                    cmd.Parameters.Add("@d13", SqlDbType.VarBinary, -1);
                    cmd.Parameters["@d13"].Value = DBNull.Value;
                }
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Saved successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
                PayableTo();
                cmbPayableTo.ResetText();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveBillTransaction()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                String query = "insert into BTransaction(BillId, Narrative, PaymentMethod, Amount, BIssueDate, BReceivedDate, DueDate, BPayableToId, Note, PeriodFrom, PeriodTo, SiNo, UserId,StatusForSN,BillImage) values (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d15)" + "SELECT CONVERT(int, SCOPE_IDENTITY())";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@d1", nameOfBillId);
                cmd.Parameters.AddWithValue("@d2", txtBillNarrative.Text);
                cmd.Parameters.AddWithValue("@d3", cmbPaymentMethod.Text);
                cmd.Parameters.AddWithValue("@d4", Convert.ToDecimal(txtAmount.Text));
                cmd.Parameters.AddWithValue("@d5", dtpBillDate.Value);
                cmd.Parameters.AddWithValue("@d6", dtpBillReceivedDate.Value);
                cmd.Parameters.AddWithValue("@d7", dtpDueDate.Value);
                cmd.Parameters.AddWithValue("@d8", bPayableToId);
                cmd.Parameters.AddWithValue("@d9", txtNote.Text);
                cmd.Parameters.AddWithValue("@d10", dtpFrom.Value);
                cmd.Parameters.AddWithValue("@d11", dtpTo.Value);
                cmd.Parameters.AddWithValue("@d12", txtBillSiNo.Text);
                cmd.Parameters.AddWithValue("@d13", user_id);
                cmd.Parameters.AddWithValue("@d14", "New");
               
                if (txtpictureBox.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    Bitmap bmpImage = new Bitmap(txtpictureBox.Image);
                    bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] data = ms.GetBuffer();
                    SqlParameter p = new SqlParameter("@d15", SqlDbType.Image);
                    p.Value = data;
                    cmd.Parameters.Add(p);
                }
                else
                {
                    cmd.Parameters.Add("@d15", SqlDbType.VarBinary, -1);
                    cmd.Parameters["@d15"].Value = DBNull.Value;
                }

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Saved successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
                PayableTo();
                cmbPayableTo.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbPayableTo.Text))
            {
                MessageBox.Show("Please  enter PayableTo Name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Please  enter Amount", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbPaymentMethod.Text))
            {
                MessageBox.Show("Please Select Payment Method", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbBillType.Text))
            {
                MessageBox.Show("Please Select Type of Bill", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbBillPurpose.Text))
            {
                MessageBox.Show("Please Select Bill Purpose", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBillNarrative.Text))
            {
                MessageBox.Show("Please  enter Bill Narrative", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbBillType.Text == "Recurrent")
            {
                SaveBillTransaction();
            }
            else
            {
                SaveBillTransaction2();
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(txtAmount.Text + ch, out x))
            {
                e.Handled = true;
            }
        }

        private void cmbPayableTo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbPayableTo.Text) && !cmbPayableTo.Items.Contains(cmbPayableTo.Text))
            {
                MessageBox.Show("Please Select A Valid Payable To", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbPayableTo.ResetText();
                this.BeginInvoke(new ChangeFocusDelegate(changeFocus), cmbPayableTo);

            }
        }

        private void txtBillSiNo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            try
            {
                var _with1 = openFileDialog1;

                _with1.Filter = ("Image Files |*.png; *.bmp; *.jpg;*.jpeg; *.gif;");
                _with1.FilterIndex = 4;

                openFileDialog1.FileName = "";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtpictureBox.Image = Image.FromFile(openFileDialog1.FileName);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmBillEntry_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            MainUI1 frm3 = new MainUI1();
            frm3.Show();
        }
    }
 }

      
    
