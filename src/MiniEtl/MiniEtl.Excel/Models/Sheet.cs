
namespace MiniEtl.Excel.Models
{
    public class Sheet
    {
        private string _sheetName;
        private Dictionary<string, Table> _tables = [];
        public IReadOnlyDictionary<string, Table> Tables => _tables;
        private Sheet(string sheetName) => _sheetName = sheetName;
        public static Sheet New(string sheetName) => new(sheetName);
        internal Table GetTable(string tableName)
        {
            return _tables[tableName];
        }

    }
}
