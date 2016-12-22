using System.Collections.Generic;

namespace Epam.TravixTest.Domain.Models
{
    /// <summary>
    /// Post domain model for entity framework
    /// </summary>
    public class Post : BaseDomainEntity
    {
        public Post()
        {
            Comments = new List<Comment>();
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
