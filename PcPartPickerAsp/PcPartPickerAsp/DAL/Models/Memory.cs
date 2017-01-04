namespace PcPartPickerAsp.DAL.Models
{
    public class Memory
    {
        //properties
        public int MemoryId { get; set; }
        public int Clockspeed { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }

        public string Name { get; set; }

        //constructor
        public Memory(int memoryId,int clockspeed, string type,int price, string name)
        {
            MemoryId = memoryId;
            Clockspeed = clockspeed;
            Type = type;
            Price = price;
            Name = name;
        }
    }
}
