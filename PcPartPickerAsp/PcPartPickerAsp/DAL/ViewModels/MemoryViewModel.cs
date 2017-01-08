using System.Collections.Generic;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.ViewModels
{
    public class MemoryViewModel
    {
        public MemoryViewModel(Computer currentBuild, List<Memory> allMemories)
        {
            CurrentBuild = currentBuild;
            AllMemories = new List<Memory>();
            AllMemories.AddRange(allMemories);
        }

        public Computer CurrentBuild { get; private set; }
        public List<Memory> AllMemories { get; }
    }
}