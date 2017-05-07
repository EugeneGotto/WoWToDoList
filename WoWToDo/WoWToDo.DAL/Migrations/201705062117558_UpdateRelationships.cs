namespace WoWToDo.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateRelationships : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DailyTasks", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.GameClasses", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Personages", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.TaskToDoes", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.WeeklyTasks", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WeeklyTasks", "IsDeleted");
            DropColumn("dbo.TaskToDoes", "IsDeleted");
            DropColumn("dbo.Personages", "IsDeleted");
            DropColumn("dbo.GameClasses", "IsDeleted");
            DropColumn("dbo.DailyTasks", "IsDeleted");
        }
    }
}
