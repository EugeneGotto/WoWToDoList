using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWToDo.Infrastructure;

namespace WoWToDo.Common
{
    public class GlobalTask : BaseModel
    {
        public string TaskName { get; set; }
        public bool IsDone { get; set; }

        public override string ToString()
        {
            return TaskName;
        }
    }
}
