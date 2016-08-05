using Microsoft.Data.Entity;
using Microsoft.Data.Sqlite;

namespace Entity.Models
{
    public class MetricsContext : DbContext
    {
        public DbSet<ComputerDetail> ComputerDetailsSet { get; set; }
        public DbSet<UsageData> UsageDatasSet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "metrics.db" };
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);

            optionsBuilder.UseSqlite(connection);
        }
    }
}
