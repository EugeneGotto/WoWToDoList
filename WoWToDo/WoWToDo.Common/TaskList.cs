using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWToDo.Infrastructure;
using WoWToDo.Infrastructure.Interfaces;

namespace WoWToDo.Common
{
    [Serializable]
    public class TaskList : ITaskList
    {
        private IPersonage _pers;
        private Dictionary<TaskType, IEnumerable<ITaskToDo>> _taskList;

        public TaskList()
        {
            
        }

        public IPersonage Personage
        {
            get { return _pers ?? new Personage(); }
            set {_pers = value ?? new Personage(); }
        }

        public IEnumerable<ITaskToDo> Daily
        {
            get { return _taskList[TaskType.Daily]; }
            set
            {
                if (value == null) return;
                _taskList[TaskType.Daily] = value;
            }
        }

        public IEnumerable<ITaskToDo> Weekly
        {
            get { return _taskList[TaskType.Weekly]; }
            set
            {
                if (value == null) return;
                _taskList[TaskType.Weekly] = value;
            }
        }
    }
}
