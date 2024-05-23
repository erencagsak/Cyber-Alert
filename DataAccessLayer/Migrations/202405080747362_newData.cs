namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WorldToWorlds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        warDate = c.Int(nullable: false),
                        attackCountry = c.String(),
                        defendCountry = c.String(),
                        attackType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WorldToWorlds");
        }
    }
}
