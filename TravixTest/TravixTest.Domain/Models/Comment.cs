namespace Epam.TravixTest.Domain.Models
{
    /// <summary>
    /// Comment domain model for entity framework
    /// </summary>
    public class Comment : BaseEntity
    {
        public int PostId { get; set; }

        public virtual Post Post { get; set; }
    }
}
