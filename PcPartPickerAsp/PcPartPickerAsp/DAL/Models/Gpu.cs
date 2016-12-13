using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.GpuId = gpuId;
            this.Clockspeed = clockspeed;
            this.Vram = vram;
            this.Price = price;
        }
    }
}
