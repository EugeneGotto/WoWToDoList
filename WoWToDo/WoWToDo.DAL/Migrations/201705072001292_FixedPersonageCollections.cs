namespace WoWToDo.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedPersonageCollections : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TaskToDoes", "Personage_Id", c => c.Int());
            AddColumn("dbo.TaskToDoes", "Personage_Id1", c => c.Int());
            CreateIndex("dbo.TaskToDoes", "Personage_Id");
            CreateIndex("dbo.TaskToDoes", "Personage_Id1");
            AddForeignKey("dbo.TaskToDoes", "Personage_Id", "dbo.Personages", "Id");
            AddForeignKey("dbo.TaskToDoes", "Personage_Id1", "dbo.Personages", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TaskToDoes", "Personage_Id1", "dbo.Personages");
            DropForeignKey("dbo.TaskToDoes", "Personage_Id", "dbo.Personages");
            DropIndex("dbo.TaskToDoes", new[] { "Personage_Id1" });
            DropIndex("dbo.TaskToDoes", new[] { "Personage_Id" });
            DropColumn("dbo.TaskToDoes", "Personage_Id1");
            DropColumn("dbo.TaskToDoes", "Personage_Id");
        }
    }
}
