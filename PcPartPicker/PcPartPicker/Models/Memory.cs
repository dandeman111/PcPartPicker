using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcPartPicker
{
    class Memory
    {
        //properties
        public int Memory_id { get; set; }
        public int Clockspeed { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }

        //constructor
        public Memory(int memory_id,int clockspeed, string type,int price)
        {
            this.Memory_id = memory_id;
            this.Clockspeed = clockspeed;
            this.Type = type;
            this.Price = price;
        }
    }
}
