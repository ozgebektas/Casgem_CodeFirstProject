namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_city_booking : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                        CityCount = c.String(),
                        CityImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.CityId);
            
            CreateTable(
                "dbo.Travels",
                c => new
                    {
                        TravelID = c.Int(nullable: false, identity: true),
                        TravelTitle = c.String(),
                        TravelContent = c.String(),
                        TravelImageURL = c.String(),
                    })
                .PrimaryKey(t => t.TravelID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Travels");
            DropTable("dbo.Cities");
        }
    }
}
