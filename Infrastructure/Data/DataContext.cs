using Microsoft.EntityFrameworkCore;
using minimal_api.Domain.Entities;

namespace minimal_api.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<Admin> Admins { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}