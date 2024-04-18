using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class Employee
    {
        public Employee(int employeeId, string name, int YearsEmployeed)
        {
            EmployeeId = employeeId;
            Name = name;
            YearsEmployed = YearsEmployeed;
        }

        public int EmployeeId { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(0, 50)]
        public int YearsEmployed { get; set; }

        public override string ToString()
        {
            return EmployeeId + " " + Name + " " + YearsEmployed;

        }
    }
}
