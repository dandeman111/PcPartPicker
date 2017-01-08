using System.Collections.Generic;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Interface
{
    public interface IStorage
    {
        void Add(Storage storage);
        Storage GetById(int id);
        List<Storage> GetAll();
        void Update(Storage storage);
        void Delete(Storage storage);
    }
}