

using MiniEtl.Excel.Adapters;
using MiniEtl.Excel.Schemas;

namespace MiniEtl.Excel.Models
{
    public class WorkBook
    {
        private readonly MiniEtlExcelExtractSchema _schema;
        private readonly Dictionary<string, Sheet> _sheets = []; 
        private readonly IExcelAdapter _excelAdapter;

        private WorkBook(MiniEtlExcelExtractSchema schema, IExcelAdapter adapter)
        {
            _schema = schema ?? throw new ArgumentNullException(nameof(schema)); 
            _excelAdapter = adapter
                ?? throw new InvalidOperationException("Error creando el adaptador NPOI"); 
            CreateSheets();
        }

        internal static WorkBook Create(MiniEtlExcelExtractSchema schema, IExcelAdapter adapter) 
            => new(schema, adapter);

        public Table GetTable(string sheetName, string tableName)
        {
            if (_sheets.ContainsKey(sheetName))
            {
                return _sheets[sheetName].GetTable(tableName);
            }
            else
            {
                throw new KeyNotFoundException($"La hoja '{sheetName}' no existe.");
            }
        }

        private void CreateSheets()
        {
            foreach (MiniEtlExcelSheetSchema sheetSchema in _schema.Sheets)
            {
                Sheet sheet = Sheet.New(sheetSchema.SheetName);

                foreach (MiniEtlExcelTableSchema tableSchema in sheetSchema.Tables) 
                {
                    var tableSpecification = TableSpecification.Create(tableSchema.TableName, tableSchema.Position);
                    var table = _excelAdapter.GetTable(sheet.SheetName, tableSpecification);
                    sheet.AddTable(table); 
                }
                _sheets.Add(sheetSchema.SheetName, sheet);
            }
        }
    }
}
