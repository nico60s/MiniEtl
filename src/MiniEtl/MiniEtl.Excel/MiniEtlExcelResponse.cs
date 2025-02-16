

using MiniEtl.Common;
using MiniEtl.Excel.Models;

namespace MiniEtl.Excel
{
    public record MiniEtlExcelResponse : IMiniEtlResponse<WorkBook>
    {
        private readonly bool _isSuccess = true;
        private readonly Error? _error;
        private readonly WorkBook _workBook;
        public bool IsSuccess => _isSuccess;
        public WorkBook Result => _workBook;
        public bool IsFailure => !_isSuccess;
        public Error Error => _error;
        private MiniEtlExcelResponse(WorkBook workbook)
        {
            _workBook = workbook;
            _isSuccess = true;
        }
        private MiniEtlExcelResponse(Error error)
        {
            _error = error;
            _isSuccess = false;
        }
        public static MiniEtlExcelResponse Success(WorkBook workBook) => new(workBook);
        public static MiniEtlExcelResponse Failure(Error error) => new(error);
    }
}
