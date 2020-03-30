using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swipe.Web.Models
{
    public class PostModel
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        
        public string ShortDesciption { get; set; }
    }

    public class PostContainer
    {
        public PostModel Post { get; set; }

    }
}
