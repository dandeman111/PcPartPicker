using System.Collections.Generic;
using PcPartPickerAsp.DAL.Interface;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Repository
{
    public class GpuRepo
    {
        public GpuRepo(IGpu contextGpu)
        {
            Context = contextGpu;
        }

        public IGpu Context { get; }

        public Gpu GetById(int id)
        {
            return Context.GetById(id);
        }

        public List<Gpu> GetAll()
        {
            return Context.GetAll();
        }
    }
}