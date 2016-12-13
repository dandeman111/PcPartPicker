using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcPartPicker
{
    public class Storage
    {
        //properties
        public int Storage_id { get; set; }
        public int Speed { get; set; }
        public string Interface { get; set; }
        public int Price { get; set; }

        //constructor
        public Storage(int storage_id,int speed,string interFace,int price)
        {
            this.Storage_id = storage_id;
            this.Speed = speed;
            this.Interface = interFace;
            this.Price = price;
        }
    }
}
