using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PcPartPicker.MSSQLContext;

namespace PcPartPicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void test_Click(object sender, EventArgs e)
        {
            Cpu testcpu = new Cpu(1200,1,"inteltest",1200,Socket.LGA1151,"testcpu");
            MSSQL_Cpu test = new MSSQL_Cpu();

            test.AddCpu(testcpu);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cpu testcpu = new Cpu(7,1200, 1, "inteltest", 1200, Socket.LGA1151, "testcpu");
            MSSQL_Cpu test = new MSSQL_Cpu();

            test.DeleteCpu(testcpu);
        }
    }
}
