using System.Collections.Generic;


namespace PcPartPickerAsp.DAL.Models
{
    public class User
    {
        //properties
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public List<Computer> Computers{ get;set;}

        //constructor
        public User(string username,string password,string email)
        {
            Username = username;
            Password = password;
            Email = email;
        }

    }
}
