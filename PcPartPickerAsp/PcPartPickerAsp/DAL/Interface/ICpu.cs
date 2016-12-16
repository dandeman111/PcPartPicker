using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Interface
{
   public interface ICpu
    {
        void Add( Cpu cpu);
        Cpu GetById(int id);
        List<Cpu> GetAll();
        void Update(Cpu cpu);
        void Delete(Cpu cpu);
    }
}
