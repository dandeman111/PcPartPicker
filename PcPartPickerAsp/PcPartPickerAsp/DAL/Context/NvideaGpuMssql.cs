using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PcPartPickerAsp.DAL.Interface;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Context
{
    public class NvideaGpuMssql: ConString, INvideaGpu
    {
        public void Add(NvideaGpu nvideaGpu)
        {
            throw new NotImplementedException();
        }

        public NvideaGpu GetById(int id)
        {
            using (SqlConnection con = new SqlConnection(Constring))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from gpu Join Nvidea on Nvidea.Gpu_id = Gpu.Gpu_id Where Gpu.Gpu_id = @GpuId", con))
                {

                    cmd.Parameters.AddWithValue("@GpuId", id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    return new NvideaGpu(Convert.ToString("Name"),
                        Convert.ToInt16(reader["GpuId"]),
                         Convert.ToInt16(reader["Clockspeed"]),
                         Convert.ToInt16(reader["Vram"]),
                         Convert.ToInt16(reader["Price"]),
                         Convert.ToInt16(reader["Sli"]),
                         Convert.ToBoolean(reader["gsync"]),
                         Convert.ToBoolean(reader["Physx"]));

                    
                }
            }
        }

        public List<NvideaGpu> GetAll()
        {
            List<NvideaGpu> nvideaGpus = new List<NvideaGpu>();
            using (SqlConnection con = new SqlConnection(Constring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from gpu Join Nvidea on Nvidea.Gpu_id = Gpu.Gpu_id", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    nvideaGpus.Add(new NvideaGpu(Convert.ToString("Name"),
                        Convert.ToInt16(reader["GpuId"]),
                         Convert.ToInt16(reader["Clockspeed"]),
                         Convert.ToInt16(reader["Vram"]),
                         Convert.ToInt16(reader["Price"]),
                         Convert.ToInt16(reader["Sli"]),
                         Convert.ToBoolean(reader["gsync"]),
                         Convert.ToBoolean(reader["Physx"])));
                }

            }
            return nvideaGpus;
        }

        public void Update(NvideaGpu nvideaGpu)
        {
            throw new NotImplementedException();
        }

        public void Delete(NvideaGpu nvideaGpu)
        {
            throw new NotImplementedException();
        }
    }
}