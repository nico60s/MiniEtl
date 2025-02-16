


using Newtonsoft.Json;

namespace MiniEtl.Common
{
    public class JsonService : IJsonService
    {
        public IMiniEtlResponse<IModuleSchema> GetSchema<IModuleSchema>(string jsonPath)
        {
            try
            {
                var json = File.ReadAllText(jsonPath);
                var schema = JsonConvert.DeserializeObject<IModuleSchema>(json);
                return MiniEtlCommonResponse<IModuleSchema>.Success(schema); 
            }
            catch (Exception e)
            {

                return MiniEtlCommonResponse<IModuleSchema>.Failed(
                    Error.Create("C0001","Error en parseo de archivo Json",e));
            }
           
        }
    }
}
