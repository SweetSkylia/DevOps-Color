using System.Text.Json;
using System.Drawing;

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
    public class JsonReader
    {
        public Color[] ReadJsonFromFile(string path)
        {
            string jsonContent = File.ReadAllText(path);

            JsonDocument jsonDoc = JsonDocument.Parse(jsonContent);

            // Obtention de la racine de l'objet JSON
            JsonElement root = jsonDoc.RootElement;

            // Accéder à l'array à compter
            JsonElement nomsArray = root.GetProperty("listeCouleurs");

            int position = 0;
            Color[] colors = new Color[5];
            foreach (JsonElement element in nomsArray.EnumerateArray())
            {
                    if (element.TryGetProperty("Name", out JsonElement nomValue))
                    {
                       colors[position] = ColorTranslator.FromHtml("#" + nomValue.ToString());
                        position++;
                    }
                
            }
            return colors;
        }

    }
}

    
