namespace PcPartPickerAsp.DAL.Models
{
    public abstract class Gpu
    {
        //properties
        protected int GpuId { get; set; }
        protected int Clockspeed { get; set; }
        protected int Vram { get; set; }
        protected int Price { get; set; }

        //constructor
        protected Gpu(int gpuId,int clockspeed,int vram,int price)
        {
            GpuId = gpuId;
            Clockspeed = clockspeed;
            Vram = vram;
            Price = price;
        }
    }
}
