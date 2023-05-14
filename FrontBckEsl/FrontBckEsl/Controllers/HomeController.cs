using FrontBckEsl.DAL;
using FrontBckEsl.Models;
using FrontBckEsl.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontBckEsl.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IActionResult> Index()
        {


            HomeVM homeVM = new HomeVM
            {

                Sliders = await _appDbContext.Sliders.ToListAsync(),
                Categories = await _appDbContext.Categories.ToListAsync(),
                Services = await _appDbContext.services
                .Include(s => s.category)
                .Include(s => s.ServiceImages)
                .OrderByDescending(s => s.Id)
                .Take(8)
                .ToListAsync()
            };
            return View(homeVM);
        }
    }
}
