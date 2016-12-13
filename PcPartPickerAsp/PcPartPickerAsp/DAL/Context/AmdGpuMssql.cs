﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PcPartPickerAsp.DAL.Interface;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Context
{
    public class AmdGpuMssql:ConString, IAmdGpu 
    {
        public void Add(AmdGpu amdGpu)
        {
            using (SqlConnection con = new SqlConnection(Constring))
            {
                using (SqlCommand cmd = new SqlCommand("AddAmdGpu", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Clockspeed", SqlDbType.Int).Value =amdGpu.Clockspeed ;
                    cmd.Parameters.Add("@Vram", SqlDbType.Int).Value = amdGpu.Vram;
                    cmd.Parameters.Add("@Price", SqlDbType.Int).Value = amdGpu.Price;
                    cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = amdGpu.Name;
                    cmd.Parameters.Add("@Crossfire", SqlDbType.Int).Value = amdGpu.Crossfire;

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

        }

        public AmdGpu GetById(int id)
        {
            using (SqlConnection con = new SqlConnection(Constring))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from gpu Join Amd on Amd.Gpu_id = Gpu.Gpu_id Where Gpu.Gpu_id = @GpuId", con))
                {
                    
                    cmd.Parameters.AddWithValue("@GpuId", id);

                    SqlDataReader reader = cmd.ExecuteReader();

                   return new AmdGpu(Convert.ToInt16(reader["GpuId"]),
                        Convert.ToInt16(reader["Clockspeed"]),
                        Convert.ToInt16(reader["Vram"]),
                        Convert.ToInt16(reader["Price"]),
                        Convert.ToString(reader["Name"]),
                        Convert.ToInt16(reader["Crossfire"]));


                }
            }
        }

        public List<AmdGpu> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(AmdGpu amdGpu)
        {
            throw new NotImplementedException();
        }

        public void Delete(AmdGpu amdGpu)
        {
            throw new NotImplementedException();
        }
    }
}