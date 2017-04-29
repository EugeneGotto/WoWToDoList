﻿using WoWToDo.Common;
using WoWToDo.Infrastructure.Interfaces;

namespace WoWToDo.DAL.Interfaces
{
    public interface ITaskListRepository : IRepository<TaskList>
    {
        TaskList GetByPersName(string name);
        bool LoadTask(TaskList task);
        bool DeleteTask(TaskList task);
    }
}
