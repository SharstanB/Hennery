namespace Hennery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Troops", "Type", c => c.String(maxLength: 50));
            AlterColumn("dbo.CheckVaccines", "QuantityUnit", c => c.String(maxLength: 50));
            AlterColumn("dbo.Vaccines", "Type", c => c.String(maxLength: 50));
            AlterColumn("dbo.Conservations", "Type", c => c.String(maxLength: 50));
            AlterColumn("dbo.Conservations", "Procedures", c => c.String(maxLength: 100));
            AlterColumn("dbo.Consumptions", "Type", c => c.String(maxLength: 50));
            AlterColumn("dbo.ConsumptionStoreItems", "Quantity", c => c.Int());
            AlterColumn("dbo.ConsumptionStoreItems", "QuantityUnit", c => c.String(maxLength: 50));
            AlterColumn("dbo.StoreItems", "QuantityUnit", c => c.String(maxLength: 50));
            AlterColumn("dbo.FeedItems", "TemperatureUnit", c => c.String(maxLength: 50));
            AlterColumn("dbo.FeedItems", "HumidityUnit", c => c.String(maxLength: 50));
            AlterColumn("dbo.Productions", "Quantity", c => c.Int());
            AlterColumn("dbo.Productions", "QuantityUnit", c => c.String(maxLength: 50));
            AlterColumn("dbo.Items", "Name", c => c.String(maxLength: 50));
            AlterColumn("dbo.Items", "Type", c => c.String(maxLength: 50));
            AlterColumn("dbo.Stores", "StoreName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Stores", "TemperatureUnit", c => c.String(maxLength: 50));
            AlterColumn("dbo.Stores", "HumidityUnit", c => c.String(maxLength: 50));
            AlterColumn("dbo.Hingars", "Type", c => c.String(maxLength: 50));
            AlterColumn("dbo.SupplyingItems", "QuantityUnit", c => c.String(maxLength: 50));
            AlterColumn("dbo.HingarTroops", "Count", c => c.Int());
            AlterColumn("dbo.Preparations", "Notes", c => c.String(maxLength: 100));
            AlterColumn("dbo.Preparations", "Procedures", c => c.String(maxLength: 100));
            AlterColumn("dbo.Suppleirs", "Name", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Suppleirs", "Name", c => c.String());
            AlterColumn("dbo.Preparations", "Procedures", c => c.String());
            AlterColumn("dbo.Preparations", "Notes", c => c.String());
            AlterColumn("dbo.HingarTroops", "Count", c => c.Int(nullable: false));
            AlterColumn("dbo.SupplyingItems", "QuantityUnit", c => c.String());
            AlterColumn("dbo.Hingars", "Type", c => c.String());
            AlterColumn("dbo.Stores", "HumidityUnit", c => c.String());
            AlterColumn("dbo.Stores", "TemperatureUnit", c => c.String());
            AlterColumn("dbo.Stores", "StoreName", c => c.String());
            AlterColumn("dbo.Items", "Type", c => c.String());
            AlterColumn("dbo.Items", "Name", c => c.String());
            AlterColumn("dbo.Productions", "QuantityUnit", c => c.String());
            AlterColumn("dbo.Productions", "Quantity", c => c.Int(nullable: false));
            AlterColumn("dbo.FeedItems", "HumidityUnit", c => c.String());
            AlterColumn("dbo.FeedItems", "TemperatureUnit", c => c.String());
            AlterColumn("dbo.StoreItems", "QuantityUnit", c => c.String());
            AlterColumn("dbo.ConsumptionStoreItems", "QuantityUnit", c => c.String());
            AlterColumn("dbo.ConsumptionStoreItems", "Quantity", c => c.Int(nullable: false));
            AlterColumn("dbo.Consumptions", "Type", c => c.String());
            AlterColumn("dbo.Conservations", "Procedures", c => c.String());
            AlterColumn("dbo.Conservations", "Type", c => c.String());
            AlterColumn("dbo.Vaccines", "Type", c => c.String());
            AlterColumn("dbo.CheckVaccines", "QuantityUnit", c => c.String());
            AlterColumn("dbo.Troops", "Type", c => c.String());
        }
    }
}
