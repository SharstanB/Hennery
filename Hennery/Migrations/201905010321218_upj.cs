namespace Hennery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upj : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StoreItems", "Store_Id", "dbo.Stores");
            DropForeignKey("dbo.Supplyings", "SuppleirId", "dbo.Suppleirs");
            DropForeignKey("dbo.ConsumptionStoreItems", "Consumption_Id", "dbo.Consumptions");
            DropForeignKey("dbo.Consumptions", "Troop_Id", "dbo.Troops");
            DropIndex("dbo.Consumptions", new[] { "Troop_Id" });
            DropIndex("dbo.ConsumptionStoreItems", new[] { "Consumption_Id" });
            DropIndex("dbo.StoreItems", new[] { "Store_Id" });
            DropIndex("dbo.Supplyings", new[] { "SuppleirId" });
            RenameColumn(table: "dbo.ConsumptionStoreItems", name: "Consumption_Id", newName: "ConsumptionId");
            RenameColumn(table: "dbo.Consumptions", name: "Troop_Id", newName: "TroopId");
            AddColumn("dbo.CheckVaccines", "VaccineId", c => c.Int());
            AddColumn("dbo.CheckVaccines", "CheckId", c => c.Int());
            AddColumn("dbo.Conservations", "MachineId", c => c.Int(nullable: false));
            AddColumn("dbo.ConsumptionStoreItems", "StoreItemId", c => c.Int(nullable: false));
            AddColumn("dbo.FeedItemMixings", "FeedItem_Id", c => c.Int());
            AddColumn("dbo.FeedItems", "ItemId", c => c.Int(nullable: false));
            AlterColumn("dbo.Consumptions", "TroopId", c => c.Int(nullable: false));
            AlterColumn("dbo.ConsumptionStoreItems", "ConsumptionId", c => c.Int(nullable: false));
            CreateIndex("dbo.Checks", "TroopId");
            CreateIndex("dbo.CheckVaccines", "VaccineId");
            CreateIndex("dbo.CheckVaccines", "CheckId");
            CreateIndex("dbo.Conservations", "MachineId");
            CreateIndex("dbo.Consumptions", "TroopId");
            CreateIndex("dbo.ConsumptionStoreItems", "StoreItemId");
            CreateIndex("dbo.ConsumptionStoreItems", "ConsumptionId");
            CreateIndex("dbo.FeedItemMixings", "FeedItem_Id");
            CreateIndex("dbo.FeedItems", "ItemId", unique: true);
            AddForeignKey("dbo.CheckVaccines", "CheckId", "dbo.Checks", "Id");
            AddForeignKey("dbo.CheckVaccines", "VaccineId", "dbo.Vaccines", "Id");
            AddForeignKey("dbo.Checks", "TroopId", "dbo.Troops", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Conservations", "MachineId", "dbo.Machines", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ConsumptionStoreItems", "StoreItemId", "dbo.StoreItems", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FeedItemMixings", "FeedItem_Id", "dbo.FeedItems", "Id");
            AddForeignKey("dbo.FeedItems", "ItemId", "dbo.Items", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ConsumptionStoreItems", "ConsumptionId", "dbo.Consumptions", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Consumptions", "TroopId", "dbo.Troops", "Id", cascadeDelete: true);
            DropColumn("dbo.StoreItems", "Store_Id");
            DropColumn("dbo.Supplyings", "SuppleirId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Supplyings", "SuppleirId", c => c.Int());
            AddColumn("dbo.StoreItems", "Store_Id", c => c.Int());
            DropForeignKey("dbo.Consumptions", "TroopId", "dbo.Troops");
            DropForeignKey("dbo.ConsumptionStoreItems", "ConsumptionId", "dbo.Consumptions");
            DropForeignKey("dbo.FeedItems", "ItemId", "dbo.Items");
            DropForeignKey("dbo.FeedItemMixings", "FeedItem_Id", "dbo.FeedItems");
            DropForeignKey("dbo.ConsumptionStoreItems", "StoreItemId", "dbo.StoreItems");
            DropForeignKey("dbo.Conservations", "MachineId", "dbo.Machines");
            DropForeignKey("dbo.Checks", "TroopId", "dbo.Troops");
            DropForeignKey("dbo.CheckVaccines", "VaccineId", "dbo.Vaccines");
            DropForeignKey("dbo.CheckVaccines", "CheckId", "dbo.Checks");
            DropIndex("dbo.FeedItems", new[] { "ItemId" });
            DropIndex("dbo.FeedItemMixings", new[] { "FeedItem_Id" });
            DropIndex("dbo.ConsumptionStoreItems", new[] { "ConsumptionId" });
            DropIndex("dbo.ConsumptionStoreItems", new[] { "StoreItemId" });
            DropIndex("dbo.Consumptions", new[] { "TroopId" });
            DropIndex("dbo.Conservations", new[] { "MachineId" });
            DropIndex("dbo.CheckVaccines", new[] { "CheckId" });
            DropIndex("dbo.CheckVaccines", new[] { "VaccineId" });
            DropIndex("dbo.Checks", new[] { "TroopId" });
            AlterColumn("dbo.ConsumptionStoreItems", "ConsumptionId", c => c.Int());
            AlterColumn("dbo.Consumptions", "TroopId", c => c.Int());
            DropColumn("dbo.FeedItems", "ItemId");
            DropColumn("dbo.FeedItemMixings", "FeedItem_Id");
            DropColumn("dbo.ConsumptionStoreItems", "StoreItemId");
            DropColumn("dbo.Conservations", "MachineId");
            DropColumn("dbo.CheckVaccines", "CheckId");
            DropColumn("dbo.CheckVaccines", "VaccineId");
            RenameColumn(table: "dbo.Consumptions", name: "TroopId", newName: "Troop_Id");
            RenameColumn(table: "dbo.ConsumptionStoreItems", name: "ConsumptionId", newName: "Consumption_Id");
            CreateIndex("dbo.Supplyings", "SuppleirId");
            CreateIndex("dbo.StoreItems", "Store_Id");
            CreateIndex("dbo.ConsumptionStoreItems", "Consumption_Id");
            CreateIndex("dbo.Consumptions", "Troop_Id");
            AddForeignKey("dbo.Consumptions", "Troop_Id", "dbo.Troops", "Id");
            AddForeignKey("dbo.ConsumptionStoreItems", "Consumption_Id", "dbo.Consumptions", "Id");
            AddForeignKey("dbo.Supplyings", "SuppleirId", "dbo.Suppleirs", "Id");
            AddForeignKey("dbo.StoreItems", "Store_Id", "dbo.Stores", "Id");
        }
    }
}
