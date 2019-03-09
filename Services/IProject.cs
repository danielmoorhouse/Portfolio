using System.Collections.Generic;
using System.Threading.Tasks;
using danielmoorhouse.Data;

namespace danielmoorhouse.Services
{
    public interface IProject
    {
       IEnumerable<Projects> GetAll(); 
       Task Create(Projects projects);
        Task Edit(int projectsId);
         Task Delete(int projectsId);
    }
}