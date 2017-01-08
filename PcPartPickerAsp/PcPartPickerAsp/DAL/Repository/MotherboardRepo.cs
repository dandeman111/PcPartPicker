using System;
using System.Collections.Generic;
using PcPartPickerAsp.DAL.Interface;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Repository
{
    public class MotherboardRepo
    {
        public MotherboardRepo(IMotherboard motherboardContext)
        {
            Context = motherboardContext;
        }

        public IMotherboard Context { get; }

        public void Add(Motherboard motherboard)
        {
            throw new NotImplementedException();
        }

        public Motherboard GetById(int id)
        {
            return Context.GetById(id);
        }

        public List<Motherboard> GetAll()
        {
            return Context.GetAll();
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