using EntityFramework.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Contexts
{
    internal class CompanyDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       
          => optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server = DESKTOP-3KIHJRO;Database = Company;Trusted_Connection = True");
        
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}
