using System;

namespace Epam.TravixTest.Domain.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastUpdatedDate { get; set; }
    }
}
