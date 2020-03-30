using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Swipe.Api.Data
{
    public class Post
    {
        public int Id { get; set; }
        
        public string Url { get; set; }
        public string ImageUrl {get; set; }
        
        [StringLength(100)]
        public string Title { get; set; }
        
        [StringLength(360)]
        public string ShortDesciption { get; set; }
        
        public DateTimeOffset IntroducedAt { get; set; }
        
        public long Opened { get; set; }
        public long Ignored { get; set; }
    }
}