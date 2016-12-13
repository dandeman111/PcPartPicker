using PcPartPicker;

namespace PcPartPickerAsp.DAL.Models
{
    public class AmdGpu : Gpu
    {
        //properties
        public int Crossfire { get; private set; }

        //constructor
        public AmdGpu(int gpuId, int clockspeed, int vram, int price, int crossfire) : base(gpuId, clockspeed, vram, price)
        {
            this.Crossfire = crossfire;
        }
    }
}
