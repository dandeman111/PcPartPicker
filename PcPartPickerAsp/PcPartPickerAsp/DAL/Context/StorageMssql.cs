using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using PcPartPickerAsp.DAL.Interface;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Context
{
    public class StorageMssql : ConString, IStorage
    {
        public void Add(Storage storage)
        {
            throw new NotImplementedException();
        }

        public Storage GetById(int id)
        {
            using (var con = new SqlConnection(Constring))
            {
                con.Open();
                using (var cmd = new SqlCommand("Select * from Storage where Storage_id = @id", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    var reader = cmd.ExecuteReader();

                    if (reader.Read())
                        return new Storage(Convert.ToInt16(reader["Storage_id"]),
                            Convert.ToString(reader["Speed"]),
                            Convert.ToString(reader["Interface"]),
                            Convert.ToInt16(reader["Price"]),
                            Convert.ToString(reader["Name"]));
                    return null;
                }
            }
        }

        public List<Storage> GetAll()
        {
            var storages = new List<Storage>();
            using (var con = new SqlConnection(Constring))
            {
                con.Open();
                var cmd = new SqlCommand("select * from [Storage] ", con);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                    storages.Add(new Storage(Convert.ToInt16(reader["Storage_id"]),
                        Convert.ToString(reader["Speed"]),
                        Convert.ToString(reader["Interface"]),
                        Convert.ToInt16(reader["Price"]),
                        Convert.ToString(reader["Name"])));
            }
            return storages;
        }

        public void Update(Storage storage)
        {
            throw new NotImplementedException();
        }

        public void Delete(Storage storage)
        {
            throw new NotImplementedException();
        }
    }
}