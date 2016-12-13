using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcPartPicker;

namespace PcPartPickerAsp.DAL.Interface
{
    interface IMotherboard
    {
        void Add(Motherboard motherboard);
        Motherboard GetById(int id);
        List<Motherboard> GetAll();
        void Update(Motherboard motherboard);
        void Delete(Motherboard motherboard);
    }
}
