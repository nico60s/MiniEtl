

namespace MiniEtl.Excel.Models
{
    internal class TableSpecification
    {
        internal string PropertyName {  get; set; }
        internal string TablePosition { get; set; }

        private List<(int row, int column)> TranslateTablePosition(string tablePosition)
        {

        }

    }
}
