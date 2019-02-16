using System.Data.Entity;
using GameOnEntertainment.Domain.Entities;

namespace GameOnEntertainment.Domain
{
    public class PlayerContext: DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<HighScore> HighScores { get; set; }
    }
}
