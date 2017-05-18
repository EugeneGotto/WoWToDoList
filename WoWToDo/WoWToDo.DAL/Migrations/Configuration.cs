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
                context.Set<GameClass>()
                    .AddOrUpdate(new GameClass()
                    {
                        Name = "Warrior",
                        NameRu = "Воин",
                        Red = 198,
                        Green = 155,
                        Blue = 109
                    });
                context.Set<GameClass>()
                    .AddOrUpdate(new GameClass()
                    {
                        Name = "Paladin",
                        NameRu = "Паладин",
                        Red = 244,
                        Green = 140,
                        Blue = 186
                    });
                context.Set<GameClass>()
                    .AddOrUpdate(new GameClass()
                    {
                        Name = "Hunter",
                        NameRu = "Охотник",
                        Red = 170,
                        Green = 211,
                        Blue = 114
                    });
                context.Set<GameClass>()
                    .AddOrUpdate(new GameClass()
                    {
                        Name = "Rogue",
                        NameRu = "Разбойник",
                        Red = 255,
                        Green = 244,
                        Blue = 104
                    });
                context.Set<GameClass>()
                    .AddOrUpdate(new GameClass()
                    {
                        Name = "Priest",
                        NameRu = "Жрец",
                        Red = 240,
                        Green = 235,
                        Blue = 224
                    });
                context.Set<GameClass>()
                    .AddOrUpdate(new GameClass()
                    {
                        Name = "Death Knight",
                        NameRu = "Рыцарь смерти",
                        Red = 196,
                        Green = 30,
                        Blue = 59
                    });
                context.Set<GameClass>()
                    .AddOrUpdate(new GameClass()
                    {
                        Name = "Shaman",
                        NameRu = "Шаман",
                        Red = 35,
                        Green = 89,
                        Blue = 255
                    });
                context.Set<GameClass>()
                    .AddOrUpdate(new GameClass()
                    {
                        Name = "Mage",
                        NameRu = "Маг",
                        Red = 104,
                        Green = 204,
                        Blue = 239
                    });
                context.Set<GameClass>()
                    .AddOrUpdate(new GameClass()
                    {
                        Name = "Warlock",
                        NameRu = "Чернокнижник",
                        Red = 147,
                        Green = 130,
                        Blue = 201
                    });
                context.Set<GameClass>()
                    .AddOrUpdate(new GameClass() {
                        Name = "Monk",
                        NameRu = "Монах",
                        Red = 0,
                        Green = 255,
                        Blue = 186
                    });
                context.Set<GameClass>()
                    .AddOrUpdate(new GameClass()
                    {
                        Name = "Druid",
                        NameRu = "Друид",
                        Red = 255,
                        Green = 124,
                        Blue = 10
                    });
                context.Set<GameClass>()
                    .AddOrUpdate(new GameClass()
                    {
                        Name = "Demon Hunter",
                        NameRu = "Охотник на демонов",
                        Red = 164,
                        Green = 48,
                        Blue = 201
                    });
            }
        }
    }
}
