using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcPartPicker;

namespace PcPartPickerAsp.DAL.Interface
{
    public interface IMemory
    {
        void Add( Memory memory);
        Memory GetById(int id);
        List<Memory> GetAll();
        void Update(Memory memory);
        void Delete(Memory memory);
    }
}
