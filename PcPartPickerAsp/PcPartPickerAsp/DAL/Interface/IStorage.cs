using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcPartPicker;

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
