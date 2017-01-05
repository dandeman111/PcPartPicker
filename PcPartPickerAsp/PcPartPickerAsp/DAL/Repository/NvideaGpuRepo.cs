using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PcPartPickerAsp.DAL.Interface;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Repository
{
    public class NvideaGpuRepo
    {
        public INvideaGpu Context { get; private set; }

        public NvideaGpuRepo(INvideaGpu nvideaGpuContext)
        {
            Context = nvideaGpuContext;
        }
        public void Add(NvideaGpu nvideaGpu)
        {
            throw new NotImplementedException();
        }

        public NvideaGpu GetById(int id)
        {
            return Context.GetById(id);
        }

        public List<NvideaGpu> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(NvideaGpu nvideaGpu)
        {
            throw new NotImplementedException();
        }

        public void Delete(NvideaGpu nvideaGpu)
        {
            throw new NotImplementedException();
        }
    }
}