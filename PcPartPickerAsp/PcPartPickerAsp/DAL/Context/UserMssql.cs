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
                con.Open();
                using (SqlCommand cmd = new SqlCommand("Select * from [User] left join[User_computer]on User_computer.Username = [User].Username where [User].Username = @Username", con))
                {
                    string un = null;
                    string pw = null;
                    string em = null;
                    List<int> pcs = new List<int>();
                    cmd.Parameters.AddWithValue("@Username", username);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                         un = Convert.ToString(reader["Username"]);
                        pw = Convert.ToString(reader["Password"]);
                        em = Convert.ToString(reader["Email"]);
                        pcs.Add(Convert.ToInt16(GetInt(reader["Computer_id"])));
#warning als het NULL is returned het een 0
                    }
                    return new User(
                        un,
                        pw,
                        em,
                        pcs
                        );


                }
            }
        }

        public List<User> GetAll()
        {
            List<User> users = new List<User>();
            using (SqlConnection con = new SqlConnection(Constring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from [User] left join[User_computer]on User_computer.Username = [User].Username", con);
                SqlDataReader reader = cmd.ExecuteReader();
                
                List<string> usernames = new List<string>();
                while (reader.Read())
                {
                    usernames.Add(Convert.ToString(reader["Username"]));

                }
                foreach (string un in usernames)
                {
                   users.Add(GetByUsername(un));
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