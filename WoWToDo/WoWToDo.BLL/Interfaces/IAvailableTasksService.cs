using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWToDo.Common;

namespace WoWToDo.BLL.Interfaces
{
    public interface IAvailableTasksService
    {
        bool AddNewTask(TaskToDo task);
        bool RenameTask(string oldName, string newName);
    }
}
