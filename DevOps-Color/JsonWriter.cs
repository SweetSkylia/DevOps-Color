using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Globalization;

namespace DevOps_Color
{
    public class JsonWriter
    {
        public void WriteToJsonFile(Color[] listeCouleurs) {

            var data = new
            {
                listeCouleurs
            };

            string jsonData = JsonSerializer.Serialize(data);
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "\\" + DateTime.Now.ToString("dd'-'MM'-'yyyy'_'HH'-'mm'-'ss") + ".json";

            File.WriteAllText(filePath, jsonData);
        }
    }
}
