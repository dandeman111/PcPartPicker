using System.Collections.Generic;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Interface
{
    public interface IMotherboard
    {
        void Add(Motherboard motherboard);
        Motherboard GetById(int id);
        List<Motherboard> GetAll();
        void Update(Motherboard motherboard);
        void Delete(Motherboard motherboard);
    }
}