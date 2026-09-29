using Microsoft.AspNetCore.Mvc;
using SkopjeDrive.Models;

namespace SkopjeDrive.Controllers
{
    public class TeamController : Controller
    {
        private static readonly List<TeamMember> Members = new()
        {
            new TeamMember { Id = 1, Name = "Ziko Todorovski", Role = "TeamRole1", Bio = "TeamBio1", Initials = "ZT" },
            new TeamMember { Id = 2, Name = "Darko Rangelov", Role = "TeamRole2", Bio = "TeamBio2", Initials = "DR" },
            new TeamMember { Id = 3, Name = "Andrej Sehtanski", Role = "TeamRole3", Bio = "TeamBio3", Initials = "AS" },
            new TeamMember { Id = 4, Name = "Luka Stojanovski", Role = "TeamRole4", Bio = "TeamBio4", Initials = "LS" },
        };

        public IActionResult Index()
        {
            return View(Members);
        }
    }
}
