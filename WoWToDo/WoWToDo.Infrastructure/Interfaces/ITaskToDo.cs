using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWToDo.Infrastructure.Interfaces
{
    public interface ITaskToDo
    {
        string TaskName { get; set; }
        bool IsChecked { get; set; }
    }
}
