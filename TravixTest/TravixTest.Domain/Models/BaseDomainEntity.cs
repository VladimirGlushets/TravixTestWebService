using System;

namespace Epam.TravixTest.Domain.Models
{
    /// <summary>
    /// BaseEntity includes all common fields for inherit entities
    /// </summary>
    public class BaseDomainEntity
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastUpdatedDate { get; set; }
    }
}
