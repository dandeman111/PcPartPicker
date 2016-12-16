namespace PcPartPickerAsp.DAL.Models
{
    public abstract class Gpu
    {
        //properties
        public int GpuId { get; set; }
        public int Clockspeed { get; set; }
        public int Vram { get; set; }
        public int Price { get; set; }
        public string Name { get; private set; }

        //constructor
        protected Gpu(string name, int gpuId, int clockspeed, int vram, int price)
        {
            GpuId = gpuId;
            Clockspeed = clockspeed;
            Vram = vram;
            Price = price;
            Name = name;
        }
    }
}
