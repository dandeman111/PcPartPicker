using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PcPartPickerAsp.DAL.Interface;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Context
{
    public class ComputerMssql : ConString, IComputer
    {
        public void Add(Computer computer, string username)
        {
            using (var conn = new SqlConnection(Constring))
            {
                using (var command = new SqlCommand("AddComputerTest", conn)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    using (var table = new DataTable())
                    {
                        //table.Columns.Add("Gpu_id", typeof(int));
                        //table.Columns.Add("Amount", typeof(int));

                        //foreach (Gpu gp in computer.Gpus)
                        //{
                        //    table.Rows.Add(gp.GpuId, 1);
                        //}

                        //var pList = new SqlParameter("@gpus", SqlDbType.Structured);
                        //pList.TypeName = "dbo.gpus";
                        //pList.Value = table;

                        //command.Parameters.AddWithValue("@Gpus", pList);
                        command.Parameters.AddWithValue("@Cpu_id", computer.Cpu.CpuId);
                        command.Parameters.AddWithValue("@Motherboard_id", computer.Motherboard.MotherboardId);
                        command.Parameters.AddWithValue("@Memory_id", computer.Memory.MemoryId);
                        command.Parameters.AddWithValue("@Storage_id", computer.Storage.StorageId);
                        command.Parameters.AddWithValue("@Username", username);

                        conn.Open();
                        command.ExecuteNonQuery();
                    }
#warning ik heb hiervoor een stored procedure aangemaakt
                }
            }
        }

        public void Delete(Computer computer)
        {
            throw new NotImplementedException();
        }

        public List<Computer> GetAll()
        {
            var computers = new List<Computer>();
            var pcs = new List<int>();
            using (var con = new SqlConnection(Constring))
            {
                con.Open();
                var cmd =
                    new SqlCommand(
                        "Select * from Computer left join User_computer on Computer.Computer_id = User_computer.Computer_id left join Computer_gpu on Computer_gpu.Computer_id = Computer.Computer_id",
                        con);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    pcs.Add(Convert.ToInt16(GetInt(reader["Computer_id"])));
#warning als een waard null is returned hij 0
                }
            }
            foreach (var pc in pcs)
                computers.Add(GetById(pc));
            return computers;
        }

        public Computer GetById(int id)
        {
            if (id == 0)
                return null;
            using (var con = new SqlConnection(Constring))
            {
                con.Open();
                using (
                    var cmd =
                        new SqlCommand(
                            "Select * from Computer left join User_computer on Computer.Computer_id = User_computer.Computer_id left join Computer_gpu on Computer_gpu.Computer_id = Computer.Computer_id where Computer.Computer_id = @id",
                            con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    var pcid = 0;
                    var cpid = 0;
                    var mbid = 0;
                    var memid = 0;
                    var stid = 0;
                    var gpus = new List<int>();

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        pcid = Convert.ToInt16(GetInt(reader["Computer_id"]));
                        cpid = Convert.ToInt16(GetInt(reader["Cpu_id"]));
                        mbid = Convert.ToInt16(GetInt(reader["Motherboard_id"]));
                        memid = Convert.ToInt16(GetInt(reader["Memory_id"]));
                        stid = Convert.ToInt16(GetInt(reader["Storage_id"]));
                        gpus.Add(Convert.ToInt16(GetInt(reader["Gpu_id"])));
                    }

                    return new Computer(
                        pcid,
                        cpid,
                        mbid,
                        memid,
                        stid,
                        gpus);
                }
            }
        }

        public void Update(Computer computer)
        {
            using (var con = new SqlConnection(Constring))
            {
                con.Open();
                using (
                    var cmd =
                        new SqlCommand(
                            "Update Computer set Cpu_id = @cpuid,Motherboard_id = @motherboardId, Memory_id = @memoryid, Storage_id = @storageid, Price = @price where Computer_id = @computerid",
                            con))
                {
                    cmd.Parameters.AddWithValue("@computerid", computer.ComputerId);
                    cmd.Parameters.AddWithValue("@motherboardId", Convert.ToInt16(computer.Motherboard.MotherboardId));
                    cmd.Parameters.AddWithValue("@memoryid", Convert.ToInt16(computer.Memory.MemoryId));
                    cmd.Parameters.AddWithValue("@storageid", Convert.ToInt16(computer.Storage.StorageId));
                    cmd.Parameters.AddWithValue("@Price", Convert.ToInt32(computer.Price));
                    cmd.Parameters.AddWithValue("@cpuid", computer.Cpu.CpuId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}