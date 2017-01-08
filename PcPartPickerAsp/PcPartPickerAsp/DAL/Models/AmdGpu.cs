namespace PcPartPickerAsp.DAL.Models
{
    public class AmdGpu : Gpu
    {
        //constructor
        public AmdGpu(int gpuId, int clockspeed, int vram, int price, string name, int crossfire)
            : base(name, gpuId, clockspeed, vram, price)
        {
            Crossfire = crossfire;
        }

        //properties
        public int Crossfire { get; private set; }
    }
}