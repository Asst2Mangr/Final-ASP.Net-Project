using Microsoft.AspNetCore.Mvc;
using Project2.Models;

namespace Project2.Controllers
{
    public class DeckController : Controller
    {
        private DeckContext context { get; set; }

        public DeckController(DeckContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Deck = context.Decks.OrderBy(d => d.DeckName).ToList();
            return View("Edit", new Deck());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Deck = context.Decks.OrderBy(d => d.DeckName).ToList();
            var deck = context.Decks.Find(id);
            return View(deck);
        }

        [HttpPost]
        public IActionResult Edit(Deck deck)
        {
            if (ModelState.IsValid)
            {
                if (deck.DeckID == 0)
                    context.Decks.Add(deck);
                else
                    context.Decks.Update(deck);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (deck.DeckID == 0) ? "Add" : "Edit";
                ViewBag.Decks = context.Decks.OrderBy(d => d.DeckName).ToList();
                return View(deck);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var deck = context.Decks.Find(id);
            return View(deck);
        }

        [HttpPost]
        public IActionResult Delete(Deck deck)
        {
            context.Decks.Remove(deck);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
