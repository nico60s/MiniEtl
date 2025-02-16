

namespace MiniEtl.Common
{
    public interface IJsonService
    {
        IMiniEtlResponse<IModuleSchema> GetSchema<IModuleSchema>(string jsonPath);
    }
}
