namespace GameOnProject.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addfieldstodatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Profiles",
                c => new
                    {
                        UserId = c.Guid(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Gender = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            AddColumn("dbo.People", "Gender", c => c.String());
            AddColumn("dbo.People", "PhoneNumber", c => c.String());
            AddColumn("dbo.People", "ProfileId", c => c.Guid(nullable: false));
            AddColumn("dbo.People", "Profile_UserId", c => c.Guid());
            CreateIndex("dbo.People", "Profile_UserId");
            AddForeignKey("dbo.People", "Profile_UserId", "dbo.Profiles", "UserId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "Profile_UserId", "dbo.Profiles");
            DropIndex("dbo.People", new[] { "Profile_UserId" });
            DropColumn("dbo.People", "Profile_UserId");
            DropColumn("dbo.People", "ProfileId");
            DropColumn("dbo.People", "PhoneNumber");
            DropColumn("dbo.People", "Gender");
            DropTable("dbo.Profiles");
        }
    }
}
