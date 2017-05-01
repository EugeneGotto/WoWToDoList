using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWToDo.Common;
using WoWToDo.DAL.Interfaces;
using WoWToDo.Infrastructure;
using WoWToDo.Infrastructure.Interfaces;

namespace WoWToDo.DAL
{
    public class AvailableTasksRepository : BaseRepository<TaskToDo>, IAvailableTasksRepository
    {
        public IEnumerable<ITaskToDo> GetByType(TaskType taskType)
        {
            var result = this.GetAll().Where(t => t.TaskType == taskType);
            return result ?? new List<TaskToDo>();
        }

        public void DeleteTask(TaskToDo task)
        {
            var taskList = this.GetAll().ToList();
            taskList.Remove(task);
            this.LoadAll(taskList);
        }
    }
}
