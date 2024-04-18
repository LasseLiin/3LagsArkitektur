using DTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeDataAccess.Model
{
    internal class Employee
    {
        public Employee()
        {
        }

        public Employee(string name)
        {
            Name = name;
        }

        public Employee(int employeeId, string name)
        {
            EmployeeId = employeeId;
            Name = name;
        }

        public Employee(int employeeId, string name, int yearsEmployeed) : this(employeeId, name)
        {
            EmployeeId = employeeId;
            Name = name;
            YearsEmployeed = yearsEmployeed;
        }

        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int YearsEmployeed { get; set; }



    }
}
