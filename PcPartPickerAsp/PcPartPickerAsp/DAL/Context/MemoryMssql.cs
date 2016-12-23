using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PcPartPickerAsp.DAL.Interface;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Context
{
    public class MemoryMssql: ConString, IMemory
    {
        public void Add(Memory memory)
        {
            throw new NotImplementedException();
        }

        public Memory GetById(int id)
        {
            using (SqlConnection con = new SqlConnection(Constring))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from Memory where Memory_id = @id", con))
                {

                    cmd.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    return new Memory(Convert.ToInt16(reader["Memory_id"]),
                        Convert.ToInt16(reader["Clockspeed"]),
                        Convert.ToString(reader["Type"]),
                        Convert.ToInt16(reader["Price"]));



                }
            }
        }

        public List<Memory> GetAll()
        {
            List<Memory> mems = new List<Memory>();
            using (SqlConnection con = new SqlConnection(Constring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from [Memory] ", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    mems.Add(new Memory(Convert.ToInt16(reader["Memory_id"]),
                        Convert.ToInt16(reader["Clockspeed"]),
                        Convert.ToString(reader["Type"]),
                        Convert.ToInt16(reader["Price"])));
                }

            }
            return mems;
        }

        public void Update(Memory memory)
        {
            throw new NotImplementedException();
        }

        public void Delete(Memory memory)
        {
            throw new NotImplementedException();
        }
    }
}