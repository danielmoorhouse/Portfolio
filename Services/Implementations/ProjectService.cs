using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using danielmoorhouse.Data;

namespace danielmoorhouse.Services.Implementations
{
    public class ProjectService : IProject
    {
       private readonly ApplicationDbContext _db;
        public ProjectService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task Create(Projects project)
        {
            _db.Add(project);
            await _db.SaveChangesAsync();
        }
      

        public Task Delete(int projectId)
        {
            throw new System.NotImplementedException();
        }

        public Task Edit(int projectId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Projects> GetAll()
        {
            return _db.Projects.ToList();
        }

        public Projects GetById(int id)
        {
              var project = _db.Projects.Where(c => c.Id == id).FirstOrDefault();
            return project;
        }
    }
}