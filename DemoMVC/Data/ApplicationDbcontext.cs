
using Microsoft.EntityFrameworkCore;

using DemoMVC.Models.Entities;
using DemoMvc.Models.Entities;

namespace DemoMVC.Data 
{
    public class ApplicationDbContext  : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

       
        public DbSet<Student> Students { get; set; }
         public DbSet<Person> Person { get; set; }
        public DbSet<DemoMvc.Models.Entities.Employee> Employee { get; set; } = default!;
    }
}
   