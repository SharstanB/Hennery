namespace Hennery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Checks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CheckDate = c.DateTime(nullable: false),
                        TroopId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CheckVaccines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        QuantityUnit = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Conservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Type = c.String(maxLength: 50),
                        Procedures = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Consumptions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ConsumptionDate = c.DateTime(nullable: false),
                        Type = c.String(maxLength: 50),
                        Troop_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Troops", t => t.Troop_Id)
                .Index(t => t.Troop_Id);
            
            CreateTable(
                "dbo.ConsumptionStoreItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(),
                        QuantityUnit = c.String(maxLength: 50),
                        Consumption_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Consumptions", t => t.Consumption_Id)
                .Index(t => t.Consumption_Id);
            
            CreateTable(
                "dbo.Troops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TroopNum = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        Type = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FeedItemMixings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FeedItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Temperature = c.Int(nullable: false),
                        TemperatureUnit = c.String(maxLength: 50),
                        Humidity = c.Int(nullable: false),
                        HumidityUnit = c.String(maxLength: 50),
                        Light = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Hingars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Capacity = c.Int(nullable: false),
                        Type = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HingarTroops",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Count = c.Int(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Type = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Machines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SequenceNumber = c.String(),
                        Company = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Mixings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MixDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Preparations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Notes = c.String(maxLength: 100),
                        Procedures = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Productions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductionDate = c.DateTime(nullable: false),
                        Quantity = c.Int(),
                        QuantityUnit = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StoreItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        QuantityUnit = c.String(maxLength: 50),
                        Store_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stores", t => t.Store_Id)
                .Index(t => t.Store_Id);
            
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StoreName = c.String(maxLength: 50),
                        Area = c.Int(nullable: false),
                        Temperature = c.Int(nullable: false),
                        TemperatureUnit = c.String(maxLength: 50),
                        Humidity = c.Int(nullable: false),
                        HumidityUnit = c.String(maxLength: 50),
                        Light = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StroreItemFeedItemMixings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Suppleirs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Phone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Supplyings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SupplyingDate = c.DateTime(nullable: false),
                        SuppleirId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Suppleirs", t => t.SuppleirId)
                .Index(t => t.SuppleirId);
            
            CreateTable(
                "dbo.SupplyingItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        QuantityUnit = c.String(maxLength: 50),
                        Price = c.Int(nullable: false),
                        ProductionDate = c.DateTime(nullable: false),
                        GoodnessPeriod = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vaccines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Supplyings", "SuppleirId", "dbo.Suppleirs");
            DropForeignKey("dbo.StoreItems", "Store_Id", "dbo.Stores");
            DropForeignKey("dbo.Consumptions", "Troop_Id", "dbo.Troops");
            DropForeignKey("dbo.ConsumptionStoreItems", "Consumption_Id", "dbo.Consumptions");
            DropIndex("dbo.Supplyings", new[] { "SuppleirId" });
            DropIndex("dbo.StoreItems", new[] { "Store_Id" });
            DropIndex("dbo.ConsumptionStoreItems", new[] { "Consumption_Id" });
            DropIndex("dbo.Consumptions", new[] { "Troop_Id" });
            DropTable("dbo.Vaccines");
            DropTable("dbo.SupplyingItems");
            DropTable("dbo.Supplyings");
            DropTable("dbo.Suppleirs");
            DropTable("dbo.StroreItemFeedItemMixings");
            DropTable("dbo.Stores");
            DropTable("dbo.StoreItems");
            DropTable("dbo.Productions");
            DropTable("dbo.Preparations");
            DropTable("dbo.Mixings");
            DropTable("dbo.Machines");
            DropTable("dbo.Items");
            DropTable("dbo.HingarTroops");
            DropTable("dbo.Hingars");
            DropTable("dbo.FeedItems");
            DropTable("dbo.FeedItemMixings");
            DropTable("dbo.Troops");
            DropTable("dbo.ConsumptionStoreItems");
            DropTable("dbo.Consumptions");
            DropTable("dbo.Conservations");
            DropTable("dbo.CheckVaccines");
            DropTable("dbo.Checks");
        }
    }
}
