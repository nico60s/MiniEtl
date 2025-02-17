

namespace MiniEtl.Excel.Schemas
{
    public class MiniEtlExcelExtractSchema : IMiniEtlExcelExtractSchema
    {
        public required string FileName { get; init; }
        public int Version { get; init; }
        public List<MiniEtlExcelSheetSchema> Sheets { get; init; }

    }
    public record MiniEtlExcelSheetSchema
    {
        public string SheetName { get; init; }
        public List<MiniEtlExcelTableSchema> Tables { get; init; }
    }
    public record MiniEtlExcelTableSchema
    {
        public string TableName { get; init; } //nombre de negocio
        public string Position { get; init; } //Rangos - celda, etc
    }
}
