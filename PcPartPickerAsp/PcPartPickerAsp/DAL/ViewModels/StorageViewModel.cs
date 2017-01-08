using System.Collections.Generic;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.ViewModels
{
    public class StorageViewModel
    {
        public StorageViewModel(Computer currentBuild, List<Storage> allStorages)
        {
            CurrentBuild = currentBuild;
            AllStorages = new List<Storage>();
            AllStorages.AddRange(allStorages);
        }

        public Computer CurrentBuild { get; private set; }
        public List<Storage> AllStorages { get; }
    }
}