using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100DerseCore.Models
{
    public class Context:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // connection string
        {
            optionsBuilder.UseSqlServer("server=(LocalDB)\\MSSQLLocalDB; database=CoreAndFood; integrated security = true;");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
