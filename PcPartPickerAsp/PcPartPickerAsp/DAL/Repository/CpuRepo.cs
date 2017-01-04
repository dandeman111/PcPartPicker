using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PcPartPickerAsp.DAL.Interface;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Repository
{
    public class CpuRepo
    {
        public ICpu Context { get; private set; }

        public CpuRepo(ICpu contextCpu)
        {
            Context = contextCpu;
        }
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
            throw new NotImplementedException();
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