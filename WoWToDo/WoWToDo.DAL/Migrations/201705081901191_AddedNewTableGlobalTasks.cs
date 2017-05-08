namespace WoWToDo.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNewTableGlobalTasks : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GlobalTasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TaskName = c.String(),
                        IsDone = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GlobalTasks");
        }
    }
}
