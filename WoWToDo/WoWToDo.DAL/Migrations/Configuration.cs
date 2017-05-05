using WoWToDo.Common;

namespace WoWToDo.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WowContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WowContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            this.AddGameClasses(context);
        }

        private void AddGameClasses(WowContext context)
        {
            if (!context.Set<GameClass>().Any())
            {
                context.Set<GameClass>().AddOrUpdate(new GameClass() { Name = "Warrior", NameRu = "����" });
                context.Set<GameClass>().AddOrUpdate(new GameClass() { Name = "Paladin", NameRu = "�������" });
                context.Set<GameClass>().AddOrUpdate(new GameClass() { Name = "Hunter", NameRu = "�������" });
                context.Set<GameClass>().AddOrUpdate(new GameClass() { Name = "Rogue", NameRu = "���������" });
                context.Set<GameClass>().AddOrUpdate(new GameClass() { Name = "Priest", NameRu = "����" });
                context.Set<GameClass>().AddOrUpdate(new GameClass() { Name = "Death Knight", NameRu = "������ ������" });
                context.Set<GameClass>().AddOrUpdate(new GameClass() { Name = "Shaman", NameRu = "�����" });
                context.Set<GameClass>().AddOrUpdate(new GameClass() { Name = "Mage", NameRu = "���" });
                context.Set<GameClass>().AddOrUpdate(new GameClass() { Name = "Warlock", NameRu = "������������" });
                context.Set<GameClass>().AddOrUpdate(new GameClass() { Name = "Monk", NameRu = "�����" });
                context.Set<GameClass>().AddOrUpdate(new GameClass() { Name = "Druid", NameRu = "�����" });
                context.Set<GameClass>().AddOrUpdate(new GameClass() { Name = "Demon Hunter", NameRu = "������� �� �������" });
            }
        }
    }
}
