using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using PcPartPickerAsp.DAL.Interface;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Context
{
    public class MemoryMssql : ConString, IMemory
    {
        public void Add(Memory memory)
        {
            throw new NotImplementedException();
        }

        public Memory GetById(int id)
        {
            using (var con = new SqlConnection(Constring))
            {
                con.Open();
                using (var cmd = new SqlCommand("Select * from Memory where Memory_id = @id", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    var reader = cmd.ExecuteReader();

                    if (reader.Read())
                        return new Memory(Convert.ToInt16(reader["Memory_id"]),
                            Convert.ToInt16(reader["Clockspeed"]),
                            Convert.ToString(reader["Type"]),
                            Convert.ToInt16(reader["Price"]),
                            Convert.ToString(reader["Name"]));
                    return null;
                }
            }
        }

        public List<Memory> GetAll()
        {
            var mems = new List<Memory>();
            using (var con = new SqlConnection(Constring))
            {
                con.Open();
                var cmd = new SqlCommand("select * from [Memory] ", con);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                    mems.Add(new Memory(Convert.ToInt16(reader["Memory_id"]),
                        Convert.ToInt16(reader["Clockspeed"]),
                        Convert.ToString(reader["Type"]),
                        Convert.ToInt16(reader["Price"]),
                        Convert.ToString(reader["Name"])));
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