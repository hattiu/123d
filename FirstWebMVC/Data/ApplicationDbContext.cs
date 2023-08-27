using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirstWebMVC.Models;
namespace FirstWebMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; } = default!;
        public DbSet<Student> Student{ get; set; } = default!;
        public DbSet<FirstWebMVC.Models.Employee> Employee { get; set; } = default!;
       
        public DbSet<FirstWebMVC.Models.Faculty> Faculty { get; set; } = default!;
     
    }


}
    