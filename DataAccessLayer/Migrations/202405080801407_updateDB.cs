namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WorldToWorlds", "attackCount", c => c.String());
            AddColumn("dbo.WorldToWorlds", "attackRate", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WorldToWorlds", "attackRate");
            DropColumn("dbo.WorldToWorlds", "attackCount");
        }
    }
}
