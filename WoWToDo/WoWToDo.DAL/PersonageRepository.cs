using System.Collections.Generic;
using System.Linq;
using WoWToDo.Common;
using WoWToDo.Infrastructure;

namespace WoWToDo.DAL
{
    public class PersonageRepository : BaseRepository<Personage>, IPersonageRepository
    {
        public Personage GetByName(string name)
        {
            var allPersonages = this.GetAll() ?? new List<Personage>();
            var result = allPersonages.FirstOrDefault(p => p.Name == name);
            return result ?? (new Personage() {Name = name, Class = GameClass.Druid, Level = 1});
        }

        public bool LoadPers(Personage pers)
        {
            var allPersonages = this.GetAll().ToList();
            var deletedPers = allPersonages.FirstOrDefault(p => p.Name == pers.Name);
            allPersonages.Remove(deletedPers);
            allPersonages.Add(pers);
            return this.LoadAll(allPersonages);
        }

        public bool DeletePers(Personage pers)
        {
            var allPersonages = this.GetAll().ToList();
            allPersonages.Remove(pers);
            return this.LoadAll(allPersonages);
        }
    }
}
