namespace PcPartPickerAsp.DAL.Models
{
    public class Motherboard
    {
        //properties
        public int MotherboardId { get; set; }
        public string Chipset { get; set; }
        public string Socket { get; set; }
        public int Price { get; set; }

        //constructor
        public Motherboard(int motherboardId,string chipset,string socket, int price)
        {
            MotherboardId = motherboardId;
            Chipset = chipset;
            Socket = socket;
            Price = price;
        }
    }
}
