using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcPartPicker.Interfaces
{
   public  interface ICpu
    {
        Cpu GetCpu(int id);
        void AddCpu(Cpu cpu);
        void DeleteCpu(Cpu cpu);
        void EditCpu(Cpu cpu);

    }
}
