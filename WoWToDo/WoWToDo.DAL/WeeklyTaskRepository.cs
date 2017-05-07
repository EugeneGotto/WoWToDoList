using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWToDo.Common;

namespace WoWToDo.DAL
{
    public class WeeklyTaskRepository : BaseRepository<WeeklyTask>
    {
        public WeeklyTaskRepository(DbContext dbContext) : base(dbContext)
        { }
    }
}
