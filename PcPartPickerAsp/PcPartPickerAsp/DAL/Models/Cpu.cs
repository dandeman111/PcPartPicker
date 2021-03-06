﻿namespace PcPartPickerAsp.DAL.Models
{
    public enum Socket //enum voor het socket type van de cpu, is public want het moederboord moet hem ook bij kunnen
    {
        Lga1151,
        Am3
    }

    public class Cpu
    {
        //constructor
        public Cpu(int cpuId, int clockspeed, int cores, string brand, int price, string socket, string name)
        {
            CpuId = cpuId;
            Clockspeed = clockspeed;
            Cores = cores;
            Brand = brand;
            Price = price;
            Socket = socket;
            Name = name;
        }

        public Cpu(int clockspeed, int cores, string brand, int price, string socket, string name)
        {
            Clockspeed = clockspeed;
            Cores = cores;
            Brand = brand;
            Price = price;
            Socket = socket;
            Name = name;
        }

        //properties
        public int CpuId { get; set; }
        public int Clockspeed { get; set; }
        public int Cores { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }
        public string Socket { get; set; }
        public string Name { get; internal set; }
    }
}