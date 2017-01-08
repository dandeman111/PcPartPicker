namespace PcPartPickerAsp.DAL.Models
{
    public class Motherboard
    {
        //constructor
        public Motherboard(int motherboardId, string chipset, string socket, int price, string name)
        {
            MotherboardId = motherboardId;
            Chipset = chipset;
            Socket = socket;
            Price = price;
            Name = name;
        }

        //properties
        public int MotherboardId { get; set; }
        public string Chipset { get; set; }
        public string Socket { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
    }
}