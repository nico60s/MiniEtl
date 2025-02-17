using MiniEtl.Excel.Models;

namespace MiniEtl.Excel.Adapters
{
    internal interface IExcelAdapter
    {
        Table GetTable(string sheetName, TableSpecification tableSpecification);
    }
}
