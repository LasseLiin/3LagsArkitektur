using DTO.Model;

using EmployeeDataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Employees
{
    public class EmployeeBLL
    {
        public Employee getEmployee(int id)
        {
            if (id < 0) throw new IndexOutOfRangeException();
            return EmployeeRepository.getEmployee(id);
        }
        public void AddEmployee(Employee employee)
        {
            //valider employee
            EmployeeRepository.AddEmployee(employee);
        }
        public void EditEmployee(Employee employee)
        {
            EmployeeRepository.EditEmployee(employee);
        }
    }
}
