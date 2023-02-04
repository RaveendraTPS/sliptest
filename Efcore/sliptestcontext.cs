using Microsoft.EntityFrameworkCore;
using Models;
using Models.Models;

namespace Efcore
{
    public class sliptestcontext:DbContext
    {
        public sliptestcontext() {
        
        }

        public sliptestcontext(DbContextOptions<sliptestcontext> options):base(options) { 
        }

        public virtual DbSet<Role> Roles { get; set; }

        public virtual DbSet<Department> Departments { get; set; }

        public virtual DbSet<Location> Locations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Helper.ConnectionString);
            }
        }
    }


}