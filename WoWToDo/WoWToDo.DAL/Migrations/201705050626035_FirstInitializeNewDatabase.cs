namespace WoWToDo.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstInitializeNewDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DailyTasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonageId = c.Int(nullable: false),
                        TaskToDoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GameClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NameRu = c.String(),
                        Icon = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Personages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Level = c.Int(nullable: false),
                        GameClassId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TaskToDoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TaskName = c.String(),
                        IsChecked = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WeeklyTasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonageId = c.Int(nullable: false),
                        TaskToDoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WeeklyTasks");
            DropTable("dbo.TaskToDoes");
            DropTable("dbo.Personages");
            DropTable("dbo.GameClasses");
            DropTable("dbo.DailyTasks");
        }
    }
}
