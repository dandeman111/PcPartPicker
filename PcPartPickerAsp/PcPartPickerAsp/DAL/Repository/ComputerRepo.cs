using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PcPartPickerAsp.DAL.Interface;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Repository
{
    public class ComputerRepo
    {

        public IComputer Context { get; private set; }

        public ComputerRepo(IComputer computerContext)
        {
            Context = computerContext;
        }
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