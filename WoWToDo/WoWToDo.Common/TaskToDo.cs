using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWToDo.Infrastructure.Interfaces;

namespace WoWToDo.Common
{
    [Serializable]
    public class TaskToDo : ITaskToDo
    {
        private string _task;
        private bool _isChecked = false;

        public string TaskName { get { return _task ?? string.Empty; } set { _task = value ?? "NoTask"; } }
        public bool IsChecked { get { return _isChecked; } set { _isChecked = value; } }
    }
}
