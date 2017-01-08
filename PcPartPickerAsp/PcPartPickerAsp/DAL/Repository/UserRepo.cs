using System;
using System.Collections.Generic;
using PcPartPickerAsp.DAL.Interface;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Repository
{
    public class UserRepo
    {
        //constructor
        public UserRepo(IUser userContext)
        {
            Context = userContext;
        }

        public IUser Context { get; }


        public void Add(User user)
        {
            Context.Add(user);
        }

        public void Delete(User user)
        {
            Context.Delete(user);
        }

        public List<User> GetAll()
        {
            return Context.GetAll();
        }

        public User GetByUsername(string username)
        {
            return Context.GetByUsername(username);
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }

        public User Login(string password, string email)
        {
            var users = GetAll();

            foreach (var user in users)
                if ((user.Email == email) && (user.Password == password))
                    return user;
            return null;
        }
    }
}