using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PcPartPickerAsp.DAL.Context
{
    public class ConString
    {
        public string Constring { get; private set; }

        public ConString()
        {
            Constring = "Data Source = DANNY - LAPTOP; Initial Catalog = DB_PcPartPicker; Integrated Security = True";
        }
    }
}