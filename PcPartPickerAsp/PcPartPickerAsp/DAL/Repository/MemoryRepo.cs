using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PcPartPickerAsp.DAL.Interface;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Repository
{
    public class MemoryRepo
    {
        public IMemory Context { get; private set; }
        public void Add(Memory memory)
        {
            throw new NotImplementedException();
        }

        public Memory GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Memory> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Memory memory)
        {
            throw new NotImplementedException();
        }

        public void Delete(Memory memory)
        {
            throw new NotImplementedException();
        }
    }
}