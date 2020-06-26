using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace Homework_3.services
{
    class FileIOServices
    {
        private readonly string PATH;

        public FileIOServices(string path)
        {
            PATH = path;
        }
        
        public BindingList<models.TodoModel> LoadDate()
        {
            var fileExists = File.Exists(PATH);
            if (!fileExists)
            {
                File.CreateText(PATH).Dispose();
                return new BindingList<models.TodoModel>();
            }
            using (var reader = File.OpenText(PATH))
            {
                var fileText = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<models.TodoModel>>(fileText);
            }
        }

        public void SaveDate(object todoDataList)
        {
            using (StreamWriter writer = File.CreateText(PATH))
            {
                string output = JsonConvert.SerializeObject(todoDataList);
                writer.Write(output);
            }
            
              
        }
    }
}
