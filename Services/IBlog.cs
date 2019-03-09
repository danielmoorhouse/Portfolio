using System.Collections.Generic;
using System.Threading.Tasks;
using danielmoorhouse.Data;

namespace danielmoorhouse.Services
{
    public interface IBlog
    {
        BlogPost GetById(int id);
       IEnumerable<BlogPost> GetAll(); 
       Task Create(BlogPost blogPost);
        Task Edit(int blogPostId);
         Task Delete(int blogPostId);  
    }
}