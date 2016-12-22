using System;
using System.ComponentModel.DataAnnotations;

namespace Epam.TravixTest.Buisness.Models.DtoModels
{
    /// <summary>
    /// Class for comments data transfer objects
    /// </summary>
    public class CommentDto : BaseDtoModel
    {
        [Required]
        [MaxLength(2000)]
        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastUpdatedDate { get; set; }

        [Required]
        public int PostId { get; set; }
    }
}
