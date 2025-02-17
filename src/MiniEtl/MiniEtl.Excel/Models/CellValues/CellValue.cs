

namespace MiniEtl.Excel.Models.CellValues
{
    public class CellValue 
    {
        public object Value { get; }
        private CellValue(object value)
        {
            Value = value;
        }
        public static CellValue Set(object value) => new(value);
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
