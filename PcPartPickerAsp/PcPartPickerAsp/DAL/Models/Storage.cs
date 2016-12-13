namespace PcPartPickerAsp.DAL.Models
{
    public class Storage
    {
        //properties
        public int StorageId { get; set; }
        public int Speed { get; set; }
        public string Interface { get; set; }
        public int Price { get; set; }

        //constructor
        public Storage(int storageId,int speed,string interFace,int price)
        {
            StorageId = storageId;
            Speed = speed;
            Interface = interFace;
            Price = price;
        }
    }
}
