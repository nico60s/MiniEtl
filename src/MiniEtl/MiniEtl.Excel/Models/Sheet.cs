

namespace MiniEtl.Excel.Models
{
    public class Sheet
    {
        private string _sheetName;
        private Dictionary<string, Table> _tables = [];
        public string SheetName { get { return _sheetName; } }
        public IReadOnlyDictionary<string, Table> Tables => _tables;
        private Sheet(string sheetName) => _sheetName = sheetName;
        public static Sheet New(string sheetName) => new(sheetName);
        internal Table GetTable(string tableName)
        {
            return _tables[tableName];
        }
        internal void AddTable(Table table)
        {
            _tables.Add(table.Name, table);
        }

    }
}
