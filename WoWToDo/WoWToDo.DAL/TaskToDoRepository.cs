using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWToDo.Common;

namespace WoWToDo.DAL
{
    public class TaskToDoRepository : BaseRepository<TaskToDo>
    {
        public TaskToDoRepository(DbContext dbContext) : base(dbContext)
        { }
    }
}
