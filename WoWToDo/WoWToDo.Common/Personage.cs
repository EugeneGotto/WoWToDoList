using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWToDo.Infrastructure;
using WoWToDo.Infrastructure.Interfaces;

namespace WoWToDo.Common
{
    [Serializable]
    public class Personage : IPersonage
    {
        private string _name;
        private int _level;
        
        public string Name { get; set; }
        public int Level { get; set; }
        public GameClass Class { get; set; }
    }
}
