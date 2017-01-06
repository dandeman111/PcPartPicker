using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.ViewModels
{
    public class GpuViewModel
    {
        public Computer CurrentBuild { get; private set; }
        public List<Gpu> AllGpus { get; private set; }

        public GpuViewModel(Computer currentBuild, List<Gpu> allGpus)
        {
            CurrentBuild = currentBuild;
            AllGpus = new List<Gpu>();
            AllGpus.AddRange(allGpus);
        }
}