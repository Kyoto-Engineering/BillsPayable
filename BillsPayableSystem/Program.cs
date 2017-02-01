using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillsPayableSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
<<<<<<< HEAD
            Application.Run(new frmLogin());
            //Application.Run(new frmRegistration());
            //Application.Run(new frmPayment());
            //Application.Run(new frmBillEntry());
            //Application.Run(new MainUI1());  
=======
            //Application.Run(new frmLogin());
            //Application.Run(new frmRegistration());
            //Application.Run(new frmPayment());
            //Application.Run(new frmBillEntry());
            Application.Run(new MainUI1());  
>>>>>>> origin/master

=======
            Application.Run(new frmBillEntry());
>>>>>>> parent of 9ee5e2d... Fix Some Error And Design
        }
    }
}
