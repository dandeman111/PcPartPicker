using System.Collections.Generic;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Interface
{
    public interface IMemory
    {
        void Add(Memory memory);
        Memory GetById(int id);
        List<Memory> GetAll();
        void Update(Memory memory);
        void Delete(Memory memory);
    }
}