namespace PcPartPickerAsp.DAL.Models
{
    public class NvideaGpu : Gpu
    {
        //constructor
        public NvideaGpu(string name, int gpuId, int clockspeed, int vram, int price, int sli, bool gsync, bool physx)
            : base(name, gpuId, clockspeed, vram, price)
        {
            Sli = sli;
            Gsync = gsync;
            Physx = physx;
        }

        //properties
        public int Sli { get; set; }
        public bool Gsync { get; set; }
        public bool Physx { get; set; }
    }
}