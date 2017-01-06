using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.ViewModels
{
    public class MemoryViewModel
    {
        public Computer CurrentBuild { get; private set; }
        public List<Memory> AllMemories { get; private set; }

        public MemoryViewModel(Computer currentBuild, List<Memory> allMemories)
        {
            CurrentBuild = currentBuild;
            AllMemories = new List<Memory>();
            AllMemories.AddRange(allMemories);
        }
    }
}