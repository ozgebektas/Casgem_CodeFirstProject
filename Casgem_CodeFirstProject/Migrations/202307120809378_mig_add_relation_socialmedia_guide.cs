﻿namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_relation_socialmedia_guide : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SocialMedias", "GuideId", c => c.Int(nullable: false));
            CreateIndex("dbo.SocialMedias", "GuideId");
            AddForeignKey("dbo.SocialMedias", "GuideId", "dbo.Guides", "GuideID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SocialMedias", "GuideId", "dbo.Guides");
            DropIndex("dbo.SocialMedias", new[] { "GuideId" });
            DropColumn("dbo.SocialMedias", "GuideId");
        }
    }
}
