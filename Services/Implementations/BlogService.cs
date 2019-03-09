using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using danielmoorhouse.Data;

namespace danielmoorhouse.Services.Implementations
{
    public class BlogService : IBlog
    {
            private readonly ApplicationDbContext _db;
        public BlogService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task Create(BlogPost blogPost)
        {
            _db.Add(blogPost);
            await _db.SaveChangesAsync();
        }
      

        public Task Delete(int blogPostId)
        {
            throw new System.NotImplementedException();
        }

        public Task Edit(int blogPostId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<BlogPost> GetAll()
        {
            return _db.Blog.ToList();
        }

        public BlogPost GetById(int id)
        {
              var blogPost = _db.Blog.Where(c => c.Id == id).FirstOrDefault();
            return blogPost;
        }
    }
}