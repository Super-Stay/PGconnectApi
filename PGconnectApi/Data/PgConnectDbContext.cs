using Microsoft.EntityFrameworkCore;
using PGconnectApi.Models;
using System;

namespace PGconnectApi.Data
{
    public class PgConnectDbContext : DbContext
    {
        public PgConnectDbContext(DbContextOptions<PgConnectDbContext> PgConnectDbContext) : base(PgConnectDbContext) { }

        public DbSet<testing> Testings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Server=localhost;Database=pgconnect;User=root;Password=ss@123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Ensure EF Core doesn't try to modify the schema
            modelBuilder.Entity<testing>().ToTable("testing");
        }
    }
}
