using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillsPayableSystem.DbGateway
{
   public class ConnectionString
    {
       //For Live
       //public string DBConn = @"Data Source=tcp:kyotoServer,49172;Initial Catalog=BillsPayableDB;User ID=sa;Password=SystemAdministrator;Persist Security Info=True";
       
       //Dummy
       public string DBConn = @"Data Source=tcp:kyotoServer,49172;Initial Catalog=BillsPayableDB_new-R;User ID=sa;Password=SystemAdministrator;Persist Security Info=True";
       
       //For Local
      //public string DBConn = @"Data Source=KYOTO-PC99;Initial Catalog=BillsPayableDB;Persist Security Info=True;User ID=sa;Password=SystemAdministrator";
       
       //For Local
       //public string DBConn = @"Data Source=KYOTO-PC13;Initial Catalog=BillsPayableDB;Persist Security Info=True;User ID=sa;Password=SystemAdministrator";

        //public string DBConn = @"Data Source=;Initial Catalog=BillsPayableDB;Persist Security Info=True;User ID=;Password=";
    }
}
