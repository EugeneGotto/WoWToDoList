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
        private IEnumerable<string> _daily;
        private IEnumerable<string> _weekly;

        public TaskList()
        {
            
        }

        public IPersonage Personage
        {
            get { return _pers ?? new Personage(); }
            set {_pers = value ?? new Personage(); }
        }

        public IEnumerable<string> Daily
        {
            get { return _daily ?? new List<string>(); }
            set { _daily = value ?? new List<string>(); }
        }

        public IEnumerable<string> Weekly
        {
            get { return _weekly ?? new List<string>(); }
            set { _weekly = value ?? new List<string>(); }
        }
    }
}
