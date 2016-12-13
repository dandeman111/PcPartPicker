using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcPartPickerAsp.DAL.Models
{
    public class Motherboard
    {
        //properties
        public int MotherboardId { get; set; }
        public string Chipset { get; set; }
        public Socket Socket { get; set; }
        public int Price { get; set; }

        //constructor
        public Motherboard(int motherboardId,string chipset,Socket socket, int price)
        {
            this.MotherboardId = motherboardId;
            this.Chipset = chipset;
            this.Socket = socket;
            this.Price = price;
        }
    }
}
