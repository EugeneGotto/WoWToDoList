using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWToDo.Common;
using WoWToDo.Infrastructure.Interfaces;

namespace WoWToDo.DAL
{
    public interface IPersonageRepository : IRepository<Personage>
    {
        Personage GetByName(string name);
        bool LoadPers(Personage pers);
        bool DeletePers(Personage pers);
    }
}
