using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace USERS.Database.Models
{
    public class UsersDatabaseContext : DbContext
    {
        public DbSet<User> Users {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=VCDNADMPMLPT02\SQLEXPRESS;Initial Catalog=users;Integrated Security=True");
        }
    }
}
