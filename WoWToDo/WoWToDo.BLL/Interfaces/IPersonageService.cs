using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWToDo.Infrastructure;

namespace WoWToDo.BLL.Interfaces
{
    public interface IPersonageService
    {
        void AddNewPersonage(string name, GameClass gameclass, int level);
        void ChangeLevel(string name, int level);
        void ChangeName(string oldName, string newName);
        void ChangeClass(string name, GameClass gameClass);
    }
}
