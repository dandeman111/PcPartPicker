using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using PcPartPickerAsp.DAL.Interface;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Context
{
    public class NvideaGpuMssql : ConString, INvideaGpu
    {
        public void Add(NvideaGpu nvideaGpu)
        {
            throw new NotImplementedException();
        }

        public NvideaGpu GetById(int id)
        {
            using (var con = new SqlConnection(Constring))
            {
                con.Open();
                using (
                    var cmd =
                        new SqlCommand(
                            "Select * from gpu Join Nvidea on Nvidea.Gpu_id = Gpu.Gpu_id Where Gpu.Gpu_id = @GpuId", con)
                )
                {
                    cmd.Parameters.AddWithValue("@GpuId", id);

                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                        return new NvideaGpu(Convert.ToString(reader["Name"]),
                            Convert.ToInt16(reader["Gpu_id"]),
                            Convert.ToInt16(reader["Clockspeed"]),
                            Convert.ToInt16(reader["Vram"]),
                            Convert.ToInt16(reader["Price"]),
                            Convert.ToInt16(reader["Sli"]),
                            Convert.ToBoolean(reader["Gsync"]),
                            Convert.ToBoolean(reader["Physx"]));
                    return null;
                }
            }
        }

        public List<NvideaGpu> GetAll()
        {
            var nvideaGpus = new List<NvideaGpu>();
            using (var con = new SqlConnection(Constring))
            {
                con.Open();
                var cmd = new SqlCommand("Select * from gpu Join Nvidea on Nvidea.Gpu_id = Gpu.Gpu_id", con);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                    nvideaGpus.Add(new NvideaGpu(Convert.ToString("Name"),
                        Convert.ToInt16(reader["GpuId"]),
                        Convert.ToInt16(reader["Clockspeed"]),
                        Convert.ToInt16(reader["Vram"]),
                        Convert.ToInt16(reader["Price"]),
                        Convert.ToInt16(reader["Sli"]),
                        Convert.ToBoolean(reader["gsync"]),
                        Convert.ToBoolean(reader["Physx"])));
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