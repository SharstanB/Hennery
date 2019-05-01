namespace Hennery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upjtpyr : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vaccines", "ItemId", c => c.Int(nullable: false));
            CreateIndex("dbo.Vaccines", "ItemId", unique: true);
            AddForeignKey("dbo.Vaccines", "ItemId", "dbo.Items", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vaccines", "ItemId", "dbo.Items");
            DropIndex("dbo.Vaccines", new[] { "ItemId" });
            DropColumn("dbo.Vaccines", "ItemId");
        }
    }
}
