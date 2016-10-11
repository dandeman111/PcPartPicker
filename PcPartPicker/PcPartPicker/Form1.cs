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
using PcPartPicker.Cheat;

namespace PcPartPicker
{
    public partial class Form1 : Form
    {
        Allquerries aq;
        public Form1()
        {
            InitializeComponent();
            aq = new Allquerries();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = aq.querry1();
        }
    }
}
