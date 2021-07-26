using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace WEBApi_E2.Models
{
    public class UsersContext:DbContext
    {
        public DbSet<User> Users { get; set; }

        public UsersContext(DbContextOptions<UsersContext> options):base(options)
        {
            Database.EnsureCreated();
        }
    }
}
