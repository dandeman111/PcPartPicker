using System;
using System.Collections.Generic;
using PcPartPickerAsp.DAL.Interface;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Repository
{
    public class CpuRepo
    {
        public CpuRepo(ICpu contextCpu)
        {
            Context = contextCpu;
        }

        public ICpu Context { get; }

        public void Add(Cpu cpu)
        {
            Context.Add(cpu);
        }

        public Cpu GetById(int id)
        {
            return Context.GetById(id);
        }

        public List<Cpu> GetAll()
        {
            return Context.GetAll();
        }

        public void Update(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public void Delete(Cpu cpu)
        {
            throw new NotImplementedException();
        }
    }
}