using Microsoft.EntityFrameworkCore;
using Mypay.webApi.Model;

namespace Mypay.webApi.Data
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {

        }


        public DbSet<Employee> Employees { get; set; }

        public DbSet<EmployeeSalary> EmployeesSalary { get; set;}

        public DbSet<EmployeeCategory> EmployeesCategory { get; set; }
    }
}
