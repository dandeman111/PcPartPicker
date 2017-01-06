using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PcPartPickerAsp.DAL.Interface;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Context
{
    public class MotherboardMssql:ConString , IMotherboard
    {
        public void Add(Motherboard motherboard)
        {
            throw new NotImplementedException();
        }

        public Motherboard GetById(int id)
        {
            using (SqlConnection con = new SqlConnection(Constring))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("Select * from Motherboard where Motherboard_id = @id", con))
                {
                    Motherboard m;
                    m = null;
                    cmd.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int x = Convert.ToInt16(reader["Motherboard_id"]);
                        string cs = Convert.ToString(reader["Chipset"]);
                        string socket = Convert.ToString(reader["Socket"]);
                        int p = Convert.ToInt16(reader["Price"]);
                        string name = Convert.ToString(reader["Name"]);
                        m = new Motherboard(x,cs,socket,p,name);
                    }
                    return m;



                }
            }
        }

        public List<Motherboard> GetAll()
        {
            List<Motherboard> motherboards = new List<Motherboard>();
            using (SqlConnection con = new SqlConnection(Constring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from [Motherboard] ", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    motherboards.Add(new Motherboard(
                        Convert.ToInt16(reader["Motherboard_id"]),
                        Convert.ToString(reader["Chipset"]),
                        Convert.ToString(reader["Socket"]),
                        Convert.ToInt16(reader["Price"]),
                        Convert.ToString(reader["Name"])));
                }

            }
            return motherboards;
        }

        public void Update(Motherboard motherboard)
        {
            throw new NotImplementedException();
        }

        public void Delete(Motherboard motherboard)
        {
            throw new NotImplementedException();
        }
    }
}