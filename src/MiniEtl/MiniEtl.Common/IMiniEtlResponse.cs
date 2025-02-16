

namespace MiniEtl.Common
{
   public interface IMiniEtlResponse<T>
    {
        bool IsSuccess { get; }
        bool IsFailure { get; }
        Error Error { get; }
        T Result { get; }
    }
}
