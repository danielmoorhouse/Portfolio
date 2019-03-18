using System;
using Microsoft.AspNetCore.Http;

namespace danielmoorhouse.Data
{
    public class BlogPost
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }
        public string Title { get; set; }
        public DateTime PostedOn { get; set; }
        public string P1BlogContent { get; set; }
        public string P1ImageUrl { get; set; }
         public string P2BlogContent { get; set; }
        public string P2ImageUrl { get; set; }
         public string P3BlogContent { get; set; }
        public string P3ImageUrl { get; set; }

        
        
         

    }
}