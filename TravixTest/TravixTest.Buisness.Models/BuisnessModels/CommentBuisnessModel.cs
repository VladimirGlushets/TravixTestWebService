using System;

namespace Epam.TravixTest.Buisness.Models.BuisnessModels
{
    public class CommentBuisnessModel : BaseBuisnessModel
    {
        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastUpdatedDate { get; set; }
        
        public int PostId { get; set; }
    }
}
