using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWToDo.BLL.Interfaces;
using WoWToDo.Common;
using WoWToDo.DAL;

namespace WoWToDo.BLL
{
    public class AvailableTasksService : IAvailableTasksService
    {
        public bool AddNewTask(TaskToDo task)
        {
            var repo = new AvailableTasksRepository();
            var allTasks = repo.GetAll().ToList();
            allTasks.Add(task);
            return repo.LoadAll(allTasks);
        }

        public bool RenameTask(string oldName, string newName)
        {
            var repo = new AvailableTasksRepository();
            var allTasks = repo.GetAll().ToList();
            var changedTask = allTasks.FirstOrDefault(t => t.TaskName == oldName) ?? new TaskToDo();
            allTasks.Remove(changedTask);
            changedTask.TaskName = newName;
            allTasks.Add(changedTask);
            return repo.LoadAll(allTasks);
        }
    }
}
