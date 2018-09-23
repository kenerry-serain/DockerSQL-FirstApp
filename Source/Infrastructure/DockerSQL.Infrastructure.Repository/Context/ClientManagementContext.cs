using DockerSQL.Domain.Models;
using DockerSQL.Infrastructure.Repository.Configuration;
using Microsoft.EntityFrameworkCore;

namespace DockerSQL.Infrastructure.Repository.Context
{
    public class ClientManagementContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        private readonly string _connectionString;
        public ClientManagementContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientEntityConfiguration());
        }
    }
}
