using Indian_team.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace Indian_team.Controllers
{
    public class HomeController : Controller
    {
        private static List<Player> players = new List<Player>()
        {
            new Player { Pld = 1, PName = "Virat Kohli", PCountry = "India", PType = "Batsman" },
            new Player { Pld = 2, PName = "Rohit Sharma", PCountry = "India", PType = "Batsman" },
            new Player { Pld = 3, PName = "Jasprit Bumrah", PCountry = "India", PType = "Bowler" },
        };

        public IActionResult Index()
        {
            ViewBag.Countries = players.Select(p => p.PCountry).Distinct().ToList();
            return View(players);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Player player)
        {
            players.Add(player);
            return RedirectToAction("Index");
        }
    }
}
