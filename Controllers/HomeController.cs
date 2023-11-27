using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project2.Models;

namespace Project2.Controllers
{
    public class HomeController : Controller
    {
        private DeckContext context { get; set; }

        public HomeController(DeckContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            var Decks = context.Decks
                .OrderBy(d => d.DeckName)
                .ToList();
            return View(Decks);
        }
    }
}
