using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcPartPicker
{
    public class NvideaGpu : Gpu
    {
        //properties
        public int Sli { get; set; }
        public bool Gsync { get; set; }
        public  bool Physx { get; set; }

        //constructor
        public NvideaGpu(int gpu_id, int clockspeed, int vram, int price,int sli,bool gsync,bool physx) : base(gpu_id, clockspeed, vram, price)
        {
            this.Sli = sli;
            this.Gsync = gsync;
            this.Physx = physx;
        }
    }
}
