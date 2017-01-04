using System.Dynamic;

namespace PcPartPickerAsp.DAL.Models
{
    public class Motherboard
    {
        //properties
        public int MotherboardId { get; set; }
        public string Chipset { get; set; }
        public string Socket { get; set; }
        public int Price { get; set; }
        public  string Name { get; set; }
        //constructor
        public Motherboard(int motherboardId,string chipset,string socket, int price, string name)
        {
            MotherboardId = motherboardId;
            Chipset = chipset;
            Socket = socket;
            Price = price;
            Name = name;
        }
    }
}
