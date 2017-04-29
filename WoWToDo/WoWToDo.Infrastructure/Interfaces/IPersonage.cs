using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace WoWToDo.Infrastructure.Interfaces
{
    public interface IPersonage
    {
        string Name { get; set; }
        int Level { get; set; }
        GameClass Class { get; set; }
    }
}
