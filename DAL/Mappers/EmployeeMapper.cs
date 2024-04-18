
using EmployeeDataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDataAccess.Mappers
{
    internal class EmployeeMapper
    {
        public static DTO.Model.Employee Map(Employee employee)
        {
            if (employee != null)
                return new DTO.Model.Employee(employee.EmployeeId, employee.Name, employee.YearsEmployeed);
            else
                return null;
        }
        public static Employee Map(DTO.Model.Employee employee)
        {
            if (employee != null)
                return new Employee(employee.EmployeeId, employee.Name, employee.YearsEmployed);
            else
                return null;
        }

        internal static void Update(DTO.Model.Employee employee, Employee dataemp)
        {
            if (employee != null)
            {
                dataemp.Name = employee.Name;
                dataemp.YearsEmployeed = employee.YearsEmployed;
            }
            else
                dataemp = null;
        }

        internal static DTO.Model.CompanyDetail Map(Company company)
        {
            DTO.Model.CompanyDetail retur = new DTO.Model.CompanyDetail();
            retur.CompanyName = company.CompanyName;
            retur.Employees = EmployeeMapper.Map(company.Employees);
            return retur;
        }

        private static List<DTO.Model.Employee> Map(List<Employee> employees)
        {
            List<DTO.Model.Employee> retur = new List<DTO.Model.Employee>();
            foreach (Employee employee in employees)
            {
                retur.Add(EmployeeMapper.Map(employee));
            }
            return retur;
        }
    }
}
