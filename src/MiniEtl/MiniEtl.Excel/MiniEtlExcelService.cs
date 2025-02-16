using MiniEtl.Common;
using MiniEtl.Excel.Models;
using MiniEtl.Excel.Schemas;

namespace MiniEtl.Excel
{
    public class MiniEtlExcelService(IJsonService jsonService) : IMiniEtlService<MiniEtlExcelResponse>
    {
        private readonly IJsonService _jsonService = jsonService;

        public MiniEtlExcelResponse Extract(string sourceConnection)
        {
            try
            {
                var getSchemaResult = _jsonService.GetSchema<MiniEtlExcelExtractSchema>(sourceConnection);

                if (getSchemaResult.IsSuccess)
                {
                    var workBook = WorkBook.Create(getSchemaResult.Result);
                    return MiniEtlExcelResponse.Success(workBook);
                }
                else
                {
                    var error = getSchemaResult.Error;
                    return MiniEtlExcelResponse.Failure(error);
                }
            }
            catch (Exception)
            {

                throw;
            }
            
           

            throw new NotImplementedException();
        }
    }
}
