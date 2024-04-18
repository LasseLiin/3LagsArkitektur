using EmployeeDataAccess.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDataAccess.Context
{
    internal class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("Employees")
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companys { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
