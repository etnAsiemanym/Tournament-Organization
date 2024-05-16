﻿using Tournament_Organization.Models.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Tournament_Organization.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) 
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Database.EnsureCreated();
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }

        public DbSet<User> Users { get; set; }
    }
}
