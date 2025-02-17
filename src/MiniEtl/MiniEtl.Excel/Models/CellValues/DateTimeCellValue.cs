

namespace MiniEtl.Excel.Models.CellValues
{
    public class DateTimeCellValue 
    {
        private readonly DateTime _date;
        private string _defaultValueFormat = "yyyyMMdd";

        public DateTimeCellValue(DateTime date) => _date = date;
        public DateTimeCellValue(DateTime date, string defaultValueFormat) : this(date)
        {
            _defaultValueFormat = defaultValueFormat;
        }
    }
}
