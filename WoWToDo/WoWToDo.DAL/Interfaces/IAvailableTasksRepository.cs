using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWToDo.Common;
using WoWToDo.Infrastructure;
using WoWToDo.Infrastructure.Interfaces;

namespace WoWToDo.DAL.Interfaces
{
    public interface IAvailableTasksRepository : IRepository<TaskToDo>
    {
        IEnumerable<ITaskToDo> GetByType(TaskType taskType);
        void DeleteTask(TaskToDo task);
    }
}
