using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.ViewModels
{
    public class StorageViewModel
    {
        public Computer CurrentBuild { get; private set; }
        public List<Storage> AllStorages { get; private set; }

        public StorageViewModel(Computer currentBuild, List<Storage> allStorages)
        {
            CurrentBuild = currentBuild;
            AllStorages = new List<Storage>();
            AllStorages.AddRange(allStorages);
        }
    }
}