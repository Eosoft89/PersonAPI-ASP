using Microsoft.EntityFrameworkCore;
using PersonAPIASP.Models;

namespace PersonAPIASP.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            
        }

        public DbSet<Person> Persons { get; set; }
        

    }
}
