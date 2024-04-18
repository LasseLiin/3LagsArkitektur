using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDataAccess.Context
{
    internal class EmployeeInitializer : CreateDatabaseIfNotExists<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
            context.Employees.Add(new Model.Employee(1, "Olsen", 5));
            context.Employees.Add(new Model.Employee(2, "Hansen", 7));
            context.Employees.Add(new Model.Employee(3, "Jensen", 9));
            context.SaveChanges();
            //make sure EntityFramework.SqlServer.dll is included in bin folder
        }
        private void dummy()
        {
            string result = System.Data.Entity.SqlServer.SqlFunctions.Char(65);
        }
    }
}
