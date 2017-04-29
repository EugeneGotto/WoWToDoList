using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWToDo.Common;
using WoWToDo.Infrastructure.Interfaces;

namespace WoWToDo.DAL
{
    public interface ITaskListRepository : IRepository<TaskList>
    {
        TaskList GetByPersName(string name);
        bool LoadTask(TaskList task);
        bool DeleteTask(TaskList task);
    }
}
