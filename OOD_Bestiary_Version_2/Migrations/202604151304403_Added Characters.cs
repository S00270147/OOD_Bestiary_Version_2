namespace OOD_Bestiary_Version_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCharacters : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Campaigns", "FoodPips", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Campaigns", "FoodPips");
        }
    }
}
