using System.Text.Json;

namespace LAB15_Ejer3_Repaso.Services
{
    public class JsonService
    {
        public void Guardar<T>(string ruta, List<T> lista)
        {
            string json = JsonSerializer.Serialize(lista);
            File.WriteAllText(ruta, json);
        }

        public List<T> Leer<T>(string ruta)
        {
            if (!File.Exists(ruta))
            {
                return new List<T>();
            }

            string json = File.ReadAllText(ruta);

            List<T>? lista = JsonSerializer.Deserialize<List<T>>(json);

            if (lista == null)
            {
                return new List<T>();
            }

            return lista;
        }
    }
}
