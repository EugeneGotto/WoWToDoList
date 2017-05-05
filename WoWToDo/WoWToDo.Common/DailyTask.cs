using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWToDo.Infrastructure;

namespace WoWToDo.Common
{
    public class DailyTask : BaseModel
    {
        public int PersonageId { get; set; }
        public int TaskToDoId { get; set; }
    }
}
