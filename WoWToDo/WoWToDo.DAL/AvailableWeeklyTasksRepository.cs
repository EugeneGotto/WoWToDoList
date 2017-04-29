using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWToDo.Common;
using WoWToDo.DAL.Interfaces;

namespace WoWToDo.DAL
{
    public class AvailableWeeklyTasksRepository : BaseRepository<TaskToDo>, IAvailableWeeklyTasksRepository
    {
        public bool AddNewTask(TaskToDo task)
        {
            var allTasks = this.GetAll().ToList();
            allTasks.Add(task);
            return this.LoadAll(allTasks);
        }

        public bool RenameTask(string oldName, string newName)
        {
            var allTasks = this.GetAll().ToList();
            var changedTask = allTasks.FirstOrDefault(t => t.TaskName == oldName) ?? new TaskToDo();
            allTasks.Remove(changedTask);
            changedTask.TaskName = newName;
            allTasks.Add(changedTask);
            return this.LoadAll(allTasks);
        }

        public bool RemoveTask(TaskToDo task)
        {
            var allTasks = this.GetAll().ToList();
            var changedTask = allTasks.FirstOrDefault(t => t == task);
            allTasks.Remove(changedTask);
            return this.LoadAll(allTasks);
        }
    }
}
