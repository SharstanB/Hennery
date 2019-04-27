namespace Hennery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HenneryDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Checks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TroopId = c.Int(nullable: false),
                        CheckDate = c.DateTime(nullable: false),
                        CheckVaccine_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CheckVaccines", t => t.CheckVaccine_Id)
                .Index(t => t.CheckVaccine_Id);
            
            CreateTable(
                "dbo.Troops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TroopNum = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        Type = c.String(),
                        Check_Id = c.Int(),
                        Consumption_Id = c.Int(),
                        Production_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Checks", t => t.Check_Id)
                .ForeignKey("dbo.Consumptions", t => t.Consumption_Id)
                .ForeignKey("dbo.Productions", t => t.Production_Id)
                .Index(t => t.Check_Id)
                .Index(t => t.Consumption_Id)
                .Index(t => t.Production_Id);
            
            CreateTable(
                "dbo.CheckVaccines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VaccineId = c.Int(nullable: false),
                        CheckId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        QuantityUnit = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vaccines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemId = c.Int(nullable: false),
                        Type = c.String(),
                        CheckVaccine_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CheckVaccines", t => t.CheckVaccine_Id)
                .Index(t => t.CheckVaccine_Id);
            
            CreateTable(
                "dbo.Conservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MachineId = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Type = c.String(),
                        Procedures = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Machines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SupplyingItemId = c.Int(nullable: false),
                        SequenceNumber = c.String(),
                        Company = c.String(),
                        Description = c.String(),
                        Conservation_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Conservations", t => t.Conservation_Id)
                .Index(t => t.Conservation_Id);
            
            CreateTable(
                "dbo.Consumptions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TroopId = c.Int(nullable: false),
                        ConsumptionDate = c.DateTime(nullable: false),
                        Type = c.String(),
                        ConsumptionStoreItem_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ConsumptionStoreItems", t => t.ConsumptionStoreItem_Id)
                .Index(t => t.ConsumptionStoreItem_Id);
            
            CreateTable(
                "dbo.ConsumptionStoreItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StoreItemId = c.Int(nullable: false),
                        ConsumptionId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        QuantityUnit = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StoreItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductionId = c.Int(nullable: false),
                        SupplingItemId = c.Int(nullable: false),
                        FeedItemMixingId = c.Int(nullable: false),
                        StoreId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        QuantityUnit = c.String(),
                        ConsumptionStoreItem_Id = c.Int(),
                        StroreItemFeedItemMixing_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ConsumptionStoreItems", t => t.ConsumptionStoreItem_Id)
                .ForeignKey("dbo.StroreItemFeedItemMixings", t => t.StroreItemFeedItemMixing_Id)
                .Index(t => t.ConsumptionStoreItem_Id)
                .Index(t => t.StroreItemFeedItemMixing_Id);
            
            CreateTable(
                "dbo.FeedItemMixings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FeedItemId = c.Int(nullable: false),
                        MixingId = c.Int(nullable: false),
                        StoreItem_Id = c.Int(),
                        StroreItemFeedItemMixing_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StoreItems", t => t.StoreItem_Id)
                .ForeignKey("dbo.StroreItemFeedItemMixings", t => t.StroreItemFeedItemMixing_Id)
                .Index(t => t.StoreItem_Id)
                .Index(t => t.StroreItemFeedItemMixing_Id);
            
            CreateTable(
                "dbo.FeedItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Temperature = c.Int(nullable: false),
                        TemperatureUnit = c.String(),
                        Humidity = c.Int(nullable: false),
                        HumidityUnit = c.String(),
                        Light = c.Boolean(nullable: false),
                        FeedItemMixing_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FeedItemMixings", t => t.FeedItemMixing_Id)
                .Index(t => t.FeedItemMixing_Id);
            
            CreateTable(
                "dbo.Mixings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MixDate = c.DateTime(nullable: false),
                        FeedItemMixing_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FeedItemMixings", t => t.FeedItemMixing_Id)
                .Index(t => t.FeedItemMixing_Id);
            
            CreateTable(
                "dbo.Productions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemId = c.Int(nullable: false),
                        TroopId = c.Int(nullable: false),
                        ProductionDate = c.DateTime(nullable: false),
                        Quantity = c.Int(nullable: false),
                        QuantityUnit = c.String(),
                        StoreItem_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StoreItems", t => t.StoreItem_Id)
                .Index(t => t.StoreItem_Id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                        Production_Id = c.Int(),
                        SupplyingItem_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Productions", t => t.Production_Id)
                .ForeignKey("dbo.SupplyingItems", t => t.SupplyingItem_Id)
                .Index(t => t.Production_Id)
                .Index(t => t.SupplyingItem_Id);
            
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HingarId = c.Int(nullable: false),
                        StoreName = c.String(),
                        Area = c.Int(nullable: false),
                        Temperature = c.Int(nullable: false),
                        TemperatureUnit = c.String(),
                        Humidity = c.Int(nullable: false),
                        HumidityUnit = c.String(),
                        Light = c.Boolean(nullable: false),
                        StoreItem_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StoreItems", t => t.StoreItem_Id)
                .Index(t => t.StoreItem_Id);
            
            CreateTable(
                "dbo.Hingars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Capacity = c.Int(nullable: false),
                        Type = c.String(),
                        Store_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stores", t => t.Store_Id)
                .Index(t => t.Store_Id);
            
            CreateTable(
                "dbo.SupplyingItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemId = c.Int(nullable: false),
                        SupplyingId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        QuantityUnit = c.String(),
                        Price = c.Int(nullable: false),
                        ProductionDate = c.DateTime(nullable: false),
                        GoodnessPeriod = c.Int(nullable: false),
                        StoreItem_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StoreItems", t => t.StoreItem_Id)
                .Index(t => t.StoreItem_Id);
            
            CreateTable(
                "dbo.Supplyings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SuppleirId = c.Int(nullable: false),
                        SupplyingDate = c.DateTime(nullable: false),
                        Supplying_Id = c.Int(),
                        SupplyingItem_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Supplyings", t => t.Supplying_Id)
                .ForeignKey("dbo.SupplyingItems", t => t.SupplyingItem_Id)
                .Index(t => t.Supplying_Id)
                .Index(t => t.SupplyingItem_Id);
            
            CreateTable(
                "dbo.HingarTroops",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        HingarId = c.Int(nullable: false),
                        TroopId = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Preparations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HingarId = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Notes = c.String(),
                        Procedures = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StroreItemFeedItemMixings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StoreItemId = c.Int(nullable: false),
                        MixingFeedItemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Suppleirs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StoreItems", "StroreItemFeedItemMixing_Id", "dbo.StroreItemFeedItemMixings");
            DropForeignKey("dbo.FeedItemMixings", "StroreItemFeedItemMixing_Id", "dbo.StroreItemFeedItemMixings");
            DropForeignKey("dbo.StoreItems", "ConsumptionStoreItem_Id", "dbo.ConsumptionStoreItems");
            DropForeignKey("dbo.SupplyingItems", "StoreItem_Id", "dbo.StoreItems");
            DropForeignKey("dbo.Supplyings", "SupplyingItem_Id", "dbo.SupplyingItems");
            DropForeignKey("dbo.Supplyings", "Supplying_Id", "dbo.Supplyings");
            DropForeignKey("dbo.Items", "SupplyingItem_Id", "dbo.SupplyingItems");
            DropForeignKey("dbo.Stores", "StoreItem_Id", "dbo.StoreItems");
            DropForeignKey("dbo.Hingars", "Store_Id", "dbo.Stores");
            DropForeignKey("dbo.Productions", "StoreItem_Id", "dbo.StoreItems");
            DropForeignKey("dbo.Troops", "Production_Id", "dbo.Productions");
            DropForeignKey("dbo.Items", "Production_Id", "dbo.Productions");
            DropForeignKey("dbo.FeedItemMixings", "StoreItem_Id", "dbo.StoreItems");
            DropForeignKey("dbo.Mixings", "FeedItemMixing_Id", "dbo.FeedItemMixings");
            DropForeignKey("dbo.FeedItems", "FeedItemMixing_Id", "dbo.FeedItemMixings");
            DropForeignKey("dbo.Consumptions", "ConsumptionStoreItem_Id", "dbo.ConsumptionStoreItems");
            DropForeignKey("dbo.Troops", "Consumption_Id", "dbo.Consumptions");
            DropForeignKey("dbo.Machines", "Conservation_Id", "dbo.Conservations");
            DropForeignKey("dbo.Vaccines", "CheckVaccine_Id", "dbo.CheckVaccines");
            DropForeignKey("dbo.Checks", "CheckVaccine_Id", "dbo.CheckVaccines");
            DropForeignKey("dbo.Troops", "Check_Id", "dbo.Checks");
            DropIndex("dbo.Supplyings", new[] { "SupplyingItem_Id" });
            DropIndex("dbo.Supplyings", new[] { "Supplying_Id" });
            DropIndex("dbo.SupplyingItems", new[] { "StoreItem_Id" });
            DropIndex("dbo.Hingars", new[] { "Store_Id" });
            DropIndex("dbo.Stores", new[] { "StoreItem_Id" });
            DropIndex("dbo.Items", new[] { "SupplyingItem_Id" });
            DropIndex("dbo.Items", new[] { "Production_Id" });
            DropIndex("dbo.Productions", new[] { "StoreItem_Id" });
            DropIndex("dbo.Mixings", new[] { "FeedItemMixing_Id" });
            DropIndex("dbo.FeedItems", new[] { "FeedItemMixing_Id" });
            DropIndex("dbo.FeedItemMixings", new[] { "StroreItemFeedItemMixing_Id" });
            DropIndex("dbo.FeedItemMixings", new[] { "StoreItem_Id" });
            DropIndex("dbo.StoreItems", new[] { "StroreItemFeedItemMixing_Id" });
            DropIndex("dbo.StoreItems", new[] { "ConsumptionStoreItem_Id" });
            DropIndex("dbo.Consumptions", new[] { "ConsumptionStoreItem_Id" });
            DropIndex("dbo.Machines", new[] { "Conservation_Id" });
            DropIndex("dbo.Vaccines", new[] { "CheckVaccine_Id" });
            DropIndex("dbo.Troops", new[] { "Production_Id" });
            DropIndex("dbo.Troops", new[] { "Consumption_Id" });
            DropIndex("dbo.Troops", new[] { "Check_Id" });
            DropIndex("dbo.Checks", new[] { "CheckVaccine_Id" });
            DropTable("dbo.Suppleirs");
            DropTable("dbo.StroreItemFeedItemMixings");
            DropTable("dbo.Preparations");
            DropTable("dbo.HingarTroops");
            DropTable("dbo.Supplyings");
            DropTable("dbo.SupplyingItems");
            DropTable("dbo.Hingars");
            DropTable("dbo.Stores");
            DropTable("dbo.Items");
            DropTable("dbo.Productions");
            DropTable("dbo.Mixings");
            DropTable("dbo.FeedItems");
            DropTable("dbo.FeedItemMixings");
            DropTable("dbo.StoreItems");
            DropTable("dbo.ConsumptionStoreItems");
            DropTable("dbo.Consumptions");
            DropTable("dbo.Machines");
            DropTable("dbo.Conservations");
            DropTable("dbo.Vaccines");
            DropTable("dbo.CheckVaccines");
            DropTable("dbo.Troops");
            DropTable("dbo.Checks");
        }
    }
}
