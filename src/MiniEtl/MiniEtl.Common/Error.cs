
namespace MiniEtl.Common
{
    public class Error
    {
        public string Code { get; }
        public string Message { get; }
        public Exception Exception { get; }

        private Error(string code, string message, Exception exception = null)
        {
            Code = code;
            Message = message;
            Exception = exception;
        }
        public static Error Create(string code,string message, Exception exception = null)
            => new(code, message, exception);
        public override string ToString()
        {
            return $"Error Code: {Code}, Message: {Message}, Exception: {Exception?.Message}";
        }
    }
}
