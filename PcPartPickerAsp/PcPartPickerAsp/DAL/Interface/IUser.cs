using System.Collections.Generic;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Interface
{
    public interface IUser
    {
        void Add(User user);
        User GetById(int id);
        List<User> GetAll();
        void Update(User user);
        void Delete(User user);
    }
}
