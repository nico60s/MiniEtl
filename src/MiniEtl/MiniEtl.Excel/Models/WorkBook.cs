

using MiniEtl.Excel.Schemas;

namespace MiniEtl.Excel.Models
{
    public class WorkBook
    {
        private readonly MiniEtlExcelExtractSchema _schema;
        private readonly Dictionary<string, Sheet> _sheets = [];

        private WorkBook(MiniEtlExcelExtractSchema schema)
        {
            _schema = schema;
            CreateSheets();
        }
        internal static WorkBook Create(MiniEtlExcelExtractSchema schema) => new(schema);
        public Table GetTable(string sheetName, string tableName)
        {
            return _sheets[sheetName].GetTable(tableName);
        }
        private void CreateSheets()
        {
            foreach(MiniEtlExcelSheetSchema sheetSchema in _schema.Sheets)
            {
                Sheet sheet = Sheet.New(sheetSchema.SheetName);
                _sheets.Add(sheetSchema.SheetName, sheet);
            }
        }
    }
}
