namespace Hennery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upjt : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FeedItemMixings", "FeedItem_Id", "dbo.FeedItems");
            DropIndex("dbo.FeedItemMixings", new[] { "FeedItem_Id" });
            RenameColumn(table: "dbo.FeedItemMixings", name: "FeedItem_Id", newName: "FeedItemId");
            AddColumn("dbo.Machines", "SupplyingItemId", c => c.Int(nullable: false));
            AddColumn("dbo.StoreItems", "FeedItemMixing_Id", c => c.Int());
            AddColumn("dbo.FeedItemMixings", "MixingId", c => c.Int(nullable: false));
            AddColumn("dbo.HingarTroops", "HingarId", c => c.Int(nullable: false));
            AddColumn("dbo.HingarTroops", "TroopId", c => c.Int(nullable: false));
            AddColumn("dbo.Preparations", "Hingar_Id", c => c.Int());
            AddColumn("dbo.Productions", "Item_Id", c => c.Int());
            AddColumn("dbo.Stores", "Hingar_Id", c => c.Int());
            AddColumn("dbo.StroreItemFeedItemMixings", "FeedItemMixing_Id", c => c.Int());
            AddColumn("dbo.SupplyingItems", "Item_Id", c => c.Int());
            AlterColumn("dbo.FeedItemMixings", "FeedItemId", c => c.Int(nullable: false));
            AlterColumn("dbo.HingarTroops", "Count", c => c.Int(nullable: false));
            CreateIndex("dbo.Machines", "SupplyingItemId", unique: true);
            CreateIndex("dbo.SupplyingItems", "Item_Id");
            CreateIndex("dbo.StoreItems", "FeedItemMixing_Id");
            CreateIndex("dbo.FeedItemMixings", "MixingId");
            CreateIndex("dbo.FeedItemMixings", "FeedItemId");
            CreateIndex("dbo.Productions", "Item_Id");
            CreateIndex("dbo.StroreItemFeedItemMixings", "FeedItemMixing_Id");
            CreateIndex("dbo.HingarTroops", "HingarId");
            CreateIndex("dbo.HingarTroops", "TroopId");
            CreateIndex("dbo.Preparations", "Hingar_Id");
            CreateIndex("dbo.Stores", "Hingar_Id");
            AddForeignKey("dbo.Machines", "SupplyingItemId", "dbo.SupplyingItems", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Productions", "Item_Id", "dbo.Items", "Id");
            AddForeignKey("dbo.SupplyingItems", "Item_Id", "dbo.Items", "Id");
            AddForeignKey("dbo.FeedItemMixings", "MixingId", "dbo.Mixings", "Id", cascadeDelete: true);
            AddForeignKey("dbo.StoreItems", "FeedItemMixing_Id", "dbo.FeedItemMixings", "Id");
            AddForeignKey("dbo.StroreItemFeedItemMixings", "FeedItemMixing_Id", "dbo.FeedItemMixings", "Id");
            AddForeignKey("dbo.HingarTroops", "HingarId", "dbo.Hingars", "Id", cascadeDelete: true);
            AddForeignKey("dbo.HingarTroops", "TroopId", "dbo.Troops", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Preparations", "Hingar_Id", "dbo.Hingars", "Id");
            AddForeignKey("dbo.Stores", "Hingar_Id", "dbo.Hingars", "Id");
            AddForeignKey("dbo.FeedItemMixings", "FeedItemId", "dbo.FeedItems", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FeedItemMixings", "FeedItemId", "dbo.FeedItems");
            DropForeignKey("dbo.Stores", "Hingar_Id", "dbo.Hingars");
            DropForeignKey("dbo.Preparations", "Hingar_Id", "dbo.Hingars");
            DropForeignKey("dbo.HingarTroops", "TroopId", "dbo.Troops");
            DropForeignKey("dbo.HingarTroops", "HingarId", "dbo.Hingars");
            DropForeignKey("dbo.StroreItemFeedItemMixings", "FeedItemMixing_Id", "dbo.FeedItemMixings");
            DropForeignKey("dbo.StoreItems", "FeedItemMixing_Id", "dbo.FeedItemMixings");
            DropForeignKey("dbo.FeedItemMixings", "MixingId", "dbo.Mixings");
            DropForeignKey("dbo.SupplyingItems", "Item_Id", "dbo.Items");
            DropForeignKey("dbo.Productions", "Item_Id", "dbo.Items");
            DropForeignKey("dbo.Machines", "SupplyingItemId", "dbo.SupplyingItems");
            DropIndex("dbo.Stores", new[] { "Hingar_Id" });
            DropIndex("dbo.Preparations", new[] { "Hingar_Id" });
            DropIndex("dbo.HingarTroops", new[] { "TroopId" });
            DropIndex("dbo.HingarTroops", new[] { "HingarId" });
            DropIndex("dbo.StroreItemFeedItemMixings", new[] { "FeedItemMixing_Id" });
            DropIndex("dbo.Productions", new[] { "Item_Id" });
            DropIndex("dbo.FeedItemMixings", new[] { "FeedItemId" });
            DropIndex("dbo.FeedItemMixings", new[] { "MixingId" });
            DropIndex("dbo.StoreItems", new[] { "FeedItemMixing_Id" });
            DropIndex("dbo.SupplyingItems", new[] { "Item_Id" });
            DropIndex("dbo.Machines", new[] { "SupplyingItemId" });
            AlterColumn("dbo.HingarTroops", "Count", c => c.Int());
            AlterColumn("dbo.FeedItemMixings", "FeedItemId", c => c.Int());
            DropColumn("dbo.SupplyingItems", "Item_Id");
            DropColumn("dbo.StroreItemFeedItemMixings", "FeedItemMixing_Id");
            DropColumn("dbo.Stores", "Hingar_Id");
            DropColumn("dbo.Productions", "Item_Id");
            DropColumn("dbo.Preparations", "Hingar_Id");
            DropColumn("dbo.HingarTroops", "TroopId");
            DropColumn("dbo.HingarTroops", "HingarId");
            DropColumn("dbo.FeedItemMixings", "MixingId");
            DropColumn("dbo.StoreItems", "FeedItemMixing_Id");
            DropColumn("dbo.Machines", "SupplyingItemId");
            RenameColumn(table: "dbo.FeedItemMixings", name: "FeedItemId", newName: "FeedItem_Id");
            CreateIndex("dbo.FeedItemMixings", "FeedItem_Id");
            AddForeignKey("dbo.FeedItemMixings", "FeedItem_Id", "dbo.FeedItems", "Id");
        }
    }
}
