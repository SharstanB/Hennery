namespace Hennery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class up : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Checks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CheckDate = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        TroopId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Troops", t => t.TroopId)
                .Index(t => t.TroopId);
            
            CreateTable(
                "dbo.CheckVaccines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        QuantityUnit = c.String(maxLength: 50),
                        IsDeleted = c.Boolean(nullable: false),
                        VaccineId = c.Int(),
                        CheckId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Checks", t => t.CheckId)
                .ForeignKey("dbo.Vaccines", t => t.VaccineId)
                .Index(t => t.VaccineId)
                .Index(t => t.CheckId);
            
            CreateTable(
                "dbo.Vaccines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsDeleted = c.Boolean(nullable: false),
                        ItemId = c.Int(nullable: false),
                        VaccineTypeId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.VaccineTypes", t => t.VaccineTypeId)
                .Index(t => t.ItemId, unique: true)
                .Index(t => t.VaccineTypeId);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FeedItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Temperature = c.String(),
                        Humidity = c.String(),
                        Light = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        ItemId = c.Int(nullable: false),
                        FeedItemTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FeedItemTypes", t => t.FeedItemTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .Index(t => t.ItemId)
                .Index(t => t.FeedItemTypeId);
            
            CreateTable(
                "dbo.FeedItemMixings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsDeleted = c.Boolean(nullable: false),
                        MixingId = c.Int(nullable: false),
                        FeedItemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FeedItems", t => t.FeedItemId, cascadeDelete: true)
                .ForeignKey("dbo.Mixings", t => t.MixingId, cascadeDelete: true)
                .Index(t => t.MixingId)
                .Index(t => t.FeedItemId);
            
            CreateTable(
                "dbo.Mixings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MixDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StoreItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        QuantityUnit = c.String(maxLength: 50),
                        IsDeleted = c.Boolean(nullable: false),
                        ProductionId = c.Int(),
                        SupplingItemId = c.Int(),
                        FeedItemMixingId = c.Int(),
                        StoreId = c.Int(),
                        SupplyingItem_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stores", t => t.StoreId)
                .ForeignKey("dbo.Productions", t => t.ProductionId)
                .ForeignKey("dbo.SupplyingItems", t => t.SupplyingItem_Id)
                .ForeignKey("dbo.FeedItemMixings", t => t.FeedItemMixingId)
                .Index(t => t.ProductionId)
                .Index(t => t.FeedItemMixingId)
                .Index(t => t.StoreId)
                .Index(t => t.SupplyingItem_Id);
            
            CreateTable(
                "dbo.ConsumptionStoreItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(),
                        QuantityUnit = c.String(maxLength: 50),
                        IsDeleted = c.Boolean(nullable: false),
                        StoreItemId = c.Int(nullable: false),
                        ConsumptionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Consumptions", t => t.ConsumptionId, cascadeDelete: true)
                .ForeignKey("dbo.StoreItems", t => t.StoreItemId, cascadeDelete: true)
                .Index(t => t.StoreItemId)
                .Index(t => t.ConsumptionId);
            
            CreateTable(
                "dbo.Consumptions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ConsumptionDate = c.DateTime(),
                        Type = c.String(maxLength: 50),
                        IsDeleted = c.Boolean(nullable: false),
                        TroopId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Troops", t => t.TroopId)
                .Index(t => t.TroopId);
            
            CreateTable(
                "dbo.Troops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TroopNum = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        Type = c.String(maxLength: 50),
                        IsDeleted = c.Boolean(nullable: false),
                        SupplyingItemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SupplyingItems", t => t.SupplyingItemId, cascadeDelete: true)
                .Index(t => t.SupplyingItemId, unique: true);
            
            CreateTable(
                "dbo.HingarTroops",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        IsDeleted = c.Boolean(nullable: false),
                        Count = c.Int(nullable: false),
                        HingarId = c.Int(nullable: false),
                        TroopId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Hingars", t => t.HingarId, cascadeDelete: true)
                .ForeignKey("dbo.Troops", t => t.TroopId, cascadeDelete: true)
                .Index(t => t.HingarId)
                .Index(t => t.TroopId);
            
            CreateTable(
                "dbo.Hingars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Capacity = c.Int(nullable: false),
                        Type = c.String(maxLength: 50),
                        IsDeleted = c.Boolean(nullable: false),
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
                        IsDeleted = c.Boolean(nullable: false),
                        HingarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hingars", t => t.HingarId, cascadeDelete: true)
                .Index(t => t.HingarId);
            
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StoreName = c.String(maxLength: 50),
                        Area = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Temperature = c.Int(nullable: false),
                        TemperatureUnit = c.String(maxLength: 50),
                        Humidity = c.Int(nullable: false),
                        HumidityUnit = c.String(maxLength: 50),
                        Light = c.Boolean(nullable: false),
                        HingarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hingars", t => t.HingarId, cascadeDelete: true)
                .Index(t => t.HingarId);
            
            CreateTable(
                "dbo.Productions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductionDate = c.DateTime(nullable: false),
                        Quantity = c.Int(),
                        QuantityUnit = c.String(maxLength: 50),
                        IsDeleted = c.Boolean(nullable: false),
                        ItemId = c.Int(nullable: false),
                        TroopId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.Troops", t => t.TroopId, cascadeDelete: true)
                .Index(t => t.ItemId)
                .Index(t => t.TroopId);
            
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
                        IsDeleted = c.Boolean(nullable: false),
                        ItemId = c.Int(),
                        SupplyingId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.ItemId)
                .ForeignKey("dbo.Supplyings", t => t.SupplyingId)
                .Index(t => t.ItemId)
                .Index(t => t.SupplyingId);
            
            CreateTable(
                "dbo.Machines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SequenceNumber = c.String(),
                        Company = c.String(),
                        Description = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        SupplyingItemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SupplyingItems", t => t.SupplyingItemId, cascadeDelete: true)
                .Index(t => t.SupplyingItemId, unique: true);
            
            CreateTable(
                "dbo.Conservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Type = c.String(maxLength: 50),
                        Procedures = c.String(maxLength: 100),
                        IsDeleted = c.Boolean(nullable: false),
                        MachineId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Machines", t => t.MachineId, cascadeDelete: true)
                .Index(t => t.MachineId);
            
            CreateTable(
                "dbo.Supplyings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SupplyingDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        SuppleirId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Suppleirs", t => t.SuppleirId)
                .Index(t => t.SuppleirId);
            
            CreateTable(
                "dbo.Suppleirs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        IsDeleted = c.Boolean(nullable: false),
                        Phone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StroreItemFeedItemMixings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsDeleted = c.Boolean(nullable: false),
                        StoreItemId = c.Int(nullable: false),
                        FeedItemMixingId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FeedItemMixings", t => t.FeedItemMixingId, cascadeDelete: true)
                .ForeignKey("dbo.StoreItems", t => t.StoreItemId, cascadeDelete: true)
                .Index(t => t.StoreItemId)
                .Index(t => t.FeedItemMixingId);
            
            CreateTable(
                "dbo.FeedItemTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FeedType = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VaccineTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        _VaccineType = c.String(maxLength: 50),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vaccines", "VaccineTypeId", "dbo.VaccineTypes");
            DropForeignKey("dbo.Vaccines", "ItemId", "dbo.Items");
            DropForeignKey("dbo.FeedItems", "ItemId", "dbo.Items");
            DropForeignKey("dbo.FeedItems", "FeedItemTypeId", "dbo.FeedItemTypes");
            DropForeignKey("dbo.StroreItemFeedItemMixings", "StoreItemId", "dbo.StoreItems");
            DropForeignKey("dbo.StroreItemFeedItemMixings", "FeedItemMixingId", "dbo.FeedItemMixings");
            DropForeignKey("dbo.StoreItems", "FeedItemMixingId", "dbo.FeedItemMixings");
            DropForeignKey("dbo.ConsumptionStoreItems", "StoreItemId", "dbo.StoreItems");
            DropForeignKey("dbo.Troops", "SupplyingItemId", "dbo.SupplyingItems");
            DropForeignKey("dbo.SupplyingItems", "SupplyingId", "dbo.Supplyings");
            DropForeignKey("dbo.Supplyings", "SuppleirId", "dbo.Suppleirs");
            DropForeignKey("dbo.StoreItems", "SupplyingItem_Id", "dbo.SupplyingItems");
            DropForeignKey("dbo.Machines", "SupplyingItemId", "dbo.SupplyingItems");
            DropForeignKey("dbo.Conservations", "MachineId", "dbo.Machines");
            DropForeignKey("dbo.SupplyingItems", "ItemId", "dbo.Items");
            DropForeignKey("dbo.Productions", "TroopId", "dbo.Troops");
            DropForeignKey("dbo.StoreItems", "ProductionId", "dbo.Productions");
            DropForeignKey("dbo.Productions", "ItemId", "dbo.Items");
            DropForeignKey("dbo.HingarTroops", "TroopId", "dbo.Troops");
            DropForeignKey("dbo.StoreItems", "StoreId", "dbo.Stores");
            DropForeignKey("dbo.Stores", "HingarId", "dbo.Hingars");
            DropForeignKey("dbo.Preparations", "HingarId", "dbo.Hingars");
            DropForeignKey("dbo.HingarTroops", "HingarId", "dbo.Hingars");
            DropForeignKey("dbo.Consumptions", "TroopId", "dbo.Troops");
            DropForeignKey("dbo.Checks", "TroopId", "dbo.Troops");
            DropForeignKey("dbo.ConsumptionStoreItems", "ConsumptionId", "dbo.Consumptions");
            DropForeignKey("dbo.FeedItemMixings", "MixingId", "dbo.Mixings");
            DropForeignKey("dbo.FeedItemMixings", "FeedItemId", "dbo.FeedItems");
            DropForeignKey("dbo.CheckVaccines", "VaccineId", "dbo.Vaccines");
            DropForeignKey("dbo.CheckVaccines", "CheckId", "dbo.Checks");
            DropIndex("dbo.StroreItemFeedItemMixings", new[] { "FeedItemMixingId" });
            DropIndex("dbo.StroreItemFeedItemMixings", new[] { "StoreItemId" });
            DropIndex("dbo.Supplyings", new[] { "SuppleirId" });
            DropIndex("dbo.Conservations", new[] { "MachineId" });
            DropIndex("dbo.Machines", new[] { "SupplyingItemId" });
            DropIndex("dbo.SupplyingItems", new[] { "SupplyingId" });
            DropIndex("dbo.SupplyingItems", new[] { "ItemId" });
            DropIndex("dbo.Productions", new[] { "TroopId" });
            DropIndex("dbo.Productions", new[] { "ItemId" });
            DropIndex("dbo.Stores", new[] { "HingarId" });
            DropIndex("dbo.Preparations", new[] { "HingarId" });
            DropIndex("dbo.HingarTroops", new[] { "TroopId" });
            DropIndex("dbo.HingarTroops", new[] { "HingarId" });
            DropIndex("dbo.Troops", new[] { "SupplyingItemId" });
            DropIndex("dbo.Consumptions", new[] { "TroopId" });
            DropIndex("dbo.ConsumptionStoreItems", new[] { "ConsumptionId" });
            DropIndex("dbo.ConsumptionStoreItems", new[] { "StoreItemId" });
            DropIndex("dbo.StoreItems", new[] { "SupplyingItem_Id" });
            DropIndex("dbo.StoreItems", new[] { "StoreId" });
            DropIndex("dbo.StoreItems", new[] { "FeedItemMixingId" });
            DropIndex("dbo.StoreItems", new[] { "ProductionId" });
            DropIndex("dbo.FeedItemMixings", new[] { "FeedItemId" });
            DropIndex("dbo.FeedItemMixings", new[] { "MixingId" });
            DropIndex("dbo.FeedItems", new[] { "FeedItemTypeId" });
            DropIndex("dbo.FeedItems", new[] { "ItemId" });
            DropIndex("dbo.Vaccines", new[] { "VaccineTypeId" });
            DropIndex("dbo.Vaccines", new[] { "ItemId" });
            DropIndex("dbo.CheckVaccines", new[] { "CheckId" });
            DropIndex("dbo.CheckVaccines", new[] { "VaccineId" });
            DropIndex("dbo.Checks", new[] { "TroopId" });
            DropTable("dbo.VaccineTypes");
            DropTable("dbo.FeedItemTypes");
            DropTable("dbo.StroreItemFeedItemMixings");
            DropTable("dbo.Suppleirs");
            DropTable("dbo.Supplyings");
            DropTable("dbo.Conservations");
            DropTable("dbo.Machines");
            DropTable("dbo.SupplyingItems");
            DropTable("dbo.Productions");
            DropTable("dbo.Stores");
            DropTable("dbo.Preparations");
            DropTable("dbo.Hingars");
            DropTable("dbo.HingarTroops");
            DropTable("dbo.Troops");
            DropTable("dbo.Consumptions");
            DropTable("dbo.ConsumptionStoreItems");
            DropTable("dbo.StoreItems");
            DropTable("dbo.Mixings");
            DropTable("dbo.FeedItemMixings");
            DropTable("dbo.FeedItems");
            DropTable("dbo.Items");
            DropTable("dbo.Vaccines");
            DropTable("dbo.CheckVaccines");
            DropTable("dbo.Checks");
        }
    }
}
