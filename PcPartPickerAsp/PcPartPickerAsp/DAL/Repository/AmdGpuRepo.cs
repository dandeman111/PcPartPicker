using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PcPartPickerAsp.DAL.Interface;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Repository
{
    public class AmdGpuRepo
    {
        public IAmdGpu Context { get; private set; }

        public AmdGpuRepo(IAmdGpu amdGpuContext)
        {
            Context = amdGpuContext;
        }
        public void Add(AmdGpu amdGpu)
        {
            Context.Add(amdGpu);
        }

        public void Delete(AmdGpu amdGpu)
        {
            throw new NotImplementedException();
        }

        public List<AmdGpu> GetAll()
        {
            throw new NotImplementedException();
        }

        public AmdGpu GetById(int id)
        {
            return Context.GetById(id);
        }

        public void Update(AmdGpu amdGpu)
        {
            throw new NotImplementedException();
        }
    }
}