using System;

namespace HRLIB
{
    public class Employee
    {
        public string name;

        public string EName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string address;

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public Employee()
        {
            this.EName = "Darshan";
            this.Address = "Nagpur";
        }
        public Employee(string name, string add)
        {
            this.EName = name;
            this.Address = add;
        }
    }
}
