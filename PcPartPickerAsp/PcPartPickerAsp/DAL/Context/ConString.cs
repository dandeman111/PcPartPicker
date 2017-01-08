using System;

namespace PcPartPickerAsp.DAL.Context
{
    public class ConString
    {
        public ConString()
        {
            Constring = "Data Source=DANNY-LAPTOP;Initial Catalog=DB_PcPartPicker;Integrated Security=True";
        }

        public string Constring { get; private set; }

        protected static string GetString(object o)
        {
            if (o == DBNull.Value) return null;
            return (string) o;
        }

        protected static int? GetInt(object o)
        {
            if (o == DBNull.Value) return null;
            return (int?) o;
        }
    }
}