using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWToDo.Infrastructure;

namespace WoWToDo.Common
{
    public class GameClass : BaseModel
    {
        public string Name { get; set; }
        public string NameRu { get; set; }
        public byte[] Icon { get; set; }
    }
}
