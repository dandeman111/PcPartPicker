using System.Collections.Generic;
using PcPartPickerAsp.DAL.Context;
using PcPartPickerAsp.DAL.Repository;

namespace PcPartPickerAsp.DAL.Models
{
    public class Computer
    {
        //properties
        public int ComputerId { get; set; }
        public Cpu Cpu { get; set; }
        public Motherboard Motherboard { get; set; }
        public Memory Memory { get; set; }
        public Storage Storage { get; set; }
        public List<Gpu> Gpus { get; set; }
        public List<User> Owner { get; set; }
        public int Price { get; set; }

        private CpuRepo cpuRepo= new CpuRepo();

        //constructor
        public Computer(int computerId, int cpuId, int motherboardId, int memoryId, int storageId,List<Gpu> gpus, List<User> owners  )
        {
            ComputerId = computerId;
            Cpu = 
        }

    }
}
