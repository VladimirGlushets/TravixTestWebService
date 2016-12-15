using System.Collections.Generic;

namespace Epam.TravixTest.Domain.Models
{
    public class Post : BaseEntity
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
