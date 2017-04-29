using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWToDo.Common;
using WoWToDo.Infrastructure.Interfaces;

namespace WoWToDo.DAL.Interfaces
{
    public interface IAvailableDailyTasksRepository : IRepository<TaskToDo>
    {
        bool AddNewTask(TaskToDo task);
        bool RenameTask(string oldName, string newName);
        bool RemoveTask(TaskToDo task);
    }
}
