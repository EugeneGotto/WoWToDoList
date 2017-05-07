namespace WoWToDo.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateRelationships_2 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.DailyTasks", "PersonageId");
            CreateIndex("dbo.DailyTasks", "TaskToDoId");
            CreateIndex("dbo.WeeklyTasks", "PersonageId");
            CreateIndex("dbo.WeeklyTasks", "TaskToDoId");
            AddForeignKey("dbo.DailyTasks", "PersonageId", "dbo.Personages", "Id", cascadeDelete: true);
            AddForeignKey("dbo.DailyTasks", "TaskToDoId", "dbo.TaskToDoes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.WeeklyTasks", "PersonageId", "dbo.Personages", "Id", cascadeDelete: true);
            AddForeignKey("dbo.WeeklyTasks", "TaskToDoId", "dbo.TaskToDoes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WeeklyTasks", "TaskToDoId", "dbo.TaskToDoes");
            DropForeignKey("dbo.WeeklyTasks", "PersonageId", "dbo.Personages");
            DropForeignKey("dbo.DailyTasks", "TaskToDoId", "dbo.TaskToDoes");
            DropForeignKey("dbo.DailyTasks", "PersonageId", "dbo.Personages");
            DropIndex("dbo.WeeklyTasks", new[] { "TaskToDoId" });
            DropIndex("dbo.WeeklyTasks", new[] { "PersonageId" });
            DropIndex("dbo.DailyTasks", new[] { "TaskToDoId" });
            DropIndex("dbo.DailyTasks", new[] { "PersonageId" });
        }
    }
}
