namespace UrbanJunction.Web.Controllers
{
    using UrbanJunction.Data;
    using UrbanJunction.Data.Models;
    using UrbanJunction.Web.Models.Topics;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Security.Claims;

    public class HousesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public HousesController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult All()
        {
            AllHousesViewModel model = new AllHousesViewModel()
            {
                Topics = _dbContext.Topics
                    .Select(h => new HouseDetailsViewModel()
                    {
                        Title = h.Title,
                        Address = h.Address,
                        ImageUrl = h.ImageUrl,
                    })
            };

            return View(model);
        }

        public IActionResult Details(int id)
        {
            Topic? topic = _dbContext.Topics.FirstOrDefault(h => h.Id == id);

            if (topic is null)
            {
                return RedirectToAction("All");
            }

            HouseDetailsViewModel model = new HouseDetailsViewModel()
            {
                Title = topic.Title,
                Address = topic.Address,
                ImageUrl = topic.ImageUrl,
            };

            return View(model);
        }

        [Authorize] 
        public IActionResult Mine()
        {
            var currentUserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            AllHousesViewModel model = new AllHousesViewModel()
            {
                Topics = _dbContext.Topics
                    .Where(h => h.Agent.UserId == currentUserId)
                    .Select(h => new HouseDetailsViewModel()
                    {
                        Title = h.Title,
                        Address = h.Address,
                        ImageUrl = h.ImageUrl,
                    })
            };

            return View(model);
        }
    }
}
