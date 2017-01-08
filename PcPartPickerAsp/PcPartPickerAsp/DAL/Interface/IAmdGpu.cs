using System.Collections.Generic;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Interface
{
    public interface IAmdGpu
    {
        void Add(AmdGpu amdGpu);
        AmdGpu GetById(int id);
        List<AmdGpu> GetAll();
        void Update(AmdGpu amdGpu);
        void Delete(AmdGpu amdGpu);
    }
}