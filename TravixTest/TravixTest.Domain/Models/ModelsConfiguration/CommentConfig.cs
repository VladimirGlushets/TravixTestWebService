using System.Data.Entity.ModelConfiguration;

namespace Epam.TravixTest.Domain.Models.ModelsConfiguration
{
    public class CommentConfig : EntityTypeConfiguration<Comment>
    {
        public CommentConfig()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties description
            Property(t => t.Content)
                .IsRequired()
                .HasMaxLength(200);

            Property(t => t.CreatedDate)
                .IsRequired();

            Property(t => t.LastUpdatedDate)
                .IsRequired();

            Property(t => t.PostId)
                .IsRequired();

            // Table & Column Mappings
            ToTable("Comment");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Content).HasColumnName("Content");
            Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            Property(t => t.LastUpdatedDate).HasColumnName("LastUpdatedDate");
            Property(t => t.PostId).HasColumnName("PostId");
        }
    }
}
