using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PcPartPickerAsp.DAL.Interface;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Context
{
    public class UserMssql:ConString, IUser
    {
        public void Add(User user)
        {
            using (SqlConnection con = new SqlConnection(Constring))
            {
                using (SqlCommand cmd = new SqlCommand("Insert into[User]Values(@Username, @Password, @Email)", con))
                {
                    cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = user.Username;
                    cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = user.Password;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = user.Email;

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public User GetByUsername(string username)
        {
            using (SqlConnection con = new SqlConnection(Constring))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from gpu Join Amd on Amd.Gpu_id = Gpu.Gpu_id Where Gpu.Gpu_id = @GpuId", con))
                {

                    cmd.Parameters.AddWithValue("@Username", username);

                    SqlDataReader reader = cmd.ExecuteReader();

                    return new User(
                        Convert.ToString(reader["Username"]),
                        Convert.ToString(reader["Password"]),
                        Convert.ToString(reader["Email"])
                        );


                }
            }
        }

        public List<User> GetAll()
        {
            List<User> users = new List<User>();
            using (SqlConnection con = new SqlConnection(Constring))
            {

                SqlCommand cmd = new SqlCommand("select * from User ", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    users.Add(new User(
                        Convert.ToString(reader["Username"]),
                        Convert.ToString(reader["Password"]),
                        Convert.ToString(reader["Email"])
                        ));
                }

            }
            return users;
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }

        public void Delete(User user)
        {
            throw new NotImplementedException();
        }
    }
}