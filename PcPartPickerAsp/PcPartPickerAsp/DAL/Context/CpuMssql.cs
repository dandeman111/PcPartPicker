using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using PcPartPickerAsp.DAL.Interface;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Context
{
    public class CpuMssql: ConString , ICpu
    {
        public void Add(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public Cpu GetById(int id)
        {
            using (SqlConnection con = new SqlConnection(Constring))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("Select * from Cpu where Cpu_id = @id", con))
                {
                    Cpu c;
                    c = null;
                    cmd.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        c = new Cpu(Convert.ToInt16(reader["Cpu_id"]),
                        Convert.ToInt16(reader["Clockspeed"]),
                        Convert.ToInt16(reader["Cores"]),
                        Convert.ToString(reader["Brand"]),
                        Convert.ToInt16(reader["Price"]),
                        Convert.ToString(reader["Socket"]),
                        Convert.ToString(reader["Name"]));
                    }
                    
                    return c;



                }
            }
        }

        public List<Cpu> GetAll()
        {
            List<Cpu> users = new List<Cpu>();
            using (SqlConnection con = new SqlConnection(Constring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from [Cpu] ", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    users.Add(new Cpu(Convert.ToInt16(reader["Cpu_id"]),
                        Convert.ToInt16(reader["Clockspeed"]),
                        Convert.ToInt16(reader["Cores"]),
                        Convert.ToString(reader["Brand"]),
                        Convert.ToInt16(reader["Price"]),
                        Convert.ToString(reader["Socket"]),
                        Convert.ToString(reader["Name"])));
                }

            }
            return users;
        }

        public void Update(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public void Delete(Cpu cpu)
        {
            throw new NotImplementedException();
        }
    }
}