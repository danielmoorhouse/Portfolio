using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using danielmoorhouse.Data;
using danielmoorhouse.Models.Blog;
using Microsoft.AspNetCore.Http;
using System.IO;
using danielmoorhouse.Services;
using Microsoft.AspNetCore.Authorization;

namespace danielmoorhouse.Controllers
{
    public class BlogController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IBlog _blogService;
        

        public BlogController(ApplicationDbContext context, IBlog blogService)
        {
            _context = context;
            _blogService = blogService;
            
        }

        // GET: Blog
        public IActionResult Index()
        {
            var userName = _context.Users.Where(u => u.UserName == "danielmoorhouse").FirstOrDefault().UserName;
            var blogList =(from b in _context.Blog
            join Cat in _context.Categories on b.CategoryId equals Cat.Id
            //join User in _context.Users on b.AuthorId equals User.Id
            orderby b.PostedOn
            select new BlogListingModel {
               
                CategoryName = Cat.CatName,
                BlogTitle = b.Title,
                PostedOn = b.PostedOn
                
            }).ToList();
          
            return View(blogList) ;
        }

        // GET: Blog/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogPost = await _context.Blog
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blogPost == null)
            {
                return NotFound();
            }

            return View(blogPost);
        }
        [Authorize]
        // GET: Blog/Create
        public IActionResult Create()
        {
            var model = new AddBlogPostModel();
            var cat = _context.Categories
                     .OrderBy(c => c.CatName)
                     .Select(x => new { Id = x.Id, Value = x.CatName });
            model.CatList = new SelectList(cat, "Id", "Value");         
            return View(model);
        }

        // POST: Blog/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AddBlogPostModel model, IFormCollection Image)
        {
              string storePath = "/images/blog/";
            var path = Path.Combine(
                     Directory.GetCurrentDirectory(), "wwwroot", "images", "blog",
                     Image.Files[0].FileName);
         

             using (var stream = new FileStream(path, FileMode.Create))
            {
                await Image.Files[0].CopyToAsync(stream);
            
             }
          var blog = new BlogPost 
          {
            
            CategoryId = model.CategoryId,
            Title = model.Title,
            BlogContent = model.BlogContent,
            Image1Url = storePath + model.Image1.FileName,
            PostedOn = DateTime.Now
          };
          await _blogService.Create(blog);
           return RedirectToAction("Index", "Blog");
        }

        // GET: Blog/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogPost = await _context.Blog.FindAsync(id);
            if (blogPost == null)
            {
                return NotFound();
            }
            return View(blogPost);
        }

        // POST: Blog/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AuthorId,CategoryId,Title,PostedOn,BlogContent,Image1,Image2")] BlogPost blogPost)
        {
            if (id != blogPost.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(blogPost);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogPostExists(blogPost.Id))
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
            return View(blogPost);
        }

        // GET: Blog/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogPost = await _context.Blog
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blogPost == null)
            {
                return NotFound();
            }

            return View(blogPost);
        }

        // POST: Blog/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var blogPost = await _context.Blog.FindAsync(id);
            _context.Blog.Remove(blogPost);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlogPostExists(int id)
        {
            return _context.Blog.Any(e => e.Id == id);
        }
    }
}
