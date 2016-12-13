using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcPartPicker;

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
