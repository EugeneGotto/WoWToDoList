using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWToDo.Common;

namespace WoWToDo.DAL
{
    public class DailyTaskRepository : BaseRepository<DailyTask>
    {
        public DailyTaskRepository(DbContext dbContext) : base(dbContext)
        { }
    }
}
