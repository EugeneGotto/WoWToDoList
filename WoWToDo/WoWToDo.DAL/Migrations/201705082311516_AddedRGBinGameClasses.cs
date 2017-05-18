namespace WoWToDo.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRGBinGameClasses : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GameClasses", "Red", c => c.Int(nullable: false));
            AddColumn("dbo.GameClasses", "Green", c => c.Int(nullable: false));
            AddColumn("dbo.GameClasses", "Blue", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.GameClasses", "Blue");
            DropColumn("dbo.GameClasses", "Green");
            DropColumn("dbo.GameClasses", "Red");
        }
    }
}
