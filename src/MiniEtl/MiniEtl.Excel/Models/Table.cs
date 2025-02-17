
namespace MiniEtl.Excel.Models
{
    public class Table
    {
        internal string Name { get; set; } // property name.
        internal List<List<Cell>> Cells { get; set; } // Representa un rango donde cada row es una lista de celdas

    }
}
