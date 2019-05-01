namespace Hennery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uoo : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Stores", "Troop_Id", "dbo.Troops");
            DropIndex("dbo.Stores", new[] { "Troop_Id" });
            DropColumn("dbo.Stores", "Troop_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Stores", "Troop_Id", c => c.Int());
            CreateIndex("dbo.Stores", "Troop_Id");
            AddForeignKey("dbo.Stores", "Troop_Id", "dbo.Troops", "Id");
        }
    }
}
