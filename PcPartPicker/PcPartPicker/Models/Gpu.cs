using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcPartPicker
{
    abstract class Gpu
    {
        //properties
        protected int Gpu_id { get; set; }
        protected int Clockspeed { get; set; }
        protected int Vram { get; set; }
        protected int Price { get; set; }

        //constructor
        protected Gpu(int gpu_id,int clockspeed,int vram,int price)
        {
            this.Gpu_id = gpu_id;
            this.Clockspeed = clockspeed;
            this.Vram = vram;
            this.Price = price;
        }
    }
}
