using Microsoft.EntityFrameworkCore;
using PGconnectApi.Models;
using PGconnectApi.Models.LoginModels;
using PGconnectApi.Models.PGSetUp;
using System;

namespace PGconnectApi.Data
{
    public class PgConnectDbContext : DbContext
    {
        public PgConnectDbContext(DbContextOptions<PgConnectDbContext> PgConnectDbContext) : base(PgConnectDbContext) { }

        public DbSet<testing> Testings { get; set; }
        public DbSet<login_master> LoginMaster { get; set; }
        public DbSet<owner_details> OwnerDetails { get; set; }
        public DbSet<user_details> UserDetails { get; set; }
        public DbSet<pg_org_master> PgOrgMaster { get; set; }

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

            //Login 
            modelBuilder.Entity<login_master>().ToTable("login_master");
            modelBuilder.Entity<owner_details>().ToTable("owner_details");
            modelBuilder.Entity<user_details>().ToTable("user_details");
            modelBuilder.Entity<pg_org_master>().ToTable("pg_org_master");
        }
    }
}
