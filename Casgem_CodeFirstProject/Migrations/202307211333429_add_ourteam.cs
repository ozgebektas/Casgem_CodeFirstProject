namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_ourteam : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OurTeams",
                c => new
                    {
                        OurTeamID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Title = c.String(),
                        Facebook = c.String(),
                        Twitter = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.OurTeamID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OurTeams");
        }
    }
}
