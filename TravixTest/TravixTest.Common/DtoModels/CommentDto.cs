using System;
using System.ComponentModel.DataAnnotations;

namespace Epam.TravixTest.Common.DtoModels
{
    public class CommentDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(2000)]
        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastUpdatedDate { get; set; }
        
        public int? PostId { get; set; }
    }
}
