namespace GameOnEntertainment.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabaseCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HighScores",
                c => new
                    {
                        HighScoreId = c.Guid(nullable: false),
                        PersonId = c.Guid(nullable: false),
                        Score = c.Single(nullable: false),
                        DateAttained = c.DateTime(),
                    })
                .PrimaryKey(t => t.HighScoreId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Guid(nullable: false),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(),
                        DateCreated = c.DateTime(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.PersonId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
            DropTable("dbo.HighScores");
        }
    }
}
