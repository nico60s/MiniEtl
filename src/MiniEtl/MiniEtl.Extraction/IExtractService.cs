namespace MiniEtl.Extraction
{
    public interface IExtractService
    {
        IEnumerable<T> Extract<T>(string schemaJsonFilePath);
    }
}