using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Project4.Models
{
    public class Deck
    {
        public int DeckID { get; set; }
        [Required(ErrorMessage = "Please enter a deck name.")]
        public string? DeckName { get; set;}
        [Required(ErrorMessage = "Please enter a card count.")]
        [Range(0, 100, ErrorMessage = "Please enter a number with in range!")]
        public int DeckCount { get; set; }
    }
}
