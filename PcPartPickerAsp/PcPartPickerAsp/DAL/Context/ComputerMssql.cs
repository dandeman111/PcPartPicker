using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PcPartPickerAsp.DAL.Interface;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Context
{
    public class ComputerMssql : ConString, IComputer
    {
        public void Add(Computer computer)
        {
            throw new NotImplementedException();
#warning ik heb hiervoor een stored procedure aangemaakt
        }

        public void Delete(Computer computer)
        {
            throw new NotImplementedException();
        }

        public List<Computer> GetAll()
        {
            List<Computer> computers = new List<Computer>();
            using (SqlConnection con = new SqlConnection(Constring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from [computer] ", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    computers.Add(new Computer(Convert.ToInt16(reader["Computer_id"]),
                        Convert.ToInt16(reader["Cpu_id"]),
                        Convert.ToInt16(reader["Motherboard_id"]),
                        Convert.ToInt16(reader["Memory_id"]),
                        Convert.ToInt16(reader["Storage_id"])));
                }

            }
            return computers;
        }

        public Computer GetById(int id)
        {
            using (SqlConnection con = new SqlConnection(Constring))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from computer where Computer_id = @id", con))
                {

                    cmd.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    return new Computer(Convert.ToInt16(reader["Computer_id"]),
                        Convert.ToInt16(reader["Cpu_id"]),
                        Convert.ToInt16(reader["Motherboard_id"]),
                        Convert.ToInt16(reader["Memory_id"]),
                        Convert.ToInt16(reader["Storage_id"]));


                }
            }
        }

        public void Update(Computer computer)
        {
            throw new NotImplementedException();
        }
    }
}