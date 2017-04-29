using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWToDo.Common;

namespace WoWToDo.BLL.Interfaces
{
    public interface ITaskListService
    {
        void ChangedTaskState(string namePers,bool isDaily, string nameTask);
        void AddNewTask(string namePers, bool isDaily, TaskToDo task);
        void RemoveTask(string namePers, bool isDaily, TaskToDo task);
    }
}
