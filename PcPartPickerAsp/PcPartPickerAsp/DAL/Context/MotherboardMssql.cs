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
                using (SqlCommand cmd = new SqlCommand("Select * from Motherboard where Motherboard_id = @id", con))
                {

                    cmd.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    return new Motherboard(Convert.ToInt16(reader["Motherboard_id"]),
                        Convert.ToString("Chipset"),
                        Convert.ToString("Socket"),
                        Convert.ToInt16("Price"));



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
                        Convert.ToString("Chipset"),
                        Convert.ToString("Socket"),
                        Convert.ToInt16("Price")));
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