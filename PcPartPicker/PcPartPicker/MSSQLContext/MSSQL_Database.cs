using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PcPartPicker.MSSQLContext
{
    abstract class MSSQL_Database
    {

        protected SqlConnection SqlCon { get; set; }
        private string ConnString { get; set; }

        public MSSQL_Database()
        {
            ConnString = "Server=DANNY-LAPTOP;" +
                          "Trusted_Connection=yes;" +
                           "database=DB_PcPartPicker; " +
                          "connection timeout=15";
            SqlCon = new SqlConnection(ConnString);
        }
    }
}
