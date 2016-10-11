using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcPartPicker
{
    class Motherboard
    {
        //properties
        public int Motherboard_id { get; set; }
        public string Chipset { get; set; }
        public Socket Socket { get; set; }
        public int Price { get; set; }

        //constructor
        public Motherboard(int motherboard_id,string chipset,Socket socket, int price)
        {
            this.Motherboard_id = motherboard_id;
            this.Chipset = chipset;
            this.Socket = socket;
            this.Price = price;
        }
    }
}
