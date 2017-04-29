using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
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
        private GameClass _class;

        public Personage()
        {
            
        }

        public string Name { get { return _name ?? "NoName"; } set { _name = string.IsNullOrEmpty(value) ? "NoName" : value; } }
        public int Level { get { return _level; } set { _level = value <= 110 && value > 0 ? value : 1; } }
        public GameClass Class { get { return _class; } set { _class = value; }}
    }
}
