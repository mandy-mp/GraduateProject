using GraduateProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GraduateProject.Data
{
    public class ApplicationDbContext : DbContext
    { 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Profile> Profile { get; set; }
    }

       
}
