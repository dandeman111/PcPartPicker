using System.Collections.Generic;
using PcPartPickerAsp.DAL.Context;
using PcPartPickerAsp.DAL.Repository;

namespace PcPartPickerAsp.DAL.Models
{
    public class User
    {
        //constructor
        public User(string username, string password, string email, List<int> computers)
        {
            Computers = new List<Computer>();
            var cr = new ComputerRepo(new ComputerMssql());
            Username = username;
            Password = password;
            Email = email;
            foreach (var x in computers)
                Computers.Add(cr.GetById(x));
        }

        //properties
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public List<Computer> Computers { get; set; }
    }
}