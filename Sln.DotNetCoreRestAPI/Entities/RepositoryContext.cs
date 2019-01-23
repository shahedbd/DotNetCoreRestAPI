using Microsoft.EntityFrameworkCore;
using Model.Entity;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options) { }       
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<PersonalInfo> PersonalInfo { get; set; }

    }
}
