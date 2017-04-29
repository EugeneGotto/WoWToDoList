using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWToDo.Common;
using WoWToDo.Infrastructure;

namespace WoWToDo.DAL
{
    public class TaskListRepository : BaseRepository<TaskList>, ITaskListRepository
    {
        public TaskList GetByPersName(string name)
        {
            var allTasks = this.GetAll();
            var result = allTasks.FirstOrDefault(t => t.Personage.Name == name);
            return result ??
                   new TaskList()
                   {
                       Personage = new Personage() {Class = GameClass.Druid, Name = name, Level = 1},
                       Daily = null,
                       Weekly = null
                   };
        }

        public bool LoadTask(TaskList task)
        {
            var allTasks = this.GetAll().ToList();
            var deletedTask = allTasks.FirstOrDefault(t => t.Personage == task.Personage);
            allTasks.Remove(deletedTask);
            allTasks.Add(task);
            return this.LoadAll(allTasks);
        }

        public bool DeleteTask(TaskList task)
        {
            var allTasks = this.GetAll().ToList();
            allTasks.Remove(task);
            return this.LoadAll(allTasks);
        }
    }
}
