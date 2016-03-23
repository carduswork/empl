using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empl
{
    class Employee
    {
        string num, name, age, salary;

        public string Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Num
        {
            get { return num; }
            set { num = value; }
        }
        public Employee(string num,string name,string age,string salary)
        {
            this.num = num;
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        

       
    }
}
