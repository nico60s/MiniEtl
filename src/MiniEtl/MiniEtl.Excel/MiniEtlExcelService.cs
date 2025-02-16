using MiniEtl.Common;
using MiniEtl.Excel.Models;
using MiniEtl.Excel.Schemas;

namespace MiniEtl.Excel
{
    public class MiniEtlExcelService : IMiniEtlService<MiniEtlExcelResponse>
    {
        private readonly IJsonService _jsonService;

        public MiniEtlExcelService(IJsonService jsonService)
        {
            _jsonService = jsonService ?? throw new ArgumentNullException(nameof(jsonService));
        }
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
            catch (Exception e)
            {

                return MiniEtlExcelResponse.Failure(Error.Create("MiniEtl.Excel.Extract", e.Message, e));
            }
            
        }
    }
}
