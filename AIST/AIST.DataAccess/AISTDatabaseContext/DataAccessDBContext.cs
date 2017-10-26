using Microsoft.EntityFrameworkCore;
using AIST.DataAccess.AISTModel;

namespace AIST.DataAccess.AISTDatabaseContext
{
    public class DataAccessDbContext : DbContext
    {
        public DataAccessDbContext(DbContextOptions<DataAccessDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<PagesData> PagesData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PagesData>().ToTable("PagesData");
        }
    }
}
