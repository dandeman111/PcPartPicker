using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcPartPicker;

namespace PcPartPickerAsp.DAL.Interface
{
    interface IAmdGpu
    {
        void Add(AmdGpu amdGpu);
        AmdGpu GetById(int id);
        List<AmdGpu> GetAll();
        void Update(AmdGpu amdGpu);
        void Delete(AmdGpu amdGpu);
    }
}
