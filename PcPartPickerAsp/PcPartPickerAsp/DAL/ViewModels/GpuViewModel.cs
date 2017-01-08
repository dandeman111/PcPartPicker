using System.Collections.Generic;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.ViewModels
{
    public class GpuViewModel
    {
        public GpuViewModel(Computer currentBuild, List<Gpu> allGpus, int currentGpu)
        {
            CurrentBuild = currentBuild;
            CurrentGpu = currentGpu;
            AllGpus = new List<Gpu>();
            AllGpus.AddRange(allGpus);
        }

        public Computer CurrentBuild { get; private set; }
        public List<Gpu> AllGpus { get; }
        public int CurrentGpu { get; private set; }
    }
}