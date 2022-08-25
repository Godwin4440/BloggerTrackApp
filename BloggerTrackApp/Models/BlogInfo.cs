using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace BloggerTrackApp.Models
{
    public class BlogInfo
    {
        public int Id { get; set; } 
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public DateTime DateofCreation { get; set; }
        public string BlogUrl { get; set; }
        public string EmpEmailId { get; set; }
        
        
    }
}
