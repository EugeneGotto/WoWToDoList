using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWToDo.BLL.Interfaces;
using WoWToDo.Common;
using WoWToDo.DAL;
using WoWToDo.Infrastructure.Interfaces;

namespace WoWToDo.BLL
{
    public class TaskListService : ITaskListService
    {
        public void ChangedTaskState(string namePers, bool isDaily, string nameTask)
        {
            var repo = new TaskListRepository();
            var taskList = repo.GetByPersName(namePers);
            List<ITaskToDo> tasks;
            if (isDaily)
            {
                tasks = taskList.Daily.ToList();
                this.ChangeState(tasks, nameTask);
                taskList.Daily = tasks;
            }

            else
            {
                tasks = taskList.Weekly.ToList();
                this.ChangeState(tasks, nameTask);
                taskList.Weekly = tasks;
            }

            repo.LoadTask(taskList);
        }

        public void AddNewTask(string namePers, bool isDaily, TaskToDo task)
        {
            var repo = new TaskListRepository();
            var taskList = repo.GetByPersName(namePers);
            if (isDaily)
                taskList.Daily.ToList().Add(task);
            else 
                taskList.Weekly.ToList().Add(task);
            repo.LoadTask(taskList);
        }

        public void RemoveTask(string namePers, bool isDaily, TaskToDo task)
        {
            var repo = new TaskListRepository();
            var taskList = repo.GetByPersName(namePers);
            if (isDaily)
                taskList.Daily.ToList().Remove(task);
            else 
                taskList.Weekly.ToList().Remove(task);
            repo.LoadTask(taskList);
        }

        private void ChangeState(List<ITaskToDo> tasks, string nameTask)
        {
            bool flag = tasks.FirstOrDefault(t => t.TaskName == nameTask).IsChecked;
            if (flag)
                tasks.FirstOrDefault(t => t.TaskName == nameTask).IsChecked = false;
            else
                tasks.FirstOrDefault(t => t.TaskName == nameTask).IsChecked = true;
        }
    }
}
