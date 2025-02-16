

namespace MiniEtl.Service
{
    public interface IMiniEtlService
    {
        IEnumerable<object> Extract(string path); 

    }
}
