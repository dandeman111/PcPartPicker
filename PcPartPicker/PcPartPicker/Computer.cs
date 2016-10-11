using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcPartPicker
{
    class Computer
    {
        //properties
        public int Computer_id { get; set; }
        public Cpu Cpu { get; set; }
        public Motherboard Motherboard { get; set; }
        public Memory Memory { get; set; }
        public Storage Storage { get; set; }
        public List<Gpu> Gpus { get; set; }
        public List<User> Owner { get; set; }
        public int Price { get; set; }

        //constructor
        public Computer(int computer_id)
        {
            this.Computer_id = computer_id;
        }

    }
}
