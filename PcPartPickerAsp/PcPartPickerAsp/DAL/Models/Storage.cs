namespace PcPartPickerAsp.DAL.Models
{
    public class Storage
    {
        //constructor
        public Storage(int storageId, string speed, string interFace, int price, string name)
        {
            StorageId = storageId;
            Speed = speed;
            Interface = interFace;
            Price = price;
            Name = name;
        }

        //properties
        public int StorageId { get; set; }
        public string Speed { get; set; }
        public string Interface { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
    }
}