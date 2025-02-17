

namespace MiniEtl.Excel.Models
{
    internal class TableSpecification
    {
        internal string PropertyName {  get; private set; }
        internal string TablePosition { get; private set; }

        private TableSpecification(string propertyName, string tablePosition)
        {
            PropertyName = propertyName;
            TablePosition = tablePosition;
        }

        internal static TableSpecification Create(string propertyName, string tablePosition) 
            => new(propertyName, tablePosition);
    }
}
