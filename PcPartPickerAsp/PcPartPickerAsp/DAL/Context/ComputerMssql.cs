using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PcPartPickerAsp.DAL.Interface;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Context
{
    public class ComputerMssql : ConString, IComputer
    {
        public void Add(Computer computer)
        {
            
        }

        public void Delete(Computer computer)
        {
            throw new NotImplementedException();
        }

        public List<Computer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Computer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Computer computer)
        {
            throw new NotImplementedException();
        }
    }
}