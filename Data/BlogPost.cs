using System;

namespace danielmoorhouse.Data
{
    public class BlogPost
    {
        public int Id { get; set; }

        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public DateTime PostedOn { get; set; }
        public string BlogContent { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }

    }
}