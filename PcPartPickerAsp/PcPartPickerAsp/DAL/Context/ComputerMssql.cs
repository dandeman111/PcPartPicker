using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PcPartPickerAsp.DAL.Interface;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Context
{
    public class ComputerMssql : ConString, IComputer
    {
        public void Add(Computer computer)
        {
            throw new NotImplementedException();
#warning ik heb hiervoor een stored procedure aangemaakt
        }

        public void Delete(Computer computer)
        {
            throw new NotImplementedException();
        }

        public List<Computer> GetAll()
        {
            List<Computer> computers = new List<Computer>();
            using (SqlConnection con = new SqlConnection(Constring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Computer left join User_computer on Computer.Computer_id = User_computer.Computer_id left join Computer_gpu on Computer_gpu.Computer_id = Computer.Computer_id", con);
                SqlDataReader reader = cmd.ExecuteReader();
                List<int> pcs = new List<int>();
                while (reader.Read())
                {
                    pcs.Add(Convert.ToInt16(GetInt(reader["Computer_id"])));
#warning als een waard null is returned hij 0
                }
                foreach (int pc in pcs)
                {
                    computers.Add(GetById(pc));
                }
            }
            return computers;
        }

        public Computer GetById(int id)
        {
            if (id == 0)
            {
                return null;
            }
            using (SqlConnection con = new SqlConnection(Constring))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("Select * from Computer left join User_computer on Computer.Computer_id = User_computer.Computer_id left join Computer_gpu on Computer_gpu.Computer_id = Computer.Computer_id where Computer.Computer_id = @id", con))
                {

                    cmd.Parameters.AddWithValue("@id", id);
                    int pcid = 0;
                    int cpid = 0;
                    int mbid = 0;
                    int memid = 0;
                    int stid = 0;
                    List<string> owners = new List<string>();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        pcid = Convert.ToInt16(GetInt(reader["Computer_id"]));
                        cpid = Convert.ToInt16(GetInt(reader["Cpu_id"]));
                        mbid = Convert.ToInt16(GetInt(reader["Motherboard_id"]));
                        memid = Convert.ToInt16(GetInt(reader["Memory_id"]));
                        stid = Convert.ToInt16(GetInt(reader["Storage_id"]));
                        owners.Add(GetString(reader["Username"]));
                    }
                    
                    return new Computer(
                        pcid,
                        cpid,
                        mbid,
                        memid,
                        stid,
                        owners);


                }
            }
        }

        public void Update(Computer computer)
        {
            throw new NotImplementedException();
        }
    }
}