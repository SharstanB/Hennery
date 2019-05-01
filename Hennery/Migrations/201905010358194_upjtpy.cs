namespace Hennery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upjtpy : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Hingars", "Troop_Id", "dbo.Troops");
            DropIndex("dbo.Hingars", new[] { "Troop_Id" });
            DropColumn("dbo.Hingars", "Troop_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Hingars", "Troop_Id", c => c.Int());
            CreateIndex("dbo.Hingars", "Troop_Id");
            AddForeignKey("dbo.Hingars", "Troop_Id", "dbo.Troops", "Id");
        }
    }
}
