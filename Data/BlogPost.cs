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
        public string BlogContent { get; set; }
        public string Image1Url { get; set; }
        
        
         

    }
}