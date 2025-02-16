
namespace MiniEtl.Excel.Models
{
    public class Sheet
    {
        private List<Table> _tables;
        public IReadOnlyList<Table> Tables => _tables;
    }
}
