namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDatabase : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Carts", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Sales", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Sales", "UserId", "dbo.Users");
            DropForeignKey("dbo.Comments", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Comments", "UserId", "dbo.Users");
            DropIndex("dbo.Carts", new[] { "ProductId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropIndex("dbo.Sales", new[] { "ProductId" });
            DropIndex("dbo.Sales", new[] { "UserId" });
            DropIndex("dbo.Comments", new[] { "ProductId" });
            DropIndex("dbo.Comments", new[] { "UserId" });
            CreateTable(
                "dbo.AboutUS",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        aboutUs = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CyberAttacks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        attackName = c.String(),
                        attackDetails = c.String(),
                        countryID = c.Int(nullable: false),
                        worldCountry_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.WorldCountries", t => t.worldCountry_Id)
                .Index(t => t.worldCountry_Id);
            
            CreateTable(
                "dbo.WorldCountries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        countryName = c.String(),
                        population = c.String(),
                        countryDate = c.DateTime(nullable: false),
                        countryLeader = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        phone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Carts");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
            DropTable("dbo.Sales");
            DropTable("dbo.Users");
            DropTable("dbo.Comments");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        ProductId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        Email = c.String(),
                        UserName = c.String(nullable: false, maxLength: 50),
                        Password = c.String(),
                        Role = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        Image = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(nullable: false),
                        Stock = c.Int(nullable: false),
                        Popular = c.Boolean(nullable: false),
                        Image = c.String(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        youtubeLink = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        Image = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.CyberAttacks", "worldCountry_Id", "dbo.WorldCountries");
            DropIndex("dbo.CyberAttacks", new[] { "worldCountry_Id" });
            DropTable("dbo.Phones");
            DropTable("dbo.WorldCountries");
            DropTable("dbo.CyberAttacks");
            DropTable("dbo.AboutUS");
            CreateIndex("dbo.Comments", "UserId");
            CreateIndex("dbo.Comments", "ProductId");
            CreateIndex("dbo.Sales", "UserId");
            CreateIndex("dbo.Sales", "ProductId");
            CreateIndex("dbo.Products", "CategoryId");
            CreateIndex("dbo.Carts", "ProductId");
            AddForeignKey("dbo.Comments", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Comments", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Sales", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Sales", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Products", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Carts", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
        }
    }
}
