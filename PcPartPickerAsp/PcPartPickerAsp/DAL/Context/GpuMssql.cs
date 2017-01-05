using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PcPartPickerAsp.DAL.Interface;
using PcPartPickerAsp.DAL.Models;
using PcPartPickerAsp.DAL.Repository;

namespace PcPartPickerAsp.DAL.Context
{
    public class GpuMssql:ConString,IGpu
    {
        public Gpu GetById(int id)
        {
            bool amd = true;
            using (SqlConnection con = new SqlConnection(Constring))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("Select * from Gpu g left join Amd a on g.Gpu_id = a.Gpu_id left join Nvidea n on g.Gpu_id = n.Gpu_id where g.Gpu_id =@id", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader["Crossfire"] is DBNull) // als het geen crossfire heeft moet het een nvidea zijn
                        {
                            amd = false;
                        }
                    } 
                }
            }
            if (amd == false)
            {
                NvideaGpuRepo nr = new NvideaGpuRepo(new NvideaGpuMssql());
                return nr.GetById(id);
            }
            else
            {
                AmdGpuRepo ar = new AmdGpuRepo(new AmdGpuMssql());
                return ar.GetById(id);
            }
        }
    }
}