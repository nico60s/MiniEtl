

using MiniEtl.Excel.Schemas;

namespace MiniEtl.Excel.Models
{
    public class WorkBook
    {
        private readonly IMiniEtlExcelExtractSchema _schema;

        private WorkBook(IMiniEtlExcelExtractSchema schema) => _schema = schema;
        internal static WorkBook Create(IMiniEtlExcelExtractSchema schema) => new(schema);
    }
}
