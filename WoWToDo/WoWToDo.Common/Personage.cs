using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using WoWToDo.Infrastructure;
using WoWToDo.Infrastructure.Interfaces;

namespace WoWToDo.Common
{
    public class Personage : BaseModel
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int GameClassId { get; set; }
        public IEnumerable<TaskToDo> DailyTasks { get; set; }
        public IEnumerable<TaskToDo> WeeklyTasks { get; set; }

        public override bool Equals(Object obj)
        {
            var pers = (Personage) obj;
            if (this.Name == pers.Name && this.Level == pers.Level && this.GameClassId == pers.GameClassId)
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() | Name.GetHashCode() | 
                Level.GetHashCode() | GameClassId.GetHashCode() | 
                DailyTasks.GetHashCode() | WeeklyTasks.GetHashCode();
        }

        public override string ToString()
        {
            return $"{Name} Level={Level}";
        }
    }
}
