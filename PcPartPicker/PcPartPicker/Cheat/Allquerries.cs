using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcPartPicker.MSSQLContext;
using System.Data.SqlClient;
using System.Data;

namespace PcPartPicker.Cheat
{
   public  class Allquerries:MSSQL_Database
    {
        public DataTable  querry1 ()
        {
            DataTable dt = new DataTable();
            string commandString = @"USE [DB_PcPartPicker] Select u.username,c.Name
                                        from[User] u
                                        left join User_computer uc
                                        on uc.Username = u.Username
                                        left join Computer c
                                        on c.Computer_id = uc.Computer_id";

            using (SqlCommand command = new SqlCommand(commandString, SqlCon))
            {
                using(SqlDataAdapter a = new SqlDataAdapter(commandString, SqlCon))
                {
                    a.Fill(dt);
                }
            }
            return (dt);

        }

    }
}
