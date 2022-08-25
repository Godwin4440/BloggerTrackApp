using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace BloggerTrackApp.Models
{
    public class EmpInfo
    {
        public int Id { get; set; }
        public string EmailId { get; set; }
      
        public string Name { get; set; }
        public DateTime? DateofJoining { get; set; }
        public string Password { get; set; }
    }
}
