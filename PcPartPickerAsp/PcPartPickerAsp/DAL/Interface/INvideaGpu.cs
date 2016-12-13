using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcPartPicker;

namespace PcPartPickerAsp.DAL.Interface
{
    interface INvideaGpu
    {
        void Add(NvideaGpu nvideaGpu);
        NvideaGpu GetById(int id);
        List<NvideaGpu> GetAll();
        void Update(NvideaGpu nvideaGpu);
        void Delete(NvideaGpu nvideaGpu);
    }
}
