using BloggerTrackApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BloggerTrackApp.Data
{
    public class AdminDbContext : IdentityDbContext<AdminInfo>
    {
        public AdminDbContext(DbContextOptions<AdminDbContext> options) : base(options)
        {
        
        }
      
        public DbSet<EmpInfo> EmpInfo { get; set; }
        public DbSet<BlogInfo> BlogInfo { get; set; }
    }
}
