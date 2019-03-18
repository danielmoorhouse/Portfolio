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
       
        
        public string P1BlogContent { get; set; }
        public string P1ImageUrl { get; set; }
        public IFormFile Image1 { get; set; }
         public string P2BlogContent { get; set; }
        public string P2ImageUrl { get; set; }
        public IFormFile Image2 { get; set; }
        public string P3BlogContent { get; set; }
        public string P3ImageUrl { get; set; }
        public IFormFile Image3 { get; set; }
      
    }
}