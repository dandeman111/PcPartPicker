using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcPartPicker.Interfaces;
using System.Data.SqlClient;

namespace PcPartPicker.MSSQLContext
{
    class MSSQL_Cpu : MSSQL_Database, ICpu
    {
        //properties
        
        //constructor

        //methoden
        public void AddCpu(Cpu cpu)
        {
            string commandString = "USE [DB_PcPartPicker] INSERT INTO [dbo].[Cpu]([Clockspeed],[Cores],[Brand],[Price],[Socket],[Name])VALUES ( " + cpu.Clockspeed + " , " + cpu.Cores + " , ' " + cpu.Brand.ToString() + "' , " + cpu.Price + " , '"+ cpu.Socket.ToString() + " ',' " + cpu.Name.ToString() + "' )";
  
            using (SqlCommand command = new SqlCommand(commandString, SqlCon))
            {
                try
                {
                    SqlCon.Open();
                    command.ExecuteNonQuery();
                    SqlCon.Close();
                }
                catch (SqlException e)
                {
                    System.Console.WriteLine(e);
                }
            }
            
        }

        public void DeleteCpu(Cpu cpu)
        {
            string commandString = "USE [DB_PcPartPicker] DELETE FROM [dbo].[Cpu] WHERE Cpu_id ="+cpu.Cpu_id ;

            using (SqlCommand command = new SqlCommand(commandString, SqlCon))
            {
                try
                {
                    SqlCon.Open();
                    command.ExecuteNonQuery();
                    SqlCon.Close();
                }
                catch (SqlException e)
                {
                    System.Console.WriteLine(e);
                }
            }
        }

        public void EditCpu(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public Cpu GetCpu(int id)
        {
            throw new NotImplementedException();
        }
    }
}
