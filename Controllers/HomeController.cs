using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project4.Models;

namespace Project4.Controllers
{
    public class HomeController : Controller
    {
        private DeckContext context { get; set; }

        public HomeController(DeckContext ctx)
        {
            context = ctx;
        }
        public ViewResult Index()
        {
            var Decks = context.Decks
                .OrderBy(d => d.DeckName)
                .ToList();
            return View(Decks);
        }
    }
}
