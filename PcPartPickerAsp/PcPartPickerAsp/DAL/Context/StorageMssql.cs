using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PcPartPickerAsp.DAL.Interface;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Context
{
    public class StorageMssql:ConString, IStorage
    {
        public void Add(Storage storage)
        {
            throw new NotImplementedException();
        }

        public Storage GetById(int id)
        {
            using (SqlConnection con = new SqlConnection(Constring))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from Storage where Storage_id = @id", con))
                {

                    cmd.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    return new Storage(Convert.ToInt16(reader["Storage_id"]),
                        Convert.ToInt16(reader["Speed"]),
                        Convert.ToString(reader["Interface"]),
                        Convert.ToInt16(reader["Price"]));



                }
            }
        }

        public List<Storage> GetAll()
        {
            List<Storage> storages = new List<Storage>();
            using (SqlConnection con = new SqlConnection(Constring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from [Storage] ", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    storages.Add(new Storage(Convert.ToInt16(reader["Storage_id"]),
                        Convert.ToInt16(reader["Speed"]),
                        Convert.ToString(reader["Interface"]),
                        Convert.ToInt16(reader["Price"])));
                }

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