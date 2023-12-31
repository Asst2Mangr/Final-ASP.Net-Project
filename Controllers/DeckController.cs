﻿using Microsoft.AspNetCore.Mvc;
using Project4.Models;

namespace Project4.Controllers
{
    public class DeckController : Controller
    {
        private DeckContext context { get; set; }

        public DeckController(DeckContext ctx)
        {
            context = ctx;
        }
        public ViewResult Index()
        {
            return View();
        }

        //add method allowing user to add deck to the database
        [HttpGet]
        public ViewResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Deck = context.Decks.OrderBy(d => d.DeckName).ToList();
            return View("Edit", new Deck());
        }

        [HttpGet]
        public ViewResult Edit(int id)
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
        //delete methods allowing user to delete decks 
        [HttpGet]
        public ViewResult Delete(int id)
        {
            var deck = context.Decks.Find(id);
            return View(deck);
        }

        [HttpPost]
        public RedirectToActionResult Delete(Deck deck)
        {
            context.Decks.Remove(deck);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
