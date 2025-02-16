using MiniEtl.Extraction.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MiniEtl.Extraction.Configuration
{
    internal class JsonAdapter : IJsonAdapter
    {
        private static readonly string SCHEMA_TYPE_JSON_TOKEN = "type";

        private readonly string _jsonFilePath;
        private JsonAdapter(string jsonFilePath)
        {
            Validator.ThrowIfFileDoesNotExist(jsonFilePath);
            _jsonFilePath = jsonFilePath;
        }
        internal static JsonAdapter Create(string jsonFilePath) => new(jsonFilePath);
        public string GetSchemaType()
        {
            var json = File.ReadAllText(_jsonFilePath);
            JToken jtoken = JToken.Parse(json);
            return  jtoken[SCHEMA_TYPE_JSON_TOKEN].ToObject<string>() 
                                ?? throw new Exception(nameof(json));
        }

        public TJsonSchema ReadSchema<TJsonSchema>()
        {
            var schema = JsonConvert.DeserializeObject<TJsonSchema>(_jsonFilePath);
            return schema ?? throw new ArgumentException(null, nameof(_jsonFilePath));
        }
    }
}
