namespace Hennery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upjtp : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Checks", "TroopId", "dbo.Troops");
            DropForeignKey("dbo.Consumptions", "TroopId", "dbo.Troops");
            DropForeignKey("dbo.StroreItemFeedItemMixings", "FeedItemMixing_Id", "dbo.FeedItemMixings");
            DropForeignKey("dbo.Productions", "Item_Id", "dbo.Items");
            DropForeignKey("dbo.Preparations", "Hingar_Id", "dbo.Hingars");
            DropForeignKey("dbo.Stores", "Hingar_Id", "dbo.Hingars");
            DropIndex("dbo.Checks", new[] { "TroopId" });
            DropIndex("dbo.Consumptions", new[] { "TroopId" });
            DropIndex("dbo.Productions", new[] { "Item_Id" });
            DropIndex("dbo.StroreItemFeedItemMixings", new[] { "FeedItemMixing_Id" });
            DropIndex("dbo.Preparations", new[] { "Hingar_Id" });
            DropIndex("dbo.Stores", new[] { "Hingar_Id" });
            RenameColumn(table: "dbo.StoreItems", name: "FeedItemMixing_Id", newName: "FeedItemMixingId");
            RenameColumn(table: "dbo.StroreItemFeedItemMixings", name: "FeedItemMixing_Id", newName: "FeedItemMixingId");
            RenameColumn(table: "dbo.Productions", name: "Item_Id", newName: "ItemId");
            RenameColumn(table: "dbo.SupplyingItems", name: "Item_Id", newName: "ItemId");
            RenameColumn(table: "dbo.Preparations", name: "Hingar_Id", newName: "HingarId");
            RenameColumn(table: "dbo.Stores", name: "Hingar_Id", newName: "HingarId");
            RenameIndex(table: "dbo.StoreItems", name: "IX_FeedItemMixing_Id", newName: "IX_FeedItemMixingId");
            RenameIndex(table: "dbo.SupplyingItems", name: "IX_Item_Id", newName: "IX_ItemId");
            AddColumn("dbo.Troops", "SupplyingItemId", c => c.Int(nullable: false));
            AddColumn("dbo.SupplyingItems", "SupplyingId", c => c.Int());
            AddColumn("dbo.StoreItems", "ProductionId", c => c.Int());
            AddColumn("dbo.StoreItems", "SupplingItemId", c => c.Int());
            AddColumn("dbo.StoreItems", "StoreId", c => c.Int());
            AddColumn("dbo.StoreItems", "SupplyingItem_Id", c => c.Int());
            AddColumn("dbo.Productions", "TroopId", c => c.Int(nullable: false));
            AddColumn("dbo.StroreItemFeedItemMixings", "StoreItemId", c => c.Int(nullable: false));
            AddColumn("dbo.Hingars", "Troop_Id", c => c.Int());
            AddColumn("dbo.Supplyings", "SuppleirId", c => c.Int());
            AlterColumn("dbo.Checks", "CheckDate", c => c.DateTime());
            AlterColumn("dbo.Checks", "TroopId", c => c.Int());
            AlterColumn("dbo.Consumptions", "ConsumptionDate", c => c.DateTime());
            AlterColumn("dbo.Consumptions", "TroopId", c => c.Int());
            AlterColumn("dbo.FeedItems", "Temperature", c => c.Int());
            AlterColumn("dbo.FeedItems", "Humidity", c => c.Int());
            AlterColumn("dbo.Productions", "ItemId", c => c.Int(nullable: false));
            AlterColumn("dbo.StroreItemFeedItemMixings", "FeedItemMixingId", c => c.Int(nullable: false));
            AlterColumn("dbo.Preparations", "HingarId", c => c.Int(nullable: false));
            AlterColumn("dbo.Stores", "HingarId", c => c.Int(nullable: false));
            CreateIndex("dbo.Checks", "TroopId");
            CreateIndex("dbo.Troops", "SupplyingItemId", unique: true);
            CreateIndex("dbo.Consumptions", "TroopId");
            CreateIndex("dbo.StoreItems", "ProductionId");
            CreateIndex("dbo.StoreItems", "StoreId");
            CreateIndex("dbo.StoreItems", "SupplyingItem_Id");
            CreateIndex("dbo.Productions", "ItemId");
            CreateIndex("dbo.Productions", "TroopId");
            CreateIndex("dbo.SupplyingItems", "SupplyingId");
            CreateIndex("dbo.Supplyings", "SuppleirId");
            CreateIndex("dbo.StroreItemFeedItemMixings", "StoreItemId");
            CreateIndex("dbo.StroreItemFeedItemMixings", "FeedItemMixingId");
            CreateIndex("dbo.Stores", "HingarId");
            CreateIndex("dbo.Hingars", "Troop_Id");
            CreateIndex("dbo.Preparations", "HingarId");
            AddForeignKey("dbo.StoreItems", "ProductionId", "dbo.Productions", "Id");
            AddForeignKey("dbo.Productions", "TroopId", "dbo.Troops", "Id", cascadeDelete: true);
            AddForeignKey("dbo.StoreItems", "SupplyingItem_Id", "dbo.SupplyingItems", "Id");
            AddForeignKey("dbo.Supplyings", "SuppleirId", "dbo.Suppleirs", "Id");
            AddForeignKey("dbo.SupplyingItems", "SupplyingId", "dbo.Supplyings", "Id");
            AddForeignKey("dbo.StroreItemFeedItemMixings", "StoreItemId", "dbo.StoreItems", "Id", cascadeDelete: true);
            AddForeignKey("dbo.StoreItems", "StoreId", "dbo.Stores", "Id");
            AddForeignKey("dbo.Hingars", "Troop_Id", "dbo.Troops", "Id");
            AddForeignKey("dbo.Troops", "SupplyingItemId", "dbo.SupplyingItems", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Checks", "TroopId", "dbo.Troops", "Id");
            AddForeignKey("dbo.Consumptions", "TroopId", "dbo.Troops", "Id");
            AddForeignKey("dbo.StroreItemFeedItemMixings", "FeedItemMixingId", "dbo.FeedItemMixings", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Productions", "ItemId", "dbo.Items", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Preparations", "HingarId", "dbo.Hingars", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Stores", "HingarId", "dbo.Hingars", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stores", "HingarId", "dbo.Hingars");
            DropForeignKey("dbo.Preparations", "HingarId", "dbo.Hingars");
            DropForeignKey("dbo.Productions", "ItemId", "dbo.Items");
            DropForeignKey("dbo.StroreItemFeedItemMixings", "FeedItemMixingId", "dbo.FeedItemMixings");
            DropForeignKey("dbo.Consumptions", "TroopId", "dbo.Troops");
            DropForeignKey("dbo.Checks", "TroopId", "dbo.Troops");
            DropForeignKey("dbo.Troops", "SupplyingItemId", "dbo.SupplyingItems");
            DropForeignKey("dbo.Hingars", "Troop_Id", "dbo.Troops");
            DropForeignKey("dbo.StoreItems", "StoreId", "dbo.Stores");
            DropForeignKey("dbo.StroreItemFeedItemMixings", "StoreItemId", "dbo.StoreItems");
            DropForeignKey("dbo.SupplyingItems", "SupplyingId", "dbo.Supplyings");
            DropForeignKey("dbo.Supplyings", "SuppleirId", "dbo.Suppleirs");
            DropForeignKey("dbo.StoreItems", "SupplyingItem_Id", "dbo.SupplyingItems");
            DropForeignKey("dbo.Productions", "TroopId", "dbo.Troops");
            DropForeignKey("dbo.StoreItems", "ProductionId", "dbo.Productions");
            DropIndex("dbo.Preparations", new[] { "HingarId" });
            DropIndex("dbo.Hingars", new[] { "Troop_Id" });
            DropIndex("dbo.Stores", new[] { "HingarId" });
            DropIndex("dbo.StroreItemFeedItemMixings", new[] { "FeedItemMixingId" });
            DropIndex("dbo.StroreItemFeedItemMixings", new[] { "StoreItemId" });
            DropIndex("dbo.Supplyings", new[] { "SuppleirId" });
            DropIndex("dbo.SupplyingItems", new[] { "SupplyingId" });
            DropIndex("dbo.Productions", new[] { "TroopId" });
            DropIndex("dbo.Productions", new[] { "ItemId" });
            DropIndex("dbo.StoreItems", new[] { "SupplyingItem_Id" });
            DropIndex("dbo.StoreItems", new[] { "StoreId" });
            DropIndex("dbo.StoreItems", new[] { "ProductionId" });
            DropIndex("dbo.Consumptions", new[] { "TroopId" });
            DropIndex("dbo.Troops", new[] { "SupplyingItemId" });
            DropIndex("dbo.Checks", new[] { "TroopId" });
            AlterColumn("dbo.Stores", "HingarId", c => c.Int());
            AlterColumn("dbo.Preparations", "HingarId", c => c.Int());
            AlterColumn("dbo.StroreItemFeedItemMixings", "FeedItemMixingId", c => c.Int());
            AlterColumn("dbo.Productions", "ItemId", c => c.Int());
            AlterColumn("dbo.FeedItems", "Humidity", c => c.Int(nullable: false));
            AlterColumn("dbo.FeedItems", "Temperature", c => c.Int(nullable: false));
            AlterColumn("dbo.Consumptions", "TroopId", c => c.Int(nullable: false));
            AlterColumn("dbo.Consumptions", "ConsumptionDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Checks", "TroopId", c => c.Int(nullable: false));
            AlterColumn("dbo.Checks", "CheckDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Supplyings", "SuppleirId");
            DropColumn("dbo.Hingars", "Troop_Id");
            DropColumn("dbo.StroreItemFeedItemMixings", "StoreItemId");
            DropColumn("dbo.Productions", "TroopId");
            DropColumn("dbo.StoreItems", "SupplyingItem_Id");
            DropColumn("dbo.StoreItems", "StoreId");
            DropColumn("dbo.StoreItems", "SupplingItemId");
            DropColumn("dbo.StoreItems", "ProductionId");
            DropColumn("dbo.SupplyingItems", "SupplyingId");
            DropColumn("dbo.Troops", "SupplyingItemId");
            RenameIndex(table: "dbo.SupplyingItems", name: "IX_ItemId", newName: "IX_Item_Id");
            RenameIndex(table: "dbo.StoreItems", name: "IX_FeedItemMixingId", newName: "IX_FeedItemMixing_Id");
            RenameColumn(table: "dbo.Stores", name: "HingarId", newName: "Hingar_Id");
            RenameColumn(table: "dbo.Preparations", name: "HingarId", newName: "Hingar_Id");
            RenameColumn(table: "dbo.SupplyingItems", name: "ItemId", newName: "Item_Id");
            RenameColumn(table: "dbo.Productions", name: "ItemId", newName: "Item_Id");
            RenameColumn(table: "dbo.StroreItemFeedItemMixings", name: "FeedItemMixingId", newName: "FeedItemMixing_Id");
            RenameColumn(table: "dbo.StoreItems", name: "FeedItemMixingId", newName: "FeedItemMixing_Id");
            CreateIndex("dbo.Stores", "Hingar_Id");
            CreateIndex("dbo.Preparations", "Hingar_Id");
            CreateIndex("dbo.StroreItemFeedItemMixings", "FeedItemMixing_Id");
            CreateIndex("dbo.Productions", "Item_Id");
            CreateIndex("dbo.Consumptions", "TroopId");
            CreateIndex("dbo.Checks", "TroopId");
            AddForeignKey("dbo.Stores", "Hingar_Id", "dbo.Hingars", "Id");
            AddForeignKey("dbo.Preparations", "Hingar_Id", "dbo.Hingars", "Id");
            AddForeignKey("dbo.Productions", "Item_Id", "dbo.Items", "Id");
            AddForeignKey("dbo.StroreItemFeedItemMixings", "FeedItemMixing_Id", "dbo.FeedItemMixings", "Id");
            AddForeignKey("dbo.Consumptions", "TroopId", "dbo.Troops", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Checks", "TroopId", "dbo.Troops", "Id", cascadeDelete: true);
        }
    }
}