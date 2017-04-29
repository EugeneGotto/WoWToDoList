using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using WoWToDo.BLL.Interfaces;
using WoWToDo.Common;
using WoWToDo.DAL;
using WoWToDo.Infrastructure;

namespace WoWToDo.BLL
{
    public class PersonageService : IPersonageService
    {
        public void AddNewPersonage(string name, GameClass gameClass, int level)
        {
            var repo = new PersonageRepository();
            var pers = new Personage() {Class = gameClass, Name = name, Level = level};
            repo.LoadPers(pers);
        }

        public void AddNewPersonage(Personage pers)
        {
            var repo = new PersonageRepository();
            repo.LoadPers(pers);
        }

        public void ChangeLevel(string name, int level)
        {
            var repo = new PersonageRepository();
            var changedPers = repo.GetByName(name);
            changedPers.Level = level;
            repo.LoadPers(changedPers);
        }

        public void ChangeName(string oldName, string newName)
        {
            var repo = new PersonageRepository();
            var changedPers = repo.GetByName(oldName);
            changedPers.Name = newName;
            repo.LoadPers(changedPers);
        }

        public void ChangeClass(string name, GameClass gameClass)
        {
            var repo = new PersonageRepository();
            var changedPers = repo.GetByName(name);
            changedPers.Class = gameClass;
            repo.LoadPers(changedPers);
        }
    }
}
