using Microsoft.EntityFrameworkCore;

namespace Project4.Models
{
    public class DeckContext : DbContext
    {
        public DeckContext(DbContextOptions<DeckContext> options)
            : base(options)
        { }

        public DbSet<Deck> Decks { get; set; }
        //seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Deck>().HasData(
                new Deck
                {
                    DeckID = 1,
                    DeckName = "Rider-Waite Tarot", 
                    DeckCount = 78
                },
                new Deck
                {
                    DeckID = 2,
                    DeckName = "Standard",
                    DeckCount = 52
                },
                new Deck
                {
                     DeckID = 3,
                     DeckName = "another one",
                     DeckCount = 100
                },
                new Deck
                {
                    DeckID = 4,
                    DeckName = "New Deck, Who Dis?",
                    DeckCount = 55
                },
                new Deck
                {
                    DeckID = 5,
                    DeckName = "I cannot think of anymore deck examples",
                    DeckCount = 42
                }
                );

        }
    }
}
