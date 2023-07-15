using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AutomationTask.Utils
{
   public static class FileReader
    {
        public static T JsonReader<T>(string path)
        {
            return JsonConvert.DeserializeObject<T>(ReadFile(path));
        }

        public static string ReadFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                return sr.ReadToEnd();
            }
        }
    }
}
