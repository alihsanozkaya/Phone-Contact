using Microsoft.EntityFrameworkCore;
using Phone_Contact.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Contact.DataAccess.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=PhoneContact;User Id=postgres;Password=12345;");
        }

        public DbSet<Phone> Phones { get; set; }
        public DbSet<Person> People { get; set; }

    }
}
