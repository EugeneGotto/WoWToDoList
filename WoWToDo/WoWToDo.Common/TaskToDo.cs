using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWToDo.Infrastructure;
using WoWToDo.Infrastructure.Interfaces;

namespace WoWToDo.Common
{
    public class TaskToDo : BaseModel
    {
        public string TaskName { get; set; }
        public ICollection<DailyTask> DailyTasks { get; set; }
        public ICollection<WeeklyTask> WeeklyTasks { get; set; }

        public override string ToString()
        {
            return TaskName;
        }
    }
}
