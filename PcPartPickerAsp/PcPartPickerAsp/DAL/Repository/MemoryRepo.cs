using System;
using System.Collections.Generic;
using PcPartPickerAsp.DAL.Interface;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Repository
{
    public class MemoryRepo
    {
        public MemoryRepo(IMemory memoryContext)
        {
            Context = memoryContext;
        }

        public IMemory Context { get; }

        public void Add(Memory memory)
        {
            throw new NotImplementedException();
        }

        public Memory GetById(int id)
        {
            return Context.GetById(id);
        }

        public List<Memory> GetAll()
        {
            return Context.GetAll();
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