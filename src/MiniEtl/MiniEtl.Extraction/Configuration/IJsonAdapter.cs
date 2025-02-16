namespace MiniEtl.Extraction.Configuration
{
    internal interface IJsonAdapter
    {
        TJsonSchema ReadSchema<TJsonSchema>();
        string GetSchemaType();
        
    }
}
