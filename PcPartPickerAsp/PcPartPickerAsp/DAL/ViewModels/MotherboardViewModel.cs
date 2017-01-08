using System.Collections.Generic;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.ViewModels
{
    public class MotherboardViewModel
    {
        public MotherboardViewModel(Computer currentBuild, List<Motherboard> allMotherboards)
        {
            CurrentBuild = currentBuild;
            AllMotherboards = new List<Motherboard>();
            AllMotherboards.AddRange(allMotherboards);
        }

        public Computer CurrentBuild { get; private set; }
        public List<Motherboard> AllMotherboards { get; }
    }
}