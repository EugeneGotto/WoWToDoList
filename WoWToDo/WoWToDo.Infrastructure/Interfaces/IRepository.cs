﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWToDo.Infrastructure.Interfaces
{
    public interface IRepository<TModel>
    {
        IEnumerable<TModel> GetAll();
        bool LoadAll(IEnumerable<TModel> models);
    }
}
