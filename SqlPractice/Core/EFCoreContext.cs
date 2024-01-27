using Microsoft.EntityFrameworkCore;
using SqlPractice.Core.Models;
using SqlPractice.Core.PROC_Models;

namespace SqlPractice
{
    public class EFCoreContext : DbContext
    {
        private readonly string _connectionString;
        public DbSet<Concern> Concerns { get; set; }
        public DbSet<VehiclePR> PROC_VehiclePR_Model { get; set; }

        public EFCoreContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
