using System.Data.Entity.ModelConfiguration;

namespace Epam.TravixTest.Domain.Models.ModelsConfiguration
{
    public class PostConfig : EntityTypeConfiguration<Post>
    {
        public PostConfig()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties description
            Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(200);

            Property(t => t.Content)
                .IsRequired()
                .HasMaxLength(2000);

            Property(t => t.CreatedDate)
                .IsRequired();

            Property(t => t.LastUpdatedDate)
                .IsRequired();

            // Table & Column Mappings
            ToTable("Post");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Title).HasColumnName("Title");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.Content).HasColumnName("Content");
            Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            Property(t => t.LastUpdatedDate).HasColumnName("LastUpdatedDate");

            // Relationships
            HasMany(e => e.Comments)
                .WithRequired(e => e.Post)
                .WillCascadeOnDelete(true);
        }
    }
}
