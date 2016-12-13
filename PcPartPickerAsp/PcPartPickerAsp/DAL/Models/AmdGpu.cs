using PcPartPicker;

namespace PcPartPickerAsp.DAL.Models
{
    public class AmdGpu : Gpu
    {
        //properties
        public int Crossfire { get; private set; }

        //constructor
        public AmdGpu(int gpu_id, int clockspeed, int vram, int price, int crossfire) : base(gpu_id, clockspeed, vram, price)
        {
            this.Crossfire = crossfire;
        }
    }
}
