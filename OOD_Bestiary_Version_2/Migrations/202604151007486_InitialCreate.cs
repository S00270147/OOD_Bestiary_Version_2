namespace OOD_Bestiary_Version_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Campaigns",
                c => new
                    {
                        CampaignId = c.Int(nullable: false, identity: true),
                        CharacterName = c.String(),
                        Portrait = c.String(),
                        Speed = c.String(),
                        Diet = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CampaignId);
            
            CreateTable(
                "dbo.Creatures",
                c => new
                    {
                        CreatureId = c.Int(nullable: false, identity: true),
                        SubjectName = c.String(),
                        Portrait = c.String(),
                        WalkGif = c.String(),
                        Camapigns = c.String(),
                        Species = c.String(),
                        Nature = c.String(),
                        Habitat = c.String(),
                        Description = c.String(),
                        DangerLevel = c.String(),
                        Speed = c.String(),
                        HP = c.String(),
                        Campaign_CampaignId = c.Int(),
                    })
                .PrimaryKey(t => t.CreatureId)
                .ForeignKey("dbo.Campaigns", t => t.Campaign_CampaignId)
                .Index(t => t.Campaign_CampaignId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Creatures", "Campaign_CampaignId", "dbo.Campaigns");
            DropIndex("dbo.Creatures", new[] { "Campaign_CampaignId" });
            DropTable("dbo.Creatures");
            DropTable("dbo.Campaigns");
        }
    }
}
