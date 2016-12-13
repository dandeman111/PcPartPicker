namespace PcPartPickerAsp.DAL.Models
{
    public class AmdGpu : Gpu
    {
        //properties
        public int Crossfire { get; private set; }

        //constructor
        public AmdGpu(int gpuId, int clockspeed, int vram, int price,string name, int crossfire) : base(gpuId, clockspeed, vram, price , name)
        {
            Crossfire = crossfire;
        }
    }
}
