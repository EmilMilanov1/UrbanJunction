using UrbanJunction.Data;
using UrbanJunction.Data.Models;
using UrbanJunction.Web.Models.Topics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
namespace UrbanJunction.Web.Controllers
{
	public class TopicsController : Controller
    {
		private readonly ApplicationDbContext _dbContext;

		public TopicsController(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		// /Topics/Art
		[HttpGet("/topics/art")]
		public IActionResult Art()
		{
			var posts = GetPostsByTopicName("Art");
			ViewBag.Title = "Art";
			return View("Topic", posts); // View shared across all 3
		}

		// /Topics/Music
		[HttpGet("/topics/music")]
		public IActionResult Music()
		{
			var posts = GetPostsByTopicName("Music");
			ViewBag.Title = "Music";
			return View("Topic", posts);
		}

		// /Topics/Fashion
		[HttpGet("/topics/fashion")]
		public IActionResult Fashion()
		{
			var posts = GetPostsByTopicName("Fashion");
			ViewBag.Title = "Fashion";
			return View("Topic", posts);
		}

		// Internal shared logic
		private IEnumerable<Post> GetPostsByTopicName(string topicName)
		{
			return _dbContext.Posts
				.Include(p => p.Subcategory)
					.ThenInclude(sc => sc.Topic)
				.Include(p => p.User)
				.Where(p => p.Subcategory.Topic.Name == topicName)
				.OrderByDescending(p => p.CreatedOn)
				.ToList();
		}

	}
}
