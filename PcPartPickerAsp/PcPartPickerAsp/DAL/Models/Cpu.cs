using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcPartPicker
{
    public enum Socket //enum voor het socket type van de cpu, is public want het moederboord moet hem ook bij kunnen
    {
         LGA1151,AM3

    };
   public  class Cpu
    {
        //properties
        public int Cpu_id { get; set; }
        public int Clockspeed { get; set; }
        public int Cores { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }
        public Socket Socket { get; set;}
        public string Name { get; internal set; }

        //constructor
        public Cpu(int cpu_id,int clockspeed,int cores,string brand,int price,Socket socket, string name)
        {
            this.Cpu_id = cpu_id;
            this.Clockspeed = clockspeed;
            this.Cores = cores;
            this.Brand = brand;
            this.Price = price;
            this.Socket = socket;
            this.Name = name;
        }
        public Cpu( int clockspeed, int cores, string brand, int price, Socket socket, string name)
        {
            this.Clockspeed = clockspeed;
            this.Cores = cores;
            this.Brand = brand;
            this.Price = price;
            this.Socket = socket;
            this.Name = name;
        }

    }
}
