using System.Collections.Generic;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Interface
{
    public interface INvideaGpu
    {
        void Add(NvideaGpu nvideaGpu);
        NvideaGpu GetById(int id);
        List<NvideaGpu> GetAll();
        void Update(NvideaGpu nvideaGpu);
        void Delete(NvideaGpu nvideaGpu);
    }
}