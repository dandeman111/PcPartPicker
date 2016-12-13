using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.StorageId = storageId;
            this.Speed = speed;
            this.Interface = interFace;
            this.Price = price;
        }
    }
}
