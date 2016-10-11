using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcPartPicker
{
    class AmdGpu : Gpu
    {
        //properties
        public int Crossfire { get; set; }

        //constructor
        public AmdGpu(int gpu_id, int clockspeed, int vram, int price, int crossfire) : base(gpu_id, clockspeed, vram, price)
        {
            this.Crossfire = crossfire;
        }
    }
}
