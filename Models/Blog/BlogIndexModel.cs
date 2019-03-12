using System.Collections.Generic;

namespace danielmoorhouse.Models.Blog
{
    public class BlogIndexModel
    {
        public IEnumerable<BlogListingModel> BlogList { get; set; }
    }
}