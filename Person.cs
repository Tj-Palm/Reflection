using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public abstract class Person
    {
        private string _name;
        private int _birthOfYear;
        private int _currentYear = 2020;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int BirthOfYear
        {
            get { return _birthOfYear; }
            set { _birthOfYear = value; }
        }

        public int Age
        {
            get { return _currentYear - BirthOfYear; }
        }

        protected Person(string name, int birthOfYear)
        {
            _name = name;
            _birthOfYear = birthOfYear;
        }

        protected Person()
        {
        }
        
    }
}
