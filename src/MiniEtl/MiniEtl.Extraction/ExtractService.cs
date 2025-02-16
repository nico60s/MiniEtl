

using MiniEtl.Extraction.Configuration;
using MiniEtl.Extraction.Helpers;

namespace MiniEtl.Extraction
{
    public class ExtractService : IExtractService
    {
        private static IExtractService? _instance;
        private readonly IJsonAdapter _jsonAdapter;
        private ExtractService(string jsonSchema)
        {
            _instance = new ExtractService(jsonSchema);
            _jsonAdapter = JsonAdapter.Create(jsonSchema);

        }
        public static ExtractService GetExtractService(string jsonSchema)
        {
            Validator.ThrowIfIsNullOrEmptyString(jsonSchema);

            if (_instance is null)
            {
                var instance = new ExtractService(jsonSchema);
                _instance = instance;
                return (ExtractService)_instance;
            }
            else
            {
                return _instance as ExtractService;

            }
        }
        public IEnumerable<T> Extract<T>(string schemaJsonFilePath)
        {
            var schemaType = _jsonAdapter.GetSchemaType();


            throw new NotImplementedException();

        }

    }
}
