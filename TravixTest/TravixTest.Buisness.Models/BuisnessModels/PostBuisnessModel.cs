using System;
using System.Collections.Generic;

namespace Epam.TravixTest.Buisness.Models.BuisnessModels
{
    public class PostBuisnessModel : BaseBuisnessModel
    {
        public PostBuisnessModel()
        {
            Comments = new List<CommentBuisnessModel>();
        }
        
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastUpdatedDate { get; set; }

        public List<CommentBuisnessModel> Comments { get; set; }
    }
}
