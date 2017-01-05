using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.Views
{
    public class CpuViewModel
    {
        public Computer CurrentBuild { get; private set; }
        public List<Cpu> AllCpus { get; private set; }

        public CpuViewModel(Computer currentBuild, List<Cpu> allCpus )
        {
            CurrentBuild = currentBuild;
            AllCpus = new List<Cpu>();
            AllCpus.AddRange(allCpus);
        }
    }
}