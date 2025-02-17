
using MiniEtl.Excel.Models;
using NPOI.XSSF.UserModel;

namespace MiniEtl.Excel.Adapters
{
    internal class NPOIAdapter : IExcelAdapter
    {
        private XSSFWorkbook _workbook;
        private NPOIAdapter(string jsonFilePath)
        {
            LoadWorkBookk(jsonFilePath);
        }
        public Table GetTable(string sheetName, TableSpecification tableSpecification)
        {
            throw new NotImplementedException();
        }
        public static IExcelAdapter CreateAdapter(string jsonFilePath) => new(jsonFilePath);
        private void LoadWorkBookk(string jsonFilePath) {

            using var fs = new FileStream(jsonFilePath, FileMode.Create, FileAccess.Write);
            _workbook = new XSSFWorkbook(fs);
        }
    }
}
