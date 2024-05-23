namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateddb : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.WorldToWorlds", "attackCount");
            DropColumn("dbo.WorldToWorlds", "attackRate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WorldToWorlds", "attackRate", c => c.String());
            AddColumn("dbo.WorldToWorlds", "attackCount", c => c.String());
        }
    }
}
