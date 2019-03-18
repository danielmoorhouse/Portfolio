using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using danielmoorhouse.Data;
using danielmoorhouse.Models.Projects;
using Microsoft.AspNetCore.Http;
using System.IO;
using danielmoorhouse.Services;

namespace danielmoorhouse.Controllers
{
    public class ProjectController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IProject _projectService;

        public ProjectController(ApplicationDbContext context, IProject projectService)
        {
            _context = context;
            _projectService = projectService;
        }

        // GET: Project
        public async Task<IActionResult> Index()
        {
            return View(await _context.Projects.ToListAsync());
        }

        // GET: Project/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projects = await _context.Projects
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projects == null)
            {
                return NotFound();
            }

            return View(projects);
        }

        // GET: Project/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Project/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
          public async Task<IActionResult> Create(AddProjectModel model,
             IFormCollection image1, IFormCollection image2, IFormCollection image3, IFormCollection image4)
        {
              string storePath = "/images/project/";
            var path1 = Path.Combine(
                     Directory.GetCurrentDirectory(), "wwwroot", "images", "project",
                     image1.Files[0].FileName);
            var path2 = Path.Combine(
                     Directory.GetCurrentDirectory(), "wwwroot", "images", "project",
                     image2.Files[0].FileName);
            var path3 = Path.Combine(
                     Directory.GetCurrentDirectory(), "wwwroot", "images", "project",
                     image3.Files[0].FileName);                  
           var path4 = Path.Combine(
                     Directory.GetCurrentDirectory(), "wwwroot", "images", "project",
                     image4.Files[0].FileName);  

             using (var stream = new FileStream(path1, FileMode.Create))
            {
                await image1.Files[0].CopyToAsync(stream);
            
             }
                 using (var stream = new FileStream(path2, FileMode.Create))
            {
                await image2.Files[0].CopyToAsync(stream);
            
             }
                 using (var stream = new FileStream(path3, FileMode.Create))
            {
                await image3.Files[0].CopyToAsync(stream);
            
             }
                    using (var stream = new FileStream(path4, FileMode.Create))
            {
                await image4.Files[0].CopyToAsync(stream);
            
             }
          var project = new Projects
          {
            
           Title = model.Title,
           ProjDesc = model.ProjDesc,
           GitRepo = model.GitRepo,
           Status = model.ProjectStatus,
           PImage1 = storePath + model.Image1.FileName,
           PImage2 = storePath + model.Image2.FileName,
           PImage3 = storePath + model.Image3.FileName,
           PImage4 = storePath + model.Image4.FileName,
           
          };
          await _projectService.Create(project);
           return RedirectToAction("Index", "Project");
        }

        // GET: Project/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projects = await _context.Projects.FindAsync(id);
            if (projects == null)
            {
                return NotFound();
            }
            return View(projects);
        }

        // POST: Project/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ProjDesc,IsOnline,PImage1,PImage2")] Projects projects)
        {
            if (id != projects.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projects);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectsExists(projects.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(projects);
        }

        // GET: Project/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projects = await _context.Projects
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projects == null)
            {
                return NotFound();
            }

            return View(projects);
        }

        // POST: Project/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projects = await _context.Projects.FindAsync(id);
            _context.Projects.Remove(projects);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectsExists(int id)
        {
            return _context.Projects.Any(e => e.Id == id);
        }
    }
}
