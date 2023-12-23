using DemoJenkins.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DemoJenkins.DbContext
{
    public class HRMContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public HRMContext(DbContextOptions<HRMContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
