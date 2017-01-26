using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BillsPayableSystem.LoginUI;

namespace BillsPayableSystem.UI
{
    public partial class MainUI1 : Form
    {
        public MainUI1()
        {
            InitializeComponent();
        }

        private void btnBillEntry_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBillEntry frm1 = new frmBillEntry();
            frm1.Show();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistration frm2=new frmRegistration();
            frm2.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Show();
            
        }
    }
}
