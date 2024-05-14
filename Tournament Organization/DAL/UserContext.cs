using Microsoft.EntityFrameworkCore;
using Tournament_Organization.Models;

namespace Tournament_Organization.DAL
{
    public class UserContext : DbContext
    {
        public UserContext() // : base("UserContext") 
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
