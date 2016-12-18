using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Epam.TravixTest.Common.DtoModels
{
    /// <summary>
    /// Class for posts data transfer objects
    /// </summary>
    public class PostDto
    {
        public PostDto()
        {
            Comments = new List<CommentDto>();
        }

        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        [Required]
        [MaxLength(2000)]
        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastUpdatedDate { get; set; }

        public List<CommentDto> Comments { get; set; }
    }
}
