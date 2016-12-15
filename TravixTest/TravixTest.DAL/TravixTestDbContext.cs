using System.Data.Entity;
using System.Reflection;
using Epam.TravixTest.Domain.Models.ModelsConfiguration;

namespace TravixTest.DAL
{
    public class TravixTestDbContext : DbContext
    {
        public TravixTestDbContext() : base("name=TravixTestDbContext")
        {
        }

        // registering all config files that inherit from EntityTypeConfiguration
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PostConfig());
            modelBuilder.Configurations.Add(new CommentConfig());
        }
    }
}
