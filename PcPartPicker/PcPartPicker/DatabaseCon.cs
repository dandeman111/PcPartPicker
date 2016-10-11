using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PcPartPicker
{
    abstract class Database
    {
        private SqlConnection Conn { get; set; }
        public String ConnectionString { get; set; }
        private SqlCommand Command { get; set; }
        private String CommandString { get; set; }
        
        public Database()
        {
            //het adres van de database
            ConnectionString = "Server=DANNY-LAPTOP;" +
                          "Trusted_Connection=yes;" +
                           "database=DB_PcPartPicker; " +
                          "connection timeout=15";
            CommandString = "Select * from [user]";

            Conn = new SqlConnection(ConnectionString);
            Conn.Open();
            SqlDataReader myreader = null;
            Command = new SqlCommand(CommandString, Conn);
            Conn.Close();
            
        }
    }
}
