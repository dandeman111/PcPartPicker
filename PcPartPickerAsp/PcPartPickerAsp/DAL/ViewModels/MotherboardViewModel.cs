using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.ViewModels
{
    public class MotherboardViewModel
    {
        public Computer CurrentBuild { get; private set; }
        public List<Motherboard> AllMotherboards { get; private set; }

        public MotherboardViewModel(Computer currentBuild, List<Motherboard> allMotherboards)
        {
            CurrentBuild = currentBuild;
            AllMotherboards = new List<Motherboard>();
            AllMotherboards.AddRange(allMotherboards);
        }
    }
}