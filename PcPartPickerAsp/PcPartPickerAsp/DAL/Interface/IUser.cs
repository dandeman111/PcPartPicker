using System.Collections.Generic;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Interface
{
    public interface IUser
    {
        void Add(User user);
        User GetByUsername(string username);
        List<User> GetAll();
        void Update(User user);
        void Delete(User user);
    }
}