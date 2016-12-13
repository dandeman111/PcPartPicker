namespace PcPartPickerAsp.DAL.Models
{
    public class NvideaGpu : Gpu
    {
        //properties
        public int Sli { get; set; }
        public bool Gsync { get; set; }
        public  bool Physx { get; set; }

        //constructor
        public NvideaGpu(int gpuId, int clockspeed, int vram, int price,int sli,bool gsync,bool physx) : base(gpuId, clockspeed, vram, price)
        {
            Sli = sli;
            Gsync = gsync;
            Physx = physx;
        }
    }
}
