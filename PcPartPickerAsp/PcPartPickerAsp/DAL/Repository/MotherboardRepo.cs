using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PcPartPickerAsp.DAL.Interface;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Repository
{
    public class MotherboardRepo
    {
        public IMotherboard Context { get; private set; }
        public void Add(Motherboard motherboard)
        {
            throw new NotImplementedException();
        }

        public Motherboard GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Motherboard> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Motherboard motherboard)
        {
            throw new NotImplementedException();
        }

        public void Delete(Motherboard motherboard)
        {
            throw new NotImplementedException();
        }
    }
}