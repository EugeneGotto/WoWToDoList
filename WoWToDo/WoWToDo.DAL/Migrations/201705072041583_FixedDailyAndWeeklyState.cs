namespace WoWToDo.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedDailyAndWeeklyState : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DailyTasks", "IsChecked", c => c.Boolean(nullable: false));
            AddColumn("dbo.WeeklyTasks", "IsChecked", c => c.Boolean(nullable: false));
            DropColumn("dbo.TaskToDoes", "IsChecked");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TaskToDoes", "IsChecked", c => c.Boolean(nullable: false));
            DropColumn("dbo.WeeklyTasks", "IsChecked");
            DropColumn("dbo.DailyTasks", "IsChecked");
        }
    }
}
