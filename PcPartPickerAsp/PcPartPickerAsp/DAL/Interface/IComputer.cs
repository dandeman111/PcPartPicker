using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Interface
{
    interface IComputer
    {
        void Add(Computer computer);
        Computer GetById(int id);
        List<Computer> GetAll();
        void Update(Computer computer);
        void Delete(Computer computer);
    }
}
