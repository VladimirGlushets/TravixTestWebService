namespace Epam.TravixTest.Domain.Models
{
    public class Comment : BaseEntity
    {
        public int PostId { get; set; }

        public virtual Post Post { get; set; }
    }
}
