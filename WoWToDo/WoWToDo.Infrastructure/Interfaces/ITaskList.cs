using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWToDo.Infrastructure.Interfaces
{
    public interface ITaskList
    {
        IPersonage Personage { get; set; }
        IEnumerable<string> Daily { get; set; }
        IEnumerable<string> Weekly { get; set; }

    }
}
