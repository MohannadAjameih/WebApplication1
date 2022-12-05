using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class EmpContext : DbContext
    {

        public EmpContext(DbContextOptions options) : base(options)
        {

        }


        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}
