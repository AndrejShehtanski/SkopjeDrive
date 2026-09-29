using Microsoft.AspNetCore.Mvc;
using SkopjeDrive.Models;

namespace SkopjeDrive.Controllers
{
    public class NewsController : Controller
    {
        private static readonly List<NewsPost> Posts = new()
        {
            new NewsPost
            {
                Id = 1,
                Title = "SkopjeDrive adds 10 new cars to the fleet",
                Summary = "We're expanding our fleet with 10 brand new vehicles, including 3 SUVs.",
                Content = "We're excited to announce that SkopjeDrive has expanded its fleet with 10 brand new vehicles this month, including 3 SUVs and 2 vans. This upgrade means shorter waiting times and more choice for our customers, especially during the busy summer season.",
                Date = new DateTime(2026, 6, 15)
            },
            new NewsPost
            {
                Id = 2,
                Title = "New airport pick-up service",
                Summary = "Skip the taxi line — pick up your rental car directly at Skopje International Airport.",
                Content = "Starting this month, SkopjeDrive offers direct pick-up and drop-off at Skopje International Airport 'Alexander the Great'. Simply select the airport location when booking online and our team will have your car ready when you land.",
                Date = new DateTime(2026, 4, 2)
            },
            new NewsPost
            {
                Id = 3,
                Title = "Summer discount: 15% off weekly rentals",
                Summary = "Book a car for 7 days or more this summer and save 15% on the total price.",
                Content = "Planning a road trip around Macedonia this summer? Book any car for 7 days or more between June and September and get an automatic 15% discount on your total rental price. No coupon code needed — the discount is applied at checkout.",
                Date = new DateTime(2026, 5, 20)
            }
        };

        public IActionResult Index()
        {
            var ordered = Posts.OrderByDescending(p => p.Date).ToList();
            return View(ordered);
        }

        public IActionResult Details(int id)
        {
            var post = Posts.FirstOrDefault(p => p.Id == id);
            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }
    }
}
