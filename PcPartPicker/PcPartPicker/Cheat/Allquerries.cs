using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcPartPicker.MSSQLContext;
using System.Data.SqlClient;
using System.Data;

namespace PcPartPicker.Cheat
{
   public  class Allquerries:MSSQL_Database
    {
        public DataTable  querry1 ()
        {
            DataTable dt = new DataTable();
            string commandString = @"USE [DB_PcPartPicker] Select u.username,c.Name
                                        from[User] u
                                        left join User_computer uc
                                        on uc.Username = u.Username
                                        left join Computer c
                                        on c.Computer_id = uc.Computer_id";

            using (SqlCommand command = new SqlCommand(commandString, SqlCon))
            {
                using(SqlDataAdapter a = new SqlDataAdapter(commandString, SqlCon))
                {
                    a.Fill(dt);
                }
            }
            return (dt);

        }
        public DataTable querry2()
        {
            DataTable dt = new DataTable();
            string commandString = @"Select m.Name motherboard, c.Name cpu, me.Name memory
                                        From Motherboard m
                                        join Cpu c
                                        on c.Socket = m.Socket
                                        join Memory me
                                        on me.Type = m.MemoryType";

            using (SqlCommand command = new SqlCommand(commandString, SqlCon))
            {
                using (SqlDataAdapter a = new SqlDataAdapter(commandString, SqlCon))
                {
                    a.Fill(dt);
                }
            }
            return (dt);

        }
        public DataTable querry3()
        {
            DataTable dt = new DataTable();
            string commandString = @"Select *
                                    from Cpu c
                                    where c.Price >(Select AVG(Price)
				                                    From cpu c)";

            using (SqlCommand command = new SqlCommand(commandString, SqlCon))
            {
                using (SqlDataAdapter a = new SqlDataAdapter(commandString, SqlCon))
                {
                    a.Fill(dt);
                }
            }
            return (dt);

        }
        public DataTable querry4()
        {
            DataTable dt = new DataTable();
            string commandString = @"Select u.username,c.Name computername, cp.Name cpuname , gp.Name gpuname, st.Name storagenaam, me.Name memoryname
                                    from [User] u
                                    join User_computer uc
                                    on uc.Username = u.Username
                                    left join Computer c
                                    on c.Computer_id = uc.Computer_id
                                    join Cpu cp
                                    on c.Cpu_id =cp.Cpu_id
                                    join Computer_gpu cg
                                    on cg.Computer_id = c.Computer_id
                                    join gpu gp
                                    on cg.Gpu_id = gp.Gpu_id
                                    join Storage st
                                    on c.Storage_id = st.Storage_id
                                    Join Memory me
                                    on me.Memory_id = c.Memory_id	";

            using (SqlCommand command = new SqlCommand(commandString, SqlCon))
            {
                using (SqlDataAdapter a = new SqlDataAdapter(commandString, SqlCon))
                {
                    a.Fill(dt);
                }
            }
            return (dt);

        }
        public DataTable querry5()
        {
            DataTable dt = new DataTable();
            string commandString = @"Select*
                                    from gpu
                                    Where Clockspeed>(Select Max(Clockspeed)/2
                                    from gpu)";

            using (SqlCommand command = new SqlCommand(commandString, SqlCon))
            {
                using (SqlDataAdapter a = new SqlDataAdapter(commandString, SqlCon))
                {
                    a.Fill(dt);
                }
            }
            return (dt);

        }
        public DataTable querry6()
        {
            DataTable dt = new DataTable();
            string commandString = @"Select cpu.Name
                                    From Cpu
                                    where Cpu.Cpu_id in (select Cpu_id
					                                    from Computer
					                                    join Computer_gpu cg
					                                    on cg.Computer_id = Computer.Computer_id)";

            using (SqlCommand command = new SqlCommand(commandString, SqlCon))
            {
                using (SqlDataAdapter a = new SqlDataAdapter(commandString, SqlCon))
                {
                    a.Fill(dt);
                }
            }
            return (dt);

        }
    }
}
