

namespace MiniEtl.Common
{
    public class MiniEtlCommonResponse<T> : IMiniEtlResponse<T>
    {
        private bool _success;
        private Error _error;
        private T _data;
        public bool IsSuccess => _success;
        public bool IsFailure => !_success;
        public Error Error => _error;
        public T Result => _data;
        public static MiniEtlCommonResponse<T> Success(T data) => new(data);
        public static MiniEtlCommonResponse<T> Failed(Error error) => new(error);

        private MiniEtlCommonResponse(T data)
        {
            _success = true;
            _data = data;
        }
        private MiniEtlCommonResponse(Error error)
        {
            _error = error;
            _success = false;
        }
    }
}
