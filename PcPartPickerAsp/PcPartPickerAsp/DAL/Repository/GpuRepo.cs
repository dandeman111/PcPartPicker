using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PcPartPickerAsp.DAL.Interface;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Repository
{
    public class GpuRepo
    {
        public IGpu Context { get; private set; }

        public GpuRepo(IGpu contextGpu)
        {
            Context = contextGpu;
        }

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