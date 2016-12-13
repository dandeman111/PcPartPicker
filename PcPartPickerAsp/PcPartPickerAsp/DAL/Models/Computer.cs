using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Models
{
    public class Computer
    {
        //properties
        public int ComputerId { get; set; }
        public Cpu Cpu { get; set; }
        public Motherboard Motherboard { get; set; }
        public Memory Memory { get; set; }
        public Storage Storage { get; set; }
        public List<Gpu> Gpus { get; set; }
        public List<User> Owner { get; set; }
        public int Price { get; set; }

        //constructor
        public Computer(int computerId)
        {
            this.ComputerId = computerId;
        }

    }
}
