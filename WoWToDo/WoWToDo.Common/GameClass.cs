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
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public int[] Argb => new int[] {255, Red, Green, Blue};
        public byte[] Icon { get; set; }
    }
}
