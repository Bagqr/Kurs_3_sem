using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace Курсовая_работа_за_3_семестр
{
    /// <summary>
    /// Универсальный менеджер для чтения/записи списков объектов T в JSON-файл.
    /// Если T == Client (абстрактный), то разбирает записи как Individual или LegalEntity.
    /// </summary>
    public class DataManager<T>
    {
        private readonly string _filePath;
        private readonly JsonSerializerSettings _settings;
        private readonly JsonSerializer _serializer;

        public DataManager(string filePath)
        {
            _filePath = filePath;
            _settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
                TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple,
                Formatting = Formatting.Indented,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore // ✅ Ключевая настройка
            };
            _serializer = JsonSerializer.Create(_settings);
        }

        public List<T> LoadData()
        {
            if (!File.Exists(_filePath))
            {
                File.Create(_filePath).Close();
                return new List<T>();
            }

            var json = File.ReadAllText(_filePath);
            if (string.IsNullOrWhiteSpace(json))
                return new List<T>();

            // Особая логика для типа Client (Individual / LegalEntity)
            if (typeof(T) == typeof(Client))
            {
                var rootToken = JToken.Parse(json);
                JArray arrayToken;

                if (rootToken.Type == JTokenType.Object && rootToken["$values"] is JArray valuesArray)
                {
                    arrayToken = valuesArray;
                }
                else if (rootToken.Type == JTokenType.Array)
                {
                    arrayToken = (JArray)rootToken;
                }
                else
                {
                    return new List<T>();
                }

                var result = new List<T>();
                foreach (var token in arrayToken)
                {
                    Client obj;
                    if (token["CompanyName"] != null)
                    {
                        obj = token.ToObject<LegalEntity>(_serializer);
                    }
                    else
                    {
                        obj = token.ToObject<Individual>(_serializer);
                    }

                    result.Add((T)(object)obj);
                }
                return result;
            }

            // Универсальная загрузка
            var root = JToken.Parse(json);
            if (root.Type == JTokenType.Object && root["$values"] is JArray arr)
            {
                return arr.ToObject<List<T>>(_serializer) ?? new List<T>();
            }
            else if (root.Type == JTokenType.Array)
            {
                return JsonConvert.DeserializeObject<List<T>>(json, _settings) ?? new List<T>();
            }
            else
            {
                return new List<T>();
            }
        }

        public void SaveData(List<T> items)
        {
            var json = JsonConvert.SerializeObject(items, Formatting.Indented, _settings);
            File.WriteAllText(_filePath, json);
        }
    }
}
