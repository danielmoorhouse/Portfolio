using Microsoft.AspNetCore.Http;

namespace danielmoorhouse.Data
{
    public class Projects
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ProjDesc { get; set; }

        public string GitRepo { get; set; }

        public string Status { get; set; }

        public string PImage1 { get; set; }
        
        public string PImage2 { get; set; }
       
        public string PImage3 { get; set; }
       
        public string PImage4 { get; set; }
        
    }
}