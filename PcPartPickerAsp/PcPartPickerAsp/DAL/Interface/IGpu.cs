using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Interface
{
    public interface IGpu
    {
        Gpu GetById(int id);

    }
}
