using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Mime;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WoWToDo.Common;
using WoWToDo.DAL.Migrations;

namespace WoWToDo.DAL
{
    public class WowContext : DbContext
    {
        public WowContext() : base("TasksConnection")
        {
            
            AppDomain.CurrentDomain.SetData("DataDirectory", AppDomain.CurrentDomain.BaseDirectory);
            Database.SetInitializer(new CreateDatabaseIfNotExists<WowContext>());
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<WowContext, Configuration>());
        }

        public DbSet<Personage> Personages { get; set; }
        public DbSet<GameClass> GameClasses { get; set; }
        public DbSet<TaskToDo> TaskToDos { get; set; }
        public DbSet<DailyTask> DailyTasks { get; set; }
        public DbSet<WeeklyTask> WeeklyTasks { get; set; }
    }
}
