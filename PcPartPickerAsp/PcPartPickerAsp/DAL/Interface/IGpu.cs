using System.Collections.Generic;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Interface
{
    public interface IGpu
    {
        Gpu GetById(int id);
        List<Gpu> GetAll();
    }
}