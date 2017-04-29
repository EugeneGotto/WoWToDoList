using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWToDo.Infrastructure.Interfaces;

namespace WoWToDo.Common
{
    [Serializable]
    public class TaskList : ITaskList
    {
        private IPersonage _pers;
        private IEnumerable<ITaskToDo> _daily;
        private IEnumerable<ITaskToDo> _weekly;

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
            get { return _daily; }
            set { _daily = value; }
        }

        public IEnumerable<ITaskToDo> Weekly
        {
            get { return _weekly; }
            set { _weekly = value; }
        }
    }
}
