using Microsoft.AspNetCore.Http;

namespace danielmoorhouse.Models.Projects
{
    public class AddProjectModel
    {
        public string Title { get; set; }
        public string ProjDesc { get; set; }
        public string GitRepo { get; set; }

        public string ProjectStatus { get; set; }

        public string PImage1 { get; set; }
        public IFormFile Image1 { get; set; }

        public string Image1Caption { get; set; }
        public string PImage2 { get; set; }
        public IFormFile Image2 { get; set; }
        public string Image2Caption { get; set; }
        public string PImage3 { get; set; }
        public IFormFile Image3 { get; set; }
        public string Image3Caption { get; set; }
        public string PImage4 { get; set; }
        public IFormFile Image4 { get; set; }
        public string Image4Caption { get; set; }
    }
}