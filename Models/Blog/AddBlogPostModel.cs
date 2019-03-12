using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace danielmoorhouse.Models.Blog
{
    public class AddBlogPostModel
    {
           public int Id { get; set; }

        public int CategoryId { get; set; }
        public SelectList CatList { get; set; }
        public string Title { get; set; }
        public DateTime PostedOn { get; set; }
        public string BlogContent { get; set; }
        public string Image1Url { get; set; }
        public IFormFile Image1 { get; set; }
      
    }
}