using System.Web.Mvc.Html;

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
        protected Gpu(int gpuId,int clockspeed,int vram,int price ,string name)
        {
            GpuId = gpuId;
            Clockspeed = clockspeed;
            Vram = vram;
            Price = price;
            Name = name;
        }
    }
}
