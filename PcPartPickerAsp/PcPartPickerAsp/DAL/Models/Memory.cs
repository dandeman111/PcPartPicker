using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcPartPickerAsp.DAL.Models
{
    public class Memory
    {
        //properties
        public int MemoryId { get; set; }
        public int Clockspeed { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }

        //constructor
        public Memory(int memoryId,int clockspeed, string type,int price)
        {
            this.MemoryId = memoryId;
            this.Clockspeed = clockspeed;
            this.Type = type;
            this.Price = price;
        }
    }
}
