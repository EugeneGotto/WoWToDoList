using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWToDo.Common;

namespace WoWToDo.DAL
{
    public class GlobalTaskRepository : BaseRepository<GlobalTask>
    {
        public GlobalTaskRepository(DbContext dbContext) : base(dbContext)
        { }
    }
}
