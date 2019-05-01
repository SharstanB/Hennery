namespace Hennery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upjtpyrp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Checks", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.CheckVaccines", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Vaccines", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Items", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Productions", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.StoreItems", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.ConsumptionStoreItems", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Consumptions", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Troops", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.HingarTroops", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Hingars", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Preparations", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Stores", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.SupplyingItems", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Supplyings", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Suppleirs", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.FeedItemMixings", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.FeedItems", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Mixings", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.StroreItemFeedItemMixings", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Conservations", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Machines", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Machines", "IsDeleted");
            DropColumn("dbo.Conservations", "IsDeleted");
            DropColumn("dbo.StroreItemFeedItemMixings", "IsDeleted");
            DropColumn("dbo.Mixings", "IsDeleted");
            DropColumn("dbo.FeedItems", "IsDeleted");
            DropColumn("dbo.FeedItemMixings", "IsDeleted");
            DropColumn("dbo.Suppleirs", "IsDeleted");
            DropColumn("dbo.Supplyings", "IsDeleted");
            DropColumn("dbo.SupplyingItems", "IsDeleted");
            DropColumn("dbo.Stores", "IsDeleted");
            DropColumn("dbo.Preparations", "IsDeleted");
            DropColumn("dbo.Hingars", "IsDeleted");
            DropColumn("dbo.HingarTroops", "IsDeleted");
            DropColumn("dbo.Troops", "IsDeleted");
            DropColumn("dbo.Consumptions", "IsDeleted");
            DropColumn("dbo.ConsumptionStoreItems", "IsDeleted");
            DropColumn("dbo.StoreItems", "IsDeleted");
            DropColumn("dbo.Productions", "IsDeleted");
            DropColumn("dbo.Items", "IsDeleted");
            DropColumn("dbo.Vaccines", "IsDeleted");
            DropColumn("dbo.CheckVaccines", "IsDeleted");
            DropColumn("dbo.Checks", "IsDeleted");
        }
    }
}
