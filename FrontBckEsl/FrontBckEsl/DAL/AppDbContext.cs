using FrontBckEsl.Models;
using Microsoft.EntityFrameworkCore;

namespace FrontBckEsl.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
    public DbSet<Slider> Sliders { get;set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Service> services { get; set; }
        public DbSet<ServiceImage> serviceImages { get; set; }

    }
}
