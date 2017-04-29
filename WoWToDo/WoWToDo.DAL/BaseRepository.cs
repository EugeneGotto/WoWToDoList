using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WoWToDo.Infrastructure.Interfaces;

namespace WoWToDo.DAL
{
    public class BaseRepository<TModel> : IRepository<TModel>
    {
        private string _fileName = $"{typeof(TModel)}s";
        
        public IEnumerable<TModel> GetAll()
        {
            if (!File.Exists($"../../Data/{_fileName}.xml"))
            {
                this.LoadAll(new List<TModel>());
            }

            var fileStream = File.Open($"../../Data/{_fileName}.xml", FileMode.OpenOrCreate);
            var serializer = new XmlSerializer(typeof(List<TModel>));
            var result = (List<TModel>)serializer.Deserialize(fileStream);
            fileStream.Close();
            return result;
        }

        public bool LoadAll(IEnumerable<TModel> models)
        {
            if (models == null) return false;
            var fileStream = File.Open($"../../Data/{_fileName}.xml", FileMode.OpenOrCreate);
            var serializer = new XmlSerializer(typeof(List<TModel>));
            serializer.Serialize(fileStream, models);
            fileStream.Close();
            return true;
        }
    }
}
