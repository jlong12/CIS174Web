namespace GameOnEntertainment.Domain.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using GameOnEntertainment.Domain.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<GameOnEntertainment.Domain.PlayerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GameOnEntertainment.Domain.PlayerContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Persons.AddOrUpdate(new Person
            {
                PersonId = Guid.Parse("08d1c76f-10f3-4e92-a338-5e9a6a850ea0"),
                FirstName = "Jonathan",
                LastName = "Long",
                DateCreated = new DateTime(2019, 2, 14),
                Email = "jlong12@dmacc.edu"
            });

            context.Persons.AddOrUpdate(new Person
            {
                PersonId = Guid.Parse("d0012934-d557-4596-bd3c-95f45822c46b"),
                FirstName = "Rob",
                LastName = "Dunavan",
                DateCreated = new DateTime(2019, 2, 14),
                Email = "rrdunavan@dmacc.edu"
            });

            context.HighScores.AddOrUpdate(new HighScore
            {
                HighScoreId = Guid.Parse("fb0f8dc6-119b-4378-b11a-f95a81d41007"),
                PersonId = Guid.Parse("bd083830-2df0-4727-87f7-0a8db5dc8697"),
                Score = 15f,
                DateAttained = new DateTime(2019, 2, 14)
            });

            context.HighScores.AddOrUpdate(new HighScore
            {
                HighScoreId = Guid.Parse("97861d1c-a2fd-4ccf-aa93-3755cfc21c00"),
                PersonId = Guid.Parse("7c7d0a3c-2569-4b4f-91ea-89b3e92d13f2"),
                Score = 16f,
                DateAttained = new DateTime(2019, 2, 14)
            });

            context.HighScores.AddOrUpdate(new HighScore
            {
                HighScoreId = Guid.Parse("754136d6-ed74-420c-9b1e-c43b2a0782ce"),
                PersonId = Guid.Parse("fa936168-aa16-41eb-9277-eb3caf3ddeb7"),
                Score = 20f,
                DateAttained = new DateTime(2019, 2, 14)
            });

            context.HighScores.AddOrUpdate(new HighScore
            {
                HighScoreId = Guid.Parse("deaaf438-9753-4843-b743-f669b3bd013f"),
                PersonId = Guid.Parse("e794b11e-0c21-4559-9f2c-83a18f790e6d"),
                Score = 25f,
                DateAttained = new DateTime(2019, 2, 14)
            });

            context.HighScores.AddOrUpdate(new HighScore
            {
                HighScoreId = Guid.Parse("426a8d8c-1844-49a9-a916-17a1d199fedf"),
                PersonId = Guid.Parse("a735d819-79e8-46ba-83a6-50adc5da04bf"),
                Score = 30f,
                DateAttained = new DateTime(2019, 2, 14)
            });
        }
    }
}
