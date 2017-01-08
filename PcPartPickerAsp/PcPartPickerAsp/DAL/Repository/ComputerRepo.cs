using System;
using System.Collections.Generic;
using PcPartPickerAsp.DAL.Interface;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Repository
{
    public class ComputerRepo
    {
        public ComputerRepo(IComputer computerContext)
        {
            Context = computerContext;
        }

        public IComputer Context { get; }

        public void Add(Computer computer, string username)
        {
            Context.Add(computer, username);
        }

        public Computer GetById(int id)
        {
            return Context.GetById(id);
        }

        public List<Computer> GetAll()
        {
            return Context.GetAll();
        }

        public void Update(Computer computer)
        {
            Context.Update(computer);
        }

        public void Delete(Computer computer)
        {
            throw new NotImplementedException();
        }
    }
}