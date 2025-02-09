using Microsoft.EntityFrameworkCore;
using PGconnectApi.Models;

namespace PGconnectApi.Data
{
    public class PgConnectDbContext : DbContext
    {
        public PgConnectDbContext(DbContextOptions<PgConnectDbContext> PgConnectDbContext) : base(PgConnectDbContext)
        {

        }

        public DbSet<Testing> Testings { get; set; }
    }
}
