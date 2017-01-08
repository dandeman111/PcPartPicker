using System;
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
        public int Price { get; set; }

        private CpuRepo cpuRepo= new CpuRepo(new CpuMssql());
        private MotherboardRepo motherboardRepo = new MotherboardRepo(new MotherboardMssql());
        private MemoryRepo memoryRepo = new MemoryRepo(new MemoryMssql());
        private StorageRepo storageRepo = new StorageRepo(new StorageMssql());
        private GpuRepo gpuRepo = new GpuRepo(new GpuMssql());
#warning nog geen gpu's gefixt
        //constructor
        public Computer(int computerId, int cpuId, int motherboardId, int memoryId, int storageId,List<int> gpus )
        {
            Gpus = new List<Gpu>();
            ComputerId = computerId;
            Cpu = cpuRepo.GetById(Convert.ToInt16(cpuId));
            Motherboard = motherboardRepo.GetById(motherboardId);
            Memory = memoryRepo.GetById(memoryId);
            Storage = storageRepo.GetById(storageId);

            foreach (int gpu in gpus)
            {
                if (gpuRepo.GetById(gpu) != null)
                {
                    Gpus.Add(gpuRepo.GetById(gpu));
                }  
            }
        }

        public Computer()
        {
            Gpus = new List<Gpu>();

        }

    }
}
