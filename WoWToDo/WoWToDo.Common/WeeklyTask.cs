using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWToDo.Infrastructure;

namespace WoWToDo.Common
{
    public class WeeklyTask : BaseModel
    {
        public int PersonageId { get; set; }
        public int TaskToDoId { get; set; }
        public bool IsChecked { get; set; }
        public virtual Personage Personage { get; set; }
        public virtual TaskToDo TaskToDo { get; set; }
    }
}
