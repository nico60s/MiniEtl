

namespace MiniEtl.Extraction.Helpers
{
    internal static class Validator
    {
        internal static void ThrowIfIsNullOrEmptyString(string value) {
            if(string.IsNullOrEmpty(value)) 
                throw new ArgumentNullException(nameof(value));
        }

        internal static void ThrowIfFileDoesNotExist(string filePath)
        {
            if(!File.Exists(filePath))
                throw new FileNotFoundException(nameof(filePath));
        }
    }
}
