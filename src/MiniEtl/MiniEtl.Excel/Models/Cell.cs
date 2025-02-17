

using MiniEtl.Excel.Models.CellValues;

namespace MiniEtl.Excel.Models
{
    public class Cell
    {
        private readonly string _description; //representación alfanumérica de la celda. Ej. "A1"
        private readonly int _columnIndex; // index 0-based
        private readonly int _rowIndex; // index 0-based
        private readonly CellValue _cellValue;

        public string Description { get { return _description; } }
        public int ColumnIndex { get { return _columnIndex; } }
        public int RowIndex { get { return _rowIndex; } }
        public CellValue CellValue { get { return _cellValue; } }
        private Cell(string description, int columnIndex, int rowIndex, CellValue cellValue) { 
            
            _cellValue = cellValue; 
            _description = description;
            _rowIndex = rowIndex;
            _columnIndex = columnIndex;
            
        }
        public static Cell New(string description, int columnIndex, int rowIndex, CellValue cellValue) 
            => new(description, columnIndex, rowIndex, cellValue);

    }
}
