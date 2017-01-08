using System.Collections.Generic;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.Views
{
    public class CpuViewModel
    {
        public CpuViewModel(Computer currentBuild, List<Cpu> allCpus)
        {
            CurrentBuild = currentBuild;
            AllCpus = new List<Cpu>();
            AllCpus.AddRange(allCpus);
        }

        public Computer CurrentBuild { get; private set; }
        public List<Cpu> AllCpus { get; }
    }
}