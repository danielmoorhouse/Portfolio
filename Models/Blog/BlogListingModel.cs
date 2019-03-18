using System;

namespace danielmoorhouse.Models.Blog
{
    public class BlogListingModel
    {
        public int Id { get; set; }
        public string P1Image1Url { get; set; }
        public string CategoryName { get; set; }
        public string BlogTitle { get; set; }
        public DateTime PostedOn { get; set; }

    }
}