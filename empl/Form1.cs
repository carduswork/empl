using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace empl
{
    public partial class Form1 : Form
    {
        static List<Employee> es=new List<Employee>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void reload()
        {
            StreamReader sr = new StreamReader("Employees.txt");
            int count=0;
                while (!sr.EndOfStream)
                {
                    count++;
                    //sr.ReadLine();
                    string res = sr.ReadLine().ToString();
                    string[] buffer = res.Split(',');
                    es.Add(new Employee(buffer[0], buffer[1], buffer[2],buffer[3]));
                    
                }
                dataGridView1.DataSource = es;
                sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            es.Sort(new NameCompare());
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = es;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //List<Employee> es2 = new List<Employee>();
            es.Sort(new SalaryCompare());
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = es;
        }
    }
}
