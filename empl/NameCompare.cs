﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empl
{
    class NameCompare : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return (x.Name.CompareTo(y.Name));
            //throw new NotImplementedException();
        }
    }
}
