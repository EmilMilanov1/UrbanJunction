using System.Diagnostics;
using UrbanJunction.Data;
using UrbanJunction.Web.Models;
using UrbanJunction.Web.Models.Home;
using Microsoft.AspNetCore.Mvc;

namespace UrbanJunction.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public HomeController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel()
            {
                TotalHouses = _dbContext.Topics.Count(),
                TotalRents = _dbContext.Topics.Where(h => h.RenterId != null).Count(),
                Topics = _dbContext.Topics
                    .Select(h => new HouseIndexViewModel()
                    {
                        Title = h.Title,
                        ImageUrl = h.ImageUrl,
                    }).ToList()
            };
            
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
