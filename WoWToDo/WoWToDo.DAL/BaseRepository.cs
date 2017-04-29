﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WoWToDo.Infrastructure.Interfaces;

namespace WoWToDo.DAL
{
    public class BaseRepository<TModel> : IRepository<TModel>
    {

        public IEnumerable<TModel> GetAll()
        {
            var fileStream = File.Open("~/Data/LibraryTest.xml", FileMode.Open);
            var serializer = new XmlSerializer(typeof(List<TModel>));
            var result = (List<TModel>)serializer.Deserialize(fileStream);
            fileStream.Close();
            return result;
        }

        public bool LoadAll(IEnumerable<TModel> models)
        {
            if (models == null) return false;
            var fileStream = File.Open("~/Data/LibraryTest.xml", FileMode.OpenOrCreate);
            var serializer = new XmlSerializer(typeof(List<TModel>));
            serializer.Serialize(fileStream, models);
            fileStream.Close();
            return true;
        }
    }
}
