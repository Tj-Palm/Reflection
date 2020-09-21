using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public class Manager : Person
    {
        private List<Person> _employees;

        public List<Person> Employees
        {
            get { return _employees; }
            set { _employees = value; }
        }

        public Manager()
        {
            _employees
        }
        
    }
}
