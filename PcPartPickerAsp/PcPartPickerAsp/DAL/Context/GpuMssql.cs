﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using PcPartPickerAsp.DAL.Interface;
using PcPartPickerAsp.DAL.Models;
using PcPartPickerAsp.DAL.Repository;

namespace PcPartPickerAsp.DAL.Context
{
    public class GpuMssql : ConString, IGpu
    {
        public Gpu GetById(int id)
        {
            var amd = true;
            using (var con = new SqlConnection(Constring))
            {
                con.Open();
                using (
                    var cmd =
                        new SqlCommand(
                            "Select * from Gpu g left join Amd a on g.Gpu_id = a.Gpu_id left join Nvidea n on g.Gpu_id = n.Gpu_id where g.Gpu_id =@id",
                            con))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                        if (reader["Crossfire"] is DBNull) // als het geen crossfire heeft moet het een nvidea zijn
                            amd = false;
                }
            }
            if (amd == false)
            {
                var nr = new NvideaGpuRepo(new NvideaGpuMssql());
                return nr.GetById(id);
            }
            var ar = new AmdGpuRepo(new AmdGpuMssql());
            return ar.GetById(id);
        }

        public List<Gpu> GetAll()
        {
            var gpus = new List<Gpu>();
            using (var con = new SqlConnection(Constring))
            {
                con.Open();
                var cmd =
                    new SqlCommand(
                        "Select * from Gpu g left join Amd a on g.Gpu_id = a.Gpu_id left join Nvidea n on g.Gpu_id = n.Gpu_id ",
                        con);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                    if (reader["Crossfire"] is DBNull) // als het geen crossfire heeft moet het een nvidea zijn
                        gpus.Add(new NvideaGpu(Convert.ToString(reader["Name"]),
                            Convert.ToInt16(reader["Gpu_id"]),
                            Convert.ToInt16(reader["Clockspeed"]),
                            Convert.ToInt16(reader["Vram"]),
                            Convert.ToInt16(reader["Price"]),
                            Convert.ToInt16(reader["Sli"]),
                            Convert.ToBoolean(reader["Gsync"]),
                            Convert.ToBoolean(reader["PhysX"])));
                    else
                        gpus.Add(new AmdGpu(Convert.ToInt16(reader["Gpu_id"]),
                            Convert.ToInt16(reader["Clockspeed"]),
                            Convert.ToInt16(reader["Vram"]),
                            Convert.ToInt16(reader["Price"]),
                            Convert.ToString(reader["Name"]),
                            Convert.ToInt16(reader["Crossfire"])));
            }
            return gpus;
        }
    }
}